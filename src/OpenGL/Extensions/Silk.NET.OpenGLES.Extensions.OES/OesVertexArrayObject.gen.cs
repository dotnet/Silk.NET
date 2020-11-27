// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_vertex_array_object")]
    public unsafe partial class OesVertexArrayObject : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_vertex_array_object";
        [NativeApi(EntryPoint = "glBindVertexArrayOES")]
        public partial void BindVertexArray([Flow(FlowDirection.In)] uint array);

        [NativeApi(EntryPoint = "glDeleteVertexArraysOES")]
        public unsafe partial void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* arrays);

        [NativeApi(EntryPoint = "glDeleteVertexArraysOES")]
        public partial void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] in uint arrays);

        [NativeApi(EntryPoint = "glGenVertexArraysOES")]
        public unsafe partial void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays);

        [NativeApi(EntryPoint = "glGenVertexArraysOES")]
        public partial void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] out uint arrays);

        [NativeApi(EntryPoint = "glIsVertexArrayOES")]
        public partial bool IsVertexArray([Flow(FlowDirection.In)] uint array);

        public unsafe void DeleteVertexArray([Count(Parameter = "n"), Flow(FlowDirection.In)] uint arrays)
        {
            // ArrayParameterOverloader
            DeleteVertexArrays(1, &arrays);
        }

        public unsafe uint GenVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenVertexArrays(n, &ret);
            return ret;
        }

        public OesVertexArrayObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

