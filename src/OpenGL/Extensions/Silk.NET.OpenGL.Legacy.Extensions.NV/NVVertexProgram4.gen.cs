// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_vertex_program4")]
    public abstract unsafe partial class NVVertexProgram4 : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIivEXT")]
        public abstract unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIivEXT")]
        public abstract void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIuivEXT")]
        public abstract unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIuivEXT")]
        public abstract void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI1iEXT")]
        public abstract void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI1uiEXT")]
        public abstract void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI1ivEXT")]
        public abstract unsafe void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI1ivEXT")]
        public abstract void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref int v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI1uivEXT")]
        public abstract unsafe void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] uint* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI1uivEXT")]
        public abstract void VertexAttribI1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref uint v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI2iEXT")]
        public abstract void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI2uiEXT")]
        public abstract void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI2ivEXT")]
        public abstract unsafe void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI2ivEXT")]
        public abstract void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI2uivEXT")]
        public abstract unsafe void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] uint* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI2uivEXT")]
        public abstract void VertexAttribI2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<uint> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI3iEXT")]
        public abstract void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI3uiEXT")]
        public abstract void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI3ivEXT")]
        public abstract unsafe void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI3ivEXT")]
        public abstract void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI3uivEXT")]
        public abstract unsafe void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] uint* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI3uivEXT")]
        public abstract void VertexAttribI3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<uint> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4iEXT")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] int z, [Flow(FlowDirection.In)] int w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4uiEXT")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] uint x, [Flow(FlowDirection.In)] uint y, [Flow(FlowDirection.In)] uint z, [Flow(FlowDirection.In)] uint w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4ivEXT")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4ivEXT")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<int> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4uivEXT")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] uint* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4uivEXT")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<uint> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4bvEXT")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] sbyte* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4bvEXT")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<sbyte> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4svEXT")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] short* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4svEXT")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<short> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4ubvEXT")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] byte* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4ubvEXT")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<byte> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4usvEXT")]
        public abstract unsafe void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ushort* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4usvEXT")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ushort> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribIPointerEXT")]
        public abstract unsafe void VertexAttribIPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribIPointerEXT")]
        public abstract void VertexAttribIPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIivEXT")]
        public abstract unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIivEXT")]
        public abstract void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIuivEXT")]
        public abstract unsafe void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribIuivEXT")]
        public abstract void GetVertexAttribI([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Count = 1), Flow(FlowDirection.Out)] out uint @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribI4ubvEXT")]
        public abstract void VertexAttribI4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] string v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribIPointerEXT")]
        public abstract unsafe void VertexAttribIPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribIPointerEXT")]
        public abstract void VertexAttribIPointer<T0>([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        public NVVertexProgram4(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

