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
    [NativeName("Name", "VkSamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM")]
    public unsafe partial struct SamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM : IExtendsChain<SamplerYcbcrConversionCreateInfo>, IExtendsChain<SamplerYcbcrConversionCreateInfoKHR>
    {
        public SamplerYcbcrConversionYcbcrDegammaCreateInfoQCOM
        (
            StructureType? sType = StructureType.SamplerYcbcrConversionYcbcrDegammaCreateInfoQCom,
            void* pNext = null,
            Bool32? enableYDegamma = null,
            Bool32? enableCbCrDegamma = null
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

            if (enableYDegamma is not null)
            {
                EnableYDegamma = enableYDegamma.Value;
            }

            if (enableCbCrDegamma is not null)
            {
                EnableCbCrDegamma = enableCbCrDegamma.Value;
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
        [NativeName("Name", "enableYDegamma")]
        public Bool32 EnableYDegamma;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "enableCbCrDegamma")]
        public Bool32 EnableCbCrDegamma;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SamplerYcbcrConversionYcbcrDegammaCreateInfoQCom;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
