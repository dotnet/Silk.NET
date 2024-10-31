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
    [NativeName("Name", "XrPassthroughColorLutCreateInfoMETA")]
    public unsafe partial struct PassthroughColorLutCreateInfoMETA
    {
        public PassthroughColorLutCreateInfoMETA
        (
            StructureType? type = StructureType.TypePassthroughColorLutCreateInfoMeta,
            void* next = null,
            PassthroughColorLutChannelsMETA? channels = null,
            uint? resolution = null,
            PassthroughColorLutDataMETA? data = null
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

            if (channels is not null)
            {
                Channels = channels.Value;
            }

            if (resolution is not null)
            {
                Resolution = resolution.Value;
            }

            if (data is not null)
            {
                Data = data.Value;
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
        [NativeName("Type", "XrPassthroughColorLutChannelsMETA")]
        [NativeName("Type.Name", "XrPassthroughColorLutChannelsMETA")]
        [NativeName("Name", "channels")]
        public PassthroughColorLutChannelsMETA Channels;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "resolution")]
        public uint Resolution;
/// <summary></summary>
        [NativeName("Type", "XrPassthroughColorLutDataMETA")]
        [NativeName("Type.Name", "XrPassthroughColorLutDataMETA")]
        [NativeName("Name", "data")]
        public PassthroughColorLutDataMETA Data;
    }
}
