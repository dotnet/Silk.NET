// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_mem_migration_flags")]
    public enum MemMigrationFlags : ulong
    {
        [NativeName("Name", "CL_MIGRATE_MEM_OBJECT_HOST")]
        MigrateMemObjectHost = 0x1,
        [NativeName("Name", "CL_MIGRATE_MEM_OBJECT_HOST_EXT")]
        MigrateMemObjectHostExt = 0x1,
        [NativeName("Name", "CL_MIGRATE_MEM_OBJECT_CONTENT_UNDEFINED")]
        MigrateMemObjectContentUndefined = 0x2,
    }
}
