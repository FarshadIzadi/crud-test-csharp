﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNmber { get; set; }
        public string Email { get; set; }

    }
}
