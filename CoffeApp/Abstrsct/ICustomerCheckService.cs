﻿using CoffeApp.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeApp.Abstrsct
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);

    }
}
