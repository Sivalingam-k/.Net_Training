


namespace ReservationAppApi.Models
{
    public class Repository : IRepository
    {
        private Dictionary<int, Reservation> items;
        public Repository()
        {
            items = new Dictionary<int, Reservation>();
            new List<Reservation>{
            new Reservation{id = 1, name="Eswaran", startLocation="Kanchipuram", endLocation="Tirukoilur"},
            new Reservation{id = 2, name="Suresh", startLocation="Kanchipuram", endLocation="Chennai"},
            new Reservation{id = 3, name="Basil", startLocation="Kanchipuram", endLocation="Chennai"},
            new Reservation{id = 4, name="Sandeep", startLocation="Kanchipuram", endLocation="Sankarapuram"},
    }.ForEach(r=>AddReservation(r));
        }

        public Reservation this[int id] => items.ContainsKey(id) ? items[id] : null;

        public IEnumerable<Reservation> Reservations => items.Values;

        public Reservation AddReservation(Reservation reservation)
        {
            if (reservation.id == 0)
            {
                int key = items.Count;
                while (items.ContainsKey(key)) { key++; };
                reservation.id = key;
            }
            items[reservation.id] = reservation;
            return reservation;
        }

        public void DeleteReservation(int id) => items.Remove(id);


        public Reservation UpdateReservation(Reservation reservation)=> AddReservation((Reservation)reservation);

    }
}
