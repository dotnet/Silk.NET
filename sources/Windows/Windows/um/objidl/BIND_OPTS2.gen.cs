// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BIND_OPTS2.xml' path='doc/member[@name="BIND_OPTS2"]/*' />
[NativeTypeName("struct tagBIND_OPTS2 : tagBIND_OPTS")]
[NativeInheritance("tagBIND_OPTS")]
public unsafe partial struct BIND_OPTS2
{
    public BIND_OPTS Base;

    /// <include file='BIND_OPTS2.xml' path='doc/member[@name="BIND_OPTS2.dwTrackFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTrackFlags;

    /// <include file='BIND_OPTS2.xml' path='doc/member[@name="BIND_OPTS2.dwClassContext"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwClassContext;

    /// <include file='BIND_OPTS2.xml' path='doc/member[@name="BIND_OPTS2.locale"]/*' />
    [NativeTypeName("LCID")]
    public uint locale;

    /// <include file='BIND_OPTS2.xml' path='doc/member[@name="BIND_OPTS2.pServerInfo"]/*' />
    public COSERVERINFO* pServerInfo;
}
