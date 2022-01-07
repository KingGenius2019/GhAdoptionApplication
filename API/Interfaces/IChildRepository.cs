using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Interfaces
{
    public interface IChildRepository
    {
        //  Task<PagedList<Child>> GetChildrenAsync(ChildParams childParams);
         Task<IEnumerable<Child>> GetChildrenAsync ();
              Task<Child> GetChildByIdAsync(int chld);
        Task<Child> GetChildByCodeAsync(string chldcode);
        // Task<Child> GetChildReviewByIdAsync(int childid);
        Task<Child> AddChildrenAsync(Child child);
      
    
        // Task<Photo> GetMainPhotoForChild(int childId);
       

        void Updatec(string  childcode);
        Task<bool> SaveAllAsync();

        void DeleteChild(int chld);
    }
}