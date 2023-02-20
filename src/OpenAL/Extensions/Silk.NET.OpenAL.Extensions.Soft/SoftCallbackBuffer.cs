// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.OpenAL;

namespace Silk.NET.OpenAL.Extensions.Soft
{
    /// <summary>
    /// Exposes the public API of functions added by AL_SOFT_callback_buffer
    /// </summary>
    [NativeApi(Prefix = "al")]
    [Extension("AL_SOFT_callback_buffer")]
    public unsafe partial class SoftCallbackBuffer : NativeExtension<AL> 
    {
        /// <inheritdoc cref="ExtensionBase" />
        public SoftCallbackBuffer(INativeContext ctx)
            : base(ctx) 
        {
        }

        /// <inheritdoc />
        [NativeApi(EntryPoint = "BufferCallbackSOFT")]
        public partial void BufferCallback(uint buffer, BufferFormat format, int freq, PfnBufferCallback callback, void* userPtr);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetBufferPtrSOFT")]
        public partial void GetBufferPtr(uint buffer, SoftBufferCallback param, void** ptr);
        
        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetBuffer3PtrSOFT")]
        public partial void GetBuffer3Ptr(uint buffer, SoftBufferCallback param, void** ptr0, void** ptr1, void** ptr2);
        
        /// <inheritdoc />
        [NativeApi(EntryPoint = "GetBufferPtrvSOFT")]
        public partial void GetBufferPtrv(uint buffer, SoftBufferCallback param, void** ptr);
    }
}
