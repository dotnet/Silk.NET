// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "_ETW_PROCESS_HANDLE_INFO_TYPE")]
    public enum EtwProcessHandleInfoType : int
    {
        [NativeName("Name", "EtwQueryPartitionInformation")]
        EtwQueryPartitionInformation = 0x1,
        [NativeName("Name", "EtwQueryPartitionInformationV2")]
        EtwQueryPartitionInformationV2 = 0x2,
        [NativeName("Name", "EtwQueryLastDroppedTimes")]
        EtwQueryLastDroppedTimes = 0x3,
        [NativeName("Name", "EtwQueryProcessHandleInfoMax")]
        EtwQueryProcessHandleInfoMax = 0x4,
    }
}
