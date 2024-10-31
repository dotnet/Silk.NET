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
    [NativeName("Name", "VkDepthBiasInfoEXT")]
    public unsafe partial struct DepthBiasInfoEXT : IChainStart
    {
        public DepthBiasInfoEXT
        (
            StructureType? sType = StructureType.DepthBiasInfoExt,
            void* pNext = null,
            float? depthBiasConstantFactor = null,
            float? depthBiasClamp = null,
            float? depthBiasSlopeFactor = null
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

            if (depthBiasConstantFactor is not null)
            {
                DepthBiasConstantFactor = depthBiasConstantFactor.Value;
            }

            if (depthBiasClamp is not null)
            {
                DepthBiasClamp = depthBiasClamp.Value;
            }

            if (depthBiasSlopeFactor is not null)
            {
                DepthBiasSlopeFactor = depthBiasSlopeFactor.Value;
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
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "depthBiasConstantFactor")]
        public float DepthBiasConstantFactor;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "depthBiasClamp")]
        public float DepthBiasClamp;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "depthBiasSlopeFactor")]
        public float DepthBiasSlopeFactor;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DepthBiasInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref DepthBiasInfoEXT Chain(
            out DepthBiasInfoEXT capture)
        {
            capture = new DepthBiasInfoEXT(StructureType.DepthBiasInfoExt);
            return ref capture;
        }
    }
}
