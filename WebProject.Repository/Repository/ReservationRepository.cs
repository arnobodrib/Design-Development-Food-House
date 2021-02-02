using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using WebProject.Model.Model;
using WebProject.DatabaseContext.DatabaseContext;



namespace WebProject.Repository.Repository
{
    public class ReservationRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();

        public bool Add(Reservation reserves)
        {
            _dbContext.Reservation.Add(reserves);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Reservation> GetAll()
        {
            return _dbContext.Reservation.ToList();
        }
    }
}
