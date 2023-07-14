// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_ETW_PROCESS_HANDLE_INFO_TYPE")]
    public enum EtwProcessHandleInfoType : int
    {
        [Obsolete("Deprecated in favour of \"PartitionInformation\"")]
        [NativeName("Name", "EtwQueryPartitionInformation")]
        EtwQueryPartitionInformation = 0x1,
        [Obsolete("Deprecated in favour of \"PartitionInformationV2\"")]
        [NativeName("Name", "EtwQueryPartitionInformationV2")]
        EtwQueryPartitionInformationV2 = 0x2,
        [Obsolete("Deprecated in favour of \"LastDroppedTimes\"")]
        [NativeName("Name", "EtwQueryLastDroppedTimes")]
        EtwQueryLastDroppedTimes = 0x3,
        [Obsolete("Deprecated in favour of \"LogFileHeader\"")]
        [NativeName("Name", "EtwQueryLogFileHeader")]
        EtwQueryLogFileHeader = 0x4,
        [Obsolete("Deprecated in favour of \"ProcessHandleInfoMax\"")]
        [NativeName("Name", "EtwQueryProcessHandleInfoMax")]
        EtwQueryProcessHandleInfoMax = 0x5,
        [NativeName("Name", "EtwQueryPartitionInformation")]
        PartitionInformation = 0x1,
        [NativeName("Name", "EtwQueryPartitionInformationV2")]
        PartitionInformationV2 = 0x2,
        [NativeName("Name", "EtwQueryLastDroppedTimes")]
        LastDroppedTimes = 0x3,
        [NativeName("Name", "EtwQueryLogFileHeader")]
        LogFileHeader = 0x4,
        [NativeName("Name", "EtwQueryProcessHandleInfoMax")]
        ProcessHandleInfoMax = 0x5,
    }
}
