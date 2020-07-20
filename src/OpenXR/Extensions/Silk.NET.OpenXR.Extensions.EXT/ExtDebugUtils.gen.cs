// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenXR;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR.Extensions.EXT
{
    [Extension("XR_EXT_debug_utils")]
    public abstract unsafe partial class ExtDebugUtils : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_debug_utils";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateDebugUtilsMessengerEXT")]
        public abstract unsafe Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* createInfo, [Count(Count = 0)] DebugUtilsMessengerEXT* messenger);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrCreateDebugUtilsMessengerEXT")]
        public abstract Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsMessengerCreateInfoEXT createInfo, [Count(Count = 0)] ref DebugUtilsMessengerEXT messenger);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrDestroyDebugUtilsMessengerEXT")]
        public abstract Result DestroyDebugUtilsMessenger([Count(Count = 0)] DebugUtilsMessengerEXT messenger);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSessionBeginDebugUtilsLabelRegionEXT")]
        public abstract unsafe Result SessionBeginDebugUtilsLabelRegion([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* labelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSessionBeginDebugUtilsLabelRegionEXT")]
        public abstract Result SessionBeginDebugUtilsLabelRegion([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsLabelEXT labelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSessionEndDebugUtilsLabelRegionEXT")]
        public abstract Result SessionEndDebugUtilsLabelRegion([Count(Count = 0)] Session session);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSessionInsertDebugUtilsLabelEXT")]
        public abstract unsafe Result SessionInsertDebugUtilsLabel([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsLabelEXT* labelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSessionInsertDebugUtilsLabelEXT")]
        public abstract Result SessionInsertDebugUtilsLabel([Count(Count = 0)] Session session, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsLabelEXT labelInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSetDebugUtilsObjectNameEXT")]
        public abstract unsafe Result SetDebugUtilsObjectName([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsObjectNameInfoEXT* nameInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSetDebugUtilsObjectNameEXT")]
        public abstract Result SetDebugUtilsObjectName([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsObjectNameInfoEXT nameInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSubmitDebugUtilsMessageEXT")]
        public abstract unsafe Result SubmitDebugUtilsMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(FlowDirection.In)] DebugUtilsMessengerCallbackDataEXT* callbackData);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "xrSubmitDebugUtilsMessageEXT")]
        public abstract Result SubmitDebugUtilsMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugUtilsMessengerCallbackDataEXT callbackData);

        public ExtDebugUtils(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

