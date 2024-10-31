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
    [NativeName("Name", "XrCompositionLayerCubeKHR")]
    public unsafe partial struct CompositionLayerCubeKHR
    {
        public CompositionLayerCubeKHR
        (
            StructureType? type = StructureType.TypeCompositionLayerCubeKhr,
            void* next = null,
            CompositionLayerFlags? layerFlags = null,
            Space? space = null,
            EyeVisibility? eyeVisibility = null,
            Swapchain? swapchain = null,
            uint? imageArrayIndex = null,
            Quaternionf? orientation = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (layerFlags is not null)
            {
                LayerFlags = layerFlags.Value;
            }

            if (space is not null)
            {
                Space = space.Value;
            }

            if (eyeVisibility is not null)
            {
                EyeVisibility = eyeVisibility.Value;
            }

            if (swapchain is not null)
            {
                Swapchain = swapchain.Value;
            }

            if (imageArrayIndex is not null)
            {
                ImageArrayIndex = imageArrayIndex.Value;
            }

            if (orientation is not null)
            {
                Orientation = orientation.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrCompositionLayerFlags")]
        [NativeName("Type.Name", "XrCompositionLayerFlags")]
        [NativeName("Name", "layerFlags")]
        public CompositionLayerFlags LayerFlags;
/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "space")]
        public Space Space;
/// <summary></summary>
        [NativeName("Type", "XrEyeVisibility")]
        [NativeName("Type.Name", "XrEyeVisibility")]
        [NativeName("Name", "eyeVisibility")]
        public EyeVisibility EyeVisibility;
/// <summary></summary>
        [NativeName("Type", "XrSwapchain")]
        [NativeName("Type.Name", "XrSwapchain")]
        [NativeName("Name", "swapchain")]
        public Swapchain Swapchain;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "imageArrayIndex")]
        public uint ImageArrayIndex;
/// <summary></summary>
        [NativeName("Type", "XrQuaternionf")]
        [NativeName("Type.Name", "XrQuaternionf")]
        [NativeName("Name", "orientation")]
        public Quaternionf Orientation;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
