// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "_FILE_INFO_BY_HANDLE_CLASS")]
    public enum FileInfoByHandleClass : int
    {
        [NativeName("Name", "FileBasicInfo")]
        FileBasicInfo = 0x0,
        [NativeName("Name", "FileStandardInfo")]
        FileStandardInfo = 0x1,
        [NativeName("Name", "FileNameInfo")]
        FileNameInfo = 0x2,
        [NativeName("Name", "FileRenameInfo")]
        FileRenameInfo = 0x3,
        [NativeName("Name", "FileDispositionInfo")]
        FileDispositionInfo = 0x4,
        [NativeName("Name", "FileAllocationInfo")]
        FileAllocationInfo = 0x5,
        [NativeName("Name", "FileEndOfFileInfo")]
        FileEndOfFileInfo = 0x6,
        [NativeName("Name", "FileStreamInfo")]
        FileStreamInfo = 0x7,
        [NativeName("Name", "FileCompressionInfo")]
        FileCompressionInfo = 0x8,
        [NativeName("Name", "FileAttributeTagInfo")]
        FileAttributeTagInfo = 0x9,
        [NativeName("Name", "FileIdBothDirectoryInfo")]
        FileIdBothDirectoryInfo = 0xA,
        [NativeName("Name", "FileIdBothDirectoryRestartInfo")]
        FileIdBothDirectoryRestartInfo = 0xB,
        [NativeName("Name", "FileIoPriorityHintInfo")]
        FileIoPriorityHintInfo = 0xC,
        [NativeName("Name", "FileRemoteProtocolInfo")]
        FileRemoteProtocolInfo = 0xD,
        [NativeName("Name", "FileFullDirectoryInfo")]
        FileFullDirectoryInfo = 0xE,
        [NativeName("Name", "FileFullDirectoryRestartInfo")]
        FileFullDirectoryRestartInfo = 0xF,
        [NativeName("Name", "FileStorageInfo")]
        FileStorageInfo = 0x10,
        [NativeName("Name", "FileAlignmentInfo")]
        FileAlignmentInfo = 0x11,
        [NativeName("Name", "FileIdInfo")]
        FileIdInfo = 0x12,
        [NativeName("Name", "FileIdExtdDirectoryInfo")]
        FileIdExtdDirectoryInfo = 0x13,
        [NativeName("Name", "FileIdExtdDirectoryRestartInfo")]
        FileIdExtdDirectoryRestartInfo = 0x14,
        [NativeName("Name", "FileDispositionInfoEx")]
        FileDispositionInfoEx = 0x15,
        [NativeName("Name", "FileRenameInfoEx")]
        FileRenameInfoEx = 0x16,
        [NativeName("Name", "FileCaseSensitiveInfo")]
        FileCaseSensitiveInfo = 0x17,
        [NativeName("Name", "FileNormalizedNameInfo")]
        FileNormalizedNameInfo = 0x18,
        [NativeName("Name", "MaximumFileInfoByHandleClass")]
        MaximumFileInfoByHandleClass = 0x19,
    }
}
