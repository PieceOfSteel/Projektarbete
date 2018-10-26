using Projekt_C.Core.Repositories;
using System;

namespace Projekt_C.Persistence.Repositories
{
    abstract public class Repository : IRepository<IPersistent>
    {
        public string Path { get; set; }
        public void Add(IPersistent persistent)
        {
            throw new NotImplementedException();
        }

        public IPersistent Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(IPersistent persistent)
        {
            throw new NotImplementedException();
        }
    }
}
