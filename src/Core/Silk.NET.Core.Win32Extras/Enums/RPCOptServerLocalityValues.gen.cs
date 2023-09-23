// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagRPCOPT_SERVER_LOCALITY_VALUES")]
    public enum RPCOptServerLocalityValues : int
    {
        [Obsolete("Deprecated in favour of \"ProcessLocal\"")]
        [NativeName("Name", "SERVER_LOCALITY_PROCESS_LOCAL")]
        ServerLocalityProcessLocal = 0x0,
        [Obsolete("Deprecated in favour of \"MachineLocal\"")]
        [NativeName("Name", "SERVER_LOCALITY_MACHINE_LOCAL")]
        ServerLocalityMachineLocal = 0x1,
        [Obsolete("Deprecated in favour of \"Remote\"")]
        [NativeName("Name", "SERVER_LOCALITY_REMOTE")]
        ServerLocalityRemote = 0x2,
        [NativeName("Name", "SERVER_LOCALITY_PROCESS_LOCAL")]
        ProcessLocal = 0x0,
        [NativeName("Name", "SERVER_LOCALITY_MACHINE_LOCAL")]
        MachineLocal = 0x1,
        [NativeName("Name", "SERVER_LOCALITY_REMOTE")]
        Remote = 0x2,
    }
}
