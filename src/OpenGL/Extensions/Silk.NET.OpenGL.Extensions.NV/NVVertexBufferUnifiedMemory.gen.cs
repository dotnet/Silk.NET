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

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_vertex_buffer_unified_memory")]
    public unsafe partial class NVVertexBufferUnifiedMemory : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vertex_buffer_unified_memory";
        [NativeApi(EntryPoint = "glBufferAddressRangeNV", Convention = CallingConvention.Winapi)]
        public partial void BufferAddressRange([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong address, [Flow(FlowDirection.In)] nuint length);

        [NativeApi(EntryPoint = "glColorFormatNV", Convention = CallingConvention.Winapi)]
        public partial void ColorFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glEdgeFlagFormatNV", Convention = CallingConvention.Winapi)]
        public partial void EdgeFlagFormat([Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glFogCoordFormatNV", Convention = CallingConvention.Winapi)]
        public partial void FogCoordFormat([Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glGetIntegerui64i_vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetIntegerui64([Flow(FlowDirection.In)] NV value, [Flow(FlowDirection.In)] uint index, [Count(Computed = "value"), Flow(FlowDirection.Out)] ulong* result);

        [NativeApi(EntryPoint = "glGetIntegerui64i_vNV", Convention = CallingConvention.Winapi)]
        public partial void GetIntegerui64([Flow(FlowDirection.In)] NV value, [Flow(FlowDirection.In)] uint index, [Count(Computed = "value"), Flow(FlowDirection.Out)] out ulong result);

        [NativeApi(EntryPoint = "glIndexFormatNV", Convention = CallingConvention.Winapi)]
        public partial void IndexFormat([Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glNormalFormatNV", Convention = CallingConvention.Winapi)]
        public partial void NormalFormat([Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glSecondaryColorFormatNV", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColorFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glSecondaryColorFormatNV", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColorFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glTexCoordFormatNV", Convention = CallingConvention.Winapi)]
        public partial void TexCoordFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] Boolean normalized, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] Boolean normalized, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribIFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribIFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribIFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribIFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride);

        public NVVertexBufferUnifiedMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

