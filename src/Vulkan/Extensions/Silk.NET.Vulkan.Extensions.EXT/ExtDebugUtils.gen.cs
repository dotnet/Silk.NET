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
    [Extension("VK_EXT_debug_utils")]
    public unsafe partial class ExtDebugUtils : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_debug_utils";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginDebugUtilsLabelEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdBeginDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginDebugUtilsLabelEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdBeginDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsLabelEXT pLabelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdEndDebugUtilsLabelEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdEndDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdInsertDebugUtilsLabelEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdInsertDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdInsertDebugUtilsLabelEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdInsertDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsLabelEXT pLabelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugUtilsMessengerEXT* pMessenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugUtilsMessengerEXT pMessenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugUtilsMessengerEXT* pMessenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugUtilsMessengerEXT pMessenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsMessengerCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugUtilsMessengerEXT* pMessenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsMessengerCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugUtilsMessengerEXT pMessenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsMessengerCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugUtilsMessengerEXT* pMessenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsMessengerCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugUtilsMessengerEXT pMessenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessengerEXT messenger, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public partial void DestroyDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessengerEXT messenger, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueBeginDebugUtilsLabelEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void QueueBeginDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueBeginDebugUtilsLabelEXT", Convention = CallingConvention.Winapi)]
        public partial void QueueBeginDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsLabelEXT pLabelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueEndDebugUtilsLabelEXT", Convention = CallingConvention.Winapi)]
        public partial void QueueEndDebugUtilsLabel([Count(Count = 0)] Queue queue);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueInsertDebugUtilsLabelEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void QueueInsertDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueInsertDebugUtilsLabelEXT", Convention = CallingConvention.Winapi)]
        public partial void QueueInsertDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsLabelEXT pLabelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectNameEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SetDebugUtilsObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsObjectNameInfoEXT* pNameInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectNameEXT", Convention = CallingConvention.Winapi)]
        public partial Result SetDebugUtilsObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsObjectNameInfoEXT pNameInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectTagEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SetDebugUtilsObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsObjectTagInfoEXT* pTagInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectTagEXT", Convention = CallingConvention.Winapi)]
        public partial Result SetDebugUtilsObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsObjectTagInfoEXT pTagInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSubmitDebugUtilsMessageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void SubmitDebugUtilsMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsMessengerCallbackDataEXT* pCallbackData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkSubmitDebugUtilsMessageEXT", Convention = CallingConvention.Winapi)]
        public partial void SubmitDebugUtilsMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsMessengerCallbackDataEXT pCallbackData);

        public ExtDebugUtils(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

