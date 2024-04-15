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

namespace Silk.NET.OpenXR.Extensions.EXT
{
    [Extension("XR_EXT_debug_utils")]
    public unsafe partial class ExtDebugUtils : NativeExtension<XR>
    {
        public const string ExtensionName = "XR_EXT_debug_utils";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* createInfo, [Count(Count = 0)] DebugUtilsMessengerEXT* messenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsMessengerCreateInfoEXT* createInfo, [Count(Count = 0)] ref DebugUtilsMessengerEXT messenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsMessengerCreateInfoEXT createInfo, [Count(Count = 0)] DebugUtilsMessengerEXT* messenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrCreateDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateDebugUtilsMessenger([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsMessengerCreateInfoEXT createInfo, [Count(Count = 0)] ref DebugUtilsMessengerEXT messenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrDestroyDebugUtilsMessengerEXT", Convention = CallingConvention.Winapi)]
        public partial Result DestroyDebugUtilsMessenger([Count(Count = 0)] DebugUtilsMessengerEXT messenger);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSessionBeginDebugUtilsLabelRegionEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SessionBeginDebugUtilsLabelRegion([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsLabelEXT* labelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSessionBeginDebugUtilsLabelRegionEXT", Convention = CallingConvention.Winapi)]
        public partial Result SessionBeginDebugUtilsLabelRegion([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsLabelEXT labelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSessionEndDebugUtilsLabelRegionEXT", Convention = CallingConvention.Winapi)]
        public partial Result SessionEndDebugUtilsLabelRegion([Count(Count = 0)] Session session);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSessionInsertDebugUtilsLabelEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SessionInsertDebugUtilsLabel([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsLabelEXT* labelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSessionInsertDebugUtilsLabelEXT", Convention = CallingConvention.Winapi)]
        public partial Result SessionInsertDebugUtilsLabel([Count(Count = 0)] Session session, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsLabelEXT labelInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetDebugUtilsObjectNameEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SetDebugUtilsObjectName([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsObjectNameInfoEXT* nameInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSetDebugUtilsObjectNameEXT", Convention = CallingConvention.Winapi)]
        public partial Result SetDebugUtilsObjectName([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsObjectNameInfoEXT nameInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSubmitDebugUtilsMessageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result SubmitDebugUtilsMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugUtilsMessengerCallbackDataEXT* callbackData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "xrSubmitDebugUtilsMessageEXT", Convention = CallingConvention.Winapi)]
        public partial Result SubmitDebugUtilsMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugUtilsMessageSeverityFlagsEXT messageSeverity, [Count(Count = 0)] DebugUtilsMessageTypeFlagsEXT messageTypes, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugUtilsMessengerCallbackDataEXT callbackData);

        public ExtDebugUtils(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

