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
    [Extension("VK_EXT_debug_report")]
    public abstract unsafe partial class ExtDebugReport : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT")]
        public abstract unsafe Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugReportCallbackCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DebugReportCallbackEXT* pCallback);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT")]
        public abstract Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugReportCallbackCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DebugReportCallbackEXT pCallback);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public abstract unsafe void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerPrefix, [Count(Count = 0), Flow(FlowDirection.In)] byte* pMessage);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public abstract void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pLayerPrefix, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pMessage);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDestroyDebugReportCallbackEXT")]
        public abstract unsafe void DestroyDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportCallbackEXT callback, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDestroyDebugReportCallbackEXT")]
        public abstract void DestroyDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportCallbackEXT callback, [Count(Count = 0), Flow(FlowDirection.In)] ref AllocationCallbacks pAllocator);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public abstract void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Flow(FlowDirection.In)] string pLayerPrefix, [Flow(FlowDirection.In)] string pMessage);

        /// <summary>To be added.</summary>
        public unsafe void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] uint location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerPrefix, [Count(Count = 0), Flow(FlowDirection.In)] byte* pMessage)
        {
            // IntPtrOverloader
            DebugReportMessage(instance, flags, objectType, @object, new UIntPtr(location), messageCode, pLayerPrefix, pMessage);
        }

        /// <summary>To be added.</summary>
        public unsafe void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] uint location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pLayerPrefix, [Count(Count = 0), Flow(FlowDirection.In)] ref byte pMessage)
        {
            // IntPtrOverloader
            DebugReportMessage(instance, flags, objectType, @object, new UIntPtr(location), messageCode, ref pLayerPrefix, ref pMessage);
        }

        /// <summary>To be added.</summary>
        public unsafe void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] uint location, [Count(Count = 0)] int messageCode, [Flow(FlowDirection.In)] string pLayerPrefix, [Flow(FlowDirection.In)] string pMessage)
        {
            // IntPtrOverloader
            DebugReportMessage(instance, flags, objectType, @object, new UIntPtr(location), messageCode, pLayerPrefix, pMessage);
        }

        public ExtDebugReport(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

