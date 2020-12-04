// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE")]
    public enum MetaCommandParameterStage
    {
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE_CREATION")]
        MetaCommandParameterStageCreation = 0x0,
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE_INITIALIZATION")]
        MetaCommandParameterStageInitialization = 0x1,
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE_EXECUTION")]
        MetaCommandParameterStageExecution = 0x2,
    }
}
