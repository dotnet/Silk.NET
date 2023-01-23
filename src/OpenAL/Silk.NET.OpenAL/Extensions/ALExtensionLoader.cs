// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Microsoft.Extensions.DependencyModel;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions
{
    /// <summary>
    /// A loader for OpenAL extensions.
    /// </summary>
    [Obsolete
    (
        "This class is deprecated and will be removed in Silk.NET 3.0. "+
        "Please use the TryGetExtension method on ALContext."
    )]
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
                ? (TContextExtension)Activator.CreateInstance(typeof(TContextExtension), baseApi.Context)
                : null;
        }
    }
}