﻿using KD25_BitirmeProjesi.CoreLayer.Entities;
using KD25_BitirmeProjesi.CoreLayer.Repositories.Abstract;
using KD25_BitirmeProjesi.InfrastructureLayer.DAL;
using KD25_BitirmeProjesi.InfrastructureLayer.Repositories.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD25_BitirmeProjesi.InfrastructureLayer.Repositories.Concrete
{
    public class AppUserRepository : BaseAppUserRepository<AppUser>, IAppUserRepository
    {
        private readonly AppDbContext _context;
        private readonly IAppUserRepository _repo;


        public AppUserRepository(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<AppUser> GetUserSummaryAsync(int userId)
        {
            return await _repo.FindAsync(userId);
       
        }
    }
}
