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
    [NativeName("Name", "VkQueueFamilyProperties2KHR")]
    [NativeName("AliasOf", "VkQueueFamilyProperties2")]
    public unsafe partial struct QueueFamilyProperties2KHR : IChainStart
    {
        public QueueFamilyProperties2KHR
        (
            StructureType? sType = StructureType.QueueFamilyProperties2,
            void* pNext = null,
            QueueFamilyProperties? queueFamilyProperties = null
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

            if (queueFamilyProperties is not null)
            {
                QueueFamilyProperties = queueFamilyProperties.Value;
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
        [NativeName("Type", "VkQueueFamilyProperties")]
        [NativeName("Type.Name", "VkQueueFamilyProperties")]
        [NativeName("Name", "queueFamilyProperties")]
        public QueueFamilyProperties QueueFamilyProperties;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.QueueFamilyProperties2;
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
        public static unsafe ref QueueFamilyProperties2KHR Chain(
            out QueueFamilyProperties2KHR capture)
        {
            capture = new QueueFamilyProperties2KHR(StructureType.QueueFamilyProperties2);
            return ref capture;
        }
    }
}
