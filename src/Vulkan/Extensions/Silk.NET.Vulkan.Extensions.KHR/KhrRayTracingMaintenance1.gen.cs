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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_ray_tracing_maintenance1")]
    public unsafe partial class KhrRayTracingMaintenance1 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_ray_tracing_maintenance1";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdTraceRaysIndirect2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdTraceRaysIndirect2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ulong indirectDeviceAddress);

        public KhrRayTracingMaintenance1(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

