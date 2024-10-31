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
    [NativeName("Name", "VkAntiLagDataAMD")]
    public unsafe partial struct AntiLagDataAMD : IChainable
    {
        public AntiLagDataAMD
        (
            StructureType? sType = StructureType.AntiLagDataAmd,
            void* pNext = null,
            AntiLagModeAMD? mode = null,
            uint? maxFps = null,
            AntiLagPresentationInfoAMD* pPresentationInfo = null
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

            if (mode is not null)
            {
                Mode = mode.Value;
            }

            if (maxFps is not null)
            {
                MaxFps = maxFps.Value;
            }

            if (pPresentationInfo is not null)
            {
                PPresentationInfo = pPresentationInfo;
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
        [NativeName("Type", "VkAntiLagModeAMD")]
        [NativeName("Type.Name", "VkAntiLagModeAMD")]
        [NativeName("Name", "mode")]
        public AntiLagModeAMD Mode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxFPS")]
        public uint MaxFps;
/// <summary></summary>
        [NativeName("Type", "VkAntiLagPresentationInfoAMD*")]
        [NativeName("Type.Name", "VkAntiLagPresentationInfoAMD")]
        [NativeName("Name", "pPresentationInfo")]
        public AntiLagPresentationInfoAMD* PPresentationInfo;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.AntiLagDataAmd;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
