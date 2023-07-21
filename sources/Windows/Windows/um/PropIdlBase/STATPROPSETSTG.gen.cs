// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='STATPROPSETSTG.xml' path='doc/member[@name="STATPROPSETSTG"]/*' />
public partial struct STATPROPSETSTG
{
    /// <include file='STATPROPSETSTG.xml' path='doc/member[@name="STATPROPSETSTG.fmtid"]/*' />
    [NativeTypeName("FMTID")]
    public Guid fmtid;

    /// <include file='STATPROPSETSTG.xml' path='doc/member[@name="STATPROPSETSTG.clsid"]/*' />
    [NativeTypeName("CLSID")]
    public Guid clsid;

    /// <include file='STATPROPSETSTG.xml' path='doc/member[@name="STATPROPSETSTG.grfFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint grfFlags;

    /// <include file='STATPROPSETSTG.xml' path='doc/member[@name="STATPROPSETSTG.mtime"]/*' />
    public FILETIME mtime;

    /// <include file='STATPROPSETSTG.xml' path='doc/member[@name="STATPROPSETSTG.ctime"]/*' />
    public FILETIME ctime;

    /// <include file='STATPROPSETSTG.xml' path='doc/member[@name="STATPROPSETSTG.atime"]/*' />
    public FILETIME atime;

    /// <include file='STATPROPSETSTG.xml' path='doc/member[@name="STATPROPSETSTG.dwOSVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOSVersion;
}
