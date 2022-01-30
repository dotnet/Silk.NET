// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "_READ_DIRECTORY_NOTIFY_INFORMATION_CLASS")]
    public enum ReadDirectoryNotifyInformationClass : int
    {
        [NativeName("Name", "ReadDirectoryNotifyInformation")]
        ReadDirectoryNotifyInformation = 0x1,
        [NativeName("Name", "ReadDirectoryNotifyExtendedInformation")]
        ReadDirectoryNotifyExtendedInformation = 0x2,
    }
}
