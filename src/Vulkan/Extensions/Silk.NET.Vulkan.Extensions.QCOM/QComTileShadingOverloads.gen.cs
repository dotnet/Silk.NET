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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.QCOM
{
    public static class QComTileShadingOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdBeginPerTileExecution(this QComTileShading thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PerTileBeginInfoQCOM> pPerTileBeginInfo)
        {
            // SpanOverloader
            thisApi.CmdBeginPerTileExecution(commandBuffer, in pPerTileBeginInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdDispatchTile(this QComTileShading thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<DispatchTileInfoQCOM> pDispatchTileInfo)
        {
            // SpanOverloader
            thisApi.CmdDispatchTile(commandBuffer, in pDispatchTileInfo.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdEndPerTileExecution(this QComTileShading thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<PerTileEndInfoQCOM> pPerTileEndInfo)
        {
            // SpanOverloader
            thisApi.CmdEndPerTileExecution(commandBuffer, in pPerTileEndInfo.GetPinnableReference());
        }

    }
}

