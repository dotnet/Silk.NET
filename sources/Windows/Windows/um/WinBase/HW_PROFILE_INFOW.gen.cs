// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HW_PROFILE_INFOW.xml' path='doc/member[@name="HW_PROFILE_INFOW"]/*' />
public unsafe partial struct HW_PROFILE_INFOW
{
    /// <include file='HW_PROFILE_INFOW.xml' path='doc/member[@name="HW_PROFILE_INFOW.dwDockInfo"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDockInfo;

    /// <include file='HW_PROFILE_INFOW.xml' path='doc/member[@name="HW_PROFILE_INFOW.szHwProfileGuid"]/*' />
    [NativeTypeName("WCHAR[39]")]
    public fixed ushort szHwProfileGuid[39];

    /// <include file='HW_PROFILE_INFOW.xml' path='doc/member[@name="HW_PROFILE_INFOW.szHwProfileName"]/*' />
    [NativeTypeName("WCHAR[80]")]
    public fixed ushort szHwProfileName[80];
}
