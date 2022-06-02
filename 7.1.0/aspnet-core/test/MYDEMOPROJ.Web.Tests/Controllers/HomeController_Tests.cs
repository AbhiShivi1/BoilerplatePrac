using System.Threading.Tasks;
using MYDEMOPROJ.Models.TokenAuth;
using MYDEMOPROJ.Web.Controllers;
using Shouldly;
using Xunit;

namespace MYDEMOPROJ.Web.Tests.Controllers
{
    public class HomeController_Tests: MYDEMOPROJWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}