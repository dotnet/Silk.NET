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
    [NativeName("Name", "XrSessionCreateInfoOverlayEXTX")]
    public unsafe partial struct SessionCreateInfoOverlayEXTX
    {
        public SessionCreateInfoOverlayEXTX
        (
            StructureType? type = StructureType.TypeSessionCreateInfoOverlayExtx,
            void* next = null,
            OverlaySessionCreateFlagsEXTX? createFlags = null,
            uint? sessionLayersPlacement = null
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

            if (createFlags is not null)
            {
                CreateFlags = createFlags.Value;
            }

            if (sessionLayersPlacement is not null)
            {
                SessionLayersPlacement = sessionLayersPlacement.Value;
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
        [NativeName("Type", "XrOverlaySessionCreateFlagsEXTX")]
        [NativeName("Type.Name", "XrOverlaySessionCreateFlagsEXTX")]
        [NativeName("Name", "createFlags")]
        public OverlaySessionCreateFlagsEXTX CreateFlags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sessionLayersPlacement")]
        public uint SessionLayersPlacement;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
