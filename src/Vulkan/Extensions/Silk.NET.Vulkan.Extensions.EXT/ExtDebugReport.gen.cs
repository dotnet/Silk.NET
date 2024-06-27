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
    [Extension("VK_EXT_debug_report")]
    public unsafe partial class ExtDebugReport : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_debug_report";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugReportCallbackCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugReportCallbackEXT* pCallback);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugReportCallbackCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugReportCallbackEXT pCallback);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugReportCallbackCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugReportCallbackEXT* pCallback);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugReportCallbackCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugReportCallbackEXT pCallback);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugReportCallbackCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugReportCallbackEXT* pCallback);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugReportCallbackCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugReportCallbackEXT pCallback);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugReportCallbackCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] DebugReportCallbackEXT* pCallback);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT", Convention = CallingConvention.Winapi)]
        public partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugReportCallbackCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out DebugReportCallbackEXT pCallback);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] nuint location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pLayerPrefix, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pMessage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] nuint location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pLayerPrefix, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pMessage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] nuint location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pLayerPrefix, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pMessage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] nuint location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pLayerPrefix, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pMessage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT", Convention = CallingConvention.Winapi)]
        public partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] nuint location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pLayerPrefix, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pMessage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT", Convention = CallingConvention.Winapi)]
        public partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] nuint location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pLayerPrefix, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pMessage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] nuint location, [Count(Count = 0)] int messageCode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pLayerPrefix, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pMessage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT", Convention = CallingConvention.Winapi)]
        public partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] nuint location, [Count(Count = 0)] int messageCode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pLayerPrefix, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pMessage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT", Convention = CallingConvention.Winapi)]
        public partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] nuint location, [Count(Count = 0)] int messageCode, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pLayerPrefix, [Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pMessage);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDebugReportCallbackEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void DestroyDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportCallbackEXT callback, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDestroyDebugReportCallbackEXT", Convention = CallingConvention.Winapi)]
        public partial void DestroyDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportCallbackEXT callback, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in AllocationCallbacks pAllocator);

        public ExtDebugReport(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

