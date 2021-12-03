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
    [NativeName("Name", "VkFormatProperties2")]
    [NativeName("Aliases", "VkFormatProperties2KHR")]
    public unsafe partial struct FormatProperties2 : IChainStart
    {
        public FormatProperties2
        (
            StructureType? sType = StructureType.FormatProperties2,
            void* pNext = null,
            FormatProperties? formatProperties = null
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

            if (formatProperties is not null)
            {
                FormatProperties = formatProperties.Value;
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
        [NativeName("Type", "VkFormatProperties")]
        [NativeName("Type.Name", "VkFormatProperties")]
        [NativeName("Name", "formatProperties")]
        public FormatProperties FormatProperties;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.FormatProperties2;
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
        public static unsafe ref FormatProperties2 Chain(
            out FormatProperties2 capture)
        {
            capture = new FormatProperties2(StructureType.FormatProperties2);
            return ref capture;
        }
    }
}
