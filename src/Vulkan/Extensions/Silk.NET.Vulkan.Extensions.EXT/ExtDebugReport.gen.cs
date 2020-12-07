// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT")]
        public unsafe partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugReportCallbackCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DebugReportCallbackEXT* pCallback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT")]
        public unsafe partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugReportCallbackCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DebugReportCallbackEXT pCallback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT")]
        public unsafe partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugReportCallbackCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DebugReportCallbackEXT* pCallback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT")]
        public unsafe partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] DebugReportCallbackCreateInfoEXT* pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DebugReportCallbackEXT pCallback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT")]
        public unsafe partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DebugReportCallbackCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DebugReportCallbackEXT* pCallback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT")]
        public unsafe partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DebugReportCallbackCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DebugReportCallbackEXT pCallback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT")]
        public unsafe partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DebugReportCallbackCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] DebugReportCallbackEXT* pCallback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCreateDebugReportCallbackEXT")]
        public partial Result CreateDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0), Flow(FlowDirection.In)] in DebugReportCallbackCreateInfoEXT pCreateInfo, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator, [Count(Count = 0), Flow(FlowDirection.Out)] out DebugReportCallbackEXT pCallback);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public unsafe partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerPrefix, [Count(Count = 0), Flow(FlowDirection.In)] byte* pMessage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public unsafe partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerPrefix, [Count(Count = 0), Flow(FlowDirection.In)] in byte pMessage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public unsafe partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(FlowDirection.In)] byte* pLayerPrefix, [Flow(FlowDirection.In)] string pMessage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public unsafe partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(FlowDirection.In)] in byte pLayerPrefix, [Count(Count = 0), Flow(FlowDirection.In)] byte* pMessage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(FlowDirection.In)] in byte pLayerPrefix, [Count(Count = 0), Flow(FlowDirection.In)] in byte pMessage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Count(Count = 0), Flow(FlowDirection.In)] in byte pLayerPrefix, [Flow(FlowDirection.In)] string pMessage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public unsafe partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Flow(FlowDirection.In)] string pLayerPrefix, [Count(Count = 0), Flow(FlowDirection.In)] byte* pMessage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Flow(FlowDirection.In)] string pLayerPrefix, [Count(Count = 0), Flow(FlowDirection.In)] in byte pMessage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugReportMessageEXT")]
        public partial void DebugReportMessage([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportFlagsEXT flags, [Count(Count = 0)] DebugReportObjectTypeEXT objectType, [Count(Count = 0)] ulong @object, [Count(Count = 0)] UIntPtr location, [Count(Count = 0)] int messageCode, [Flow(FlowDirection.In)] string pLayerPrefix, [Flow(FlowDirection.In)] string pMessage);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDebugReportCallbackEXT")]
        public unsafe partial void DestroyDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportCallbackEXT callback, [Count(Count = 0), Flow(FlowDirection.In)] AllocationCallbacks* pAllocator);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDestroyDebugReportCallbackEXT")]
        public partial void DestroyDebugReportCallback([Count(Count = 0)] Instance instance, [Count(Count = 0)] DebugReportCallbackEXT callback, [Count(Count = 0), Flow(FlowDirection.In)] in AllocationCallbacks pAllocator);

        public ExtDebugReport(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

