﻿using BookMovieTickets.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMovieTickets.Services
{
    public interface IResultRaitingRepository
    {
        List<MessageVM> GetAllRaitings();
    }
}
