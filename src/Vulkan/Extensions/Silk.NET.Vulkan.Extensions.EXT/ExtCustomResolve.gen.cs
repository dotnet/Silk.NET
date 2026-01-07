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
    [Extension("VK_EXT_custom_resolve")]
    public unsafe partial class ExtCustomResolve : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_custom_resolve";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginCustomResolveEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginCustomResolve([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BeginCustomResolveInfoEXT* pBeginCustomResolveInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginCustomResolveEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdBeginCustomResolve([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ref readonly BeginCustomResolveInfoEXT pBeginCustomResolveInfo);

        public ExtCustomResolve(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

