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
    [NativeName("Name", "aiVertexWeight")]
    public unsafe partial struct VertexWeight
    {
        public VertexWeight
        (
            uint mVertexId = default,
            float mWeight = default
        )
        {
            MVertexId = mVertexId;
            MWeight = mWeight;
        }


        [NativeName("Type", "unsigned int")]
        [NativeName("Type.Name", "unsigned int")]
        [NativeName("Name", "mVertexId")]
        public uint MVertexId;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "mWeight")]
        public float MWeight;
    }
}
