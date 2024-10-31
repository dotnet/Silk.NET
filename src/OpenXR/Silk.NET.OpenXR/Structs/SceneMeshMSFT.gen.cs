// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSceneMeshMSFT")]
    public unsafe partial struct SceneMeshMSFT
    {
        public SceneMeshMSFT
        (
            ulong? meshBufferId = null,
            uint? supportsIndicesUint16 = null
        ) : this()
        {
            if (meshBufferId is not null)
            {
                MeshBufferId = meshBufferId.Value;
            }

            if (supportsIndicesUint16 is not null)
            {
                SupportsIndicesUint16 = supportsIndicesUint16.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "meshBufferId")]
        public ulong MeshBufferId;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "supportsIndicesUint16")]
        public uint SupportsIndicesUint16;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
