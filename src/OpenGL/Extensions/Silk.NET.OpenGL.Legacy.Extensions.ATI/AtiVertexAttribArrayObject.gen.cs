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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_vertex_attrib_array_object")]
    public unsafe partial class AtiVertexAttribArrayObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_vertex_attrib_array_object";
        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glVertexAttribArrayObjectATI", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ATI type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glVertexAttribArrayObjectATI", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ATI type, [Flow(FlowDirection.In)] Boolean normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glVertexAttribArrayObjectATI", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] bool normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glVertexAttribArrayObjectATI", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribArrayObject([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] VertexAttribPointerType type, [Flow(FlowDirection.In)] Boolean normalized, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        public AtiVertexAttribArrayObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

