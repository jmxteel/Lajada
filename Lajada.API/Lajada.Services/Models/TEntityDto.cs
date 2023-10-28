using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lajada.Services.Models
{
    public class TEntityDto<TEntity>
    {
        public TEntity? Entity { get; set; }
    }
}
