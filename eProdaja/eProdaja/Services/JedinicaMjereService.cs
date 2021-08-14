using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Database;

namespace eProdaja.Services
{
    public class JedinicaMjereService : BaseReadService<Model.JediniceMjere,Database.JediniceMjere, object> , IJedinicaMjereService
    {
     
        public JedinicaMjereService(eProdajaContext context, IMapper mapper) //konstruktor
          :base(context,mapper)
        {
            
        }
       
    
    }
}
