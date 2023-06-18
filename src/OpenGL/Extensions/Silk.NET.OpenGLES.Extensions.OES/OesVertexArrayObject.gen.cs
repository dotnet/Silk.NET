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
using Silk.NET.OpenGLES;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_vertex_array_object")]
    public unsafe partial class OesVertexArrayObject : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_vertex_array_object";
        [NativeApi(EntryPoint = "glBindVertexArrayOES", Convention = CallingConvention.Winapi)]
        public partial void BindVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint array);

        [NativeApi(EntryPoint = "glDeleteVertexArraysOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* arrays);

        [NativeApi(EntryPoint = "glGenVertexArraysOES", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* arrays);

        [NativeApi(EntryPoint = "glIsVertexArrayOES", Convention = CallingConvention.Winapi)]
        public partial bool IsVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint array);

        public OesVertexArrayObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

