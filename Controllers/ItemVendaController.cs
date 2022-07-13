using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using desafio_final_atos.Data;
using desafio_final_atos.Models;

namespace desafio_final_atos.Controllers
{
    public class ItemVendaController : Controller
    {
        private readonly desafio_final_atosContext _context;

        public ItemVendaController(desafio_final_atosContext context)
        {
            _context = context;
        }

        // GET: ItemVenda
        public async Task<IActionResult> Index()
        {
              return _context.ItemVenda != null ? 
                          View(await _context.ItemVenda.ToListAsync()) :
                          Problem("Entity set 'desafio_final_atosContext.ItemVenda'  is null.");
        }

        // GET: ItemVenda/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ItemVenda == null)
            {
                return NotFound();
            }

            var itemVenda = await _context.ItemVenda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemVenda == null)
            {
                return NotFound();
            }

            return View(itemVenda);
        }

        // GET: ItemVenda/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ItemVenda/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Quantidade,PrecoUnitario,PrecoTotal,IdProduto,IdVenda")] ItemVenda itemVenda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(itemVenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(itemVenda);
        }

        // GET: ItemVenda/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ItemVenda == null)
            {
                return NotFound();
            }

            var itemVenda = await _context.ItemVenda.FindAsync(id);
            if (itemVenda == null)
            {
                return NotFound();
            }
            return View(itemVenda);
        }

        // POST: ItemVenda/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Quantidade,PrecoUnitario,PrecoTotal,IdProduto,IdVenda")] ItemVenda itemVenda)
        {
            if (id != itemVenda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(itemVenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemVendaExists(itemVenda.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(itemVenda);
        }

        // GET: ItemVenda/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ItemVenda == null)
            {
                return NotFound();
            }

            var itemVenda = await _context.ItemVenda
                .FirstOrDefaultAsync(m => m.Id == id);
            if (itemVenda == null)
            {
                return NotFound();
            }

            return View(itemVenda);
        }

        // POST: ItemVenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ItemVenda == null)
            {
                return Problem("Entity set 'desafio_final_atosContext.ItemVenda'  is null.");
            }
            var itemVenda = await _context.ItemVenda.FindAsync(id);
            if (itemVenda != null)
            {
                _context.ItemVenda.Remove(itemVenda);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemVendaExists(int id)
        {
          return (_context.ItemVenda?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
