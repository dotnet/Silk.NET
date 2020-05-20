// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Microsoft.Extensions.DependencyModel;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

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
            where TContextExtension : NativeExtension<ALContext>
        {
            return baseApi.IsExtensionPresent(ExtensionAttribute.GetExtensionAttribute(typeof(TContextExtension)).Name)
                ? LibraryActivator.CreateInstance<TContextExtension>(baseApi.Library)
                : null;
        }
    }
}