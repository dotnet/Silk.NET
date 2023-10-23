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

namespace Silk.NET.SPIRV.Reflect
{
    [NativeName("Name", "Traits")]
    public unsafe partial struct Traits
    {
        public Traits
        (
            NumericTraits? numeric = null,
            ImageTraits? image = null,
            ArrayTraits? array = null
        ) : this()
        {
            if (numeric is not null)
            {
                Numeric = numeric.Value;
            }

            if (image is not null)
            {
                Image = image.Value;
            }

            if (array is not null)
            {
                Array = array.Value;
            }
        }


        [NativeName("Type", "SpvReflectNumericTraits")]
        [NativeName("Type.Name", "SpvReflectNumericTraits")]
        [NativeName("Name", "numeric")]
        public NumericTraits Numeric;

        [NativeName("Type", "SpvReflectImageTraits")]
        [NativeName("Type.Name", "SpvReflectImageTraits")]
        [NativeName("Name", "image")]
        public ImageTraits Image;

        [NativeName("Type", "SpvReflectArrayTraits")]
        [NativeName("Type.Name", "SpvReflectArrayTraits")]
        [NativeName("Name", "array")]
        public ArrayTraits Array;
    }
}
