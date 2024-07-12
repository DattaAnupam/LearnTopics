using DependencyInjection.Models.Interfaces;

namespace DependencyInjection.Models
{
    public class AddTransientModel : IAddTransient
    {
        Guid id;

        public AddTransientModel()
        {
            id = Guid.NewGuid();
        }

        public Guid GetAddTransiendOperationID()
        {
            return id;
        }
    }
}
