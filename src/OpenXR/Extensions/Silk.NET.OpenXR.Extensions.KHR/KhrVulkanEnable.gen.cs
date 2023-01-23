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
using Silk.NET.OpenXR;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.KHR
{
    [Extension("XR_KHR_vulkan_enable")]
    public unsafe partial class KhrVulkanEnable : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_KHR_vulkan_enable";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanDeviceExtensionsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVulkanDeviceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanDeviceExtensionsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVulkanDeviceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanDeviceExtensionsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVulkanDeviceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanDeviceExtensionsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVulkanDeviceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanDeviceExtensionsKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetVulkanDeviceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanDeviceExtensionsKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetVulkanDeviceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsDeviceKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVulkanGraphicsDevice([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle vkInstance, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle* vkPhysicalDevice);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsDeviceKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetVulkanGraphicsDevice([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] Silk.NET.Core.Native.VkHandle vkInstance, [Count(Count = 0)] ref Silk.NET.Core.Native.VkHandle vkPhysicalDevice);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsRequirementsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVulkanGraphicsRequirements([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] GraphicsRequirementsVulkanKHR* graphicsRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanGraphicsRequirementsKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetVulkanGraphicsRequirements([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref GraphicsRequirementsVulkanKHR graphicsRequirements);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanInstanceExtensionsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVulkanInstanceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanInstanceExtensionsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVulkanInstanceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanInstanceExtensionsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVulkanInstanceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] uint* bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanInstanceExtensionsKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetVulkanInstanceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] byte* buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanInstanceExtensionsKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetVulkanInstanceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] ref byte buffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrGetVulkanInstanceExtensionsKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetVulkanInstanceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint bufferCapacityInput, [Count(Count = 0)] ref uint bufferCountOutput, [UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer);

        /// <summary>To be documented.</summary>
        public unsafe Result GetVulkanDeviceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetVulkanDeviceExtension(instance, systemId, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetVulkanDeviceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetVulkanDeviceExtension(instance, systemId, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetVulkanInstanceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] uint* bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetVulkanInstanceExtension(instance, systemId, (uint) buffer.Length, bufferCountOutput, ref buffer.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result GetVulkanInstanceExtension([Count(Count = 0)] Instance instance, [Count(Count = 0)] ulong systemId, [Count(Count = 0)] ref uint bufferCountOutput, [Count(Parameter = "bufferCapacityInput")] Span<byte> buffer)
        {
            // ImplicitCountSpanOverloader
            return GetVulkanInstanceExtension(instance, systemId, (uint) buffer.Length, ref bufferCountOutput, ref buffer.GetPinnableReference());
        }

        public KhrVulkanEnable(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

