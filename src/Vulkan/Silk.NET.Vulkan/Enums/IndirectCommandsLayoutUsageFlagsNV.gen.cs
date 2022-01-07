// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkIndirectCommandsLayoutUsageFlagsNV")]
    public enum IndirectCommandsLayoutUsageFlagsNV : int
    {
        [NativeName("Name", "VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EXPLICIT_PREPROCESS_BIT_NV")]
        IndirectCommandsLayoutUsageExplicitPreprocessBitNV = 1,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_LAYOUT_USAGE_INDEXED_SEQUENCES_BIT_NV")]
        IndirectCommandsLayoutUsageIndexedSequencesBitNV = 2,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_NV")]
        IndirectCommandsLayoutUsageUnorderedSequencesBitNV = 4,
    }
}
