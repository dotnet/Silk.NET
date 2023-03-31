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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_device_fault")]
    public unsafe partial class ExtDeviceFault : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_device_fault";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceFaultInfoEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDeviceFaultInfo([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceFaultCountsEXT* pFaultCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeviceFaultInfoEXT* pFaultInfo);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pFaultInfo = new(StructureType.DeviceFaultInfoExt);")]
        [NativeApi(EntryPoint = "vkGetDeviceFaultInfoEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDeviceFaultInfo([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceFaultCountsEXT* pFaultCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DeviceFaultInfoEXT pFaultInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceFaultInfoEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetDeviceFaultInfo([Count(Count = 0)] Device device, [Count(Count = 0)] ref DeviceFaultCountsEXT pFaultCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DeviceFaultInfoEXT* pFaultInfo);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pFaultInfo = new(StructureType.DeviceFaultInfoExt);")]
        [NativeApi(EntryPoint = "vkGetDeviceFaultInfoEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetDeviceFaultInfo([Count(Count = 0)] Device device, [Count(Count = 0)] ref DeviceFaultCountsEXT pFaultCounts, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DeviceFaultInfoEXT pFaultInfo);

        public ExtDeviceFault(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

