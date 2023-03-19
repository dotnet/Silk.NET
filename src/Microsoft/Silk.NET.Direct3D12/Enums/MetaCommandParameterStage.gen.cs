// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE")]
    public enum MetaCommandParameterStage : int
    {
        [Obsolete("Deprecated in favour of \"Creation\"")]
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE_CREATION")]
        MetaCommandParameterStageCreation = 0x0,
        [Obsolete("Deprecated in favour of \"Initialization\"")]
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE_INITIALIZATION")]
        MetaCommandParameterStageInitialization = 0x1,
        [Obsolete("Deprecated in favour of \"Execution\"")]
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE_EXECUTION")]
        MetaCommandParameterStageExecution = 0x2,
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE_CREATION")]
        Creation = 0x0,
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE_INITIALIZATION")]
        Initialization = 0x1,
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE_EXECUTION")]
        Execution = 0x2,
    }
}
