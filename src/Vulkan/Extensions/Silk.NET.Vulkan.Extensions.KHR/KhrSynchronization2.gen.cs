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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_synchronization2")]
    public unsafe partial class KhrSynchronization2 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_synchronization2";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdPipelineBarrier2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DependencyInfo* pDependencyInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdPipelineBarrier2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdPipelineBarrier2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DependencyInfo pDependencyInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdResetEvent2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdResetEvent2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0)] PipelineStageFlags2 stageMask);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetEvent2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetEvent2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DependencyInfo* pDependencyInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetEvent2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdSetEvent2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] Event @event, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DependencyInfo pDependencyInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdWaitEvents2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Event* pEvents, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DependencyInfo* pDependencyInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdWaitEvents2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Event* pEvents, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DependencyInfo pDependencyInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdWaitEvents2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Event pEvents, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DependencyInfo* pDependencyInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWaitEvents2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdWaitEvents2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint eventCount, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Event pEvents, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DependencyInfo pDependencyInfos);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdWriteTimestamp2KHR", Convention = CallingConvention.Winapi)]
        public partial void CmdWriteTimestamp2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] PipelineStageFlags2 stage, [Count(Count = 0)] QueryPool queryPool, [Count(Count = 0)] uint query);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueSubmit2KHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result QueueSubmit2([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Parameter = "submitCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] SubmitInfo2* pSubmits, [Count(Count = 0)] Fence fence);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkQueueSubmit2KHR", Convention = CallingConvention.Winapi)]
        public partial Result QueueSubmit2([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint submitCount, [Count(Parameter = "submitCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SubmitInfo2 pSubmits, [Count(Count = 0)] Fence fence);

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] Event* pEvents, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DependencyInfo> pDependencyInfos)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents2(commandBuffer, (uint) pDependencyInfos.Length, pEvents, in pDependencyInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] DependencyInfo* pDependencyInfos)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents2(commandBuffer, (uint) pEvents.Length, in pEvents.GetPinnableReference(), pDependencyInfos);
        }

        /// <summary>To be documented.</summary>
        public unsafe void CmdWaitEvents2([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Event> pEvents, [Count(Parameter = "eventCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DependencyInfo> pDependencyInfos)
        {
            // ImplicitCountSpanOverloader
            CmdWaitEvents2(commandBuffer, (uint) pDependencyInfos.Length, in pEvents.GetPinnableReference(), in pDependencyInfos.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public unsafe Result QueueSubmit2([Count(Count = 0)] Queue queue, [Count(Parameter = "submitCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<SubmitInfo2> pSubmits, [Count(Count = 0)] Fence fence)
        {
            // ImplicitCountSpanOverloader
            return QueueSubmit2(queue, (uint) pSubmits.Length, in pSubmits.GetPinnableReference(), fence);
        }

        public KhrSynchronization2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

