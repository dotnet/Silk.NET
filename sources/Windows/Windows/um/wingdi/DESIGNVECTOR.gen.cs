// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DESIGNVECTOR.xml' path='doc/member[@name="DESIGNVECTOR"]/*' />
public unsafe partial struct DESIGNVECTOR
{
    /// <include file='DESIGNVECTOR.xml' path='doc/member[@name="DESIGNVECTOR.dvReserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint dvReserved;

    /// <include file='DESIGNVECTOR.xml' path='doc/member[@name="DESIGNVECTOR.dvNumAxes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dvNumAxes;

    /// <include file='DESIGNVECTOR.xml' path='doc/member[@name="DESIGNVECTOR.dvValues"]/*' />
    [NativeTypeName("LONG[16]")]
    public fixed int dvValues[16];
}
