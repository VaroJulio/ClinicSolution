using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ClinicSolution.Domain.DocumentTypes;
using ClinicSolution.Domain.Patients;
using ClinicSolution.Persistence;
using ClinicSolution.WebApi.App_Start;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unity;

namespace ClinicSolution.Infraestructure.Test
{
    [TestClass]
    public class UnitTest1
    {
        private IMapper mapper;


        [TestInitialize]
        public void Init()
        {
            var mapperConfig = MappingProfile.InitializeAutoMapper();
            mapper = mapperConfig.CreateMapper();
        }


        [TestMethod]
        public void AddPatient()
        {
            PatientEntity result = new PatientEntity();
            using (var context = new ContextDb(mapper))
            {
                try
                {
                    var patient1 = new Patient() { Document = "1067876365", DocumentTypeId = context.DocumentTypes.FirstOrDefault(x => x.DocumentName == "Cedula").Id, FirstName = "Thanos", LastName = "Dios del Universo", PhoneNumber = "3193745954", Email = "thanos@hotmail.com", BirthDay = new DateTime(1930, 4, 23) };                   
                    result = context.Patients.Add(mapper.Map<PatientEntity>(patient1));
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("El error: " + ex);
                    Assert.Fail("Error: " + ex);
                }
            }
            Assert.IsNotNull(result.Document);
        }
    }
}
