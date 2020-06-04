using EP.CursoMvc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.CursoMvc.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CursoMvcContext _context;

        public UnitOfWork(CursoMvcContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
