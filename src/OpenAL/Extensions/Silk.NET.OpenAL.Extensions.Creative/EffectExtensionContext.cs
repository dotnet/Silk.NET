// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// Exposes the context-related functions of the Effects Extension.
    /// </summary>
    [Extension("ALC_EXT_EFX")]
    [NativeApi(Prefix = "alc")]
    public partial class EffectExtensionContext : NativeExtension<ALContext>
    {
        /// <inheritdoc cref="ExtensionBase" />
        public EffectExtensionContext(INativeContext ctx)
            : base(ctx)
        {
        }

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetIntegerv")]
        public unsafe partial void GetContextProperty(nint device, EFXContextInteger param, int size, int* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetIntegerv")]
        public unsafe partial void GetContextProperty(Device* device, EFXContextInteger param, int size, int* data);

        /// <summary>
        /// Gets the major version of the Effect Extension.
        /// </summary>
        /// <param name="device">The device that the context is on.</param>
        /// <returns>The major version.</returns>
        public int GetEFXMajorVersion(nint device)
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
        public int GetEFXMinorVersion(nint device)
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
        public Version GetEFXVersion(nint device)
        {
            return new Version(GetEFXMajorVersion(device), GetEFXMinorVersion(device));
        }
    }
}