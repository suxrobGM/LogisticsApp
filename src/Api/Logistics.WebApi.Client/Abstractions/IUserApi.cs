﻿namespace Logistics.WebApi.Client;

public interface IUserApi
{
    Task<UserDto> GetUserAsync(string id);
    Task<UserRoleDto> GetUserRoleAsync(string userId);
    Task<PagedDataResult<UserDto>> GetUsersAsync(string searchInput = "", int page = 1, int pageSize = 10);
    Task<bool> UserExistsAsync(string id);
    Task CreateUserAsync(UserDto user);
    Task UpdateUserAsync(UserDto user);
    Task<bool> TryCreateUserAsync(UserDto user);
}
