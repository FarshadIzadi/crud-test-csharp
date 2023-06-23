﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customers.Commands.DeleteCustomer
{
    internal class DeleteCustomerCommand : IRequest
    {
        public int Id { get; set; }
    }
}