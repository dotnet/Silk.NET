// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDataGraphModelCacheTypeQCOM")]
    public enum DataGraphModelCacheTypeQCOM : int
    {
        [Obsolete("Deprecated in favour of \"GenericBinaryQCom\"")]
        [NativeName("Name", "VK_DATA_GRAPH_MODEL_CACHE_TYPE_GENERIC_BINARY_QCOM")]
        DataGraphModelCacheTypeGenericBinaryQCom = 0,
        [NativeName("Name", "VK_DATA_GRAPH_MODEL_CACHE_TYPE_GENERIC_BINARY_QCOM")]
        GenericBinaryQCom = 0,
    }
}
