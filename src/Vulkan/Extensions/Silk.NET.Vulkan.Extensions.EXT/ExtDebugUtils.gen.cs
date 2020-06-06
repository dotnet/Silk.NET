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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_debug_utils")]
    public unsafe partial class ExtDebugUtils : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_debug_utils";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginDebugUtilsLabelEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdBeginDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo)
            => ImplCmdBeginDebugUtilsLabel(commandBuffer, pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBeginDebugUtilsLabelEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdBeginDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsLabelEXT pLabelInfo)
            => ImplCmdBeginDebugUtilsLabel(commandBuffer, pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdEndDebugUtilsLabelEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdEndDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer)
            => ImplCmdEndDebugUtilsLabel(commandBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdInsertDebugUtilsLabelEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdInsertDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo)
            => ImplCmdInsertDebugUtilsLabel(commandBuffer, pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdInsertDebugUtilsLabelEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdInsertDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsLabelEXT pLabelInfo)
            => ImplCmdInsertDebugUtilsLabel(commandBuffer, pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DebugUtilsMessengerEXT* pMessenger)
            => ImplCreateDebugUtilsMessenger(instance, pCreateInfo, pAllocator, pMessenger);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsMessengerCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DebugUtilsMessengerEXT pMessenger)
            => ImplCreateDebugUtilsMessenger(instance, pCreateInfo, pAllocator, pMessenger);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDebugUtilsMessengerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void DestroyDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessengerEXT messenger, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator)
            => ImplDestroyDebugUtilsMessenger(instance, messenger, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDebugUtilsMessengerEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void DestroyDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessengerEXT messenger, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator)
            => ImplDestroyDebugUtilsMessenger(instance, messenger, pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueBeginDebugUtilsLabelEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void QueueBeginDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo)
            => ImplQueueBeginDebugUtilsLabel(queue, pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueBeginDebugUtilsLabelEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void QueueBeginDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsLabelEXT pLabelInfo)
            => ImplQueueBeginDebugUtilsLabel(queue, pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueEndDebugUtilsLabelEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void QueueEndDebugUtilsLabel([Count(Count = 0)] Queue queue)
            => ImplQueueEndDebugUtilsLabel(queue);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueInsertDebugUtilsLabelEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void QueueInsertDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo)
            => ImplQueueInsertDebugUtilsLabel(queue, pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkQueueInsertDebugUtilsLabelEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void QueueInsertDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsLabelEXT pLabelInfo)
            => ImplQueueInsertDebugUtilsLabel(queue, pLabelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectNameEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result SetDebugUtilsObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsObjectNameInfoEXT* pNameInfo)
            => ImplSetDebugUtilsObjectName(device, pNameInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectNameEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result SetDebugUtilsObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsObjectNameInfoEXT pNameInfo)
            => ImplSetDebugUtilsObjectName(device, pNameInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectTagEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result SetDebugUtilsObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsObjectTagInfoEXT* pTagInfo)
            => ImplSetDebugUtilsObjectTag(device, pTagInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectTagEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result SetDebugUtilsObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsObjectTagInfoEXT pTagInfo)
            => ImplSetDebugUtilsObjectTag(device, pTagInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSubmitDebugUtilsMessageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void SubmitDebugUtilsMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCallbackDataEXT* pCallbackData)
            => ImplSubmitDebugUtilsMessage(instance, messageSeverity, messageTypes, pCallbackData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkSubmitDebugUtilsMessageEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void SubmitDebugUtilsMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsMessengerCallbackDataEXT pCallbackData)
            => ImplSubmitDebugUtilsMessage(instance, messageSeverity, messageTypes, pCallbackData);

        public ExtDebugUtils(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

