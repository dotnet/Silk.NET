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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETERS")]
    public unsafe partial struct FeatureDataVideoExtensionCommandParameters
    {
        public FeatureDataVideoExtensionCommandParameters
        (
            Guid? commandId = null,
            VideoExtensionCommandParameterStage? stage = null,
            uint? parameterCount = null,
            VideoExtensionCommandParameterInfo* pParameterInfos = null
        ) : this()
        {
            if (commandId is not null)
            {
                CommandId = commandId.Value;
            }

            if (stage is not null)
            {
                Stage = stage.Value;
            }

            if (parameterCount is not null)
            {
                ParameterCount = parameterCount.Value;
            }

            if (pParameterInfos is not null)
            {
                PParameterInfos = pParameterInfos;
            }
        }


        [NativeName("Type", "GUID")]
        [NativeName("Type.Name", "GUID")]
        [NativeName("Name", "CommandId")]
        public Guid CommandId;

        [NativeName("Type", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE")]
        [NativeName("Type.Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE")]
        [NativeName("Name", "Stage")]
        public VideoExtensionCommandParameterStage Stage;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ParameterCount")]
        public uint ParameterCount;

        [NativeName("Type", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO *")]
        [NativeName("Type.Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_INFO *")]
        [NativeName("Name", "pParameterInfos")]
        public VideoExtensionCommandParameterInfo* PParameterInfos;
    }
}
