// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_debug_utils")]
    public abstract unsafe partial class ExtDebugUtils : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdBeginDebugUtilsLabelEXT")]
        public abstract unsafe void CmdBeginDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdBeginDebugUtilsLabelEXT")]
        public abstract void CmdBeginDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsLabelEXT pLabelInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdEndDebugUtilsLabelEXT")]
        public abstract void CmdEndDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdInsertDebugUtilsLabelEXT")]
        public abstract unsafe void CmdInsertDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdInsertDebugUtilsLabelEXT")]
        public abstract void CmdInsertDebugUtilsLabel([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsLabelEXT pLabelInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        public abstract unsafe Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DebugUtilsMessengerEXT* pMessenger);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateDebugUtilsMessengerEXT")]
        public abstract Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsMessengerCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DebugUtilsMessengerEXT pMessenger);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDestroyDebugUtilsMessengerEXT")]
        public abstract unsafe void DestroyDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessengerEXT messenger, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDestroyDebugUtilsMessengerEXT")]
        public abstract void DestroyDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessengerEXT messenger, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkQueueBeginDebugUtilsLabelEXT")]
        public abstract unsafe void QueueBeginDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkQueueBeginDebugUtilsLabelEXT")]
        public abstract void QueueBeginDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsLabelEXT pLabelInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkQueueEndDebugUtilsLabelEXT")]
        public abstract void QueueEndDebugUtilsLabel([Count(Count = 0)] Queue queue);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkQueueInsertDebugUtilsLabelEXT")]
        public abstract unsafe void QueueInsertDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* pLabelInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkQueueInsertDebugUtilsLabelEXT")]
        public abstract void QueueInsertDebugUtilsLabel([Count(Count = 0)] Queue queue, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsLabelEXT pLabelInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectNameEXT")]
        public abstract unsafe Result SetDebugUtilsObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsObjectNameInfoEXT* pNameInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectNameEXT")]
        public abstract Result SetDebugUtilsObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsObjectNameInfoEXT pNameInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectTagEXT")]
        public abstract unsafe Result SetDebugUtilsObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsObjectTagInfoEXT* pTagInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkSetDebugUtilsObjectTagEXT")]
        public abstract Result SetDebugUtilsObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsObjectTagInfoEXT pTagInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkSubmitDebugUtilsMessageEXT")]
        public abstract unsafe void SubmitDebugUtilsMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCallbackDataEXT* pCallbackData);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkSubmitDebugUtilsMessageEXT")]
        public abstract void SubmitDebugUtilsMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsMessengerCallbackDataEXT pCallbackData);

        public ExtDebugUtils(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

