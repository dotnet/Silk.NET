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
    [NativeName("Name", "VkPhysicalDeviceShaderIntegerDotProductPropertiesKHR")]
    public unsafe partial struct PhysicalDeviceShaderIntegerDotProductPropertiesKHR : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceShaderIntegerDotProductPropertiesKHR
        (
            StructureType? sType = StructureType.PhysicalDeviceShaderIntegerDotProductPropertiesKhr,
            void* pNext = null,
            Bool32? integerDotProduct8BitUnsignedAccelerated = null,
            Bool32? integerDotProduct8BitSignedAccelerated = null,
            Bool32? integerDotProduct8BitMixedSignednessAccelerated = null,
            Bool32? integerDotProduct4x8BitPackedUnsignedAccelerated = null,
            Bool32? integerDotProduct4x8BitPackedSignedAccelerated = null,
            Bool32? integerDotProduct4x8BitPackedMixedSignednessAccelerated = null,
            Bool32? integerDotProduct16BitUnsignedAccelerated = null,
            Bool32? integerDotProduct16BitSignedAccelerated = null,
            Bool32? integerDotProduct16BitMixedSignednessAccelerated = null,
            Bool32? integerDotProduct32BitUnsignedAccelerated = null,
            Bool32? integerDotProduct32BitSignedAccelerated = null,
            Bool32? integerDotProduct32BitMixedSignednessAccelerated = null,
            Bool32? integerDotProduct64BitUnsignedAccelerated = null,
            Bool32? integerDotProduct64BitSignedAccelerated = null,
            Bool32? integerDotProduct64BitMixedSignednessAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating8BitUnsignedAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating8BitSignedAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating16BitUnsignedAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating16BitSignedAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating32BitUnsignedAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating32BitSignedAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating64BitUnsignedAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating64BitSignedAccelerated = null,
            Bool32? integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated = null
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

            if (integerDotProduct8BitUnsignedAccelerated is not null)
            {
                IntegerDotProduct8BitUnsignedAccelerated = integerDotProduct8BitUnsignedAccelerated.Value;
            }

            if (integerDotProduct8BitSignedAccelerated is not null)
            {
                IntegerDotProduct8BitSignedAccelerated = integerDotProduct8BitSignedAccelerated.Value;
            }

            if (integerDotProduct8BitMixedSignednessAccelerated is not null)
            {
                IntegerDotProduct8BitMixedSignednessAccelerated = integerDotProduct8BitMixedSignednessAccelerated.Value;
            }

            if (integerDotProduct4x8BitPackedUnsignedAccelerated is not null)
            {
                IntegerDotProduct4x8BitPackedUnsignedAccelerated = integerDotProduct4x8BitPackedUnsignedAccelerated.Value;
            }

            if (integerDotProduct4x8BitPackedSignedAccelerated is not null)
            {
                IntegerDotProduct4x8BitPackedSignedAccelerated = integerDotProduct4x8BitPackedSignedAccelerated.Value;
            }

            if (integerDotProduct4x8BitPackedMixedSignednessAccelerated is not null)
            {
                IntegerDotProduct4x8BitPackedMixedSignednessAccelerated = integerDotProduct4x8BitPackedMixedSignednessAccelerated.Value;
            }

            if (integerDotProduct16BitUnsignedAccelerated is not null)
            {
                IntegerDotProduct16BitUnsignedAccelerated = integerDotProduct16BitUnsignedAccelerated.Value;
            }

            if (integerDotProduct16BitSignedAccelerated is not null)
            {
                IntegerDotProduct16BitSignedAccelerated = integerDotProduct16BitSignedAccelerated.Value;
            }

            if (integerDotProduct16BitMixedSignednessAccelerated is not null)
            {
                IntegerDotProduct16BitMixedSignednessAccelerated = integerDotProduct16BitMixedSignednessAccelerated.Value;
            }

            if (integerDotProduct32BitUnsignedAccelerated is not null)
            {
                IntegerDotProduct32BitUnsignedAccelerated = integerDotProduct32BitUnsignedAccelerated.Value;
            }

            if (integerDotProduct32BitSignedAccelerated is not null)
            {
                IntegerDotProduct32BitSignedAccelerated = integerDotProduct32BitSignedAccelerated.Value;
            }

            if (integerDotProduct32BitMixedSignednessAccelerated is not null)
            {
                IntegerDotProduct32BitMixedSignednessAccelerated = integerDotProduct32BitMixedSignednessAccelerated.Value;
            }

            if (integerDotProduct64BitUnsignedAccelerated is not null)
            {
                IntegerDotProduct64BitUnsignedAccelerated = integerDotProduct64BitUnsignedAccelerated.Value;
            }

            if (integerDotProduct64BitSignedAccelerated is not null)
            {
                IntegerDotProduct64BitSignedAccelerated = integerDotProduct64BitSignedAccelerated.Value;
            }

            if (integerDotProduct64BitMixedSignednessAccelerated is not null)
            {
                IntegerDotProduct64BitMixedSignednessAccelerated = integerDotProduct64BitMixedSignednessAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating8BitUnsignedAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated = integerDotProductAccumulatingSaturating8BitUnsignedAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating8BitSignedAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating8BitSignedAccelerated = integerDotProductAccumulatingSaturating8BitSignedAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated = integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated = integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated = integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated = integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating16BitUnsignedAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated = integerDotProductAccumulatingSaturating16BitUnsignedAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating16BitSignedAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating16BitSignedAccelerated = integerDotProductAccumulatingSaturating16BitSignedAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated = integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating32BitUnsignedAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated = integerDotProductAccumulatingSaturating32BitUnsignedAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating32BitSignedAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating32BitSignedAccelerated = integerDotProductAccumulatingSaturating32BitSignedAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated = integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating64BitUnsignedAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated = integerDotProductAccumulatingSaturating64BitUnsignedAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating64BitSignedAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating64BitSignedAccelerated = integerDotProductAccumulatingSaturating64BitSignedAccelerated.Value;
            }

            if (integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated is not null)
            {
                IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated = integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated.Value;
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
        [NativeName("Name", "integerDotProduct8BitUnsignedAccelerated")]
        public Bool32 IntegerDotProduct8BitUnsignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProduct8BitSignedAccelerated")]
        public Bool32 IntegerDotProduct8BitSignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProduct8BitMixedSignednessAccelerated")]
        public Bool32 IntegerDotProduct8BitMixedSignednessAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProduct4x8BitPackedUnsignedAccelerated")]
        public Bool32 IntegerDotProduct4x8BitPackedUnsignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProduct4x8BitPackedSignedAccelerated")]
        public Bool32 IntegerDotProduct4x8BitPackedSignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProduct4x8BitPackedMixedSignednessAccelerated")]
        public Bool32 IntegerDotProduct4x8BitPackedMixedSignednessAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProduct16BitUnsignedAccelerated")]
        public Bool32 IntegerDotProduct16BitUnsignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProduct16BitSignedAccelerated")]
        public Bool32 IntegerDotProduct16BitSignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProduct16BitMixedSignednessAccelerated")]
        public Bool32 IntegerDotProduct16BitMixedSignednessAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProduct32BitUnsignedAccelerated")]
        public Bool32 IntegerDotProduct32BitUnsignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProduct32BitSignedAccelerated")]
        public Bool32 IntegerDotProduct32BitSignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProduct32BitMixedSignednessAccelerated")]
        public Bool32 IntegerDotProduct32BitMixedSignednessAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProduct64BitUnsignedAccelerated")]
        public Bool32 IntegerDotProduct64BitUnsignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProduct64BitSignedAccelerated")]
        public Bool32 IntegerDotProduct64BitSignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProduct64BitMixedSignednessAccelerated")]
        public Bool32 IntegerDotProduct64BitMixedSignednessAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating8BitUnsignedAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating8BitSignedAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating8BitSignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating4x8BitPackedUnsignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating4x8BitPackedSignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating4x8BitPackedMixedSignednessAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating16BitUnsignedAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating16BitSignedAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating16BitSignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating32BitUnsignedAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating32BitSignedAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating32BitSignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating64BitUnsignedAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating64BitSignedAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating64BitSignedAccelerated;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "integerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated")]
        public Bool32 IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceShaderIntegerDotProductPropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
