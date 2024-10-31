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
    [NativeName("Name", "VkAccelerationStructureCreateInfoNV")]
    public unsafe partial struct AccelerationStructureCreateInfoNV : IChainStart
    {
        public AccelerationStructureCreateInfoNV
        (
            StructureType? sType = StructureType.AccelerationStructureCreateInfoNV,
            void* pNext = null,
            ulong? compactedSize = null,
            AccelerationStructureInfoNV? info = null
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

            if (compactedSize is not null)
            {
                CompactedSize = compactedSize.Value;
            }

            if (info is not null)
            {
                Info = info.Value;
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
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "compactedSize")]
        public ulong CompactedSize;
/// <summary></summary>
        [NativeName("Type", "VkAccelerationStructureInfoNV")]
        [NativeName("Type.Name", "VkAccelerationStructureInfoNV")]
        [NativeName("Name", "info")]
        public AccelerationStructureInfoNV Info;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AccelerationStructureCreateInfoNV;
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
        public static unsafe ref AccelerationStructureCreateInfoNV Chain(
            out AccelerationStructureCreateInfoNV capture)
        {
            capture = new AccelerationStructureCreateInfoNV(StructureType.AccelerationStructureCreateInfoNV);
            return ref capture;
        }
    }
}
