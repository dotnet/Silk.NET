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
    [NativeName("Name", "VkBindMemoryStatus")]
    [NativeName("Aliases", "VkBindMemoryStatusKHR")]
    public unsafe partial struct BindMemoryStatus : IExtendsChain<BindBufferMemoryInfo>, IExtendsChain<BindBufferMemoryInfoKHR>, IExtendsChain<BindImageMemoryInfo>, IExtendsChain<BindImageMemoryInfoKHR>
    {
        public BindMemoryStatus
        (
            StructureType? sType = StructureType.BindMemoryStatus,
            void* pNext = null,
            Result* pResult = null
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

            if (pResult is not null)
            {
                PResult = pResult;
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
        [NativeName("Type", "VkResult*")]
        [NativeName("Type.Name", "VkResult")]
        [NativeName("Name", "pResult")]
        public Result* PResult;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.BindMemoryStatus;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
