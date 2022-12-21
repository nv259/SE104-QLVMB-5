using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class TicketDAO
    {
        private Ticket ticket;
        private static TicketDAO instance;

        public static TicketDAO Instance { get { if (instance == null) instance = new TicketDAO(); return instance; } }

        public Ticket[] GetAllTicketType()
        {
            Ticket[] tickets = new Ticket[2];
            string query = "SELECT * FROM [dbo].HANGVE";
            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(query);
            
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                tickets[i++] = new Ticket(dr);
            }

            if (i != 0) return tickets;
            return null;
        }
    }
}
