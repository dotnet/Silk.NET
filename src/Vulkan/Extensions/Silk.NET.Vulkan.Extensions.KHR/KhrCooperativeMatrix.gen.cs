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
    [Extension("VK_KHR_cooperative_matrix")]
    public unsafe partial class KhrCooperativeMatrix : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_cooperative_matrix";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceCooperativeMatrixProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CooperativeMatrixPropertiesKHR* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.CooperativeMatrixPropertiesKhr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceCooperativeMatrixProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CooperativeMatrixPropertiesKHR pProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceCooperativeMatrixProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CooperativeMatrixPropertiesKHR* pProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pProperties = new(StructureType.CooperativeMatrixPropertiesKhr);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceCooperativeMatrixProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Parameter = "pPropertyCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CooperativeMatrixPropertiesKHR pProperties);

        public KhrCooperativeMatrix(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

