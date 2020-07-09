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
    [NativeName("Name", "aiTexture")]
    public unsafe struct Texture
    {
        public Texture
        (
            uint mWidth = default,
            uint mHeight = default,
            Texel* pcData = default,
            AssimpString mFilename = default
        )
        {
           MWidth = mWidth;
           MHeight = mHeight;
           PcData = pcData;
           MFilename = mFilename;
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mWidth")]
        public uint MWidth;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mHeight")]
        public uint MHeight;
        [NativeName("Type", "char [9]")]
        [NativeName("Type.Name", "char [9]")]
        [NativeName("Name", "achFormatHint")]
       public fixed byte AchFormatHint[9];

        [NativeName("Type", "aiTexel *")]
        [NativeName("Type.Name", "aiTexel *")]
        [NativeName("Name", "pcData")]
        public Texel* PcData;

        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mFilename")]
        public AssimpString MFilename;
    }
}
