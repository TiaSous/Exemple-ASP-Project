using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.OM;


namespace Domain.Interfaces
{
    public interface IPasswordHelper
    {
        string HashPassword(OMUser user, string password);
    }
}
