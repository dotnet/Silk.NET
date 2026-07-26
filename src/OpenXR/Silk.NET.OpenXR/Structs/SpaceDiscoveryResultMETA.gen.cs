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
    [NativeName("Name", "XrSpaceDiscoveryResultMETA")]
    public unsafe partial struct SpaceDiscoveryResultMETA
    {
        public SpaceDiscoveryResultMETA
        (
            Space? space = null,
            UuidEXT? uuid = null
        ) : this()
        {
            if (space is not null)
            {
                Space = space.Value;
            }

            if (uuid is not null)
            {
                Uuid = uuid.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrSpace")]
        [NativeName("Type.Name", "XrSpace")]
        [NativeName("Name", "space")]
        public Space Space;
/// <summary></summary>
        [NativeName("Type", "XrUuidEXT")]
        [NativeName("Type.Name", "XrUuidEXT")]
        [NativeName("Name", "uuid")]
        public UuidEXT Uuid;
    }
}
