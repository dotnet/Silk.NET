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
    [NativeName("Name", "aiMeshMorphKey")]
    public unsafe partial struct MeshMorphKey
    {
        public MeshMorphKey
        (
            double mTime = default,
            uint* mValues = default,
            double* mWeights = default,
            uint mNumValuesAndWeights = default
        )
        {
            MTime = mTime;
            MValues = mValues;
            MWeights = mWeights;
            MNumValuesAndWeights = mNumValuesAndWeights;
        }


        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "mTime")]
        public double MTime;

        [NativeName("Type", "unsigned int *")]
        [NativeName("Type.Name", "unsigned int *")]
        [NativeName("Name", "mValues")]
        public uint* MValues;

        [NativeName("Type", "double *")]
        [NativeName("Type.Name", "double *")]
        [NativeName("Name", "mWeights")]
        public double* MWeights;

        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mNumValuesAndWeights")]
        public uint MNumValuesAndWeights;
    }
}
