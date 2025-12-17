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
    [NativeName("Name", "D3D12_VIDEO_ENCODER_RESOLVE_INPUT_PARAM_LAYOUT_INPUT_ARGUMENTS")]
    public unsafe partial struct VideoEncoderResolveInputParamLayoutInputArguments
    {
        public VideoEncoderResolveInputParamLayoutInputArguments
        (
            VideoEncoderInputMapSessionInfo? sessionInfo = null,
            VideoEncoderInputMapData? inputData = null
        ) : this()
        {
            if (sessionInfo is not null)
            {
                SessionInfo = sessionInfo.Value;
            }

            if (inputData is not null)
            {
                InputData = inputData.Value;
            }
        }


        [NativeName("Type", "D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_SESSION_INFO")]
        [NativeName("Name", "SessionInfo")]
        public VideoEncoderInputMapSessionInfo SessionInfo;

        [NativeName("Type", "D3D12_VIDEO_ENCODER_INPUT_MAP_DATA")]
        [NativeName("Type.Name", "D3D12_VIDEO_ENCODER_INPUT_MAP_DATA")]
        [NativeName("Name", "InputData")]
        public VideoEncoderInputMapData InputData;
    }
}
