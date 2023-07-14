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

namespace Silk.NET.WGL.Extensions.NV
{
    public static class NVGpuAffinityOverloads
    {
        public static unsafe nint CreateAffinityDC(this NVGpuAffinity thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> phGpuList)
        {
            // SpanOverloader
            return thisApi.CreateAffinityDC(in phGpuList.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 EnumGp(this NVGpuAffinity thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint iGpuIndex, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> phGpu)
        {
            // SpanOverloader
            return thisApi.EnumGp(iGpuIndex, out phGpu.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 EnumGpuDevices(this NVGpuAffinity thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint iDeviceIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<GpuDevice> lpGpuDevice)
        {
            // SpanOverloader
            return thisApi.EnumGpuDevices(hGpu, iDeviceIndex, in lpGpuDevice.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 EnumGpusFromAffinityDC(this NVGpuAffinity thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hAffinityDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint iGpuIndex, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> hGpu)
        {
            // SpanOverloader
            return thisApi.EnumGpusFromAffinityDC(hAffinityDC, iGpuIndex, out hGpu.GetPinnableReference());
        }

    }
}

