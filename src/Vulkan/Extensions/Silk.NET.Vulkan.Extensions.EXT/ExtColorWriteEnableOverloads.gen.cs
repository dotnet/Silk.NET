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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    public static class ExtColorWriteEnableOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetColorWriteEnable(this ExtColorWriteEnable thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint attachmentCount, [Count(Parameter = "attachmentCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Bool32> pColorWriteEnables)
        {
            // SpanOverloader
            thisApi.CmdSetColorWriteEnable(commandBuffer, attachmentCount, in pColorWriteEnables.GetPinnableReference());
        }

    }
}

