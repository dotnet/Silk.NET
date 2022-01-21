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
    [Extension("VK_EXT_pageable_device_local_memory")]
    public unsafe partial class ExtPageableDeviceLocalMemory : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_pageable_device_local_memory";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetDeviceMemoryPriorityEXT", Convention = CallingConvention.Winapi)]
        public partial void SetDeviceMemoryPriority([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] float priority);

        public ExtPageableDeviceLocalMemory(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

