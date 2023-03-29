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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVVdpauInteropOverloads
    {
        public static unsafe void VdpaugetSurface(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.VdpaugetSurface(surface, pname, count, length, out values.GetPinnableReference());
        }

        public static unsafe void VdpaugetSurface(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // SpanOverloader
            thisApi.VdpaugetSurface(surface, pname, count, out length.GetPinnableReference(), values);
        }

        public static unsafe void VdpaugetSurface(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] nint surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.VdpaugetSurface(surface, pname, count, out length.GetPinnableReference(), out values.GetPinnableReference());
        }

        public static unsafe void VdpaumapSurfaces(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] uint numSurfaces, [Count(Parameter = "numSurfaces"), Flow(FlowDirection.In)] ReadOnlySpan<nint> surfaces)
        {
            // SpanOverloader
            thisApi.VdpaumapSurfaces(numSurfaces, in surfaces.GetPinnableReference());
        }

        public static unsafe nint VdpauregisterOutputSurface<T0>(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] Span<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textureNames) where T0 : struct
        {
            // SpanOverloader
            fixed (void* vdpSurfaceSpp = vdpSurface)
                return thisApi.VdpauregisterOutputSurface(vdpSurfaceSpp, target, numTextureNames, in textureNames.GetPinnableReference());
        }

        public static unsafe nint VdpauregisterVideoSurface<T0>(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] Span<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textureNames) where T0 : struct
        {
            // SpanOverloader
            fixed (void* vdpSurfaceSpp = vdpSurface)
                return thisApi.VdpauregisterVideoSurface(vdpSurfaceSpp, target, numTextureNames, in textureNames.GetPinnableReference());
        }

        public static unsafe void VdpauunmapSurfaces(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] uint numSurface, [Count(Parameter = "numSurface"), Flow(FlowDirection.In)] ReadOnlySpan<nint> surfaces)
        {
            // SpanOverloader
            thisApi.VdpauunmapSurfaces(numSurface, in surfaces.GetPinnableReference());
        }

    }
}

