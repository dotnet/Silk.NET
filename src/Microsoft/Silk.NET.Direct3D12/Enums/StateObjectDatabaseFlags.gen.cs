// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_STATE_OBJECT_DATABASE_FLAGS")]
    public enum StateObjectDatabaseFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_STATE_OBJECT_DATABASE_FLAG_NONE")]
        StateObjectDatabaseFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"ReadOnly\"")]
        [NativeName("Name", "D3D12_STATE_OBJECT_DATABASE_FLAG_READ_ONLY")]
        StateObjectDatabaseFlagReadOnly = 0x1,
        [NativeName("Name", "D3D12_STATE_OBJECT_DATABASE_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_STATE_OBJECT_DATABASE_FLAG_READ_ONLY")]
        ReadOnly = 0x1,
    }
}
