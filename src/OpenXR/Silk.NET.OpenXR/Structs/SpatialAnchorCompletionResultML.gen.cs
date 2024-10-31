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
    [NativeName("Name", "XrSpatialAnchorCompletionResultML")]
    public unsafe partial struct SpatialAnchorCompletionResultML
    {
        public SpatialAnchorCompletionResultML
        (
            UuidEXT? uuid = null,
            Result? result = null
        ) : this()
        {
            if (uuid is not null)
            {
                Uuid = uuid.Value;
            }

            if (result is not null)
            {
                Result = result.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrUuidEXT")]
        [NativeName("Type.Name", "XrUuidEXT")]
        [NativeName("Name", "uuid")]
        public UuidEXT Uuid;
/// <summary></summary>
        [NativeName("Type", "XrResult")]
        [NativeName("Type.Name", "XrResult")]
        [NativeName("Name", "result")]
        public Result Result;
    }
}
