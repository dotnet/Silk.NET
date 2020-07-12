// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct SecondaryViewConfigurationFrameEndInfoMSFT
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
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public uint ViewConfigurationCount;
/// <summary></summary>
        public SecondaryViewConfigurationLayerInfoMSFT* ViewConfigurationLayersInfo;
    }
}
