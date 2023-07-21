// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CSFV.xml' path='doc/member[@name="CSFV"]/*' />
public unsafe partial struct CSFV
{
    /// <include file='CSFV.xml' path='doc/member[@name="CSFV.cbSize"]/*' />
    public uint cbSize;

    /// <include file='CSFV.xml' path='doc/member[@name="CSFV.pshf"]/*' />
    public IShellFolder* pshf;

    /// <include file='CSFV.xml' path='doc/member[@name="CSFV.psvOuter"]/*' />
    public IShellView* psvOuter;

    /// <include file='CSFV.xml' path='doc/member[@name="CSFV.pidl"]/*' />
    [NativeTypeName("LPCITEMIDLIST")]
    public ITEMIDLIST* pidl;

    /// <include file='CSFV.xml' path='doc/member[@name="CSFV.lEvents"]/*' />
    [NativeTypeName("LONG")]
    public int lEvents;

    /// <include file='CSFV.xml' path='doc/member[@name="CSFV.pfnCallback"]/*' />
    [NativeTypeName("LPFNVIEWCALLBACK")]
    public delegate* unmanaged<IShellView*, IShellFolder*, HWND, uint, WPARAM, LPARAM, HRESULT> pfnCallback;

    /// <include file='CSFV.xml' path='doc/member[@name="CSFV.fvm"]/*' />
    public FOLDERVIEWMODE fvm;
}
