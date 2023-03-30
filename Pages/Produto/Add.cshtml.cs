using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_DAPPER.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_DAPPER.Pages.Produto
{
    public class AddModel : PageModel
    {

        IProdutoRepository _produtoRepository;

        public AddModel(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [BindProperty]
        public Entities.Produto Produto { get; set; }

        [TempData]
        public string Message { get; set; }

        public IActionResult getOn()
        {
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            if (ModelState.IsValid)
            {
                var count = _produtoRepository.Add(Produto);
                if (count > 0)
                {
                    Message = "Produto Criado Com Sucesso";
                    return RedirectToPage("/Produto/Index");
                }

            }
            return Page();
        }

    }
}
