﻿using GestionServicios.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionServicios.Domain.Users;

public interface IUserRepository : IRepository<User>
{
}
