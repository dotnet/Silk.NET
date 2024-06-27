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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_fragment_shading_rate_enums")]
    public unsafe partial class NVFragmentShadingRateEnums : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_fragment_shading_rate_enums";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetFragmentShadingRateEnumNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetFragmentShadingRateEnum([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] FragmentShadingRateNV shadingRate, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] FragmentShadingRateCombinerOpKHR* combinerOps);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetFragmentShadingRateEnumNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetFragmentShadingRateEnum([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] FragmentShadingRateNV shadingRate, [Count(Count = 2), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in FragmentShadingRateCombinerOpKHR combinerOps);

        public NVFragmentShadingRateEnums(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

