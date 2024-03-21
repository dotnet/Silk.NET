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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_vertex_array_object")]
    public unsafe partial class ArbVertexArrayObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_vertex_array_object";
        [NativeApi(EntryPoint = "glBindVertexArray", Convention = CallingConvention.Winapi)]
        public partial void BindVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint array);

        [NativeApi(EntryPoint = "glDeleteVertexArrays", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* arrays);

        [NativeApi(EntryPoint = "glDeleteVertexArrays", Convention = CallingConvention.Winapi)]
        public partial void DeleteVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in uint arrays);

        [NativeApi(EntryPoint = "glDeleteVertexArrays", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexArray* arrays);

        [NativeApi(EntryPoint = "glDeleteVertexArrays", Convention = CallingConvention.Winapi)]
        public partial void DeleteVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexArray arrays);

        [NativeApi(EntryPoint = "glGenVertexArrays", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* arrays);

        [NativeApi(EntryPoint = "glGenVertexArrays", Convention = CallingConvention.Winapi)]
        public partial void GenVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint arrays);

        [NativeApi(EntryPoint = "glGenVertexArrays", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] VertexArray* arrays);

        [NativeApi(EntryPoint = "glGenVertexArrays", Convention = CallingConvention.Winapi)]
        public partial void GenVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out VertexArray arrays);

        [NativeApi(EntryPoint = "glIsVertexArray", Convention = CallingConvention.Winapi)]
        public partial bool IsVertexArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint array);

        public unsafe void DeleteVertexArray([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint arrays)
        {
            // ArrayParameterOverloader
            DeleteVertexArrays(1, &arrays);
        }

        public unsafe void DeleteVertexArrays([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> arrays)
        {
            // ImplicitCountSpanOverloader
            DeleteVertexArrays((uint) arrays.Length, in arrays.GetPinnableReference());
        }

        public unsafe void DeleteVertexArrays([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<VertexArray> arrays)
        {
            // ImplicitCountSpanOverloader
            DeleteVertexArrays((uint) arrays.Length, in arrays.GetPinnableReference());
        }

        public unsafe uint GenVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenVertexArrays(n, &ret);
            return ret;
        }

        public unsafe void GenVertexArrays([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> arrays)
        {
            // ImplicitCountSpanOverloader
            GenVertexArrays((uint) arrays.Length, out arrays.GetPinnableReference());
        }

        public unsafe void GenVertexArrays([Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<VertexArray> arrays)
        {
            // ImplicitCountSpanOverloader
            GenVertexArrays((uint) arrays.Length, out arrays.GetPinnableReference());
        }

        public unsafe uint GenVertexArrays([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n)
        {
            // NonKhrReturnTypeOverloader
            GenVertexArrays(n, out uint silkRet);
            return silkRet;
        }

        public ArbVertexArrayObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

