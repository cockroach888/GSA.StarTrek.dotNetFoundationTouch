using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace GenericHost4Lib01
{
    public static class UniqueOfMultipleImplementationsExtensions
    {
        /// <summary>
        /// Get unique service of type <typeparamref name="TService"/> from the <see cref="IServiceProvider"/>.
        /// </summary>
        /// <typeparam name="TService">The type of service object to get.</typeparam>
        /// <param name="provider">The <see cref="IServiceProvider"/> to retrieve the service object from.</param>
        /// <param name="uniqueId">The Unique Id.</param>
        /// <returns>A service object of type <typeparamref name="TService"/> or null if there is no such service.</returns>
        public static TService GetService<TService>(this IServiceProvider provider, string uniqueId)
        {
            if (provider == null)
            {
                throw new ArgumentNullException(nameof(provider));
            }

            var implementations = provider.GetServices<TService>();

            if (implementations == null || implementations.Count() <= 0)
            {
                throw new InvalidOperationException($"No service for type '{nameof(TService)}' has been registered.");
            }

            foreach (var item in implementations)
            {
                if (item is IUniqueOfMultipleImplementations result && result.UniqueId == uniqueId)
                {
                    return item;
                }
            }
            return default(TService);
        }

        /// <summary>
        /// Get unique service of type <typeparamref name="TService"/> from the <see cref="IServiceProvider"/>.
        /// </summary>
        /// <typeparam name="TService">The type of service object to get.</typeparam>
        /// <typeparam name="TImplementation">The type of the implementation to use.</typeparam>
        /// <param name="provider">The <see cref="IServiceProvider"/> to retrieve the service object from.</param>
        /// <returns>A service object of type <typeparamref name="TService"/> or null if there is no such service.</returns>
        public static TService GetService<TService, TImplementation>(this IServiceProvider provider)
        {
            if (provider == null)
            {
                throw new ArgumentNullException(nameof(provider));
            }

            var implementations = provider.GetServices<TService>();

            if (implementations == null || implementations.Count() <= 0)
            {
                throw new InvalidOperationException($"No service for type '{nameof(TService)}' has been registered.");
            }

            return implementations.FirstOrDefault(t => t.GetType() == typeof(TImplementation));
        }
    }
}
