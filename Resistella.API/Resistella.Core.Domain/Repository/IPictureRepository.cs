using Resistella.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistella.Core.Framework.Repository
{
    public interface IPictureRepository<T> : IGenericRepository<T> where T : class
    {
    }
}
