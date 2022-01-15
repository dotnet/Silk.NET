// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.OpenGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_shader_image_load_store")]
    public unsafe partial class ArbShaderImageLoadStore : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_shader_image_load_store";
        [NativeApi(EntryPoint = "glBindImageTexture", Convention = CallingConvention.Winapi)]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] ARB access, [Flow(FlowDirection.In)] ARB format);

        [NativeApi(EntryPoint = "glBindImageTexture", Convention = CallingConvention.Winapi)]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] ARB access, [Flow(FlowDirection.In)] InternalFormat format);

        [NativeApi(EntryPoint = "glBindImageTexture", Convention = CallingConvention.Winapi)]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] ARB format);

        [NativeApi(EntryPoint = "glBindImageTexture", Convention = CallingConvention.Winapi)]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] bool layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] InternalFormat format);

        [NativeApi(EntryPoint = "glBindImageTexture", Convention = CallingConvention.Winapi)]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] Boolean layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] ARB access, [Flow(FlowDirection.In)] ARB format);

        [NativeApi(EntryPoint = "glBindImageTexture", Convention = CallingConvention.Winapi)]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] Boolean layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] ARB access, [Flow(FlowDirection.In)] InternalFormat format);

        [NativeApi(EntryPoint = "glBindImageTexture", Convention = CallingConvention.Winapi)]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] Boolean layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] ARB format);

        [NativeApi(EntryPoint = "glBindImageTexture", Convention = CallingConvention.Winapi)]
        public partial void BindImageTexture([Flow(FlowDirection.In)] uint unit, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] Boolean layered, [Flow(FlowDirection.In)] int layer, [Flow(FlowDirection.In)] BufferAccessARB access, [Flow(FlowDirection.In)] InternalFormat format);

        [NativeApi(EntryPoint = "glMemoryBarrier", Convention = CallingConvention.Winapi)]
        public partial void MemoryBarrier([Flow(FlowDirection.In)] uint barriers);

        [NativeApi(EntryPoint = "glMemoryBarrier", Convention = CallingConvention.Winapi)]
        public partial void MemoryBarrier([Flow(FlowDirection.In)] MemoryBarrierMask barriers);

        public ArbShaderImageLoadStore(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

