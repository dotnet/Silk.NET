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
    [Extension("VK_HUAWEI_invocation_mask")]
    public unsafe partial class HuaweiInvocationMask : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_HUAWEI_invocation_mask";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBindInvocationMaskHUAWEI", Convention = CallingConvention.Winapi)]
        public partial void CmdBindInvocationMaskHuawei([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ImageView imageView, [Count(Count = 0)] ImageLayout imageLayout);

        public HuaweiInvocationMask(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

