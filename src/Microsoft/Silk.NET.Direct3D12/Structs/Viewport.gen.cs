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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIEWPORT")]
    public unsafe partial struct Viewport
    {
        public Viewport
        (
            float? topLeftX = null,
            float? topLeftY = null,
            float? width = null,
            float? height = null,
            float? minDepth = null,
            float? maxDepth = null
        ) : this()
        {
            if (topLeftX is not null)
            {
                TopLeftX = topLeftX.Value;
            }

            if (topLeftY is not null)
            {
                TopLeftY = topLeftY.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (minDepth is not null)
            {
                MinDepth = minDepth.Value;
            }

            if (maxDepth is not null)
            {
                MaxDepth = maxDepth.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "TopLeftX")]
        public float TopLeftX;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "TopLeftY")]
        public float TopLeftY;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Width")]
        public float Width;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Height")]
        public float Height;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MinDepth")]
        public float MinDepth;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MaxDepth")]
        public float MaxDepth;
    }
}
