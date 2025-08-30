// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_FILE_INFO_BY_NAME_CLASS")]
    public enum FileInfoByNameClass : int
    {
        [NativeName("Name", "FileStatByNameInfo")]
        FileStatByNameInfo = 0x0,
        [NativeName("Name", "FileStatLxByNameInfo")]
        FileStatLxByNameInfo = 0x1,
        [NativeName("Name", "FileCaseSensitiveByNameInfo")]
        FileCaseSensitiveByNameInfo = 0x2,
        [NativeName("Name", "FileStatBasicByNameInfo")]
        FileStatBasicByNameInfo = 0x3,
        [NativeName("Name", "MaximumFileInfoByNameClass")]
        MaximumFileInfoByNameClass = 0x4,
    }
}
