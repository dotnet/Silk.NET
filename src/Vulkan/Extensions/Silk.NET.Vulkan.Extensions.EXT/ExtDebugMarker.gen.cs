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
    [Extension("VK_EXT_debug_marker")]
    public unsafe partial class ExtDebugMarker : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_debug_marker";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerBeginEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdDebugMarkerBegin([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugMarkerMarkerInfoEXT* pMarkerInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerBeginEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdDebugMarkerBegin([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugMarkerMarkerInfoEXT pMarkerInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerEndEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdDebugMarkerEnd([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerInsertEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdDebugMarkerInsert([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugMarkerMarkerInfoEXT* pMarkerInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerInsertEXT", Convention = CallingConvention.Winapi)]
        public partial void CmdDebugMarkerInsert([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugMarkerMarkerInfoEXT pMarkerInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectNameEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result DebugMarkerSetObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugMarkerObjectNameInfoEXT* pNameInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectNameEXT", Convention = CallingConvention.Winapi)]
        public partial Result DebugMarkerSetObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugMarkerObjectNameInfoEXT pNameInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectTagEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result DebugMarkerSetObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DebugMarkerObjectTagInfoEXT* pTagInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectTagEXT", Convention = CallingConvention.Winapi)]
        public partial Result DebugMarkerSetObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DebugMarkerObjectTagInfoEXT pTagInfo);

        public ExtDebugMarker(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

