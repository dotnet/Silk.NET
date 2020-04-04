// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Extensions.NV
{
    [Extension("NV_vertex_buffer_unified_memory")]
    public abstract unsafe partial class NVVertexBufferUnifiedMemory : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBufferAddressRangeNV")]
        public abstract void BufferAddressRange([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong address, [Flow(FlowDirection.In)] UIntPtr length);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glColorFormatNV")]
        public abstract void ColorFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEdgeFlagFormatNV")]
        public abstract void EdgeFlagFormat([Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glFogCoordFormatNV")]
        public abstract void FogCoordFormat([Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetIntegerui64i_vNV")]
        public abstract unsafe void GetIntegerui64([Flow(FlowDirection.In)] NV value, [Flow(FlowDirection.In)] uint index, [Count(Computed = "value"), Flow(FlowDirection.Out)] ulong* result);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetIntegerui64i_vNV")]
        public abstract void GetIntegerui64([Flow(FlowDirection.In)] NV value, [Flow(FlowDirection.In)] uint index, [Count(Computed = "value"), Flow(FlowDirection.Out)] out ulong result);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glIndexFormatNV")]
        public abstract void IndexFormat([Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glNormalFormatNV")]
        public abstract void NormalFormat([Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColorFormatNV")]
        public abstract void SecondaryColorFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glTexCoordFormatNV")]
        public abstract void TexCoordFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribFormatNV")]
        public abstract void VertexAttribFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribIFormatNV")]
        public abstract void VertexAttribIFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexFormatNV")]
        public abstract void VertexFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glSecondaryColorFormatNV")]
        public abstract void SecondaryColorFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribFormatNV")]
        public abstract void VertexAttribFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribIFormatNV")]
        public abstract void VertexAttribIFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexFormatNV")]
        public abstract void VertexFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride);

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
        public unsafe void BufferAddressRange([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong address, [Flow(FlowDirection.In)] uint length)
        {
            // IntPtrOverloader
            BufferAddressRange(pname, index, address, new UIntPtr(length));
        }

        public NVVertexBufferUnifiedMemory(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

