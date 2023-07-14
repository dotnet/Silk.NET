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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_vertex_buffer_unified_memory")]
    public unsafe partial class NVVertexBufferUnifiedMemory : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vertex_buffer_unified_memory";
        [NativeApi(EntryPoint = "glBufferAddressRangeNV", Convention = CallingConvention.Winapi)]
        public partial void BufferAddressRange([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong address, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint length);

        [NativeApi(EntryPoint = "glColorFormatNV", Convention = CallingConvention.Winapi)]
        public partial void ColorFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glColorFormatNV", Convention = CallingConvention.Winapi)]
        public partial void ColorFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glEdgeFlagFormatNV", Convention = CallingConvention.Winapi)]
        public partial void EdgeFlagFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glFogCoordFormatNV", Convention = CallingConvention.Winapi)]
        public partial void FogCoordFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glGetIntegerui64i_vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetIntegerui64([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "value"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* result);

        [NativeApi(EntryPoint = "glGetIntegerui64i_vNV", Convention = CallingConvention.Winapi)]
        public partial void GetIntegerui64([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "value"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong result);

        [NativeApi(EntryPoint = "glIndexFormatNV", Convention = CallingConvention.Winapi)]
        public partial void IndexFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glNormalFormatNV", Convention = CallingConvention.Winapi)]
        public partial void NormalFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glSecondaryColorFormatNV", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColorFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glSecondaryColorFormatNV", Convention = CallingConvention.Winapi)]
        public partial void SecondaryColorFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glTexCoordFormatNV", Convention = CallingConvention.Winapi)]
        public partial void TexCoordFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribIFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribIFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribIFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribIFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribIType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexFormat([Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride);

        public unsafe ulong GetIntegerui64([Flow(Silk.NET.Core.Native.FlowDirection.In)] NV value, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetIntegerui64(value, index, out ulong silkRet);
            return silkRet;
        }

        public NVVertexBufferUnifiedMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

