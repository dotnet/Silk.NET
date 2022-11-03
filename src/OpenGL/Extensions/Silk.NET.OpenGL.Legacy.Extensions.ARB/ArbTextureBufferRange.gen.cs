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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_texture_buffer_range")]
    public unsafe partial class ArbTextureBufferRange : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_texture_buffer_range";
        [NativeApi(EntryPoint = "glTexBufferRange", Convention = CallingConvention.Winapi)]
        public partial void TexBufferRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTexBufferRange", Convention = CallingConvention.Winapi)]
        public partial void TexBufferRange([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTexBufferRange", Convention = CallingConvention.Winapi)]
        public partial void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] ARB internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glTexBufferRange", Convention = CallingConvention.Winapi)]
        public partial void TexBufferRange([Flow(FlowDirection.In)] TextureTarget target, [Flow(FlowDirection.In)] SizedInternalFormat internalformat, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size);

        public ArbTextureBufferRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

