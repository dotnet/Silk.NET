using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions
{
    /// <summary>
    /// A loader for OpenAL extensions.
    /// </summary>
    public static class ALExtensionLoader
    {
        /// <summary>
        /// Loads the API for the given extension, using the base API.
        /// </summary>
        /// <param name="device">The device of the context.</param>
        /// <param name="baseAPI">The base API instance.</param>
        /// <typeparam name="TContextExtension">The extension type.</typeparam>
        /// <returns>The extension.</returns>
        /// <exception cref="ExtensionNotSupportedException">Thrown if the API doesn't support the extension.</exception>
        internal static TContextExtension LoadContextExtension<TContextExtension>(ALContext baseApi)
            where TContextExtension:NativeExtension<ALContext>
        {
            return LibraryLoader.Load<TContextExtension, ALContext>(baseApi);
        }
    }
}
