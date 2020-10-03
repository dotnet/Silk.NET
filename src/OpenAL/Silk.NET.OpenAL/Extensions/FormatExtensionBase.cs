// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenAL.Extensions
{
    /// <summary>
    /// Base class for OpenAL extensions that add audio formats.
    /// </summary>
    /// <typeparam name="TExtendedBufferFormat">The extended buffer format enumeration.</typeparam>
    public abstract class FormatExtensionBase<TExtendedBufferFormat> : NativeExtension<AL>
        where TExtendedBufferFormat : struct, Enum
    {
        /// <inheritdoc cref="ExtensionBase" />
        protected FormatExtensionBase(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }

        /// <inheritdoc cref="BufferData" />
        public abstract unsafe void BufferData(uint buffer, TExtendedBufferFormat format, void* data, int size,
            int frequency);

        /// <summary>
        /// Fills a buffer with audio data.
        /// </summary>
        /// <typeparam name="TElement">The type of the data.</typeparam>
        /// <param name="buffer">The buffer to fill.</param>
        /// <param name="format">The format of the data.</param>
        /// <param name="data">The data.</param>
        /// <param name="frequency">The frequency of the data.</param>
        public void BufferData<TElement>(uint buffer, TExtendedBufferFormat format, TElement[] data, int frequency)
            where TElement : unmanaged
        {
            unsafe
            {
                var size = sizeof(TElement) * data.Length;
                fixed (void* ptr = data)
                {
                    BufferData(buffer, format, ptr, size, frequency);
                }
            }
        }
    }
}