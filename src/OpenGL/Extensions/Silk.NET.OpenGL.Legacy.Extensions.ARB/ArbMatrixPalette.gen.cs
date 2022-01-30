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
    [Extension("ARB_matrix_palette")]
    public unsafe partial class ArbMatrixPalette : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_matrix_palette";
        [NativeApi(EntryPoint = "glCurrentPaletteMatrixARB", Convention = CallingConvention.Winapi)]
        public partial void CurrentPaletteMatrix([Flow(FlowDirection.In)] int index);

        [NativeApi(EntryPoint = "glMatrixIndexubvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] byte* indices);

        [NativeApi(EntryPoint = "glMatrixIndexubvARB", Convention = CallingConvention.Winapi)]
        public partial void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in byte indices);

        [NativeApi(EntryPoint = "glMatrixIndexubvARB", Convention = CallingConvention.Winapi)]
        public partial void MatrixIndex([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string indices);

        [NativeApi(EntryPoint = "glMatrixIndexusvARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] ushort* indices);

        [NativeApi(EntryPoint = "glMatrixIndexusvARB", Convention = CallingConvention.Winapi)]
        public partial void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in ushort indices);

        [NativeApi(EntryPoint = "glMatrixIndexuivARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] uint* indices);

        [NativeApi(EntryPoint = "glMatrixIndexuivARB", Convention = CallingConvention.Winapi)]
        public partial void MatrixIndex([Flow(FlowDirection.In)] int size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in uint indices);

        [NativeApi(EntryPoint = "glMatrixIndexPointerARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixIndexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glMatrixIndexPointerARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MatrixIndexPointer([Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] MatrixIndexPointerTypeARB type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "size, type, stride"), Flow(FlowDirection.In)] void* pointer);

        public unsafe void MatrixIndex([Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<byte> indices)
        {
            // ImplicitCountSpanOverloader
            MatrixIndex((int) indices.Length, in indices.GetPinnableReference());
        }

        public unsafe void MatrixIndex([Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<ushort> indices)
        {
            // ImplicitCountSpanOverloader
            MatrixIndex((int) indices.Length, in indices.GetPinnableReference());
        }

        public unsafe void MatrixIndex([Count(Parameter = "size"), Flow(FlowDirection.In)] ReadOnlySpan<uint> indices)
        {
            // ImplicitCountSpanOverloader
            MatrixIndex((int) indices.Length, in indices.GetPinnableReference());
        }

        public ArbMatrixPalette(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

