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
        public unsafe partial void GetVertexAttribL([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLdvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribL([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLdvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribL([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribLdvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribL([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glVertexAttribL1dEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x);

        [NativeApi(EntryPoint = "glVertexAttribL1dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL1dvEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL1([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glVertexAttribL2dEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y);

        [NativeApi(EntryPoint = "glVertexAttribL2dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL2dvEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL2([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glVertexAttribL3dEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z);

        [NativeApi(EntryPoint = "glVertexAttribL3dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL3dvEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL3([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glVertexAttribL4dEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double x, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double y, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double z, [Flow(Silk.NET.Core.Native.FlowDirection.In)] double w);

        [NativeApi(EntryPoint = "glVertexAttribL4dvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribL4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* v);

        [NativeApi(EntryPoint = "glVertexAttribL4dvEXT", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribL4([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double v);

        [NativeApi(EntryPoint = "glVertexAttribLPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribLPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glVertexAttribLPointerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void VertexAttribLPointer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribLType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* pointer);

        public unsafe double GetVertexAttribL([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT pname)
        {
            // NonKhrReturnTypeOverloader
            GetVertexAttribL(index, pname, out double silkRet);
            return silkRet;
        }

        public unsafe double GetVertexAttribL([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribEnum pname)
        {
            // NonKhrReturnTypeOverloader
            GetVertexAttribL(index, pname, out double silkRet);
            return silkRet;
        }

        public ExtVertexAttrib64bit(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

