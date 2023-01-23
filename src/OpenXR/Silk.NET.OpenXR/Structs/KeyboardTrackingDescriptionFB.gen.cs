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
    [NativeName("Name", "XrKeyboardTrackingDescriptionFB")]
    public unsafe partial struct KeyboardTrackingDescriptionFB
    {
        public KeyboardTrackingDescriptionFB
        (
            ulong? trackedKeyboardId = null,
            Vector3f? size = null,
            KeyboardTrackingFlagsFB? flags = null
        ) : this()
        {
            if (trackedKeyboardId is not null)
            {
                TrackedKeyboardId = trackedKeyboardId.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "trackedKeyboardId")]
        public ulong TrackedKeyboardId;
/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "size")]
        public Vector3f Size;
/// <summary></summary>
        [NativeName("Type", "XrKeyboardTrackingFlagsFB")]
        [NativeName("Type.Name", "XrKeyboardTrackingFlagsFB")]
        [NativeName("Name", "flags")]
        public KeyboardTrackingFlagsFB Flags;
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "name")]
        public fixed byte Name[128];
    }
}
