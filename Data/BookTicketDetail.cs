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
        public int? ComboId { get; set; }
        public int? CountCombo { get; set; }
        public int? ComboPrice { get; set; }
        public bool? State { get; set; }
        public int? ShowTimeId { get; set; }
        public bool? Deleted { get; set; }

        public virtual BookTicket BookTicket { get; set; }
        public virtual Chair Chair { get; set; }
        public virtual Combo Combo { get; set; }
        public virtual ShowTime ShowTime { get; set; }
    }
}
