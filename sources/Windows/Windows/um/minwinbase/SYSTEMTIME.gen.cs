// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYSTEMTIME.xml' path='doc/member[@name="SYSTEMTIME"]/*' />
public partial struct SYSTEMTIME
{
    /// <include file='SYSTEMTIME.xml' path='doc/member[@name="SYSTEMTIME.wYear"]/*' />
    [NativeTypeName("WORD")]
    public ushort wYear;

    /// <include file='SYSTEMTIME.xml' path='doc/member[@name="SYSTEMTIME.wMonth"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMonth;

    /// <include file='SYSTEMTIME.xml' path='doc/member[@name="SYSTEMTIME.wDayOfWeek"]/*' />
    [NativeTypeName("WORD")]
    public ushort wDayOfWeek;

    /// <include file='SYSTEMTIME.xml' path='doc/member[@name="SYSTEMTIME.wDay"]/*' />
    [NativeTypeName("WORD")]
    public ushort wDay;

    /// <include file='SYSTEMTIME.xml' path='doc/member[@name="SYSTEMTIME.wHour"]/*' />
    [NativeTypeName("WORD")]
    public ushort wHour;

    /// <include file='SYSTEMTIME.xml' path='doc/member[@name="SYSTEMTIME.wMinute"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMinute;

    /// <include file='SYSTEMTIME.xml' path='doc/member[@name="SYSTEMTIME.wSecond"]/*' />
    [NativeTypeName("WORD")]
    public ushort wSecond;

    /// <include file='SYSTEMTIME.xml' path='doc/member[@name="SYSTEMTIME.wMilliseconds"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMilliseconds;
}
