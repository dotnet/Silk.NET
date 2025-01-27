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
    [NativeName("Name", "XrSystemFaceTrackingProperties2FB")]
    public unsafe partial struct SystemFaceTrackingProperties2FB
    {
        public SystemFaceTrackingProperties2FB
        (
            StructureType? type = StructureType.TypeSystemFaceTrackingProperties2FB,
            void* next = null,
            uint? supportsVisualFaceTracking = null,
            uint? supportsAudioFaceTracking = null
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

            if (supportsVisualFaceTracking is not null)
            {
                SupportsVisualFaceTracking = supportsVisualFaceTracking.Value;
            }

            if (supportsAudioFaceTracking is not null)
            {
                SupportsAudioFaceTracking = supportsAudioFaceTracking.Value;
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
        [NativeName("Name", "supportsVisualFaceTracking")]
        public uint SupportsVisualFaceTracking;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "supportsAudioFaceTracking")]
        public uint SupportsAudioFaceTracking;
    }
}
