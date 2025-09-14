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
    [NativeName("Name", "VkDisplayModeProperties2KHR")]
    public unsafe partial struct DisplayModeProperties2KHR : IChainStart
    {
        public DisplayModeProperties2KHR
        (
            StructureType? sType = StructureType.DisplayModeProperties2Khr,
            void* pNext = null,
            DisplayModePropertiesKHR? displayModeProperties = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (displayModeProperties is not null)
            {
                DisplayModeProperties = displayModeProperties.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkDisplayModePropertiesKHR")]
        [NativeName("Type.Name", "VkDisplayModePropertiesKHR")]
        [NativeName("Name", "displayModeProperties")]
        public DisplayModePropertiesKHR DisplayModeProperties;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DisplayModeProperties2Khr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref DisplayModeProperties2KHR Chain(
            out DisplayModeProperties2KHR capture)
        {
            capture = new DisplayModeProperties2KHR(StructureType.DisplayModeProperties2Khr);
            return ref capture;
        }
    }
}
