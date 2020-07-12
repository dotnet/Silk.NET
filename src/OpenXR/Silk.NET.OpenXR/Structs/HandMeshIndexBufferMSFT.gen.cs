// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct HandMeshIndexBufferMSFT
    {
        public HandMeshIndexBufferMSFT
        (
            uint indexBufferKey = default,
            uint indexCapacityInput = default,
            uint indexCountOutput = default,
            uint* indices = default
        )
        {
           IndexBufferKey = indexBufferKey;
           IndexCapacityInput = indexCapacityInput;
           IndexCountOutput = indexCountOutput;
           Indices = indices;
        }

/// <summary></summary>
        public uint IndexBufferKey;
/// <summary></summary>
        public uint IndexCapacityInput;
/// <summary></summary>
        public uint IndexCountOutput;
/// <summary></summary>
        public uint* Indices;
    }
}
