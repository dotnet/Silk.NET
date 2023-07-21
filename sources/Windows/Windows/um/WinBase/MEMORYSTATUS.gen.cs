// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS"]/*' />
public partial struct MEMORYSTATUS
{
    /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLength;

    /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwMemoryLoad"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMemoryLoad;

    /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwTotalPhys"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint dwTotalPhys;

    /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwAvailPhys"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint dwAvailPhys;

    /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwTotalPageFile"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint dwTotalPageFile;

    /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwAvailPageFile"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint dwAvailPageFile;

    /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwTotalVirtual"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint dwTotalVirtual;

    /// <include file='MEMORYSTATUS.xml' path='doc/member[@name="MEMORYSTATUS.dwAvailVirtual"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint dwAvailVirtual;
}
