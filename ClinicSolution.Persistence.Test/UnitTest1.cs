using System;
using AutoMapper;
using ClinicSolution.Domain.DocumentTypes;
using ClinicSolution.Persistence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClinicSolution.Infraestructure.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Init()
        {

        }


        [TestMethod]
        public void AddDocumentTypes()
        {
            //DocumentTypeEntity result;
            //var config = new MapperConfiguration(cfg => cfg.CreateMap<DocumentType, DocumentTypeEntity>());
            //IDocumentType documentType = new DocumentType
            //{
            //    DocumentName = "Cedula de Extranjeria",
            //};
            //var mapper = config.CreateMapper();
            //DocumentTypeEntity obj = mapper.Map<DocumentTypeEntity>(documentType);
            //using (var context = new ContextDb())
            //{
            //    try
            //    {
            //        result = context.DocumentTypes.Add(obj);
            //        context.SaveChanges();
            //    }
            //    catch (Exception ex)
            //    {
            //        result = null;
            //        Assert.IsTrue(ex != null);
            //    }
            //}
            //Assert.IsNotNull(result);
        }
    }
}
