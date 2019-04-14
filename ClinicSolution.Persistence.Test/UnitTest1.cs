using System;
using AutoMapper;
using ClinicSolution.Domain.DocumentTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClinicSolution.Infraestructure.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddDocumentTypes()
        {
            DocumentTypeEntity result;
            var config = new MapperConfiguration(cfg => cfg.CreateMap<DocumentType, DocumentTypeEntity>());
            IDocumentType documentType = new DocumentType
            {
                DocumentName = "Cedula",
            };
            var mapper = config.CreateMapper();
            DocumentTypeEntity obj = mapper.Map<DocumentTypeEntity>(documentType);
            using (var context = new ContextDb())
            {
                try
                {
                    result = context.DocumentTypes.Add(obj);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    result = null;
                    Assert.IsTrue(ex != null);
                }
            }
            Assert.IsNotNull(result);
        }
    }
}
