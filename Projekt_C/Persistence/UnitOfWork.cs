using Projekt_C.Core;
using Projekt_C.Persistence.Repositories;
using System;

namespace Projekt_C.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public CategoryRepository Category => throw new NotImplementedException();

        public FeedRepository Feed => throw new NotImplementedException();
    }
}
