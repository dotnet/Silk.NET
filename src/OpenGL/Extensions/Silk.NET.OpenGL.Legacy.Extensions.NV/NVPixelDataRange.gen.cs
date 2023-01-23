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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_pixel_data_range")]
    public unsafe partial class NVPixelDataRange : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_pixel_data_range";
        [NativeApi(EntryPoint = "glFlushPixelDataRangeNV", Convention = CallingConvention.Winapi)]
        public partial void FlushPixelDataRange([Flow(FlowDirection.In)] NV target);

        [NativeApi(EntryPoint = "glFlushPixelDataRangeNV", Convention = CallingConvention.Winapi)]
        public partial void FlushPixelDataRange([Flow(FlowDirection.In)] PixelDataRangeTargetNV target);

        [NativeApi(EntryPoint = "glPixelDataRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelDataRange([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glPixelDataRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PixelDataRange<T0>([Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glPixelDataRangeNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void PixelDataRange([Flow(FlowDirection.In)] PixelDataRangeTargetNV target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glPixelDataRangeNV", Convention = CallingConvention.Winapi)]
        public partial void PixelDataRange<T0>([Flow(FlowDirection.In)] PixelDataRangeTargetNV target, [Flow(FlowDirection.In)] uint length, [Count(Parameter = "length"), Flow(FlowDirection.In)] in T0 pointer) where T0 : unmanaged;

        public unsafe void PixelDataRange<T0>([Flow(FlowDirection.In)] NV target, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PixelDataRange(target, (uint) (pointer.Length * Unsafe.SizeOf<T0>()), in pointer.GetPinnableReference());
        }

        public unsafe void PixelDataRange<T0>([Flow(FlowDirection.In)] PixelDataRangeTargetNV target, [Count(Parameter = "length"), Flow(FlowDirection.In)] ReadOnlySpan<T0> pointer) where T0 : unmanaged
        {
            // ImplicitCountSpanOverloader
            PixelDataRange(target, (uint) (pointer.Length * Unsafe.SizeOf<T0>()), in pointer.GetPinnableReference());
        }

        public NVPixelDataRange(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

