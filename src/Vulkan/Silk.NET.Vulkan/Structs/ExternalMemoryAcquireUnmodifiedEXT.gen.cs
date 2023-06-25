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
    [NativeName("Name", "VkExternalMemoryAcquireUnmodifiedEXT")]
    public unsafe partial struct ExternalMemoryAcquireUnmodifiedEXT : IExtendsChain<BufferMemoryBarrier>, IExtendsChain<BufferMemoryBarrier2>, IExtendsChain<BufferMemoryBarrier2KHR>, IExtendsChain<ImageMemoryBarrier>, IExtendsChain<ImageMemoryBarrier2>, IExtendsChain<ImageMemoryBarrier2KHR>
    {
        public ExternalMemoryAcquireUnmodifiedEXT
        (
            StructureType? sType = StructureType.ExternalMemoryAcquireUnmodifiedExt,
            void* pNext = null,
            Bool32? acquireUnmodifiedMemory = null
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

            if (acquireUnmodifiedMemory is not null)
            {
                AcquireUnmodifiedMemory = acquireUnmodifiedMemory.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "acquireUnmodifiedMemory")]
        public Bool32 AcquireUnmodifiedMemory;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ExternalMemoryAcquireUnmodifiedExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
