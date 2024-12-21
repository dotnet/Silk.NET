// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkIndirectCommandsLayoutUsageFlagsEXT")]
    public enum IndirectCommandsLayoutUsageFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ExplicitPreprocessBitExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EXPLICIT_PREPROCESS_BIT_EXT")]
        IndirectCommandsLayoutUsageExplicitPreprocessBitExt = 1,
        [Obsolete("Deprecated in favour of \"UnorderedSequencesBitExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_EXT")]
        IndirectCommandsLayoutUsageUnorderedSequencesBitExt = 2,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_LAYOUT_USAGE_EXPLICIT_PREPROCESS_BIT_EXT")]
        ExplicitPreprocessBitExt = 1,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_LAYOUT_USAGE_UNORDERED_SEQUENCES_BIT_EXT")]
        UnorderedSequencesBitExt = 2,
    }
}
