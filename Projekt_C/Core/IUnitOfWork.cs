
using Projekt_C.Persistence.Repositories;

namespace Projekt_C.Core
{
    public interface IUnitOfWork 
    {
        CategoryRepository Category { get; }
        FeedRepository Feed { get; }
    }
}
