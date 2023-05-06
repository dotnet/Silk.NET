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
        public unsafe partial void GetVertexAttribArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectfvATI", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVertexAttribArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVertexAttribArrayObjectivATI", Convention = CallingConvention.Winapi)]
        public partial void GetVertexAttribArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glVertexAttribArrayObjectATI", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glVertexAttribArrayObjectATI", Convention = CallingConvention.Winapi)]
        public partial void VertexAttribArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexAttribPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool normalized, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint offset);

        public unsafe float GetVertexAttribArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ATI pname)
        {
            // NonKhrReturnTypeOverloader
            GetVertexAttribArrayObject(index, pname, out float silkRet);
            return silkRet;
        }

        public unsafe float GetVertexAttribArrayObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ArrayObjectPNameATI pname)
        {
            // NonKhrReturnTypeOverloader
            GetVertexAttribArrayObject(index, pname, out float silkRet);
            return silkRet;
        }

        public AtiVertexAttribArrayObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

