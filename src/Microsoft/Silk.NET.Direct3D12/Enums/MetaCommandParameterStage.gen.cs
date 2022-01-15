// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE")]
    public enum MetaCommandParameterStage : int
    {
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE_CREATION")]
        MetaCommandParameterStageCreation = 0x0,
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE_INITIALIZATION")]
        MetaCommandParameterStageInitialization = 0x1,
        [NativeName("Name", "D3D12_META_COMMAND_PARAMETER_STAGE_EXECUTION")]
        MetaCommandParameterStageExecution = 0x2,
    }
}
