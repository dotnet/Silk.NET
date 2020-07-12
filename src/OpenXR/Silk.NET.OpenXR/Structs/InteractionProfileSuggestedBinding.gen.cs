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
    [NativeName("Name", "XrInteractionProfileSuggestedBinding")]
    public unsafe partial struct InteractionProfileSuggestedBinding
    {
        public InteractionProfileSuggestedBinding
        (
            StructureType type = StructureType.TypeInteractionProfileSuggestedBinding,
            void* next = default,
            ulong interactionProfile = default,
            uint countSuggestedBindings = default,
            ActionSuggestedBinding* suggestedBindings = default
        )
        {
            Type = type;
            Next = next;
            InteractionProfile = interactionProfile;
            CountSuggestedBindings = countSuggestedBindings;
            SuggestedBindings = suggestedBindings;
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
        [NativeName("Type", "XrPath")]
        [NativeName("Type.Name", "XrPath")]
        [NativeName("Name", "interactionProfile")]
        public ulong InteractionProfile;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "countSuggestedBindings")]
        public uint CountSuggestedBindings;
/// <summary></summary>
        [NativeName("Type", "XrActionSuggestedBinding*")]
        [NativeName("Type.Name", "XrActionSuggestedBinding")]
        [NativeName("Name", "suggestedBindings")]
        public ActionSuggestedBinding* SuggestedBindings;
    }
}
