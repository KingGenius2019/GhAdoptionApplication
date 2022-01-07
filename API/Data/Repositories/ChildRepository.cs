using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;

namespace API.Data.Repositories
{
    public class ChildRepository : IChildRepository
    {
        private readonly DataContext _context;
        public ChildRepository(DataContext context)
        {
            _context = context;
        }

        public async  Task<Child> AddChildrenAsync(Child child)
        {
            var result = await _context.Children.AddAsync(child);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public void DeleteChild(int chld)
        {
            throw new NotImplementedException();
        }

        public Task<Child> GetChildByCodeAsync(string chldcode)
        {
            throw new NotImplementedException();
        }

        public Task<Child> GetChildByIdAsync(int chld)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Child>> GetChildrenAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new NotImplementedException();
        }

        public void Updatec(string childcode)
        {
            throw new NotImplementedException();
        }
    }
}