﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BookMovieTickets.Data
{
    public partial class ShowTime
    {
        public ShowTime()
        {
            BookTickets = new HashSet<BookTicket>();
        }

        public int Id { get; set; }
        public int? CinemaRoomId { get; set; }
        public int? MovieId { get; set; }
        public DateTime? ShowDate { get; set; }
        public DateTime? ShowTime1 { get; set; }
        public double? TicketPrice { get; set; }
        public int? NumTicket { get; set; }
        public bool? Deleted { get; set; }
        public string Role { get; set; }

        public virtual CinemaRoom CinemaRoom { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual ICollection<BookTicket> BookTickets { get; set; }
    }
}
