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
    [NativeName("Name", "VkImportMetalTextureInfoEXT")]
    public unsafe partial struct ImportMetalTextureInfoEXT : IExtendsChain<ImageCreateInfo>
    {
        public ImportMetalTextureInfoEXT
        (
            StructureType? sType = StructureType.ImportMetalTextureInfoExt,
            void* pNext = null,
            ImageAspectFlags? plane = null,
            nint? mtlTexture = null
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

            if (plane is not null)
            {
                Plane = plane.Value;
            }

            if (mtlTexture is not null)
            {
                MtlTexture = mtlTexture.Value;
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
        [NativeName("Type", "VkImageAspectFlagBits")]
        [NativeName("Type.Name", "VkImageAspectFlagBits")]
        [NativeName("Name", "plane")]
        public ImageAspectFlags Plane;
/// <summary></summary>
        [NativeName("Type", "MTLTexture_id")]
        [NativeName("Type.Name", "MTLTexture_id")]
        [NativeName("Name", "mtlTexture")]
        public nint MtlTexture;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ImportMetalTextureInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
