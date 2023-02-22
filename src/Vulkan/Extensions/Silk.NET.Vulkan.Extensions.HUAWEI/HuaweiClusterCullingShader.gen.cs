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

namespace Silk.NET.Vulkan.Extensions.HUAWEI
{
    [Extension("VK_HUAWEI_cluster_culling_shader")]
    public unsafe partial class HuaweiClusterCullingShader : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_HUAWEI_cluster_culling_shader";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawClusterHUAWEI", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawClusterHuawei([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint groupCountX, [Count(Count = 0)] uint groupCountY, [Count(Count = 0)] uint groupCountZ);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDrawClusterIndirectHUAWEI", Convention = CallingConvention.Winapi)]
        public partial void CmdDrawClusterIndirectHuawei([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Buffer buffer, [Count(Count = 0)] ulong offset);

        public HuaweiClusterCullingShader(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

