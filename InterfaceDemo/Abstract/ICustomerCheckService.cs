using InterfaceDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
