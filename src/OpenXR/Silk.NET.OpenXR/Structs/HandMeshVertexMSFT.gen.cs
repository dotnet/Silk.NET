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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrHandMeshVertexMSFT")]
    public unsafe partial struct HandMeshVertexMSFT
    {
        public HandMeshVertexMSFT
        (
            Vector3f position = default,
            Vector3f normal = default
        )
        {
            Position = position;
            Normal = normal;
        }

/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "position")]
        public Vector3f Position;
/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "normal")]
        public Vector3f Normal;
    }
}
