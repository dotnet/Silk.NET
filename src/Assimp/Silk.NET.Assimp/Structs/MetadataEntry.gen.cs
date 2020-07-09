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
    [NativeName("Name", "aiMetadataEntry")]
    public unsafe struct MetadataEntry
    {
        public MetadataEntry
        (
            MetadataType mType = default,
            void* mData = default
        )
        {
           MType = mType;
           MData = mData;
        }


        [NativeName("Type", "aiMetadataType")]
        [NativeName("Type.Name", "aiMetadataType")]
        [NativeName("Name", "mType")]
        public MetadataType MType;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "mData")]
        public void* MData;
    }
}
