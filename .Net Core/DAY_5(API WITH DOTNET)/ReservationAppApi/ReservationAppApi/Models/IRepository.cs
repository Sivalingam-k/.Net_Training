namespace ReservationAppApi.Models
{
    public interface IRepository
    {
        IEnumerable<Reservation> Reservations { get; }//Getting All Reservation
        Reservation this[int id] { get; }//Getting Specific Reservation

        Reservation AddReservation(Reservation reservation);//Adding Reservation


        Reservation UpdateReservation(Reservation reservation);//Updating Reservation

        void DeleteReservation(int id);//Deleting Reservation
    }
}
