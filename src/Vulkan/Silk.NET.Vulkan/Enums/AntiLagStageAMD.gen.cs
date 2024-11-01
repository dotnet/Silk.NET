// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAntiLagStageAMD")]
    public enum AntiLagStageAMD : int
    {
        [Obsolete("Deprecated in favour of \"InputAmd\"")]
        [NativeName("Name", "VK_ANTI_LAG_STAGE_INPUT_AMD")]
        AntiLagStageInputAmd = 0,
        [Obsolete("Deprecated in favour of \"PresentAmd\"")]
        [NativeName("Name", "VK_ANTI_LAG_STAGE_PRESENT_AMD")]
        AntiLagStagePresentAmd = 1,
        [NativeName("Name", "VK_ANTI_LAG_STAGE_INPUT_AMD")]
        InputAmd = 0,
        [NativeName("Name", "VK_ANTI_LAG_STAGE_PRESENT_AMD")]
        PresentAmd = 1,
    }
}
