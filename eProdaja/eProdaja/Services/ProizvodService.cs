using AutoMapper;
using eProdaja.Database;
using eProdaja.Model;
using eProdaja.Model.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodService :BaseCRUDService<Model.Proizvodi,Database.Proizvodi, ProizvodiSearchObject,ProizvodiInsertRequest,ProizvodiUpdateRequest>, IProizvodiService
    {
       
        public ProizvodService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override IEnumerable<Model.Proizvodi> Get(ProizvodiSearchObject search = null)
        {
            var entity = Context.Set<Database.Proizvodi>().AsQueryable();//UPITE DA PISEMO
            //WARNING: NEVER DO THIS. EXECUTES QUERY ON DB
            //entity = entity.ToList();
            //Ako parametar iz searchobjecta nije prazan
            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                entity = entity.Where(x => x.Naziv.Contains(search.Naziv));
            }
            if (search.JedinicaMjereId.HasValue)
            {
                entity = entity.Where(x => x.JedinicaMjereId == search.JedinicaMjereId);
            }

            if (search.VrstaId.HasValue)
            {
                entity = entity.Where(x => x.VrstaId == search.VrstaId);
            }
            if (search?.IncludeJedinicaMjere == true)
            {
                entity = entity.Include(x => x.JedinicaMjere);
            }

            if (search?.IncludeList.Length > 0)
            {
                foreach (var item in search.IncludeList)
                {
                    entity = entity.Include(item);
                }
            }
            var list = entity.ToList();
            return _mapper.Map<List<Model.Proizvodi>>(list);
        }
   

    }
}
