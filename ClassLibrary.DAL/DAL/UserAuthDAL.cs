using System;
using DealerApi.DAL.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace DealerApi.DAL.DAL;

public class UserAuthDAL : IUserAuth
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public UserAuthDAL(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }


    public async Task<bool> AddUserToRoleAsync(string email, string roleName)
    {
        try
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                throw new ArgumentException("User not found");
            }

            if (!await _roleManager.RoleExistsAsync(roleName))
            {
                throw new ArgumentException("Role does not exist");
            }

            var result = await _userManager.AddToRoleAsync(user, roleName);
            return result.Succeeded;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Error adding user to role: {ex.Message}", ex);
        }
    }

    public async Task<bool> CreateRoleAsync(string roleName)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(roleName))
            {
                throw new ArgumentException("Role name cannot be null or empty");
            }
            if (await _roleManager.RoleExistsAsync(roleName))
            {
                throw new ArgumentException("Role already exists");
            }
            var role = new IdentityRole(roleName);
            var result = await _roleManager.CreateAsync(role);
            return result.Succeeded;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Error creating role: {ex.Message}", ex);
        }
    }

    public async Task<List<string>> GetRolesByUserAsync(string email)
    {
        try
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                throw new ArgumentException("User not found");
            }

            var roles = await _userManager.GetRolesAsync(user);
            return roles.ToList();
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Error retrieving roles for user: {ex.Message}", ex);
        }
    }

    public async Task<IdentityUser> LoginAsync(string email, string password)
    {
        try
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                throw new ArgumentException("User not found");
            }

            var result = await _userManager.CheckPasswordAsync(user, password);
            if (!result)
            {
                throw new ArgumentException("Invalid password");
            }

            return user;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Error logging in user: {ex.Message}", ex);
        }
    }

    public async Task<bool> RegisterAsync(string username, string email, string password)
    {
        try
        {
            var user = new IdentityUser { Email = email, UserName = username };
            var result = await _userManager.CreateAsync(user, password);
            return result.Succeeded;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"Error registering user: {ex.Message}", ex);
        }
    }
}
