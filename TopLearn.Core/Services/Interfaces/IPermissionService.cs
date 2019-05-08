using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.DataLayer.Entities.Permission;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Core.Services.Interfaces
{
    public interface IPermissionService
    {
        #region Role
        Role GetRoleById(int roleId);
        int AddRole(Role role);
        List<Role> GetRoles();
        void UpdateRole(Role role);
        void DeleteRole(Role role);
        void AddRolesToUser(List<int> rolesId, int userId);
        void EditRolesUser(List<int> rolesId, int userId);
        #endregion

        #region Permission
        List<Permission> GetAllPermission();
        void AddPermissionToRole(int roleId, List<int> permissions);
        List<int> PermissionRole(int roleId);
        void UpdatePermissionRole(int roleId, List<int> permissions);
        bool CheckPermission(int permissionId, string userName);
        #endregion

    }
}
