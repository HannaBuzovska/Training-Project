using System.Collections.Generic;
using System.Linq;
using Training.Data.Context;
using Training.Data.Models;

namespace Training.Data.Repository
{
    public class DoctorRepository : IRepository<Doctor>
    {
      private readonly WebApiCoreContext context;
      public IEnumerable<Doctor> All => context.Doctors.ToList();
      public DoctorRepository(WebApiCoreContext context)
      {
         this.context = context;
      }
      public void Add(Doctor entity)
      {
         context.Doctors.Add(entity);
      }
      public void Delete(Doctor entity)
      {
         context.Doctors.Remove(entity);
         context.SaveChanges();
      }
      public Doctor FindById(string Id)
      {
         throw new System.NotImplementedException();
      }
      public void Update(Doctor entity)
      {
         context.Doctors.Update(entity);
         context.SaveChanges();
      }

      public Doctor FindById(int Id)
      {
         throw new System.NotImplementedException();
      }
   }
}