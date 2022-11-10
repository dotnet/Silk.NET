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

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_INPUT_DESCRIPTION")]
    public unsafe partial struct InputDescription
    {
        public InputDescription
        (
            Filter? filter = null,
            uint? levelOfDetailCount = null
        ) : this()
        {
            if (filter is not null)
            {
                Filter = filter.Value;
            }

            if (levelOfDetailCount is not null)
            {
                LevelOfDetailCount = levelOfDetailCount.Value;
            }
        }


        [NativeName("Type", "D2D1_FILTER")]
        [NativeName("Type.Name", "D2D1_FILTER")]
        [NativeName("Name", "filter")]
        public Filter Filter;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "levelOfDetailCount")]
        public uint LevelOfDetailCount;
    }
}
