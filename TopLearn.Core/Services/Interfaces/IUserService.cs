using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.Core.DTOs;
using TopLearn.DataLayer.Entities.User;
using TopLearn.DataLayer.Entities.Wallet;

namespace TopLearn.Core.Services.Interfaces
{
    public interface IUserService
    {
        bool IsExistUserName(string userName);
        bool IsExistEmail(string email);
        int AddUser(User user);
        User LoginUser(LoginViewModel login);
        bool ActiveAccount(string activeCode);
        int GetUserIdByUserName(string userName);
        User GetUserById(int userId);
        User GetUserByEmail(string email);
        User GetUserByUserName(string userName);
        User GetUserByActiveCode(string activeCode);
        void UpdateUser(User user);
        void DeleteUser(int userId);
        #region User Panel
        InformationUserViewModel GetUserInformation(string userName);
        InformationUserViewModel GetUserInformation(int UserId);
        SideBarUserPanelViewModel GetSideBarUserPanelData(string userName);
        EditProfileViewModel GetDataForEditProfileUser(string userName);
        void EditProfile(string userName, EditProfileViewModel profile);
        bool CompareOldPassword(string oldPassword, string userName);
        void ChangeUserPassword(string userName, string newPassword);
        #endregion

        #region Wallet
        int BalanceUserWallet(string userName);
        List<WalletViewModel> GetWalletUser(string userName);
        int ChargeWallet(string userName, int amount, string description, bool isPay = false);
        int AddWallet(Wallet wallet);
        Wallet GetWalletByWalletId(int walletId);
        void UpdateWallet(Wallet wallet);
        #endregion

        #region AdminPanel
        UserForAdminViewModel GetUsers(int pageId = 1, string filterEmail = "", string filterUserName = "");
        UserForAdminViewModel GetDeleteUsers(int pageId = 1, string filterEmail = "", string filterUserName = "");
        int AddUserFromAdmin(CreateUserViewModel user);
        EditUserViewModel GetUserForShowInEditMode(int userId);
        void EditUserFromAdmin(EditUserViewModel editUser);
        #endregion
    }
}
