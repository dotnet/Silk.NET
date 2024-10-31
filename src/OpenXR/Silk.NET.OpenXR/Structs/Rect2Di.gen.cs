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
    [NativeName("Name", "XrRect2Di")]
    public unsafe partial struct Rect2Di
    {
        public Rect2Di
        (
            Offset2Di? offset = null,
            Extent2Di? extent = null
        ) : this()
        {
            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (extent is not null)
            {
                Extent = extent.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrOffset2Di")]
        [NativeName("Type.Name", "XrOffset2Di")]
        [NativeName("Name", "offset")]
        public Offset2Di Offset;
/// <summary></summary>
        [NativeName("Type", "XrExtent2Di")]
        [NativeName("Type.Name", "XrExtent2Di")]
        [NativeName("Name", "extent")]
        public Extent2Di Extent;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
