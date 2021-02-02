using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.Repository.Repository;
using WebProject.Model.Model;

namespace WebProject.BLL.BLL
{
    public class ReservationManager
    {
        ReservationRepository _reserveRepository = new ReservationRepository();
        public bool Add(Reservation reserves)
        {
            return _reserveRepository.Add(reserves);
        }

        public List<Reservation> GetAll()
        {
            return _reserveRepository.GetAll();
        }

    }
}
