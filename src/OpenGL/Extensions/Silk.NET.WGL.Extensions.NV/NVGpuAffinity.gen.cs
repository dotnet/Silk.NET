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
using Silk.NET.WGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.NV
{
    [Extension("NV_gpu_affinity")]
    public unsafe partial class NVGpuAffinity : NativeExtension<WGL>
    {
        public const string ExtensionName = "NV_gpu_affinity";
        [NativeApi(EntryPoint = "wglCreateAffinityDCNV", Convention = CallingConvention.Winapi)]
        public unsafe partial nint CreateAffinityDC([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* phGpuList);

        [NativeApi(EntryPoint = "wglCreateAffinityDCNV", Convention = CallingConvention.Winapi)]
        public partial nint CreateAffinityDC([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in nint phGpuList);

        [NativeApi(EntryPoint = "wglDeleteDCNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DeleteDC([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hdc);

        [NativeApi(EntryPoint = "wglEnumGpusNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 EnumGp([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint iGpuIndex, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* phGpu);

        [NativeApi(EntryPoint = "wglEnumGpusNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 EnumGp([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint iGpuIndex, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint phGpu);

        [NativeApi(EntryPoint = "wglEnumGpuDevicesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 EnumGpuDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint iDeviceIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GpuDevice* lpGpuDevice);

        [NativeApi(EntryPoint = "wglEnumGpuDevicesNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 EnumGpuDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint iDeviceIndex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in GpuDevice lpGpuDevice);

        [NativeApi(EntryPoint = "wglEnumGpusFromAffinityDCNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 EnumGpusFromAffinityDC([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hAffinityDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint iGpuIndex, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* hGpu);

        [NativeApi(EntryPoint = "wglEnumGpusFromAffinityDCNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 EnumGpusFromAffinityDC([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hAffinityDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint iGpuIndex, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint hGpu);

        public NVGpuAffinity(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

