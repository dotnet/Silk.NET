// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='GUIDELINE.xml' path='doc/member[@name="GUIDELINE"]/*' />
public partial struct GUIDELINE
{
    /// <include file='GUIDELINE.xml' path='doc/member[@name="GUIDELINE.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='GUIDELINE.xml' path='doc/member[@name="GUIDELINE.dwLevel"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLevel;

    /// <include file='GUIDELINE.xml' path='doc/member[@name="GUIDELINE.dwIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwIndex;

    /// <include file='GUIDELINE.xml' path='doc/member[@name="GUIDELINE.dwStrLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStrLen;

    /// <include file='GUIDELINE.xml' path='doc/member[@name="GUIDELINE.dwStrOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStrOffset;

    /// <include file='GUIDELINE.xml' path='doc/member[@name="GUIDELINE.dwPrivateSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPrivateSize;

    /// <include file='GUIDELINE.xml' path='doc/member[@name="GUIDELINE.dwPrivateOffset"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPrivateOffset;
}
