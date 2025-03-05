using McvNetCoreUtilidades.Models;
using McvNetCoreUtilidades.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace McvNetCoreUtilidades.ViewComponents
{
    public class MenuCochesViewComponent: ViewComponent
    {
        private RepositoryCoches repo;

        public MenuCochesViewComponent(RepositoryCoches repo)
        {
            this.repo = repo;
        }

        //PODRIAMOS TENER TODOS LOS METODOS QUE DESEEMOS
        //ES OBLIGATORIO TENER EL METODO INVOKEASYNC CON TASK
        //Y SERA EL METODO QUE DEVOLVERA EL MODEL A LA VISTA

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Coche> coches = this.repo.GetCoches();
            return View(coches);
        }
    }
}
