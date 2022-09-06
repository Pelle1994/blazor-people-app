﻿using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Interfaces
{
    public interface IPeopleService
    {
        Task<IList<Person>> GetAll();

        Task AddPerson(Person person);
    }
}
