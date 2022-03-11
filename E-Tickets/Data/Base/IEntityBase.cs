using E_Tickets.Data;
using E_Tickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Tickets.Data.Base
{
    public interface IEntityBase
    {
        int Id { get; set; }
    }
}