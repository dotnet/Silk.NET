// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        public static unsafe void VdpaugetSurface(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.VdpaugetSurface(surface, pname, count, length, out values.GetPinnableReference());
        }

        public static unsafe void VdpaugetSurface(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // SpanOverloader
            thisApi.VdpaugetSurface(surface, pname, count, out length.GetPinnableReference(), values);
        }

        public static unsafe void VdpaugetSurface(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] IntPtr surface, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.VdpaugetSurface(surface, pname, count, out length.GetPinnableReference(), out values.GetPinnableReference());
        }

        public static unsafe void Vdpauinit<T0>(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] void* vdpDevice, [Flow(FlowDirection.In)] ReadOnlySpan<T0> getProcAddress) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.Vdpauinit(vdpDevice, in getProcAddress.GetPinnableReference());
        }

        public static unsafe void Vdpauinit<T0>(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> vdpDevice, [Flow(FlowDirection.In)] void* getProcAddress) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.Vdpauinit(in vdpDevice.GetPinnableReference(), getProcAddress);
        }

        public static unsafe void Vdpauinit<T0, T1>(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> vdpDevice, [Flow(FlowDirection.In)] ReadOnlySpan<T1> getProcAddress) where T0 : unmanaged where T1 : unmanaged
        {
            // SpanOverloader
            thisApi.Vdpauinit(in vdpDevice.GetPinnableReference(), in getProcAddress.GetPinnableReference());
        }

        public static unsafe void VdpaumapSurfaces(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] uint numSurfaces, [Count(Parameter = "numSurfaces"), Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> surfaces)
        {
            // SpanOverloader
            thisApi.VdpaumapSurfaces(numSurfaces, in surfaces.GetPinnableReference());
        }

        public static unsafe IntPtr VdpauregisterOutputSurface(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textureNames)
        {
            // SpanOverloader
            return thisApi.VdpauregisterOutputSurface(vdpSurface, target, numTextureNames, in textureNames.GetPinnableReference());
        }

        public static unsafe IntPtr VdpauregisterOutputSurface<T0>(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] uint* textureNames) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.VdpauregisterOutputSurface(in vdpSurface.GetPinnableReference(), target, numTextureNames, textureNames);
        }

        public static unsafe IntPtr VdpauregisterOutputSurface<T0>(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textureNames) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.VdpauregisterOutputSurface(in vdpSurface.GetPinnableReference(), target, numTextureNames, in textureNames.GetPinnableReference());
        }

        public static unsafe IntPtr VdpauregisterVideoSurface(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] void* vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textureNames)
        {
            // SpanOverloader
            return thisApi.VdpauregisterVideoSurface(vdpSurface, target, numTextureNames, in textureNames.GetPinnableReference());
        }

        public static unsafe IntPtr VdpauregisterVideoSurface<T0>(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] uint* textureNames) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.VdpauregisterVideoSurface(in vdpSurface.GetPinnableReference(), target, numTextureNames, textureNames);
        }

        public static unsafe IntPtr VdpauregisterVideoSurface<T0>(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] ReadOnlySpan<T0> vdpSurface, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint numTextureNames, [Count(Parameter = "numTextureNames"), Flow(FlowDirection.In)] ReadOnlySpan<uint> textureNames) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.VdpauregisterVideoSurface(in vdpSurface.GetPinnableReference(), target, numTextureNames, in textureNames.GetPinnableReference());
        }

        public static unsafe void VdpauunmapSurfaces(this NVVdpauInterop thisApi, [Flow(FlowDirection.In)] uint numSurface, [Count(Parameter = "numSurface"), Flow(FlowDirection.In)] ReadOnlySpan<IntPtr> surfaces)
        {
            // SpanOverloader
            thisApi.VdpauunmapSurfaces(numSurface, in surfaces.GetPinnableReference());
        }

    }
}

