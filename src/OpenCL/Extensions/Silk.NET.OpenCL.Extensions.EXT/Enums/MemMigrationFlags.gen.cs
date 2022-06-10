// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.EXT
{
    [System.Flags]
    [NativeName("Name", "cl_mem_migration_flags_ext")]
    public enum MemMigrationFlags : ulong
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "CL_MIGRATE_MEM_OBJECT_HOST_EXT")]
        MigrateMemObjectHost = 0x1,
    }
}
