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
    [NativeName("Name", "XrSecondaryViewConfigurationSwapchainCreateInfoMSFT")]
    public unsafe partial struct SecondaryViewConfigurationSwapchainCreateInfoMSFT
    {
        public SecondaryViewConfigurationSwapchainCreateInfoMSFT
        (
            StructureType type = StructureType.TypeSecondaryViewConfigurationSwapchainCreateInfoMsft,
            void* next = default,
            ViewConfigurationType viewConfigurationType = default
        )
        {
            Type = type;
            Next = next;
            ViewConfigurationType = viewConfigurationType;
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
        [NativeName("Type", "XrViewConfigurationType")]
        [NativeName("Type.Name", "XrViewConfigurationType")]
        [NativeName("Name", "viewConfigurationType")]
        public ViewConfigurationType ViewConfigurationType;
    }
}
