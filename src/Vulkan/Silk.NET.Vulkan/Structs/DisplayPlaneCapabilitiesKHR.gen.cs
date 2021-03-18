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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDisplayPlaneCapabilitiesKHR")]
    public unsafe partial struct DisplayPlaneCapabilitiesKHR
    {
        public DisplayPlaneCapabilitiesKHR
        (
            DisplayPlaneAlphaFlagsKHR? supportedAlpha = null,
            Offset2D? minSrcPosition = null,
            Offset2D? maxSrcPosition = null,
            Extent2D? minSrcExtent = null,
            Extent2D? maxSrcExtent = null,
            Offset2D? minDstPosition = null,
            Offset2D? maxDstPosition = null,
            Extent2D? minDstExtent = null,
            Extent2D? maxDstExtent = null
        ) : this()
        {
            if (supportedAlpha is not null)
            {
                SupportedAlpha = supportedAlpha.Value;
            }

            if (minSrcPosition is not null)
            {
                MinSrcPosition = minSrcPosition.Value;
            }

            if (maxSrcPosition is not null)
            {
                MaxSrcPosition = maxSrcPosition.Value;
            }

            if (minSrcExtent is not null)
            {
                MinSrcExtent = minSrcExtent.Value;
            }

            if (maxSrcExtent is not null)
            {
                MaxSrcExtent = maxSrcExtent.Value;
            }

            if (minDstPosition is not null)
            {
                MinDstPosition = minDstPosition.Value;
            }

            if (maxDstPosition is not null)
            {
                MaxDstPosition = maxDstPosition.Value;
            }

            if (minDstExtent is not null)
            {
                MinDstExtent = minDstExtent.Value;
            }

            if (maxDstExtent is not null)
            {
                MaxDstExtent = maxDstExtent.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDisplayPlaneAlphaFlagsKHR")]
        [NativeName("Type.Name", "VkDisplayPlaneAlphaFlagsKHR")]
        [NativeName("Name", "supportedAlpha")]
        public DisplayPlaneAlphaFlagsKHR SupportedAlpha;
/// <summary></summary>
        [NativeName("Type", "VkOffset2D")]
        [NativeName("Type.Name", "VkOffset2D")]
        [NativeName("Name", "minSrcPosition")]
        public Offset2D MinSrcPosition;
/// <summary></summary>
        [NativeName("Type", "VkOffset2D")]
        [NativeName("Type.Name", "VkOffset2D")]
        [NativeName("Name", "maxSrcPosition")]
        public Offset2D MaxSrcPosition;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "minSrcExtent")]
        public Extent2D MinSrcExtent;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxSrcExtent")]
        public Extent2D MaxSrcExtent;
/// <summary></summary>
        [NativeName("Type", "VkOffset2D")]
        [NativeName("Type.Name", "VkOffset2D")]
        [NativeName("Name", "minDstPosition")]
        public Offset2D MinDstPosition;
/// <summary></summary>
        [NativeName("Type", "VkOffset2D")]
        [NativeName("Type.Name", "VkOffset2D")]
        [NativeName("Name", "maxDstPosition")]
        public Offset2D MaxDstPosition;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "minDstExtent")]
        public Extent2D MinDstExtent;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxDstExtent")]
        public Extent2D MaxDstExtent;
    }
}
