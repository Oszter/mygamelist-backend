using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyGameList.Data;
using MyGameList.Models;

namespace MyGameList.Services
{

    public class UserService(MyGameListContext context)
    {
        public readonly MyGameListContext _context = context;

        public IEnumerable<User> GetAll()
        {
            return [.. _context.Users.AsNoTracking()];
        }

        public User GetById(int id)
        {
            return _context.Users
            .Include(p => p.Tracker)
            .AsNoTracking()
            .SingleOrDefault(p => p.Id == id);
        }
    }
}