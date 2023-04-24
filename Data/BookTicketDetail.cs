﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BookMovieTickets.Data
{
    public partial class BookTicketDetail
    {
        public int Id { get; set; }
        public int? BookTicketId { get; set; }
        public int? ChairId { get; set; }
        public double? TicketPrice { get; set; }

        public virtual BookTicket BookTicket { get; set; }
        public virtual Chair Chair { get; set; }
    }
}
