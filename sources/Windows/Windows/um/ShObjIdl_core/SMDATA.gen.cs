// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SMDATA.xml' path='doc/member[@name="SMDATA"]/*'/>
public unsafe partial struct SMDATA
{
    /// <include file='SMDATA.xml' path='doc/member[@name="SMDATA.dwMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMask;
    /// <include file='SMDATA.xml' path='doc/member[@name="SMDATA.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='SMDATA.xml' path='doc/member[@name="SMDATA.hmenu"]/*'/>
    public HMENU hmenu;
    /// <include file='SMDATA.xml' path='doc/member[@name="SMDATA.hwnd"]/*'/>
    public HWND hwnd;
    /// <include file='SMDATA.xml' path='doc/member[@name="SMDATA.uId"]/*'/>
    public uint uId;
    /// <include file='SMDATA.xml' path='doc/member[@name="SMDATA.uIdParent"]/*'/>
    public uint uIdParent;
    /// <include file='SMDATA.xml' path='doc/member[@name="SMDATA.uIdAncestor"]/*'/>
    public uint uIdAncestor;
    /// <include file='SMDATA.xml' path='doc/member[@name="SMDATA.punk"]/*'/>
    public IUnknown* punk;
    /// <include file='SMDATA.xml' path='doc/member[@name="SMDATA.pidlFolder"]/*'/>
    [NativeTypeName("LPITEMIDLIST")]
    public ITEMIDLIST* pidlFolder;
    /// <include file='SMDATA.xml' path='doc/member[@name="SMDATA.pidlItem"]/*'/>
    [NativeTypeName("LPITEMIDLIST")]
    public ITEMIDLIST* pidlItem;
    /// <include file='SMDATA.xml' path='doc/member[@name="SMDATA.psf"]/*'/>
    public IShellFolder* psf;
    /// <include file='SMDATA.xml' path='doc/member[@name="SMDATA.pvUserData"]/*'/>
    public void* pvUserData;
}