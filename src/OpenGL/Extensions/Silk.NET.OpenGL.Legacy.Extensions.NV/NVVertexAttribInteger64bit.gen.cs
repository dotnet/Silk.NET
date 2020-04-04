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
    [Extension("NV_vertex_attrib_integer_64bit")]
    public abstract unsafe partial class NVVertexAttribInteger64bit : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLi64vNV")]
        public abstract unsafe void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLi64vNV")]
        public abstract void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLui64vNV")]
        public abstract unsafe void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLui64vNV")]
        public abstract void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL1i64NV")]
        public abstract void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] long x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL1i64vNV")]
        public abstract unsafe void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] long* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL1i64vNV")]
        public abstract void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref long v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL1ui64NV")]
        public abstract void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong x);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL1ui64vNV")]
        public abstract unsafe void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ulong* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL1ui64vNV")]
        public abstract void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ref ulong v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL2i64NV")]
        public abstract void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL2i64vNV")]
        public abstract unsafe void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] long* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL2i64vNV")]
        public abstract void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<long> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL2ui64NV")]
        public abstract void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL2ui64vNV")]
        public abstract unsafe void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] ulong* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL2ui64vNV")]
        public abstract void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] Span<ulong> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL3i64NV")]
        public abstract void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL3i64vNV")]
        public abstract unsafe void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] long* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL3i64vNV")]
        public abstract void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<long> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL3ui64NV")]
        public abstract void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL3ui64vNV")]
        public abstract unsafe void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] ulong* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL3ui64vNV")]
        public abstract void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] Span<ulong> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL4i64NV")]
        public abstract void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z, [Flow(FlowDirection.In)] long w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL4i64vNV")]
        public abstract unsafe void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] long* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL4i64vNV")]
        public abstract void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<long> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL4ui64NV")]
        public abstract void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z, [Flow(FlowDirection.In)] ulong w);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL4ui64vNV")]
        public abstract unsafe void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ulong* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribL4ui64vNV")]
        public abstract void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] Span<ulong> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribLFormatNV")]
        public abstract void VertexAttribLFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLi64vNV")]
        public abstract unsafe void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLi64vNV")]
        public abstract void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLui64vNV")]
        public abstract unsafe void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVertexAttribLui64vNV")]
        public abstract void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVertexAttribLFormatNV")]
        public abstract void VertexAttribLFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint stride);

        public NVVertexAttribInteger64bit(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

