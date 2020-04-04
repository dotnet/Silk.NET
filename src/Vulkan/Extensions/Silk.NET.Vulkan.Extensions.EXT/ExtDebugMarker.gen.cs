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
    [Extension("VK_EXT_debug_marker")]
    public abstract unsafe partial class ExtDebugMarker : NativeExtension<Vk>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdDebugMarkerBeginEXT")]
        public abstract unsafe void CmdDebugMarkerBegin([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] DebugMarkerMarkerInfoEXT* pMarkerInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdDebugMarkerBeginEXT")]
        public abstract void CmdDebugMarkerBegin([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugMarkerMarkerInfoEXT pMarkerInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdDebugMarkerEndEXT")]
        public abstract void CmdDebugMarkerEnd([Count(Count = 0)] CommandBuffer commandBuffer);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdDebugMarkerInsertEXT")]
        public abstract unsafe void CmdDebugMarkerInsert([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] DebugMarkerMarkerInfoEXT* pMarkerInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkCmdDebugMarkerInsertEXT")]
        public abstract void CmdDebugMarkerInsert([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugMarkerMarkerInfoEXT pMarkerInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectNameEXT")]
        public abstract unsafe Result DebugMarkerSetObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DebugMarkerObjectNameInfoEXT* pNameInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectNameEXT")]
        public abstract Result DebugMarkerSetObjectName([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugMarkerObjectNameInfoEXT pNameInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectTagEXT")]
        public abstract unsafe Result DebugMarkerSetObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DebugMarkerObjectTagInfoEXT* pTagInfo);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "vkDebugMarkerSetObjectTagEXT")]
        public abstract Result DebugMarkerSetObjectTag([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DebugMarkerObjectTagInfoEXT pTagInfo);

        public ExtDebugMarker(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

