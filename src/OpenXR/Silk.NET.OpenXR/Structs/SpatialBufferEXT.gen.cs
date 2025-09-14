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
    [NativeName("Name", "XrSpatialBufferEXT")]
    public unsafe partial struct SpatialBufferEXT
    {
        public SpatialBufferEXT
        (
            ulong? bufferId = null,
            SpatialBufferTypeEXT? bufferType = null
        ) : this()
        {
            if (bufferId is not null)
            {
                BufferId = bufferId.Value;
            }

            if (bufferType is not null)
            {
                BufferType = bufferType.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrSpatialBufferIdEXT")]
        [NativeName("Type.Name", "XrSpatialBufferIdEXT")]
        [NativeName("Name", "bufferId")]
        public ulong BufferId;
/// <summary></summary>
        [NativeName("Type", "XrSpatialBufferTypeEXT")]
        [NativeName("Type.Name", "XrSpatialBufferTypeEXT")]
        [NativeName("Name", "bufferType")]
        public SpatialBufferTypeEXT BufferType;
    }
}
