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
    [NativeName("Name", "XrHandMeshIndexBufferMSFT")]
    public unsafe partial struct HandMeshIndexBufferMSFT
    {
        public HandMeshIndexBufferMSFT
        (
            uint? indexBufferKey = null,
            uint? indexCapacityInput = null,
            uint? indexCountOutput = null,
            uint* indices = null
        ) : this()
        {
            if (indexBufferKey is not null)
            {
                IndexBufferKey = indexBufferKey.Value;
            }

            if (indexCapacityInput is not null)
            {
                IndexCapacityInput = indexCapacityInput.Value;
            }

            if (indexCountOutput is not null)
            {
                IndexCountOutput = indexCountOutput.Value;
            }

            if (indices is not null)
            {
                Indices = indices;
            }
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexBufferKey")]
        public uint IndexBufferKey;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexCapacityInput")]
        public uint IndexCapacityInput;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indexCountOutput")]
        public uint IndexCountOutput;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "indices")]
        public uint* Indices;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
