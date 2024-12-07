using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practos_6.youyou
{
    internal class Myao
    {
        public static string ConnectionString = "Server=DESKTOP-I89TMU1\\SQLEXPRESS;Database=Practos6;Integrated Security=True;";
        public static Practos6Entities dbo = new Practos6Entities();
        public static LoyaltyPrograms loyaltyPrograms;
        public static Audience audience;
        public static PurchaseHistory purchaseHistory;
        public static TicketTypes ticketTypes;
        public static Tickets tickets;
        public static Artists artists;
        public static SostavArtists sostavArtists;
        public static ShowSchedule showSchedule;
        public static PaymentMethods paymentMethods;
        public static Genres genres;
        public static Plays plays;
    }
}
