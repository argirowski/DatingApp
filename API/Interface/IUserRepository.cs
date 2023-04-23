﻿using API.Dtos;
using API.Entities;

namespace API.Interface
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserById(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task <IEnumerable<MemberDto>> GetMembersAsync();
        Task <MemberDto> GetMemberAsync(string username);
    }
}