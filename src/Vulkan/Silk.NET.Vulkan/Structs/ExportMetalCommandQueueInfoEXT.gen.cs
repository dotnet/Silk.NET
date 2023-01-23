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
    [NativeName("Name", "VkExportMetalCommandQueueInfoEXT")]
    public unsafe partial struct ExportMetalCommandQueueInfoEXT : IExtendsChain<ExportMetalObjectsInfoEXT>
    {
        public ExportMetalCommandQueueInfoEXT
        (
            StructureType? sType = StructureType.ExportMetalCommandQueueInfoExt,
            void* pNext = null,
            Queue? queue = null,
            nint? mtlCommandQueue = null
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

            if (queue is not null)
            {
                Queue = queue.Value;
            }

            if (mtlCommandQueue is not null)
            {
                MtlCommandQueue = mtlCommandQueue.Value;
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
        [NativeName("Type", "VkQueue")]
        [NativeName("Type.Name", "VkQueue")]
        [NativeName("Name", "queue")]
        public Queue Queue;
/// <summary></summary>
        [NativeName("Type", "MTLCommandQueue_id")]
        [NativeName("Type.Name", "MTLCommandQueue_id")]
        [NativeName("Name", "mtlCommandQueue")]
        public nint MtlCommandQueue;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ExportMetalCommandQueueInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
