
using eProdaja.Model;
using eProdaja.Model.Request;
using eProdaja.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
 
    public class ProizvodController : BaseCRUDController<Model.Proizvodi,ProizvodiSearchObject,ProizvodiInsertRequest,ProizvodiUpdateRequest>
    {
        

        public ProizvodController(ICRUDService<Proizvodi,ProizvodiSearchObject,ProizvodiInsertRequest,ProizvodiUpdateRequest> proizvodService):base(proizvodService)
        {
            
        }

       


    }
}
