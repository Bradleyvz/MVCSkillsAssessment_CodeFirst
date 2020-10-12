using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCSkillsAssessment_CodeFirst.Startup))]
namespace MVCSkillsAssessment_CodeFirst
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
