using Medium.Configuration;
using Medium.Persistence;

namespace Medium
{
    public static class Extensions
    {
        public static IMediumConfigurator AddInMemoryRepository(this IMediumConfigurator configurator)
        {
            var repository = new InMemoryWebhookRepository();
            configurator.SetRepository(repository);

            return configurator;
        } 
    }
}