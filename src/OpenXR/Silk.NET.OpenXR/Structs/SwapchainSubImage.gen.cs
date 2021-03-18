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
    [NativeName("Name", "XrSwapchainSubImage")]
    public unsafe partial struct SwapchainSubImage
    {
        public SwapchainSubImage
        (
            Swapchain? swapchain = null,
            Rect2Di? imageRect = null,
            uint? imageArrayIndex = null
        ) : this()
        {
            if (swapchain is not null)
            {
                Swapchain = swapchain.Value;
            }

            if (imageRect is not null)
            {
                ImageRect = imageRect.Value;
            }

            if (imageArrayIndex is not null)
            {
                ImageArrayIndex = imageArrayIndex.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrSwapchain")]
        [NativeName("Type.Name", "XrSwapchain")]
        [NativeName("Name", "swapchain")]
        public Swapchain Swapchain;
/// <summary></summary>
        [NativeName("Type", "XrRect2Di")]
        [NativeName("Type.Name", "XrRect2Di")]
        [NativeName("Name", "imageRect")]
        public Rect2Di ImageRect;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "imageArrayIndex")]
        public uint ImageArrayIndex;
    }
}
