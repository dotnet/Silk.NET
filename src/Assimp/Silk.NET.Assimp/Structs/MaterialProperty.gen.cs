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
    [NativeName("Name", "aiMaterialProperty")]
    public unsafe partial struct MaterialProperty
    {
        public MaterialProperty
        (
            AssimpString mKey = default,
            uint mSemantic = default,
            uint mIndex = default,
            uint mDataLength = default,
            PropertyTypeInfo mType = default,
            byte* mData = default
        )
        {
            MKey = mKey;
            MSemantic = mSemantic;
            MIndex = mIndex;
            MDataLength = mDataLength;
            MType = mType;
            MData = mData;
        }


        [NativeName("Type", "aiString")]
        [NativeName("Type.Name", "aiString")]
        [NativeName("Name", "mKey")]
        public AssimpString MKey;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mSemantic")]
        public uint MSemantic;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mIndex")]
        public uint MIndex;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mDataLength")]
        public uint MDataLength;

        [NativeName("Type", "aiPropertyTypeInfo")]
        [NativeName("Type.Name", "aiPropertyTypeInfo")]
        [NativeName("Name", "mType")]
        public PropertyTypeInfo MType;

        [NativeName("Type", "char *")]
        [NativeName("Type.Name", "char *")]
        [NativeName("Name", "mData")]
        public byte* MData;
    }
}
