// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE")]
    public enum VideoExtensionCommandParameterStage
    {
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CREATION")]
        VideoExtensionCommandParameterStageCreation = 0x0,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_INITIALIZATION")]
        VideoExtensionCommandParameterStageInitialization = 0x1,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_EXECUTION")]
        VideoExtensionCommandParameterStageExecution = 0x2,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CAPS_INPUT")]
        VideoExtensionCommandParameterStageCapsInput = 0x3,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_CAPS_OUTPUT")]
        VideoExtensionCommandParameterStageCapsOutput = 0x4,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_DEVICE_EXECUTE_INPUT")]
        VideoExtensionCommandParameterStageDeviceExecuteInput = 0x5,
        [NativeName("Name", "D3D12_VIDEO_EXTENSION_COMMAND_PARAMETER_STAGE_DEVICE_EXECUTE_OUTPUT")]
        VideoExtensionCommandParameterStageDeviceExecuteOutput = 0x6,
    }
}
