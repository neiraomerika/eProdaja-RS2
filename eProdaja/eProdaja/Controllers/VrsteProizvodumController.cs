using eProdaja.Model;
using eProdaja.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class VrsteProizvodumController : BaseReadController<Model.VrsteProizvodum,object>
    {
        public VrsteProizvodumController(IVrsteProizvodumService service)
            :base(service)
        { 

        }
    }
}
