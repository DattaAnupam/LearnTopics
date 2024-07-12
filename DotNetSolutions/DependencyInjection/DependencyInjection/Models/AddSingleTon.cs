using DependencyInjection.Models.Interfaces;

namespace DependencyInjection.Models
{
    public class AddSingleTon : IAddSingleTon
    {
        Guid ID;

        public AddSingleTon()
        {
            ID = Guid.NewGuid();
        }

        public Guid GetOperationID()
        {
            return ID; 
        }
    }
}
