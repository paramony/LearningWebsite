using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.Permission;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Core.Services.Interfaces
{
    
   public class PermissionService : IPermissionService
    {
        private readonly TopLearnContext _context;
        public PermissionService(TopLearnContext context)
        {
            _context = context;
        }

        public void AddPermissionToRole(int roleId, List<int> permissions)
        {
            foreach (var item in permissions)
            {
                _context.RolePermission.Add(new RolePermission
                {
                    PermissionId = item,
                    RoleId = roleId
                });
            }
            _context.SaveChanges();
        }

        public int AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role.RoleId;
        }

        public void AddRolesToUser(List<int> rolesId, int userId)
        {
            foreach (var item in rolesId)
            {
                _context.UserRoles.Add(new UserRole()
                {
                     RoleId = item,
                     UserId = userId
                });
            }
            _context.SaveChanges();
        }

        public bool CheckPermission(int permissionId, string userName)
        {
            int userId = _context.Users.FirstOrDefault(u=>u.UserName == userName).UserId;
            List<int> UserRoles = _context.UserRoles
                                          .Where(u => u.UserId == userId)
                                          .Select(u => u.RoleId)
                                          .ToList();
            if (!UserRoles.Any())
            {
                return false;
            }
            List<int> rolesPermission = _context.RolePermission
                                                .Where(r => r.PermissionId == permissionId)
                                                .Select(r => r.RoleId)
                                                .ToList();
            return rolesPermission.Any(p=>UserRoles.Contains(p));
        }

        public void DeleteRole(Role role)
        {
            role.IsDelete = true;
            UpdateRole(role);
        }

        public void EditRolesUser(List<int> rolesId, int userId)
        {
            _context.UserRoles.Where(r => r.UserId == userId).ToList().ForEach(r => _context.UserRoles.Remove(r));
            AddRolesToUser(rolesId, userId);
        }

        public List<Permission> GetAllPermission()
        {
            return _context.Permission.ToList();
        }

        public Role GetRoleById(int roleId)
        {
           return _context.Roles.Find(roleId);
        }

        public List<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }

        public List<int> PermissionRole(int roleId)
        {
           return  _context.RolePermission
                    .Where(p => p.RoleId == roleId)
                    .Select(p => p.PermissionId)
                    .ToList();
        }

        public void UpdatePermissionRole(int roleId, List<int> permissions)
        {
            _context.RolePermission.RemoveRange(_context.RolePermission.Where(p=>p.RoleId == roleId).ToList());
            AddPermissionToRole(roleId, permissions);
        }

        public void UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }
    }
}
