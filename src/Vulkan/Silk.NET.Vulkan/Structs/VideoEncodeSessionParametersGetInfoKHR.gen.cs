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
    [NativeName("Name", "VkVideoEncodeSessionParametersGetInfoKHR")]
    public unsafe partial struct VideoEncodeSessionParametersGetInfoKHR : IChainStart
    {
        public VideoEncodeSessionParametersGetInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeSessionParametersGetInfoKhr,
            void* pNext = null,
            VideoSessionParametersKHR? videoSessionParameters = null
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

            if (videoSessionParameters is not null)
            {
                VideoSessionParameters = videoSessionParameters.Value;
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
        [NativeName("Type", "VkVideoSessionParametersKHR")]
        [NativeName("Type.Name", "VkVideoSessionParametersKHR")]
        [NativeName("Name", "videoSessionParameters")]
        public VideoSessionParametersKHR VideoSessionParameters;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeSessionParametersGetInfoKhr;
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
        public static unsafe ref VideoEncodeSessionParametersGetInfoKHR Chain(
            out VideoEncodeSessionParametersGetInfoKHR capture)
        {
            capture = new VideoEncodeSessionParametersGetInfoKHR(StructureType.VideoEncodeSessionParametersGetInfoKhr);
            return ref capture;
        }
    }
}
