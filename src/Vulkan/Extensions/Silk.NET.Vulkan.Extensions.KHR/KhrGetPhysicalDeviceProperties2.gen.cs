// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_get_physical_device_properties2")]
    public unsafe partial class KhrGetPhysicalDeviceProperties2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_get_physical_device_properties2";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceFeatures2* pFeatures)
            => ImplGetPhysicalDeviceFeatures2(physicalDevice, pFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFeatures2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceFeatures2 pFeatures)
            => ImplGetPhysicalDeviceFeatures2(physicalDevice, pFeatures);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] FormatProperties2* pFormatProperties)
            => ImplGetPhysicalDeviceFormatProperties2(physicalDevice, format, pFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFormatProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0), Flow(FlowDirection.Out)] out FormatProperties2 pFormatProperties)
            => ImplGetPhysicalDeviceFormatProperties2(physicalDevice, format, pFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceImageFormatInfo2* pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ImageFormatProperties2* pImageFormatProperties)
            => ImplGetPhysicalDeviceImageFormatProperties2(physicalDevice, pImageFormatInfo, pImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceImageFormatProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result GetPhysicalDeviceImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceImageFormatInfo2 pImageFormatInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ImageFormatProperties2 pImageFormatProperties)
            => ImplGetPhysicalDeviceImageFormatProperties2(physicalDevice, pImageFormatInfo, pImageFormatProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceMemoryProperties2* pMemoryProperties)
            => ImplGetPhysicalDeviceMemoryProperties2(physicalDevice, pMemoryProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceMemoryProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceMemoryProperties2 pMemoryProperties)
            => ImplGetPhysicalDeviceMemoryProperties2(physicalDevice, pMemoryProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] PhysicalDeviceProperties2* pProperties)
            => ImplGetPhysicalDeviceProperties2(physicalDevice, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.Out)] out PhysicalDeviceProperties2 pProperties)
            => ImplGetPhysicalDeviceProperties2(physicalDevice, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pQueueFamilyPropertyCount, [Count(Computed = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] QueueFamilyProperties2* pQueueFamilyProperties)
            => ImplGetPhysicalDeviceQueueFamilyProperties2(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceQueueFamilyProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceQueueFamilyProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pQueueFamilyPropertyCount, [Count(Computed = "pQueueFamilyPropertyCount"), Flow(FlowDirection.Out)] out QueueFamilyProperties2 pQueueFamilyProperties)
            => ImplGetPhysicalDeviceQueueFamilyProperties2(physicalDevice, pQueueFamilyPropertyCount, pQueueFamilyProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceSparseImageFormatInfo2* pFormatInfo, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] SparseImageFormatProperties2* pProperties)
            => ImplGetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, pFormatInfo, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSparseImageFormatProperties2KHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceSparseImageFormatProperties2([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceSparseImageFormatInfo2 pFormatInfo, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out SparseImageFormatProperties2 pProperties)
            => ImplGetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, pFormatInfo, pPropertyCount, pProperties);

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe PhysicalDeviceFeatures2 GetPhysicalDeviceFeatures2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceFeatures2 ret = default;
            GetPhysicalDeviceFeatures2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe PhysicalDeviceMemoryProperties2 GetPhysicalDeviceMemoryProperties2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceMemoryProperties2 ret = default;
            GetPhysicalDeviceMemoryProperties2(physicalDevice, &ret);
            return ret;
        }

        /// <summary>To be added.</summary>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe PhysicalDeviceProperties2 GetPhysicalDeviceProperties2([Count(Count = 0)] PhysicalDevice physicalDevice)
        {
            // ReturnTypeOverloader
            PhysicalDeviceProperties2 ret = default;
            GetPhysicalDeviceProperties2(physicalDevice, &ret);
            return ret;
        }

        public KhrGetPhysicalDeviceProperties2(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

