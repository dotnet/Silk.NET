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
    [Extension("NV_vertex_attrib_integer_64bit")]
    public unsafe partial class NVVertexAttribInteger64bit : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_vertex_attrib_integer_64bit";
        [NativeApi(EntryPoint = "glGetVertexAttribLi64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLi64vNV", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLi64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLi64vNV", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLui64vNV", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLui64vNV", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glVertexAttribL1i64NV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] long x);

        [NativeApi(EntryPoint = "glVertexAttribL1i64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] long* v);

        [NativeApi(EntryPoint = "glVertexAttribL1i64vNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] in long v);

        [NativeApi(EntryPoint = "glVertexAttribL1ui64NV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong x);

        [NativeApi(EntryPoint = "glVertexAttribL1ui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ulong* v);

        [NativeApi(EntryPoint = "glVertexAttribL1ui64vNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] in ulong v);

        [NativeApi(EntryPoint = "glVertexAttribL2i64NV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y);

        [NativeApi(EntryPoint = "glVertexAttribL2i64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] long* v);

        [NativeApi(EntryPoint = "glVertexAttribL2i64vNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in long v);

        [NativeApi(EntryPoint = "glVertexAttribL2ui64NV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y);

        [NativeApi(EntryPoint = "glVertexAttribL2ui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] ulong* v);

        [NativeApi(EntryPoint = "glVertexAttribL2ui64vNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in ulong v);

        [NativeApi(EntryPoint = "glVertexAttribL3i64NV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z);

        [NativeApi(EntryPoint = "glVertexAttribL3i64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] long* v);

        [NativeApi(EntryPoint = "glVertexAttribL3i64vNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] in long v);

        [NativeApi(EntryPoint = "glVertexAttribL3ui64NV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z);

        [NativeApi(EntryPoint = "glVertexAttribL3ui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] ulong* v);

        [NativeApi(EntryPoint = "glVertexAttribL3ui64vNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] in ulong v);

        [NativeApi(EntryPoint = "glVertexAttribL4i64NV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] long x, [Flow(FlowDirection.In)] long y, [Flow(FlowDirection.In)] long z, [Flow(FlowDirection.In)] long w);

        [NativeApi(EntryPoint = "glVertexAttribL4i64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] long* v);

        [NativeApi(EntryPoint = "glVertexAttribL4i64vNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in long v);

        [NativeApi(EntryPoint = "glVertexAttribL4ui64NV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ulong x, [Flow(FlowDirection.In)] ulong y, [Flow(FlowDirection.In)] ulong z, [Flow(FlowDirection.In)] ulong w);

        [NativeApi(EntryPoint = "glVertexAttribL4ui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ulong* v);

        [NativeApi(EntryPoint = "glVertexAttribL4ui64vNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in ulong v);

        [NativeApi(EntryPoint = "glVertexAttribLFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribLFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] NV type, [Flow(FlowDirection.In)] uint stride);

        [NativeApi(EntryPoint = "glVertexAttribLFormatNV", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribLFormat([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint stride);

        public NVVertexAttribInteger64bit(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

