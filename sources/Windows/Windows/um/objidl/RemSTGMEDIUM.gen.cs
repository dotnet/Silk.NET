// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='RemSTGMEDIUM.xml' path='doc/member[@name="RemSTGMEDIUM"]/*' />
public unsafe partial struct RemSTGMEDIUM
{
    /// <include file='RemSTGMEDIUM.xml' path='doc/member[@name="RemSTGMEDIUM.tymed"]/*' />
    [NativeTypeName("DWORD")]
    public uint tymed;

    /// <include file='RemSTGMEDIUM.xml' path='doc/member[@name="RemSTGMEDIUM.dwHandleType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHandleType;

    /// <include file='RemSTGMEDIUM.xml' path='doc/member[@name="RemSTGMEDIUM.pData"]/*' />
    [NativeTypeName("ULONG")]
    public uint pData;

    /// <include file='RemSTGMEDIUM.xml' path='doc/member[@name="RemSTGMEDIUM.pUnkForRelease"]/*' />
    [NativeTypeName("ULONG")]
    public uint pUnkForRelease;

    /// <include file='RemSTGMEDIUM.xml' path='doc/member[@name="RemSTGMEDIUM.cbData"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbData;

    /// <include file='RemSTGMEDIUM.xml' path='doc/member[@name="RemSTGMEDIUM.data"]/*' />
    [NativeTypeName("byte[1]")]
    public fixed byte data[1];
}
