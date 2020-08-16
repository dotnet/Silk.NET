// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiUVTransform")]
    public unsafe partial struct UVTransform
    {
        public UVTransform
        (
            System.Numerics.Vector2 mTranslation = default,
            System.Numerics.Vector2 mScaling = default,
            float mRotation = default
        )
        {
            MTranslation = mTranslation;
            MScaling = mScaling;
            MRotation = mRotation;
        }


        [NativeName("Type", "aiVector2D")]
        [NativeName("Type.Name", "aiVector2D")]
        [NativeName("Name", "mTranslation")]
        public System.Numerics.Vector2 MTranslation;

        [NativeName("Type", "aiVector2D")]
        [NativeName("Type.Name", "aiVector2D")]
        [NativeName("Name", "mScaling")]
        public System.Numerics.Vector2 MScaling;

        [NativeName("Type", "ai_real")]
        [NativeName("Type.Name", "ai_real")]
        [NativeName("Name", "mRotation")]
        public float MRotation;
    }
}
