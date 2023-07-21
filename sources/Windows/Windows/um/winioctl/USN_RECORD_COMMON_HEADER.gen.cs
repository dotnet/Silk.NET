// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='USN_RECORD_COMMON_HEADER.xml' path='doc/member[@name="USN_RECORD_COMMON_HEADER"]/*' />
[SupportedOSPlatform("windows6.3")]
public partial struct USN_RECORD_COMMON_HEADER
{
    /// <include file='USN_RECORD_COMMON_HEADER.xml' path='doc/member[@name="USN_RECORD_COMMON_HEADER.RecordLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint RecordLength;

    /// <include file='USN_RECORD_COMMON_HEADER.xml' path='doc/member[@name="USN_RECORD_COMMON_HEADER.MajorVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MajorVersion;

    /// <include file='USN_RECORD_COMMON_HEADER.xml' path='doc/member[@name="USN_RECORD_COMMON_HEADER.MinorVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort MinorVersion;
}
