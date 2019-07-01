//
// EffectExtensionContext.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;
using AdvancedDLSupport;
using Silk.NET.Core.Extensions;
using Silk.NET.Core.Loader;

namespace Silk.NET.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// Exposes the context-related functions of the Effects Extension.
    /// </summary>
    [Extension("AL_EXT_EFX")]
    public abstract class EffectExtensionContext : ExtensionBase, IEFXContext
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected EffectExtensionContext(string path, ImplementationOptions options)
            : base(path, options)
        {
        }

        /// <summary>
        /// Gets the major version of the Effect Extension.
        /// </summary>
        /// <param name="device">The device that the context is on.</param>
        /// <returns>The major version.</returns>
        public int GetEFXMajorVersion(IntPtr device)
        {
            unsafe
            {
                var result = 0;
                GetContextProperty(device, EFXContextInteger.EFXMajorVersion, sizeof(int), &result);

                return result;
            }
        }

        /// <summary>
        /// Gets the minor version of the Effect Extension.
        /// </summary>
        /// <param name="device">The device that the context is on.</param>
        /// <returns>The minor version.</returns>
        public int GetEFXMinorVersion(IntPtr device)
        {
            unsafe
            {
                var result = 0;
                GetContextProperty(device, EFXContextInteger.EFXMinorVersion, sizeof(int), &result);

                return result;
            }
        }

        /// <summary>
        /// Gets the version of the Effect Extension.
        /// </summary>
        /// <param name="device">The device that the context is on.</param>
        /// <returns>The version.</returns>
        public Version GetEFXVersion(IntPtr device)
        {
            return new Version(GetEFXMajorVersion(device), GetEFXMinorVersion(device));
        }

        /// <inheritdoc />
        public abstract unsafe void GetContextProperty(IntPtr device, EFXContextInteger param, int size, int* data);
    }
}
