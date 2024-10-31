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
    [NativeName("Name", "XrPassthroughLayerCreateInfoFB")]
    public unsafe partial struct PassthroughLayerCreateInfoFB
    {
        public PassthroughLayerCreateInfoFB
        (
            StructureType? type = StructureType.TypePassthroughLayerCreateInfoFB,
            void* next = null,
            PassthroughFB? passthrough = null,
            PassthroughFlagsFB? flags = null,
            PassthroughLayerPurposeFB? purpose = null
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

            if (passthrough is not null)
            {
                Passthrough = passthrough.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (purpose is not null)
            {
                Purpose = purpose.Value;
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
        [NativeName("Type", "XrPassthroughFB")]
        [NativeName("Type.Name", "XrPassthroughFB")]
        [NativeName("Name", "passthrough")]
        public PassthroughFB Passthrough;
/// <summary></summary>
        [NativeName("Type", "XrPassthroughFlagsFB")]
        [NativeName("Type.Name", "XrPassthroughFlagsFB")]
        [NativeName("Name", "flags")]
        public PassthroughFlagsFB Flags;
/// <summary></summary>
        [NativeName("Type", "XrPassthroughLayerPurposeFB")]
        [NativeName("Type.Name", "XrPassthroughLayerPurposeFB")]
        [NativeName("Name", "purpose")]
        public PassthroughLayerPurposeFB Purpose;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
