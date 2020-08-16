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
    [NativeName("Name", "XrInteractionProfileAnalogThresholdVALVE")]
    public unsafe partial struct InteractionProfileAnalogThresholdVALVE
    {
        public InteractionProfileAnalogThresholdVALVE
        (
            StructureType type = StructureType.TypeInteractionProfileAnalogThresholdValve,
            void* next = default,
            Action action = default,
            ulong binding = default,
            float onThreshold = default,
            float offThreshold = default,
            HapticBaseHeader* onHaptic = default,
            HapticBaseHeader* offHaptic = default
        )
        {
            Type = type;
            Next = next;
            Action = action;
            Binding = binding;
            OnThreshold = onThreshold;
            OffThreshold = offThreshold;
            OnHaptic = onHaptic;
            OffHaptic = offHaptic;
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
        [NativeName("Type", "XrAction")]
        [NativeName("Type.Name", "XrAction")]
        [NativeName("Name", "action")]
        public Action Action;
/// <summary></summary>
        [NativeName("Type", "XrPath")]
        [NativeName("Type.Name", "XrPath")]
        [NativeName("Name", "binding")]
        public ulong Binding;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "onThreshold")]
        public float OnThreshold;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "offThreshold")]
        public float OffThreshold;
/// <summary></summary>
        [NativeName("Type", "XrHapticBaseHeader*")]
        [NativeName("Type.Name", "XrHapticBaseHeader")]
        [NativeName("Name", "onHaptic")]
        public HapticBaseHeader* OnHaptic;
/// <summary></summary>
        [NativeName("Type", "XrHapticBaseHeader*")]
        [NativeName("Type.Name", "XrHapticBaseHeader")]
        [NativeName("Name", "offHaptic")]
        public HapticBaseHeader* OffHaptic;
    }
}
