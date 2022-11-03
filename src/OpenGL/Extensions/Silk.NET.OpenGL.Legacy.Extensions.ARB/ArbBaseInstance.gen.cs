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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_base_instance")]
    public unsafe partial class ArbBaseInstance : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_base_instance";
        [NativeApi(EntryPoint = "glDrawArraysInstancedBaseInstance", Convention = CallingConvention.Winapi)]
        public partial void DrawArraysInstancedBaseInstance([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawArraysInstancedBaseInstance", Convention = CallingConvention.Winapi)]
        public partial void DrawArraysInstancedBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] int first, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstancedBaseInstance([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstancedBaseInstance([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstancedBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstancedBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseInstance", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstancedBaseVertexBaseInstance([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstancedBaseVertexBaseInstance([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstancedBaseVertexBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance", Convention = CallingConvention.Winapi)]
        public unsafe partial void DrawElementsInstancedBaseVertexBaseInstance([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] void* indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance);

        [NativeApi(EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance", Convention = CallingConvention.Winapi)]
        public partial void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] in T0 indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged;

        public unsafe void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            DrawElementsInstancedBaseInstance(mode, (uint) (indices.Length * Unsafe.SizeOf<T0>()), type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public unsafe void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            DrawElementsInstancedBaseInstance(mode, (uint) (indices.Length * Unsafe.SizeOf<T0>()), type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public unsafe void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            DrawElementsInstancedBaseInstance(mode, (uint) (indices.Length * Unsafe.SizeOf<T0>()), type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public unsafe void DrawElementsInstancedBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] PrimitiveType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            DrawElementsInstancedBaseInstance(mode, (uint) (indices.Length * Unsafe.SizeOf<T0>()), type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            DrawElementsInstancedBaseVertexBaseInstance(mode, (uint) (indices.Length * Unsafe.SizeOf<T0>()), type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

        public unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            DrawElementsInstancedBaseVertexBaseInstance(mode, (uint) (indices.Length * Unsafe.SizeOf<T0>()), type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

        public unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] ARB type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            DrawElementsInstancedBaseVertexBaseInstance(mode, (uint) (indices.Length * Unsafe.SizeOf<T0>()), type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

        public unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>([Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(FlowDirection.In)] uint instancecount, [Flow(FlowDirection.In)] int basevertex, [Flow(FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            DrawElementsInstancedBaseVertexBaseInstance(mode, (uint) (indices.Length * Unsafe.SizeOf<T0>()), type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

        public ArbBaseInstance(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

