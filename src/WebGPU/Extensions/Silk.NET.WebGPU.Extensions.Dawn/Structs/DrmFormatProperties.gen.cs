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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUDrmFormatProperties")]
    public unsafe partial struct DrmFormatProperties
    {
        public DrmFormatProperties
        (
            ulong? modifier = null,
            uint? modifierPlaneCount = null
        ) : this()
        {
            if (modifier is not null)
            {
                Modifier = modifier.Value;
            }

            if (modifierPlaneCount is not null)
            {
                ModifierPlaneCount = modifierPlaneCount.Value;
            }
        }


        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "modifier")]
        public ulong Modifier;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "modifierPlaneCount")]
        public uint ModifierPlaneCount;
    }
}
