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
    [NativeName("Name", "VkPhysicalDeviceDrmPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceDrmPropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceDrmPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceDrmPropertiesExt,
            void* pNext = null,
            Bool32? hasPrimary = null,
            Bool32? hasRender = null,
            long? primaryMajor = null,
            long? primaryMinor = null,
            long? renderMajor = null,
            long? renderMinor = null
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

            if (hasPrimary is not null)
            {
                HasPrimary = hasPrimary.Value;
            }

            if (hasRender is not null)
            {
                HasRender = hasRender.Value;
            }

            if (primaryMajor is not null)
            {
                PrimaryMajor = primaryMajor.Value;
            }

            if (primaryMinor is not null)
            {
                PrimaryMinor = primaryMinor.Value;
            }

            if (renderMajor is not null)
            {
                RenderMajor = renderMajor.Value;
            }

            if (renderMinor is not null)
            {
                RenderMinor = renderMinor.Value;
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
        [NativeName("Name", "hasPrimary")]
        public Bool32 HasPrimary;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "hasRender")]
        public Bool32 HasRender;
/// <summary></summary>
        [NativeName("Type", "int64_t")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "primaryMajor")]
        public long PrimaryMajor;
/// <summary></summary>
        [NativeName("Type", "int64_t")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "primaryMinor")]
        public long PrimaryMinor;
/// <summary></summary>
        [NativeName("Type", "int64_t")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "renderMajor")]
        public long RenderMajor;
/// <summary></summary>
        [NativeName("Type", "int64_t")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "renderMinor")]
        public long RenderMinor;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceDrmPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
