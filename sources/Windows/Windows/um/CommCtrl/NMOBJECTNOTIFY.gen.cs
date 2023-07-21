// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='NMOBJECTNOTIFY.xml' path='doc/member[@name="NMOBJECTNOTIFY"]/*' />
public unsafe partial struct NMOBJECTNOTIFY
{
    /// <include file='NMOBJECTNOTIFY.xml' path='doc/member[@name="NMOBJECTNOTIFY.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMOBJECTNOTIFY.xml' path='doc/member[@name="NMOBJECTNOTIFY.iItem"]/*' />
    public int iItem;

    /// <include file='NMOBJECTNOTIFY.xml' path='doc/member[@name="NMOBJECTNOTIFY.piid"]/*' />
    [NativeTypeName("const IID *")]
    public Guid* piid;

    /// <include file='NMOBJECTNOTIFY.xml' path='doc/member[@name="NMOBJECTNOTIFY.pObject"]/*' />
    public void* pObject;

    /// <include file='NMOBJECTNOTIFY.xml' path='doc/member[@name="NMOBJECTNOTIFY.hResult"]/*' />
    public HRESULT hResult;

    /// <include file='NMOBJECTNOTIFY.xml' path='doc/member[@name="NMOBJECTNOTIFY.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}
