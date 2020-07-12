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
    public unsafe struct InteractionProfileSuggestedBinding
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
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public ulong InteractionProfile;
/// <summary></summary>
        public uint CountSuggestedBindings;
/// <summary></summary>
        public ActionSuggestedBinding* SuggestedBindings;
    }
}
