﻿using BookMovieTickets.Models;
using BookMovieTickets.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMovieTickets.Services
{
    public interface IShowTimeRepository
    {
        List<MessageVM> GetAll();
        MessageVM GetById(int id);
        List<MessageVM> GetByMovieId(int movie_id);
        MessageVM CreateShowTime(ShowTimeDTO dto);
        MessageVM UpdateShowTime(ShowTimeDTO dto);
        MessageVM UpdateShowTimeById(ShowTimeDTO dto, int id);
        MessageVM DeleteShowTime(int id);
    }
}
