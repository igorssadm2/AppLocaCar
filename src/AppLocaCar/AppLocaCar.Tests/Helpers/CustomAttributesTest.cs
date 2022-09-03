//using AppLocaCar.Helpers.DomainObject;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Xunit;

//namespace AppLocaCar.Tests.Helpers
//{
//    public class CustomAttributesTest
//    {
//        [Theory(DisplayName = "Valida Cpf - ok")]
//        [InlineData("373299630-11")]
//        [InlineData("37fds3ds299as6d30-11")]
//        [InlineData("37329963011")]

//        public void FuncaoValidaCpf_ok(string cpf)
//        {
//            //Arrange 

//            //Act 

//            //Assert 
//            Assert.True(CpfValueObject.ValidCPF(cpf));

//        }

//        [Theory(DisplayName = "Valida Cpf passando caracteres alem de numeros - ok")]
//        [InlineData("373299613-134")]
//        [InlineData("373299613-14")]
//        [InlineData("37fds3ds1ads299as6d30-11")]

//        public void FuncaoValidaCpf_Erro(string cpf)
//        {
//            //Arrange 

//            //Act 

//            //Assert 
//            Assert.False(CpfValueObject.ValidCPF(cpf));

//        }

//    }
//}
