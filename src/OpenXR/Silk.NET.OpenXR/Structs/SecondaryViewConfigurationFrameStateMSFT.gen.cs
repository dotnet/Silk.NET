// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSecondaryViewConfigurationFrameStateMSFT")]
    public unsafe partial struct SecondaryViewConfigurationFrameStateMSFT
    {
        public SecondaryViewConfigurationFrameStateMSFT
        (
            StructureType type = StructureType.TypeSecondaryViewConfigurationFrameStateMsft,
            void* next = default,
            uint viewConfigurationCount = default,
            SecondaryViewConfigurationStateMSFT* viewConfigurationStates = default
        )
        {
            Type = type;
            Next = next;
            ViewConfigurationCount = viewConfigurationCount;
            ViewConfigurationStates = viewConfigurationStates;
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
        [NativeName("Type", "XrSecondaryViewConfigurationStateMSFT*")]
        [NativeName("Type.Name", "XrSecondaryViewConfigurationStateMSFT")]
        [NativeName("Name", "viewConfigurationStates")]
        public SecondaryViewConfigurationStateMSFT* ViewConfigurationStates;
    }
}
