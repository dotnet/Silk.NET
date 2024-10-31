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
    [NativeName("Name", "XrVirtualKeyboardModelAnimationStatesMETA")]
    public unsafe partial struct VirtualKeyboardModelAnimationStatesMETA
    {
        public VirtualKeyboardModelAnimationStatesMETA
        (
            StructureType? type = StructureType.TypeVirtualKeyboardModelAnimationStatesMeta,
            void* next = null,
            uint? stateCapacityInput = null,
            uint? stateCountOutput = null,
            VirtualKeyboardAnimationStateMETA* states = null
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

            if (stateCapacityInput is not null)
            {
                StateCapacityInput = stateCapacityInput.Value;
            }

            if (stateCountOutput is not null)
            {
                StateCountOutput = stateCountOutput.Value;
            }

            if (states is not null)
            {
                States = states;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stateCapacityInput")]
        public uint StateCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stateCountOutput")]
        public uint StateCountOutput;
/// <summary></summary>
        [NativeName("Type", "XrVirtualKeyboardAnimationStateMETA*")]
        [NativeName("Type.Name", "XrVirtualKeyboardAnimationStateMETA")]
        [NativeName("Name", "states")]
        public VirtualKeyboardAnimationStateMETA* States;
    }
}
