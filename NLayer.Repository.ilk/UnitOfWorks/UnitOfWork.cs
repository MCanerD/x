using NLayer.Core.ilk.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.ilk.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges(); //Değişiklikleri veritabanına yansıt anlamı taşıyor.
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
