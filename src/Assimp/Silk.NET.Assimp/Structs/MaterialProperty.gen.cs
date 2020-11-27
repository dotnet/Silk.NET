// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiMaterialProperty")]
    public unsafe partial struct MaterialProperty
    {
        public MaterialProperty
        (
            AssimpString? mKey = null,
            uint? mSemantic = null,
            uint? mIndex = null,
            uint? mDataLength = null,
            PropertyTypeInfo? mType = null,
            byte* mData = null
        ) : this()
        {
            if (mKey is not null)
            {
                MKey = mKey.Value;
            }

            if (mSemantic is not null)
            {
                MSemantic = mSemantic.Value;
            }

            if (mIndex is not null)
            {
                MIndex = mIndex.Value;
            }

            if (mDataLength is not null)
            {
                MDataLength = mDataLength.Value;
            }

            if (mType is not null)
            {
                MType = mType.Value;
            }

            if (mData is not null)
            {
                MData = mData;
            }
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
