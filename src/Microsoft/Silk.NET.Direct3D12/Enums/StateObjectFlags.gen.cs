// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_STATE_OBJECT_FLAGS")]
    public enum StateObjectFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_STATE_OBJECT_FLAG_NONE")]
        StateObjectFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"AllowLocalDependenciesOnExternalDefinitions\"")]
        [NativeName("Name", "D3D12_STATE_OBJECT_FLAG_ALLOW_LOCAL_DEPENDENCIES_ON_EXTERNAL_DEFINITIONS")]
        StateObjectFlagAllowLocalDependenciesOnExternalDefinitions = 0x1,
        [Obsolete("Deprecated in favour of \"AllowExternalDependenciesOnLocalDefinitions\"")]
        [NativeName("Name", "D3D12_STATE_OBJECT_FLAG_ALLOW_EXTERNAL_DEPENDENCIES_ON_LOCAL_DEFINITIONS")]
        StateObjectFlagAllowExternalDependenciesOnLocalDefinitions = 0x2,
        [Obsolete("Deprecated in favour of \"AllowStateObjectAdditions\"")]
        [NativeName("Name", "D3D12_STATE_OBJECT_FLAG_ALLOW_STATE_OBJECT_ADDITIONS")]
        StateObjectFlagAllowStateObjectAdditions = 0x4,
        [NativeName("Name", "D3D12_STATE_OBJECT_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_STATE_OBJECT_FLAG_ALLOW_LOCAL_DEPENDENCIES_ON_EXTERNAL_DEFINITIONS")]
        AllowLocalDependenciesOnExternalDefinitions = 0x1,
        [NativeName("Name", "D3D12_STATE_OBJECT_FLAG_ALLOW_EXTERNAL_DEPENDENCIES_ON_LOCAL_DEFINITIONS")]
        AllowExternalDependenciesOnLocalDefinitions = 0x2,
        [NativeName("Name", "D3D12_STATE_OBJECT_FLAG_ALLOW_STATE_OBJECT_ADDITIONS")]
        AllowStateObjectAdditions = 0x4,
    }
}
