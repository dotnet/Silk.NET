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

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVExternalMemoryCapabilitiesOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceExternalImageFormatProperties(this NVExternalMemoryCapabilities thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Format format, [Count(Count = 0)] ImageType type, [Count(Count = 0)] ImageTiling tiling, [Count(Count = 0)] ImageUsageFlags usage, [Count(Count = 0)] ImageCreateFlags flags, [Count(Count = 0)] ExternalMemoryHandleTypeFlagsNV externalHandleType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ExternalImageFormatPropertiesNV> pExternalImageFormatProperties)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceExternalImageFormatProperties(physicalDevice, format, type, tiling, usage, flags, externalHandleType, out pExternalImageFormatProperties.GetPinnableReference());
        }

    }
}

