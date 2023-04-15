// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_READ_DIRECTORY_NOTIFY_INFORMATION_CLASS")]
    public enum ReadDirectoryNotifyInformationClass : int
    {
        [Obsolete("Deprecated in favour of \"Information\"")]
        [NativeName("Name", "ReadDirectoryNotifyInformation")]
        ReadDirectoryNotifyInformation = 0x1,
        [Obsolete("Deprecated in favour of \"ExtendedInformation\"")]
        [NativeName("Name", "ReadDirectoryNotifyExtendedInformation")]
        ReadDirectoryNotifyExtendedInformation = 0x2,
        [Obsolete("Deprecated in favour of \"FullInformation\"")]
        [NativeName("Name", "ReadDirectoryNotifyFullInformation")]
        ReadDirectoryNotifyFullInformation = 0x3,
        [Obsolete("Deprecated in favour of \"MaximumInformation\"")]
        [NativeName("Name", "ReadDirectoryNotifyMaximumInformation")]
        ReadDirectoryNotifyMaximumInformation = 0x4,
        [NativeName("Name", "ReadDirectoryNotifyInformation")]
        Information = 0x1,
        [NativeName("Name", "ReadDirectoryNotifyExtendedInformation")]
        ExtendedInformation = 0x2,
        [NativeName("Name", "ReadDirectoryNotifyFullInformation")]
        FullInformation = 0x3,
        [NativeName("Name", "ReadDirectoryNotifyMaximumInformation")]
        MaximumInformation = 0x4,
    }
}
