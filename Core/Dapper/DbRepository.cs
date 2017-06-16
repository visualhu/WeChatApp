using System;


namespace Core.Dapper
{
    public abstract class DbRepository
    {
        private readonly IDbContext _context;
        protected DbRepository(IDbContext context)
        {
            _context = context;
        }

        protected IDbContext Context
        {
            get { return _context; }
        }
    }
}
