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
    [NativeName("Name", "XrSwapchainCreateInfoFoveationFB")]
    public unsafe partial struct SwapchainCreateInfoFoveationFB
    {
        public SwapchainCreateInfoFoveationFB
        (
            StructureType? type = StructureType.TypeSwapchainCreateInfoFoveationFB,
            void* next = null,
            SwapchainCreateFoveationFlagsFB? flags = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
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
        [NativeName("Type", "XrSwapchainCreateFoveationFlagsFB")]
        [NativeName("Type.Name", "XrSwapchainCreateFoveationFlagsFB")]
        [NativeName("Name", "flags")]
        public SwapchainCreateFoveationFlagsFB Flags;
    }
}
