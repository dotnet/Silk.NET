// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NAMED_PROFILE_INFO.xml' path='doc/member[@name="NAMED_PROFILE_INFO"]/*' />
public unsafe partial struct NAMED_PROFILE_INFO
{
    /// <include file='NAMED_PROFILE_INFO.xml' path='doc/member[@name="NAMED_PROFILE_INFO.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='NAMED_PROFILE_INFO.xml' path='doc/member[@name="NAMED_PROFILE_INFO.dwCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCount;

    /// <include file='NAMED_PROFILE_INFO.xml' path='doc/member[@name="NAMED_PROFILE_INFO.dwCountDevCoordinates"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCountDevCoordinates;

    /// <include file='NAMED_PROFILE_INFO.xml' path='doc/member[@name="NAMED_PROFILE_INFO.szPrefix"]/*' />
    [NativeTypeName("COLOR_NAME")]
    public fixed sbyte szPrefix[32];

    /// <include file='NAMED_PROFILE_INFO.xml' path='doc/member[@name="NAMED_PROFILE_INFO.szSuffix"]/*' />
    [NativeTypeName("COLOR_NAME")]
    public fixed sbyte szSuffix[32];
}
