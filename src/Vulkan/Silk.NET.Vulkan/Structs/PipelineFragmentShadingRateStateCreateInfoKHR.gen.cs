// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkPipelineFragmentShadingRateStateCreateInfoKHR")]
    public unsafe partial struct PipelineFragmentShadingRateStateCreateInfoKHR
    {
        public PipelineFragmentShadingRateStateCreateInfoKHR
        (
            StructureType? sType = StructureType.PipelineFragmentShadingRateStateCreateInfoKhr,
            void* pNext = null,
            Extent2D? fragmentSize = null
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

            if (fragmentSize is not null)
            {
                FragmentSize = fragmentSize.Value;
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
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "fragmentSize")]
        public Extent2D FragmentSize;
        /// <summary></summary>
        [NativeName("Type", "VkFragmentShadingRateCombinerOpKHR")]
        [NativeName("Type.Name", "VkFragmentShadingRateCombinerOpKHR")]
        [NativeName("Name", "combinerOps")]
        public CombinerOpsBuffer CombinerOps;

        public struct CombinerOpsBuffer
        {
            public FragmentShadingRateCombinerOpKHR Element0;
            public FragmentShadingRateCombinerOpKHR Element1;
            public ref FragmentShadingRateCombinerOpKHR this[int index]
            {
                get
                {
                    if (index > 1 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (FragmentShadingRateCombinerOpKHR* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1
            public Span<FragmentShadingRateCombinerOpKHR> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 2);
#endif
        }

    }
}
