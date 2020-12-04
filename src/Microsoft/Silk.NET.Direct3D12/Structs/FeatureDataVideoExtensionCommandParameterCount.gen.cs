// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "D3D12_FEATURE_DATA_VIDEO_EXTENSION_COMMAND_PARAMETER_COUNT")]
    public unsafe partial struct FeatureDataVideoExtensionCommandParameterCount
    {
        public FeatureDataVideoExtensionCommandParameterCount
        (
            Guid? commandId = null,
            VideoExtensionCommandParameterStage? stage = null,
            uint? parameterCount = null,
            uint? parameterPacking = null
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

            if (parameterPacking is not null)
            {
                ParameterPacking = parameterPacking.Value;
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

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ParameterPacking")]
        public uint ParameterPacking;
    }
}
