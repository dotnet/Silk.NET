// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='PSS_AUXILIARY_PAGE_ENTRY.xml' path='doc/member[@name="PSS_AUXILIARY_PAGE_ENTRY"]/*' />
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct PSS_AUXILIARY_PAGE_ENTRY
{
    /// <include file='PSS_AUXILIARY_PAGE_ENTRY.xml' path='doc/member[@name="PSS_AUXILIARY_PAGE_ENTRY.Address"]/*' />
    public void* Address;

    /// <include file='PSS_AUXILIARY_PAGE_ENTRY.xml' path='doc/member[@name="PSS_AUXILIARY_PAGE_ENTRY.BasicInformation"]/*' />
    public MEMORY_BASIC_INFORMATION BasicInformation;

    /// <include file='PSS_AUXILIARY_PAGE_ENTRY.xml' path='doc/member[@name="PSS_AUXILIARY_PAGE_ENTRY.CaptureTime"]/*' />
    public FILETIME CaptureTime;

    /// <include file='PSS_AUXILIARY_PAGE_ENTRY.xml' path='doc/member[@name="PSS_AUXILIARY_PAGE_ENTRY.PageContents"]/*' />
    public void* PageContents;

    /// <include file='PSS_AUXILIARY_PAGE_ENTRY.xml' path='doc/member[@name="PSS_AUXILIARY_PAGE_ENTRY.PageSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint PageSize;
}
