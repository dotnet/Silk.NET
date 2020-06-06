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
    [Extension("VK_EXT_debug_marker")]
    public unsafe partial class ExtDebugMarker : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_debug_marker";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerBeginEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdDebugMarkerBegin([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] DebugMarkerMarkerInfoEXT* pMarkerInfo)
            => ImplCmdDebugMarkerBegin(commandBuffer, pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerBeginEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDebugMarkerBegin([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugMarkerMarkerInfoEXT pMarkerInfo)
            => ImplCmdDebugMarkerBegin(commandBuffer, pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerEndEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDebugMarkerEnd([Count(Count = 0)] CommandBuffer commandBuffer)
            => ImplCmdDebugMarkerEnd(commandBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerInsertEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void CmdDebugMarkerInsert([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] DebugMarkerMarkerInfoEXT* pMarkerInfo)
            => ImplCmdDebugMarkerInsert(commandBuffer, pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerInsertEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void CmdDebugMarkerInsert([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugMarkerMarkerInfoEXT pMarkerInfo)
            => ImplCmdDebugMarkerInsert(commandBuffer, pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectNameEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result DebugMarkerSetObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DebugMarkerObjectNameInfoEXT* pNameInfo)
            => ImplDebugMarkerSetObjectName(device, pNameInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectNameEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result DebugMarkerSetObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugMarkerObjectNameInfoEXT pNameInfo)
            => ImplDebugMarkerSetObjectName(device, pNameInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectTagEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe Result DebugMarkerSetObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DebugMarkerObjectTagInfoEXT* pTagInfo)
            => ImplDebugMarkerSetObjectTag(device, pTagInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectTagEXT")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public Result DebugMarkerSetObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugMarkerObjectTagInfoEXT pTagInfo)
            => ImplDebugMarkerSetObjectTag(device, pTagInfo);

        public ExtDebugMarker(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

