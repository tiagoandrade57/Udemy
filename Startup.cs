using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemadePedidosdeProdutos.Startup))]
namespace SistemadePedidosdeProdutos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
