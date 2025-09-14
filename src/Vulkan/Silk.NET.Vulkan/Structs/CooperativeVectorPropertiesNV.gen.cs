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
    [NativeName("Name", "VkCooperativeVectorPropertiesNV")]
    public unsafe partial struct CooperativeVectorPropertiesNV : IChainable
    {
        public CooperativeVectorPropertiesNV
        (
            StructureType? sType = StructureType.CooperativeVectorPropertiesNV,
            void* pNext = null,
            ComponentTypeKHR? inputType = null,
            ComponentTypeKHR? inputInterpretation = null,
            ComponentTypeKHR? matrixInterpretation = null,
            ComponentTypeKHR? biasInterpretation = null,
            ComponentTypeKHR? resultType = null,
            Bool32? transpose = null
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

            if (inputType is not null)
            {
                InputType = inputType.Value;
            }

            if (inputInterpretation is not null)
            {
                InputInterpretation = inputInterpretation.Value;
            }

            if (matrixInterpretation is not null)
            {
                MatrixInterpretation = matrixInterpretation.Value;
            }

            if (biasInterpretation is not null)
            {
                BiasInterpretation = biasInterpretation.Value;
            }

            if (resultType is not null)
            {
                ResultType = resultType.Value;
            }

            if (transpose is not null)
            {
                Transpose = transpose.Value;
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
        [NativeName("Type", "VkComponentTypeKHR")]
        [NativeName("Type.Name", "VkComponentTypeKHR")]
        [NativeName("Name", "inputType")]
        public ComponentTypeKHR InputType;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeKHR")]
        [NativeName("Type.Name", "VkComponentTypeKHR")]
        [NativeName("Name", "inputInterpretation")]
        public ComponentTypeKHR InputInterpretation;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeKHR")]
        [NativeName("Type.Name", "VkComponentTypeKHR")]
        [NativeName("Name", "matrixInterpretation")]
        public ComponentTypeKHR MatrixInterpretation;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeKHR")]
        [NativeName("Type.Name", "VkComponentTypeKHR")]
        [NativeName("Name", "biasInterpretation")]
        public ComponentTypeKHR BiasInterpretation;
/// <summary></summary>
        [NativeName("Type", "VkComponentTypeKHR")]
        [NativeName("Type.Name", "VkComponentTypeKHR")]
        [NativeName("Name", "resultType")]
        public ComponentTypeKHR ResultType;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "transpose")]
        public Bool32 Transpose;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CooperativeVectorPropertiesNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
