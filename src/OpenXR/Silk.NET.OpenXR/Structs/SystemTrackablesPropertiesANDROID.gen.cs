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
    [NativeName("Name", "XrSystemTrackablesPropertiesANDROID")]
    public unsafe partial struct SystemTrackablesPropertiesANDROID
    {
        public SystemTrackablesPropertiesANDROID
        (
            StructureType? type = StructureType.TypeSystemTrackablesPropertiesAndroid,
            void* next = null,
            uint? supportsAnchor = null,
            uint? maxAnchors = null
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

            if (supportsAnchor is not null)
            {
                SupportsAnchor = supportsAnchor.Value;
            }

            if (maxAnchors is not null)
            {
                MaxAnchors = maxAnchors.Value;
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
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "supportsAnchor")]
        public uint SupportsAnchor;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxAnchors")]
        public uint MaxAnchors;
    }
}
