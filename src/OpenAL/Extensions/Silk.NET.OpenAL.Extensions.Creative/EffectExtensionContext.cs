// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;
namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// Exposes the context-related functions of the Effects Extension.
    /// </summary>
    [Extension("AL_EXT_EFX")]
    [NativeApi(Prefix = "alc")]
    public abstract class EffectExtensionContext : NativeExtension<AL>
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected EffectExtensionContext(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetIntegerv")]
        public abstract unsafe void GetContextProperty(IntPtr device, EFXContextInteger param, int size, int* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetIntegerv")]
        public abstract unsafe void GetContextProperty(Device* device, EFXContextInteger param, int size, int* data);

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
    }
}