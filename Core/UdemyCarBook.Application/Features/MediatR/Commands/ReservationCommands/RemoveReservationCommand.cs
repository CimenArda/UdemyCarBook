﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.MediatR.Commands.ReservationCommands
{
    public class RemoveReservationCommand :IRequest
    {
        public RemoveReservationCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
