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

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_buffer_region")]
    public unsafe partial struct BufferRegion
    {
        public BufferRegion
        (
            nuint? origin = null,
            nuint? size = null
        ) : this()
        {
            if (origin is not null)
            {
                Origin = origin.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "origin")]
        public nuint Origin;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "size")]
        public nuint Size;
    }
}
