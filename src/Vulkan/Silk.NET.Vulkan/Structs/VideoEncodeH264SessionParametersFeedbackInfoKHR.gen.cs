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
    [NativeName("Name", "VkVideoEncodeH264SessionParametersFeedbackInfoKHR")]
    public unsafe partial struct VideoEncodeH264SessionParametersFeedbackInfoKHR : IExtendsChain<VideoEncodeSessionParametersFeedbackInfoKHR>
    {
        public VideoEncodeH264SessionParametersFeedbackInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeH264SessionParametersFeedbackInfoKhr,
            void* pNext = null,
            Bool32? hasStdSpsoverrides = null,
            Bool32? hasStdPpsoverrides = null
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

            if (hasStdSpsoverrides is not null)
            {
                HasStdSpsoverrides = hasStdSpsoverrides.Value;
            }

            if (hasStdPpsoverrides is not null)
            {
                HasStdPpsoverrides = hasStdPpsoverrides.Value;
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
        [NativeName("Name", "hasStdSPSOverrides")]
        public Bool32 HasStdSpsoverrides;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "hasStdPPSOverrides")]
        public Bool32 HasStdPpsoverrides;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264SessionParametersFeedbackInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
