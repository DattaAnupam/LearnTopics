using DependencyInjection.Models.Interfaces;

namespace DependencyInjection.Models
{
    public class DiOperations : IAddSingleTon, IAddScoped, IAddTransient
    {
        Guid ID;

        public DiOperations()
        {
            ID = Guid.NewGuid();
        }

        public Guid GetOperationID()
        {
            return ID;
        }
    }
}
