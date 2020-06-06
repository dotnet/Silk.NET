// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_vertex_buffer_unified_memory")]
    public unsafe partial class NVVertexBufferUnifiedMemory : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vertex_buffer_unified_memory";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="address">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBufferAddressRangeNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BufferAddressRange([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong address, [Flow(FlowDirection.In)] UIntPtr length)
            => ImplBufferAddressRange(pname, index, address, length);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glColorFormatNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void ColorFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride)
            => ImplColorFormat(size, type, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEdgeFlagFormatNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EdgeFlagFormat([Flow(FlowDirection.In)] uint stride)
            => ImplEdgeFlagFormat(stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glFogCoordFormatNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void FogCoordFormat([Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride)
            => ImplFogCoordFormat(type, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="result">
        /// To be added.
        /// This parameter's element count is computed from value.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegerui64i_vNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetIntegerui64([Flow(FlowDirection.In)] NV value, [Flow(FlowDirection.In)] uint index, [Count(Computed = "value"), Flow(FlowDirection.Out)] ulong* result)
            => ImplGetIntegerui64(value, index, result);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="result">
        /// To be added.
        /// This parameter's element count is computed from value.
        /// </param>
        [NativeApi(EntryPoint = "glGetIntegerui64i_vNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetIntegerui64([Flow(FlowDirection.In)] NV value, [Flow(FlowDirection.In)] uint index, [Count(Computed = "value"), Flow(FlowDirection.Out)] out ulong result)
            => ImplGetIntegerui64(value, index, result);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glIndexFormatNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void IndexFormat([Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride)
            => ImplIndexFormat(type, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glNormalFormatNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void NormalFormat([Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride)
            => ImplNormalFormat(type, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorFormatNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColorFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride)
            => ImplSecondaryColorFormat(size, type, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glTexCoordFormatNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void TexCoordFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride)
            => ImplTexCoordFormat(size, type, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribFormatNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride)
            => ImplVertexAttribFormat(index, size, type, normalized, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribIFormatNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribIFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride)
            => ImplVertexAttribIFormat(index, size, type, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexFormatNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride)
            => ImplVertexFormat(size, type, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSecondaryColorFormatNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SecondaryColorFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride)
            => ImplSecondaryColorFormat(size, type, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="normalized">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribFormatNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride)
            => ImplVertexAttribFormat(index, size, type, normalized, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexAttribIFormatNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexAttribIFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint stride)
            => ImplVertexAttribIFormat(index, size, type, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="type">
        /// To be added.
        /// </param>
        /// <param name="stride">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glVertexFormatNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VertexFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride)
            => ImplVertexFormat(size, type, stride);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="index">
        /// To be added.
        /// </param>
        /// <param name="address">
        /// To be added.
        /// </param>
        /// <param name="length">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BufferAddressRange([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong address, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            BufferAddressRange(pname, index, address, new UIntPtr(length));
        }

        public NVVertexBufferUnifiedMemory(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

