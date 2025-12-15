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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RESOLVE_METADATA_OUTPUT_ARGUMENTS")]
    public unsafe partial struct VideoEncoderResolveMetadataOutputArguments
    {
        public VideoEncoderResolveMetadataOutputArguments
        (
            VideoEncoderEncodeOperationMetadataBuffer? resolvedLayoutMetadata = null
        ) : this()
        {
            if (resolvedLayoutMetadata is not null)
            {
                ResolvedLayoutMetadata = resolvedLayoutMetadata.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_ENCODE_OPERATION_METADATA_BUFFER")]
        [NativeName("Name", "ResolvedLayoutMetadata")]
        public VideoEncoderEncodeOperationMetadataBuffer ResolvedLayoutMetadata;
    }
}
