// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FILTERKEYS.xml' path='doc/member[@name="FILTERKEYS"]/*' />
public partial struct FILTERKEYS
{
    /// <include file='FILTERKEYS.xml' path='doc/member[@name="FILTERKEYS.cbSize"]/*' />
    public uint cbSize;

    /// <include file='FILTERKEYS.xml' path='doc/member[@name="FILTERKEYS.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='FILTERKEYS.xml' path='doc/member[@name="FILTERKEYS.iWaitMSec"]/*' />
    [NativeTypeName("DWORD")]
    public uint iWaitMSec;

    /// <include file='FILTERKEYS.xml' path='doc/member[@name="FILTERKEYS.iDelayMSec"]/*' />
    [NativeTypeName("DWORD")]
    public uint iDelayMSec;

    /// <include file='FILTERKEYS.xml' path='doc/member[@name="FILTERKEYS.iRepeatMSec"]/*' />
    [NativeTypeName("DWORD")]
    public uint iRepeatMSec;

    /// <include file='FILTERKEYS.xml' path='doc/member[@name="FILTERKEYS.iBounceMSec"]/*' />
    [NativeTypeName("DWORD")]
    public uint iBounceMSec;
}
