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
    [NativeName("Name", "XrActiveActionSetPrioritiesEXT")]
    public unsafe partial struct ActiveActionSetPrioritiesEXT
    {
        public ActiveActionSetPrioritiesEXT
        (
            StructureType? type = StructureType.TypeActiveActionSetPrioritiesExt,
            void* next = null,
            uint? actionSetPriorityCount = null,
            ActiveActionSetPriorityEXT* actionSetPriorities = null
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

            if (actionSetPriorityCount is not null)
            {
                ActionSetPriorityCount = actionSetPriorityCount.Value;
            }

            if (actionSetPriorities is not null)
            {
                ActionSetPriorities = actionSetPriorities;
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
        [NativeName("Name", "actionSetPriorityCount")]
        public uint ActionSetPriorityCount;
/// <summary></summary>
        [NativeName("Type", "XrActiveActionSetPriorityEXT*")]
        [NativeName("Type.Name", "XrActiveActionSetPriorityEXT")]
        [NativeName("Name", "actionSetPriorities")]
        public ActiveActionSetPriorityEXT* ActionSetPriorities;
    }
}
