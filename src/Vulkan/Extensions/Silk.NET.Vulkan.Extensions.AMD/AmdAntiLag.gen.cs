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

namespace Silk.NET.Vulkan.Extensions.AMD
{
    [Extension("VK_AMD_anti_lag")]
    public unsafe partial class AmdAntiLag : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_AMD_anti_lag";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAntiLagUpdateAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void AntiLagUpdate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AntiLagDataAMD* pData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkAntiLagUpdateAMD", Convention = CallingConvention.Winapi)]
        public partial void AntiLagUpdate([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AntiLagDataAMD pData);

        public AmdAntiLag(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

