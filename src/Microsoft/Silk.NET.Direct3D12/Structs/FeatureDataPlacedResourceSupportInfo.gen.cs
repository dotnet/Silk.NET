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
    [NativeName("Name", "D3D12_FEATURE_DATA_PLACED_RESOURCE_SUPPORT_INFO")]
    public unsafe partial struct FeatureDataPlacedResourceSupportInfo
    {
        public FeatureDataPlacedResourceSupportInfo
        (
            Silk.NET.DXGI.Format? format = null,
            ResourceDimension? dimension = null,
            HeapProperties? destHeapProperties = null,
            Silk.NET.Core.Bool32? supported = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (dimension is not null)
            {
                Dimension = dimension.Value;
            }

            if (destHeapProperties is not null)
            {
                DestHeapProperties = destHeapProperties.Value;
            }

            if (supported is not null)
            {
                Supported = supported.Value;
            }
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "D3D12_RESOURCE_DIMENSION")]
        [NativeName("Type.Name", "D3D12_RESOURCE_DIMENSION")]
        [NativeName("Name", "Dimension")]
        public ResourceDimension Dimension;

        [NativeName("Type", "D3D12_HEAP_PROPERTIES")]
        [NativeName("Type.Name", "D3D12_HEAP_PROPERTIES")]
        [NativeName("Name", "DestHeapProperties")]
        public HeapProperties DestHeapProperties;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Supported")]
        public Silk.NET.Core.Bool32 Supported;
    }
}
