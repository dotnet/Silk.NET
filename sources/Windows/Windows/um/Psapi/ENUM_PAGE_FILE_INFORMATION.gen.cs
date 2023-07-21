// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ENUM_PAGE_FILE_INFORMATION.xml' path='doc/member[@name="ENUM_PAGE_FILE_INFORMATION"]/*' />
public partial struct ENUM_PAGE_FILE_INFORMATION
{
    /// <include file='ENUM_PAGE_FILE_INFORMATION.xml' path='doc/member[@name="ENUM_PAGE_FILE_INFORMATION.cb"]/*' />
    [NativeTypeName("DWORD")]
    public uint cb;

    /// <include file='ENUM_PAGE_FILE_INFORMATION.xml' path='doc/member[@name="ENUM_PAGE_FILE_INFORMATION.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='ENUM_PAGE_FILE_INFORMATION.xml' path='doc/member[@name="ENUM_PAGE_FILE_INFORMATION.TotalSize"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint TotalSize;

    /// <include file='ENUM_PAGE_FILE_INFORMATION.xml' path='doc/member[@name="ENUM_PAGE_FILE_INFORMATION.TotalInUse"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint TotalInUse;

    /// <include file='ENUM_PAGE_FILE_INFORMATION.xml' path='doc/member[@name="ENUM_PAGE_FILE_INFORMATION.PeakUsage"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint PeakUsage;
}
