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
    [Extension("VK_EXT_debug_marker")]
    public unsafe partial class ExtDebugMarker : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_debug_marker";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerBeginEXT")]
        public unsafe partial void CmdDebugMarkerBegin([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] DebugMarkerMarkerInfoEXT* pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerBeginEXT")]
        public partial void CmdDebugMarkerBegin([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in DebugMarkerMarkerInfoEXT pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerEndEXT")]
        public partial void CmdDebugMarkerEnd([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerInsertEXT")]
        public unsafe partial void CmdDebugMarkerInsert([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] DebugMarkerMarkerInfoEXT* pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdDebugMarkerInsertEXT")]
        public partial void CmdDebugMarkerInsert([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in DebugMarkerMarkerInfoEXT pMarkerInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectNameEXT")]
        public unsafe partial Result DebugMarkerSetObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DebugMarkerObjectNameInfoEXT* pNameInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectNameEXT")]
        public partial Result DebugMarkerSetObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DebugMarkerObjectNameInfoEXT pNameInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectTagEXT")]
        public unsafe partial Result DebugMarkerSetObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DebugMarkerObjectTagInfoEXT* pTagInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectTagEXT")]
        public partial Result DebugMarkerSetObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] in DebugMarkerObjectTagInfoEXT pTagInfo);

        public ExtDebugMarker(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

