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
    [NativeName("Name", "XrSystemPassthroughProperties2FB")]
    public unsafe partial struct SystemPassthroughProperties2FB
    {
        public SystemPassthroughProperties2FB
        (
            StructureType? type = StructureType.TypeSystemPassthroughProperties2FB,
            void* next = null,
            PassthroughCapabilityFlagsFB? capabilities = null
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

            if (capabilities is not null)
            {
                Capabilities = capabilities.Value;
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
        [NativeName("Type", "XrPassthroughCapabilityFlagsFB")]
        [NativeName("Type.Name", "XrPassthroughCapabilityFlagsFB")]
        [NativeName("Name", "capabilities")]
        public PassthroughCapabilityFlagsFB Capabilities;
    }
}
