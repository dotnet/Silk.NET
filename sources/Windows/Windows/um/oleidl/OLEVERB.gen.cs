// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OLEVERB.xml' path='doc/member[@name="OLEVERB"]/*' />
public unsafe partial struct OLEVERB
{
    /// <include file='OLEVERB.xml' path='doc/member[@name="OLEVERB.lVerb"]/*' />
    [NativeTypeName("LONG")]
    public int lVerb;

    /// <include file='OLEVERB.xml' path='doc/member[@name="OLEVERB.lpszVerbName"]/*' />
    [NativeTypeName("LPOLESTR")]
    public ushort* lpszVerbName;

    /// <include file='OLEVERB.xml' path='doc/member[@name="OLEVERB.fuFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint fuFlags;

    /// <include file='OLEVERB.xml' path='doc/member[@name="OLEVERB.grfAttribs"]/*' />
    [NativeTypeName("DWORD")]
    public uint grfAttribs;
}
