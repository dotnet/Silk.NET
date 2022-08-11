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
    [NativeName("Name", "D2D1_EFFECT_INPUT_DESCRIPTION")]
    public unsafe partial struct EffectInputDescription
    {
        public EffectInputDescription
        (
            ID2D1Effect* effect = null,
            uint? inputIndex = null,
            Silk.NET.Maths.Box2D<float>? inputRectangle = null
        ) : this()
        {
            if (effect is not null)
            {
                Effect = effect;
            }

            if (inputIndex is not null)
            {
                InputIndex = inputIndex.Value;
            }

            if (inputRectangle is not null)
            {
                InputRectangle = inputRectangle.Value;
            }
        }


        [NativeName("Type", "ID2D1Effect *")]
        [NativeName("Type.Name", "ID2D1Effect *")]
        [NativeName("Name", "effect")]
        public ID2D1Effect* Effect;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "inputIndex")]
        public uint InputIndex;

        [NativeName("Type", "D2D1_RECT_F")]
        [NativeName("Type.Name", "D2D1_RECT_F")]
        [NativeName("Name", "inputRectangle")]
        public Silk.NET.Maths.Box2D<float> InputRectangle;
    }
}
