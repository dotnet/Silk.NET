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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_FEATURE_DATA_SERIALIZATION")]
    public unsafe partial struct FeatureDataSerialization
    {
        public FeatureDataSerialization
        (
            uint? nodeIndex = null,
            HeapSerializationTier? heapSerializationTier = null
        ) : this()
        {
            if (nodeIndex is not null)
            {
                NodeIndex = nodeIndex.Value;
            }

            if (heapSerializationTier is not null)
            {
                HeapSerializationTier = heapSerializationTier.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeIndex")]
        public uint NodeIndex;

        [NativeName("Type", "D3D12_HEAP_SERIALIZATION_TIER")]
        [NativeName("Type.Name", "D3D12_HEAP_SERIALIZATION_TIER")]
        [NativeName("Name", "HeapSerializationTier")]
        public HeapSerializationTier HeapSerializationTier;
    }
}
