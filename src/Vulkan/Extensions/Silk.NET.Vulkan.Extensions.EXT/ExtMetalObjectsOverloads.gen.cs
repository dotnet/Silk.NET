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
    public static class ExtMetalObjectsOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void ExportMetalObjects(this ExtMetalObjects thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] Span<ExportMetalObjectsInfoEXT> pMetalObjectsInfo)
        {
            // SpanOverloader
            thisApi.ExportMetalObjects(device, ref pMetalObjectsInfo.GetPinnableReference());
        }

    }
}

