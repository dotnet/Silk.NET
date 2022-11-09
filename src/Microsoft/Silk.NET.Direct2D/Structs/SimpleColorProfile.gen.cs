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
    [NativeName("Name", "D2D1_SIMPLE_COLOR_PROFILE")]
    public unsafe partial struct SimpleColorProfile
    {
        public SimpleColorProfile
        (
            Silk.NET.Maths.Vector2D<float>? redPrimary = null,
            Silk.NET.Maths.Vector2D<float>? greenPrimary = null,
            Silk.NET.Maths.Vector2D<float>? bluePrimary = null,
            Silk.NET.Maths.Vector2D<float>? whitePointXZ = null,
            Gamma1? gamma = null
        ) : this()
        {
            if (redPrimary is not null)
            {
                RedPrimary = redPrimary.Value;
            }

            if (greenPrimary is not null)
            {
                GreenPrimary = greenPrimary.Value;
            }

            if (bluePrimary is not null)
            {
                BluePrimary = bluePrimary.Value;
            }

            if (whitePointXZ is not null)
            {
                WhitePointXZ = whitePointXZ.Value;
            }

            if (gamma is not null)
            {
                Gamma = gamma.Value;
            }
        }


        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "redPrimary")]
        public Silk.NET.Maths.Vector2D<float> RedPrimary;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "greenPrimary")]
        public Silk.NET.Maths.Vector2D<float> GreenPrimary;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "bluePrimary")]
        public Silk.NET.Maths.Vector2D<float> BluePrimary;

        [NativeName("Type", "D2D1_POINT_2F")]
        [NativeName("Type.Name", "D2D1_POINT_2F")]
        [NativeName("Name", "whitePointXZ")]
        public Silk.NET.Maths.Vector2D<float> WhitePointXZ;

        [NativeName("Type", "D2D1_GAMMA1")]
        [NativeName("Type.Name", "D2D1_GAMMA1")]
        [NativeName("Name", "gamma")]
        public Gamma1 Gamma;
    }
}
