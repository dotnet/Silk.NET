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
    [NativeName("Name", "XrInteractionProfileSuggestedBinding")]
    public unsafe partial struct InteractionProfileSuggestedBinding
    {
        public InteractionProfileSuggestedBinding
        (
            StructureType? type = StructureType.TypeInteractionProfileSuggestedBinding,
            void* next = null,
            ulong? interactionProfile = null,
            uint? countSuggestedBindings = null,
            ActionSuggestedBinding* suggestedBindings = null
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

            if (interactionProfile is not null)
            {
                InteractionProfile = interactionProfile.Value;
            }

            if (countSuggestedBindings is not null)
            {
                CountSuggestedBindings = countSuggestedBindings.Value;
            }

            if (suggestedBindings is not null)
            {
                SuggestedBindings = suggestedBindings;
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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
