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
    [NativeName("Name", "VkDisplayPropertiesKHR")]
    public unsafe partial struct DisplayPropertiesKHR
    {
        public DisplayPropertiesKHR
        (
            DisplayKHR? display = null,
            byte* displayName = null,
            Extent2D? physicalDimensions = null,
            Extent2D? physicalResolution = null,
            SurfaceTransformFlagsKHR? supportedTransforms = null,
            Bool32? planeReorderPossible = null,
            Bool32? persistentContent = null
        ) : this()
        {
            if (display is not null)
            {
                Display = display.Value;
            }

            if (displayName is not null)
            {
                DisplayName = displayName;
            }

            if (physicalDimensions is not null)
            {
                PhysicalDimensions = physicalDimensions.Value;
            }

            if (physicalResolution is not null)
            {
                PhysicalResolution = physicalResolution.Value;
            }

            if (supportedTransforms is not null)
            {
                SupportedTransforms = supportedTransforms.Value;
            }

            if (planeReorderPossible is not null)
            {
                PlaneReorderPossible = planeReorderPossible.Value;
            }

            if (persistentContent is not null)
            {
                PersistentContent = persistentContent.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDisplayKHR")]
        [NativeName("Type.Name", "VkDisplayKHR")]
        [NativeName("Name", "display")]
        public DisplayKHR Display;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "displayName")]
        public byte* DisplayName;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "physicalDimensions")]
        public Extent2D PhysicalDimensions;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "physicalResolution")]
        public Extent2D PhysicalResolution;
/// <summary></summary>
        [NativeName("Type", "VkSurfaceTransformFlagsKHR")]
        [NativeName("Type.Name", "VkSurfaceTransformFlagsKHR")]
        [NativeName("Name", "supportedTransforms")]
        public SurfaceTransformFlagsKHR SupportedTransforms;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "planeReorderPossible")]
        public Bool32 PlaneReorderPossible;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "persistentContent")]
        public Bool32 PersistentContent;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
