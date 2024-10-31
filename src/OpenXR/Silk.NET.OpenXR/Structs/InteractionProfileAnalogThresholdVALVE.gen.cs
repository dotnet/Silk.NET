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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrInteractionProfileAnalogThresholdVALVE")]
    public unsafe partial struct InteractionProfileAnalogThresholdVALVE
    {
        public InteractionProfileAnalogThresholdVALVE
        (
            StructureType? type = StructureType.TypeInteractionProfileAnalogThresholdValve,
            void* next = null,
            Action? action = null,
            ulong? binding = null,
            float? onThreshold = null,
            float? offThreshold = null,
            HapticBaseHeader* onHaptic = null,
            HapticBaseHeader* offHaptic = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (action is not null)
            {
                Action = action.Value;
            }

            if (binding is not null)
            {
                Binding = binding.Value;
            }

            if (onThreshold is not null)
            {
                OnThreshold = onThreshold.Value;
            }

            if (offThreshold is not null)
            {
                OffThreshold = offThreshold.Value;
            }

            if (onHaptic is not null)
            {
                OnHaptic = onHaptic;
            }

            if (offHaptic is not null)
            {
                OffHaptic = offHaptic;
            }
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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
