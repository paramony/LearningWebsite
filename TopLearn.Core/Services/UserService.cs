using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TopLearn.Core.Convertors;
using TopLearn.Core.DTOs;
using TopLearn.Core.Generator;
using TopLearn.Core.Security;
using TopLearn.Core.Services.Interfaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.User;
using TopLearn.DataLayer.Entities.Wallet;

namespace TopLearn.Core.Services
{
    public class UserService : IUserService
    {
        private readonly TopLearnContext _context;
        public UserService(TopLearnContext context)
        {
            _context = context;
        }

        public bool ActiveAccount(string activeCode)
        {
            var user = _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
            if (user == null || user.IsActive)
            {
                return false;
            }
            user.IsActive = true;
            user.ActiveCode = NameGenerator.GenerateUniqCode();
            _context.SaveChanges();
            return true;
        }

        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }

        public int AddUserFromAdmin(CreateUserViewModel user)
        {
            User newUser = new User();
            newUser.Password = PasswordHelper.EncodePasswordMd5(user.Password);
            newUser.UserName = user.UserName;
            newUser.IsActive = true;
            newUser.RegisterDate = DateTime.Now;
            newUser.ActiveCode = NameGenerator.GenerateUniqCode();
            newUser.Email = user.Email;
            //Save Image
            if (user.UserAvatar != null)
            {
                string imagePath = "";
                newUser.UserAvatar = NameGenerator.GenerateUniqCode() + Path.GetExtension(user.UserAvatar.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar",newUser.UserAvatar);
                using (var stream = new FileStream(imagePath,FileMode.Create))
                {
                    user.UserAvatar.CopyTo(stream);
                }
            }
            return AddUser(newUser);
        }

        public int AddWallet(Wallet wallet)
        {
            _context.Wallets.Add(wallet);
            _context.SaveChanges();
            return wallet.WalletId;
        }

        public int BalanceUserWallet(string userName)
        {
            int userId = GetUserIdByUserName(userName);
            var enter = _context.Wallets
                                .Where(w => w.UserId == userId && w.TypeId == 1 && w.IsPay)
                                .Select(w => w.Amount)
                                .ToList();
            var exit = _context.Wallets
                                .Where(w => w.UserId == userId && w.TypeId == 2)
                                .Select(w => w.Amount)
                                .ToList();
            return (enter.Sum() - exit.Sum());
        }

        public void ChangeUserPassword(string userName, string newPassword)
        {
            var user = GetUserByUserName(userName);
            user.Password = PasswordHelper.EncodePasswordMd5(newPassword);
            UpdateUser(user);
        }

        public int ChargeWallet(string userName, int amount, string description, bool isPay = false)
        {
            var wallet = new Wallet()
            {
                Amount = amount,
                CreateDate = DateTime.Now,
                Description = description,
                IsPay = isPay,
                TypeId = 1,
                UserId = GetUserIdByUserName(userName)
            };
           return AddWallet(wallet);
        }

        public bool CompareOldPassword(string oldPassword, string userName)
        {
            string hashOldPassword = PasswordHelper.EncodePasswordMd5(oldPassword);
            return _context.Users.Any(u=>u.UserName == userName && u.Password == hashOldPassword);
        }

        public void DeleteUser(int userId)
        {
            var user = GetUserById(userId);
            user.IsDelete = true;
            UpdateUser(user);
        }

        public void EditProfile(string userName,EditProfileViewModel profile)
        {
            if (profile.UserAvatar != null)
            {
                string imagePath = "";
                if (profile.AvatarName != "Defult.jpg")
                {
                    imagePath = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/UserAvatar",profile.AvatarName);
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }
                }
                profile.AvatarName = NameGenerator.GenerateUniqCode() + Path.GetExtension(profile.UserAvatar.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", profile.AvatarName);
                using (var stream = new FileStream(imagePath,FileMode.Create))
                {
                    profile.UserAvatar.CopyTo(stream);
                }
            }
            var user = GetUserByUserName(userName);
            user.UserName = profile.UserName;
            user.Email = profile.Email;
            user.UserAvatar = profile.AvatarName;

            UpdateUser(user);
        }

        public void EditUserFromAdmin(EditUserViewModel editUser)
        {
            User user = GetUserById(editUser.UserId);
            user.Email = editUser.Email;
            if (!string.IsNullOrEmpty(editUser.Password))
            {
                user.Password = PasswordHelper.EncodePasswordMd5(editUser.Password);
            }
            if (editUser.UserAvatar != null)
            {
                //Delete Old Image
                if (editUser.AvatarName != "Defult.jpg")
                {
                    string deletePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", editUser.AvatarName);
                    if (File.Exists(deletePath))
                    {
                        File.Delete(deletePath);
                    }
                }
                //Save New Image
                string imagePath = "";
                user.UserAvatar = NameGenerator.GenerateUniqCode() + Path.GetExtension(editUser.UserAvatar.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", user.UserAvatar);
                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    editUser.UserAvatar.CopyTo(stream);
                }
            }
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public EditProfileViewModel GetDataForEditProfileUser(string userName)
        {
            return _context.Users.Where(u => u.UserName == userName).Select(u => new EditProfileViewModel()
            {
                AvatarName = u.UserAvatar,
                Email = u.Email,
                UserName = u.UserName
            }).Single();
        }

        public UserForAdminViewModel GetDeleteUsers(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> result = _context.Users.IgnoreQueryFilters().Where(u=>u.IsDelete);
            if (!string.IsNullOrEmpty(filterEmail))
            {
                result = result.Where(u => u.Email.Contains(filterEmail));
            }
            if (!string.IsNullOrEmpty(filterUserName))
            {
                result = result.Where(u => u.UserName.Contains(filterUserName));
            }
            //Show iTEM iN Page
            int take = 20;
            int skip = (pageId - 1) * take;
            var list = new UserForAdminViewModel()
            {
                CurrentPage = pageId,
                PageCount = result.Count() / take,
                Users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList()
            };
            return list;
        }

        public SideBarUserPanelViewModel GetSideBarUserPanelData(string userName)
        {
            return _context.Users.Where(u => u.UserName == userName).Select(u => new SideBarUserPanelViewModel
            {
                UserName = u.UserName,
                ImageName = u.UserAvatar,
                RegisterDate = u.RegisterDate
            }).Single();
        }

        public User GetUserByActiveCode(string activeCode)
        {
            return _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.SingleOrDefault(u => u.Email == email);
        }

        public User GetUserById(int userId)
        {
            return _context.Users.Find(userId);
        }

        public User GetUserByUserName(string userName)
        {
            return _context.Users.SingleOrDefault(u=> u.UserName == userName);
        }

        public EditUserViewModel GetUserForShowInEditMode(int userId)
        {
            return _context.Users
                           .Where(u => u.UserId == userId)
                           .Select(u => new EditUserViewModel
                           {
                               UserId = u.UserId,
                               Email = u.Email,
                               UserName = u.UserName,
                               AvatarName = u.UserAvatar,
                               UserRoles = u.UserRoles.Select(r=>r.RoleId).ToList()
                           }).Single();
        }

        public int GetUserIdByUserName(string userName)
        {
            return _context.Users.Single(u => u.UserName == userName).UserId;
        }

        public InformationUserViewModel GetUserInformation(string userName)
        {
            var user = GetUserByUserName(userName);
            return new InformationUserViewModel()
            {
                Email = user.Email,
                RegisterDate = user.RegisterDate,
                UserName = user.UserName,
                Wallet = BalanceUserWallet(userName)
            };
        }

        public InformationUserViewModel GetUserInformation(int UserId)
        {
            var user = GetUserById(UserId);
            return new InformationUserViewModel()
            {
                Email = user.Email,
                RegisterDate = user.RegisterDate,
                UserName = user.UserName,
                Wallet = BalanceUserWallet(user.UserName)
            };
        }

        public UserForAdminViewModel GetUsers(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            IQueryable<User> result = _context.Users;
            if (!string.IsNullOrEmpty(filterEmail))
            {
                result = result.Where(u => u.Email.Contains(filterEmail));
            }
            if (!string.IsNullOrEmpty(filterUserName))
            {
                result = result.Where(u => u.UserName.Contains(filterUserName));
            }
            //Show iTEM iN Page
            int take = 20;
            int skip = (pageId - 1) * take;
            var list = new UserForAdminViewModel()
            {
                CurrentPage = pageId,
                PageCount = result.Count() / take,
                Users = result.OrderBy(u => u.RegisterDate).Skip(skip).Take(take).ToList()
            };
            return list;
        }

        public Wallet GetWalletByWalletId(int walletId)
        {
            return _context.Wallets.Find(walletId);
        }

        public List<WalletViewModel> GetWalletUser(string userName)
        {
            int userId = GetUserIdByUserName(userName);
            return _context.Wallets
                           .Where(w => w.IsPay && w.UserId == userId )
                           .Select(w => new WalletViewModel()
                           {
                               Amount = w.Amount,
                               DateTime = w.CreateDate,
                               Description = w.Description,
                               Type = w.TypeId
                           })
                           .ToList();
        }

        public bool IsExistEmail(string email)
        {
           return _context.Users.Any(u => u.Email == email);
        }

        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public User LoginUser(LoginViewModel login)
        {
            string hashPassword = PasswordHelper.EncodePasswordMd5(login.Password);
            string email = FixedText.FixEmail(login.Email);
            return _context.Users.SingleOrDefault(u => u.Email == email && u.Password == hashPassword);
        }

        public void UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
        }

        public void UpdateWallet(Wallet wallet)
        {
            _context.Wallets.Update(wallet);
            _context.SaveChanges();
        }
    }
}
