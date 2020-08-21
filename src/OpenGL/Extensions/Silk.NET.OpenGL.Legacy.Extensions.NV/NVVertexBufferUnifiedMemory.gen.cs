// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_vertex_buffer_unified_memory")]
    public unsafe partial class NVVertexBufferUnifiedMemory : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vertex_buffer_unified_memory";
        [NativeApi(EntryPoint = "glBufferAddressRangeNV")]
        public partial void BufferAddressRange([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong address, [Flow(FlowDirection.In)] UIntPtr length);

        [NativeApi(EntryPoint = "glColorFormatNV")]
        public partial void ColorFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glEdgeFlagFormatNV")]
        public partial void EdgeFlagFormat([Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glFogCoordFormatNV")]
        public partial void FogCoordFormat([Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glGetIntegerui64i_vNV")]
        public unsafe partial void GetIntegerui64([Flow(FlowDirection.In)] NV value, [Flow(FlowDirection.In)] uint index, [Count(Computed = "value"), Flow(FlowDirection.Out)] ulong* result);

        [NativeApi(EntryPoint = "glGetIntegerui64i_vNV")]
        public partial void GetIntegerui64([Flow(FlowDirection.In)] NV value, [Flow(FlowDirection.In)] uint index, [Count(Computed = "value"), Flow(FlowDirection.Out)] out ulong result);

        [NativeApi(EntryPoint = "glIndexFormatNV")]
        public partial void IndexFormat([Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glNormalFormatNV")]
        public partial void NormalFormat([Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glSecondaryColorFormatNV")]
        public partial void SecondaryColorFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glSecondaryColorFormatNV")]
        public partial void SecondaryColorFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ColorPointerType type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glTexCoordFormatNV")]
        public partial void TexCoordFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribFormatNV")]
        public partial void VertexAttribFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribFormatNV")]
        public partial void VertexAttribFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribIFormatNV")]
        public partial void VertexAttribIFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribIFormatNV")]
        public partial void VertexAttribIFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexFormatNV")]
        public partial void VertexFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexFormatNV")]
        public partial void VertexFormat([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexPointerType type, [Flow(FlowDirection.In)] uint stride);

        public NVVertexBufferUnifiedMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

