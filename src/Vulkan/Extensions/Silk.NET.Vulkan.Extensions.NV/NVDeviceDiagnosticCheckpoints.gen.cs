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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_device_diagnostic_checkpoints")]
    public unsafe partial class NVDeviceDiagnosticCheckpoints : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_device_diagnostic_checkpoints";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCheckpointNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void CmdSetCheckpoint([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] void* pCheckpointMarker);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCheckpointNV", Convention = CallingConvention.Winapi)]
        public partial void CmdSetCheckpoint<T0>([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ref T0 pCheckpointMarker) where T0 : unmanaged;

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetQueueCheckpointDataNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueueCheckpointData([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint* pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CheckpointDataNV* pCheckpointData);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCheckpointData = new(StructureType.CheckpointDataNV);")]
        [NativeApi(EntryPoint = "vkGetQueueCheckpointDataNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueueCheckpointData([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint* pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CheckpointDataNV pCheckpointData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetQueueCheckpointDataNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueueCheckpointData([Count(Count = 0)] Queue queue, [Count(Count = 0)] ref uint pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CheckpointDataNV* pCheckpointData);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCheckpointData = new(StructureType.CheckpointDataNV);")]
        [NativeApi(EntryPoint = "vkGetQueueCheckpointDataNV", Convention = CallingConvention.Winapi)]
        public partial void GetQueueCheckpointData([Count(Count = 0)] Queue queue, [Count(Count = 0)] ref uint pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CheckpointDataNV pCheckpointData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetQueueCheckpointData2NV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueueCheckpointData2([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint* pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CheckpointData2NV* pCheckpointData);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCheckpointData = new(StructureType.CheckpointData2NV);")]
        [NativeApi(EntryPoint = "vkGetQueueCheckpointData2NV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueueCheckpointData2([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint* pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CheckpointData2NV pCheckpointData);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetQueueCheckpointData2NV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetQueueCheckpointData2([Count(Count = 0)] Queue queue, [Count(Count = 0)] ref uint pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] CheckpointData2NV* pCheckpointData);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCheckpointData = new(StructureType.CheckpointData2NV);")]
        [NativeApi(EntryPoint = "vkGetQueueCheckpointData2NV", Convention = CallingConvention.Winapi)]
        public partial void GetQueueCheckpointData2([Count(Count = 0)] Queue queue, [Count(Count = 0)] ref uint pCheckpointDataCount, [Count(Parameter = "pCheckpointDataCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out CheckpointData2NV pCheckpointData);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCheckpointData = new(StructureType.CheckpointDataNV);")]
        public unsafe CheckpointDataNV GetQueueCheckpointData([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint* pCheckpointDataCount)
        {
            // NonKhrReturnTypeOverloader
            GetQueueCheckpointData(queue, pCheckpointDataCount, out CheckpointDataNV silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCheckpointData = new(StructureType.CheckpointDataNV);")]
        public unsafe CheckpointDataNV GetQueueCheckpointData([Count(Count = 0)] Queue queue, [Count(Count = 0)] ref uint pCheckpointDataCount)
        {
            // NonKhrReturnTypeOverloader
            GetQueueCheckpointData(queue, ref pCheckpointDataCount, out CheckpointDataNV silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCheckpointData = new(StructureType.CheckpointData2NV);")]
        public unsafe CheckpointData2NV GetQueueCheckpointData2([Count(Count = 0)] Queue queue, [Count(Count = 0)] uint* pCheckpointDataCount)
        {
            // NonKhrReturnTypeOverloader
            GetQueueCheckpointData2(queue, pCheckpointDataCount, out CheckpointData2NV silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCheckpointData = new(StructureType.CheckpointData2NV);")]
        public unsafe CheckpointData2NV GetQueueCheckpointData2([Count(Count = 0)] Queue queue, [Count(Count = 0)] ref uint pCheckpointDataCount)
        {
            // NonKhrReturnTypeOverloader
            GetQueueCheckpointData2(queue, ref pCheckpointDataCount, out CheckpointData2NV silkRet);
            return silkRet;
        }

        public NVDeviceDiagnosticCheckpoints(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

