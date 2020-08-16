// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSecondaryViewConfigurationFrameEndInfoMSFT")]
    public unsafe partial struct SecondaryViewConfigurationFrameEndInfoMSFT
    {
        public SecondaryViewConfigurationFrameEndInfoMSFT
        (
            StructureType type = StructureType.TypeSecondaryViewConfigurationFrameEndInfoMsft,
            void* next = default,
            uint viewConfigurationCount = default,
            SecondaryViewConfigurationLayerInfoMSFT* viewConfigurationLayersInfo = default
        )
        {
            Type = type;
            Next = next;
            ViewConfigurationCount = viewConfigurationCount;
            ViewConfigurationLayersInfo = viewConfigurationLayersInfo;
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "viewConfigurationCount")]
        public uint ViewConfigurationCount;
/// <summary></summary>
        [NativeName("Type", "XrSecondaryViewConfigurationLayerInfoMSFT*")]
        [NativeName("Type.Name", "XrSecondaryViewConfigurationLayerInfoMSFT")]
        [NativeName("Name", "viewConfigurationLayersInfo")]
        public SecondaryViewConfigurationLayerInfoMSFT* ViewConfigurationLayersInfo;
    }
}
