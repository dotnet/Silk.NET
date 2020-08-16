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
    [Extension("NV_vertex_program4")]
    public unsafe partial class NVVertexProgram4 : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vertex_program4";
        [NativeApi(EntryPoint = "glGetVertexAttribIivEXT")]
        public unsafe partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIivEXT")]
        public partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuivEXT")]
        public unsafe partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuivEXT")]
        public partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glVertexAttribI1iEXT")]
        public partial void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x);

        [NativeApi(EntryPoint = "glVertexAttribI1uiEXT")]
        public partial void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x);

        [NativeApi(EntryPoint = "glVertexAttribI1ivEXT")]
        public unsafe partial void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI1ivEXT")]
        public partial void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref int v);

        [NativeApi(EntryPoint = "glVertexAttribI1uivEXT")]
        public unsafe partial void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI1uivEXT")]
        public partial void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref uint v);

        [NativeApi(EntryPoint = "glVertexAttribI2iEXT")]
        public partial void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        [NativeApi(EntryPoint = "glVertexAttribI2uiEXT")]
        public partial void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y);

        [NativeApi(EntryPoint = "glVertexAttribI2ivEXT")]
        public unsafe partial void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI2ivEXT")]
        public partial void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttribI2uivEXT")]
        public unsafe partial void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI2uivEXT")]
        public partial void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttribI3iEXT")]
        public partial void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        [NativeApi(EntryPoint = "glVertexAttribI3uiEXT")]
        public partial void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z);

        [NativeApi(EntryPoint = "glVertexAttribI3ivEXT")]
        public unsafe partial void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI3ivEXT")]
        public partial void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttribI3uivEXT")]
        public unsafe partial void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI3uivEXT")]
        public partial void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttribI4iEXT")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        [NativeApi(EntryPoint = "glVertexAttribI4uiEXT")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        [NativeApi(EntryPoint = "glVertexAttribI4ivEXT")]
        public unsafe partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glVertexAttribI4ivEXT")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        [NativeApi(EntryPoint = "glVertexAttribI4uivEXT")]
        public unsafe partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        [NativeApi(EntryPoint = "glVertexAttribI4uivEXT")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        [NativeApi(EntryPoint = "glVertexAttribI4bvEXT")]
        public unsafe partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        [NativeApi(EntryPoint = "glVertexAttribI4bvEXT")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        [NativeApi(EntryPoint = "glVertexAttribI4svEXT")]
        public unsafe partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        [NativeApi(EntryPoint = "glVertexAttribI4svEXT")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        [NativeApi(EntryPoint = "glVertexAttribI4ubvEXT")]
        public unsafe partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        [NativeApi(EntryPoint = "glVertexAttribI4ubvEXT")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        [NativeApi(EntryPoint = "glVertexAttribI4usvEXT")]
        public unsafe partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        [NativeApi(EntryPoint = "glVertexAttribI4usvEXT")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        [NativeApi(EntryPoint = "glVertexAttribIPointerEXT")]
        public unsafe partial void VertexAttribIPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribIPointerEXT")]
        public partial void VertexAttribIPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetVertexAttribIivEXT")]
        public unsafe partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIivEXT")]
        public partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuivEXT")]
        public unsafe partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribIuivEXT")]
        public partial void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glVertexAttribI4ubvEXT")]
        public partial void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v);

        [NativeApi(EntryPoint = "glVertexAttribIPointerEXT")]
        public unsafe partial void VertexAttribIPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribIPointerEXT")]
        public partial void VertexAttribIPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribIType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        public NVVertexProgram4(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

