// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenAL.Extensions.EXT
{
    /// <summary>
    /// Exposes the multi-channel buffers extension by Creative Labs.
    /// </summary>
    [Extension("AL_EXT_float32")]
    [NativeApi(Prefix = "al")]
    public partial class FloatFormat : FormatExtensionBase<FloatBufferFormat>
    {
        /// <inheritdoc cref="ExtensionBase" />
        public FloatFormat(INativeContext ctx)
            : base(ctx)
        {
        }
    }

    /// <summary>
    /// Extends the AL functions abilities to make use of the float enums provided by AL_EXT_float32.
    /// </summary>
    public static class FloatFormatALExtensions
    {
        public static unsafe void BufferData(this AL al, uint buffer, FloatBufferFormat format, void* data, int size, int frequency)
        {
            al.BufferData(buffer, (BufferFormat) format, data, size, frequency);
        }

        public static void BufferData<TElement>(this AL al, uint buffer, FloatBufferFormat format, TElement[] data, int frequency)
            where TElement : unmanaged
        {
            al.BufferData<TElement>(buffer, (BufferFormat) format, data, frequency);
        }
    }
}
