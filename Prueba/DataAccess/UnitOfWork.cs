//----------------------------------------------------------------------- 
// Copyright (c) 2019 All rights reserved.
// </copyright>
// <author>Jorge Pertuz Egea/Jpertuz</author>
// <date>Agosto 2022</date>
//-----------------------------------------------------------------------


using DataAccess.Interfaces;
using DataAccess.Repositories;
using System;

namespace DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private bool disposedValue;
        private readonly ContextDB PruebaContextDB;

        public UnitOfWork(ContextDB _PruebaContextDB)
        {
            this.PruebaContextDB = _PruebaContextDB;
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            return new Repository<TEntity>(PruebaContextDB);
        }

        public bool SaveChanges()
        {
            return PruebaContextDB.SaveChanges() > 0;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    PruebaContextDB.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
