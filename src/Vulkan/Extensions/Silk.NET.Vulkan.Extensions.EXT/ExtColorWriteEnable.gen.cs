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
    [Extension("VK_EXT_color_write_enable")]
    public unsafe partial class ExtColorWriteEnable : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_color_write_enable";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetColorWriteEnableEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetColorWriteEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Bool32* pColorWriteEnables);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetColorWriteEnableEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdSetColorWriteEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Bool32 pColorWriteEnables);

        /// <summary>To be documented.</summary>
        public unsafe void CmdSetColorWriteEnable([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Bool32> pColorWriteEnables)
        {
            // ImplicitCountSpanOverloader
            CmdSetColorWriteEnable(commandBuffer, (uint) pColorWriteEnables.Length, in pColorWriteEnables.GetPinnableReference());
        }

        public ExtColorWriteEnable(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

