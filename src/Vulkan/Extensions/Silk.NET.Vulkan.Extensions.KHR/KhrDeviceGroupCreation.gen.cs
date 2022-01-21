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
    [Extension("VK_KHR_device_group_creation")]
    public unsafe partial class KhrDeviceGroupCreation : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_device_group_creation";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroupsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceGroupCount, [Count(Parameter = "pPhysicalDeviceGroupCount")] PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroupsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] uint* pPhysicalDeviceGroupCount, [Count(Parameter = "pPhysicalDeviceGroupCount")] ref PhysicalDeviceGroupProperties pPhysicalDeviceGroupProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroupsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref uint pPhysicalDeviceGroupCount, [Count(Parameter = "pPhysicalDeviceGroupCount")] PhysicalDeviceGroupProperties* pPhysicalDeviceGroupProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkEnumeratePhysicalDeviceGroupsKHR", Convention = CallingConvention.Winapi)]
        public partial Result EnumeratePhysicalDeviceGroups([Count(Count = 0)] Instance instance, [Count(Count = 0)] ref uint pPhysicalDeviceGroupCount, [Count(Parameter = "pPhysicalDeviceGroupCount")] ref PhysicalDeviceGroupProperties pPhysicalDeviceGroupProperties);

        public KhrDeviceGroupCreation(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

