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
    [Extension("VK_EXT_depth_clamp_control")]
    public unsafe partial class ExtDepthClampControl : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_depth_clamp_control";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthClampRangeEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetDepthClampRange([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DepthClampModeEXT depthClampMode, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DepthClampRangeEXT* pDepthClampRange);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetDepthClampRangeEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetDepthClampRange([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] DepthClampModeEXT depthClampMode, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DepthClampRangeEXT pDepthClampRange);

        public ExtDepthClampControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

