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
    [NativeName("Name", "VkAmigoProfilingSubmitInfoSEC")]
    public unsafe partial struct AmigoProfilingSubmitInfoSEC : IExtendsChain<SubmitInfo>
    {
        public AmigoProfilingSubmitInfoSEC
        (
            StructureType? sType = StructureType.AmigoProfilingSubmitInfoSec,
            void* pNext = null,
            ulong? firstDrawTimestamp = null,
            ulong? swapBufferTimestamp = null
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

            if (firstDrawTimestamp is not null)
            {
                FirstDrawTimestamp = firstDrawTimestamp.Value;
            }

            if (swapBufferTimestamp is not null)
            {
                SwapBufferTimestamp = swapBufferTimestamp.Value;
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
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "firstDrawTimestamp")]
        public ulong FirstDrawTimestamp;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "swapBufferTimestamp")]
        public ulong SwapBufferTimestamp;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AmigoProfilingSubmitInfoSec;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
