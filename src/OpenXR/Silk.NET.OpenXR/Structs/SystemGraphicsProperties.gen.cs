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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSystemGraphicsProperties")]
    public unsafe partial struct SystemGraphicsProperties
    {
        public SystemGraphicsProperties
        (
            uint? maxSwapchainImageHeight = null,
            uint? maxSwapchainImageWidth = null,
            uint? maxLayerCount = null
        ) : this()
        {
            if (maxSwapchainImageHeight is not null)
            {
                MaxSwapchainImageHeight = maxSwapchainImageHeight.Value;
            }

            if (maxSwapchainImageWidth is not null)
            {
                MaxSwapchainImageWidth = maxSwapchainImageWidth.Value;
            }

            if (maxLayerCount is not null)
            {
                MaxLayerCount = maxLayerCount.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSwapchainImageHeight")]
        public uint MaxSwapchainImageHeight;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSwapchainImageWidth")]
        public uint MaxSwapchainImageWidth;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxLayerCount")]
        public uint MaxLayerCount;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
