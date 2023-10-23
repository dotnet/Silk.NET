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
    [NativeName("Name", "VkVideoEncodeSessionParametersFeedbackInfoKHR")]
    public unsafe partial struct VideoEncodeSessionParametersFeedbackInfoKHR : IChainStart
    {
        public VideoEncodeSessionParametersFeedbackInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeSessionParametersFeedbackInfoKhr,
            void* pNext = null,
            Bool32? hasOverrides = null
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

            if (hasOverrides is not null)
            {
                HasOverrides = hasOverrides.Value;
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
        [NativeName("Name", "hasOverrides")]
        public Bool32 HasOverrides;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeSessionParametersFeedbackInfoKhr;
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
        public static unsafe ref VideoEncodeSessionParametersFeedbackInfoKHR Chain(
            out VideoEncodeSessionParametersFeedbackInfoKHR capture)
        {
            capture = new VideoEncodeSessionParametersFeedbackInfoKHR(StructureType.VideoEncodeSessionParametersFeedbackInfoKhr);
            return ref capture;
        }
    }
}
