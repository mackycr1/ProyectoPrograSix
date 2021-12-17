using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Entity;
using WBL;

namespace Programacion61.Pages.Categoria
{
    public class GridModel : PageModel
    {
        private readonly ServiceApi service;

        public GridModel(ServiceApi service)
        {
            this.service = service;
        }

        public IEnumerable<CategoriaEntity> GridList { get; set; } = new List<CategoriaEntity>();


        public async Task<IActionResult> OnGet()
        {

            try
            {
                GridList = await service.CategoriaGet();

                return Page();

            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

        }

        //public async Task<IActionResult> OnDelete(int id)
        //{
        //    try
        //    {
        //        var result = await categoriaService.Delete(new() { IdCategoria = id });
        //        return new JsonResult(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new JsonResult(new DBEntity { CodeError = ex.HResult, MsgError = ex.Message });
        //    }
        //}
    }
}
