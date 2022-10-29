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
    [NativeName("Name", "VkOpticalFlowSessionCreatePrivateDataInfoNV")]
    public unsafe partial struct OpticalFlowSessionCreatePrivateDataInfoNV : IExtendsChain<OpticalFlowSessionCreateInfoNV>
    {
        public OpticalFlowSessionCreatePrivateDataInfoNV
        (
            StructureType? sType = StructureType.OpticalFlowSessionCreatePrivateDataInfoNV,
            void* pNext = null,
            uint? id = null,
            uint? size = null,
            void* pPrivateData = null
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

            if (id is not null)
            {
                Id = id.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (pPrivateData is not null)
            {
                PPrivateData = pPrivateData;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "id")]
        public uint Id;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "size")]
        public uint Size;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pPrivateData")]
        public void* PPrivateData;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.OpticalFlowSessionCreatePrivateDataInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
