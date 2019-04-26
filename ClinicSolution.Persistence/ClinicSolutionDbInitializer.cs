using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClinicSolution.Domain.DocumentTypes;
using AutoMapper;
using System.Reflection;

namespace ClinicSolution.Persistence
{
    public class ClinicSolutionDbInitializer: DropCreateDatabaseIfModelChanges<ContextDb>
    {
        private readonly IMapper _mapper;
        public  ClinicSolutionDbInitializer(IMapper mapper)
        {
            _mapper = mapper;
        }
        protected override void Seed(ContextDb context)
        {
            IList<DocumentTypeEntity> EntityList = new List<DocumentTypeEntity>();
            var cedula =  new DocumentType() { DocumentName = "Cedula" };
            var cedulaEntity = _mapper.Map<DocumentTypeEntity>(cedula);
            EntityList.Add(cedulaEntity);
            var cedulaExtrangeria = new DocumentType() { DocumentName = "Cedula de extranjeria" };
            var extranjeriaEntity = _mapper.Map<DocumentTypeEntity>(cedulaExtrangeria);
            EntityList.Add(extranjeriaEntity);
            var tarjetaIdentidad = new DocumentType() { DocumentName = "Tarjeta de Identidad" };
            var tarjetaEntity = _mapper.Map<DocumentTypeEntity>(tarjetaIdentidad);
            EntityList.Add(tarjetaEntity);
            var registroCivil = new DocumentType() { DocumentName = "Registro civil" };
            var registroEntity = _mapper.Map<DocumentTypeEntity>(registroCivil);
            EntityList.Add(registroEntity);
            context.DocumentTypes.AddRange(EntityList);
            base.Seed(context);
        }
    }
}
