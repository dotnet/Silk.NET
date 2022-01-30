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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_vertex_attrib_64bit")]
    public unsafe partial class ExtVertexAttrib64bit : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_vertex_attrib_64bit";
        [NativeApi(EntryPoint = "glGetVertexAttribLdvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLdvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLdvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLdvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribL([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glVertexAttribL1dEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glVertexAttribL1dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL1dvEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL1([Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribL2dEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glVertexAttribL2dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL2dvEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL2([Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribL3dEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glVertexAttribL3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL3([Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribL4dEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] double x, [Flow(FlowDirection.In)] double y, [Flow(FlowDirection.In)] double z, [Flow(FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glVertexAttribL4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL4dvEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL4([Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] in double v);

        [NativeApi(EntryPoint = "glVertexAttribLPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribLPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribLPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribLPointer([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribLType type, [Flow(FlowDirection.In)] uint stride, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer);

        public ExtVertexAttrib64bit(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

