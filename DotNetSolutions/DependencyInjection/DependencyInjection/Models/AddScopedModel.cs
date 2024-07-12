using DependencyInjection.Models.Interfaces;

namespace DependencyInjection.Models
{
    public class AddScopedModel : IAddScoped
    {
        Guid id;

        public AddScopedModel()
        {
            id = Guid.NewGuid();
        }

        public Guid GetAddScopedOperationID()
        {
            return id;
        }
    }
}
