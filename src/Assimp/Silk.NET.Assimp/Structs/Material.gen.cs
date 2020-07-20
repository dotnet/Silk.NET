// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiMaterial")]
    public unsafe partial struct Material
    {
        public Material
        (
            MaterialProperty** mProperties = default,
            uint mNumProperties = default,
            uint mNumAllocated = default
        )
        {
            MProperties = mProperties;
            MNumProperties = mNumProperties;
            MNumAllocated = mNumAllocated;
        }


        [NativeName("Type", "aiMaterialProperty **")]
        [NativeName("Type.Name", "aiMaterialProperty **")]
        [NativeName("Name", "mProperties")]
        public MaterialProperty** MProperties;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumProperties")]
        public uint MNumProperties;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumAllocated")]
        public uint MNumAllocated;
    }
}
