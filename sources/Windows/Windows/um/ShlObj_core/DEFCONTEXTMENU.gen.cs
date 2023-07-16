// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DEFCONTEXTMENU.xml' path='doc/member[@name="DEFCONTEXTMENU"]/*'/>
public unsafe partial struct DEFCONTEXTMENU
{
    /// <include file='DEFCONTEXTMENU.xml' path='doc/member[@name="DEFCONTEXTMENU.hwnd"]/*'/>
    public HWND hwnd;
    /// <include file='DEFCONTEXTMENU.xml' path='doc/member[@name="DEFCONTEXTMENU.pcmcb"]/*'/>
    public IContextMenuCB* pcmcb;
    /// <include file='DEFCONTEXTMENU.xml' path='doc/member[@name="DEFCONTEXTMENU.pidlFolder"]/*'/>
    [NativeTypeName("LPCITEMIDLIST")]
    public ITEMIDLIST* pidlFolder;
    /// <include file='DEFCONTEXTMENU.xml' path='doc/member[@name="DEFCONTEXTMENU.psf"]/*'/>
    public IShellFolder* psf;
    /// <include file='DEFCONTEXTMENU.xml' path='doc/member[@name="DEFCONTEXTMENU.cidl"]/*'/>
    public uint cidl;
    /// <include file='DEFCONTEXTMENU.xml' path='doc/member[@name="DEFCONTEXTMENU.apidl"]/*'/>
    [NativeTypeName("LPCITEMIDLIST *")]
    public ITEMIDLIST** apidl;
    /// <include file='DEFCONTEXTMENU.xml' path='doc/member[@name="DEFCONTEXTMENU.punkAssociationInfo"]/*'/>
    public IUnknown* punkAssociationInfo;
    /// <include file='DEFCONTEXTMENU.xml' path='doc/member[@name="DEFCONTEXTMENU.cKeys"]/*'/>
    public uint cKeys;
    /// <include file='DEFCONTEXTMENU.xml' path='doc/member[@name="DEFCONTEXTMENU.aKeys"]/*'/>
    [NativeTypeName("const HKEY *")]
    public HKEY* aKeys;
}