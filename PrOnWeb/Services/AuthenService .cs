using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PrOnWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PrOnWeb.Services
{
    public class AuthenService
    {
        ApplicationDbContext _context;
        public AuthenService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<string>> GetPasswordHistoryAsync(string userId)
        {
            string Sql = $" select  top(5) Password AS StringValue  from [dbo].[PasswordHistory]  where UserId = '{userId}'  order by CreateDate desc ";
            List <ListOfString> passList = await _context.ListOfStrings.FromSqlRaw(Sql).ToListAsync();
            List<string> pass = new List<string>();
            foreach(var ps in passList)
            {
                pass.Add(ps.StringValue);
            }

            return pass;
        }

        public async Task UpdatePasswordHistoryAsync(string id, string hPassword)
        {
            PasswordHistory pass = new PasswordHistory();
            pass.UserId = id;
            pass.Password = hPassword;
            pass.CreateDate = DateTime.Now;
            _context.PasswordHistory.Add(pass);
            await _context.SaveChangesAsync();
        }
    }

}
