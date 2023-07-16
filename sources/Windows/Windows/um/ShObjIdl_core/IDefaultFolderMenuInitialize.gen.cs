// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IDefaultFolderMenuInitialize.xml' path='doc/member[@name="IDefaultFolderMenuInitialize"]/*'/>
[Guid("7690AA79-F8FC-4615-A327-36F7D18F5D91")]
[NativeTypeName("struct IDefaultFolderMenuInitialize : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDefaultFolderMenuInitialize : IDefaultFolderMenuInitialize.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDefaultFolderMenuInitialize));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDefaultFolderMenuInitialize*, Guid*, void**, int> )(lpVtbl[0]))((IDefaultFolderMenuInitialize*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDefaultFolderMenuInitialize*, uint> )(lpVtbl[1]))((IDefaultFolderMenuInitialize*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDefaultFolderMenuInitialize*, uint> )(lpVtbl[2]))((IDefaultFolderMenuInitialize*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDefaultFolderMenuInitialize.xml' path='doc/member[@name="IDefaultFolderMenuInitialize.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(HWND hwnd, IContextMenuCB* pcmcb, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, IShellFolder* psf, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, IUnknown* punkAssociation, uint cKeys, [NativeTypeName("const HKEY *")] HKEY* aKeys)
    {
        return ((delegate* unmanaged<IDefaultFolderMenuInitialize*, HWND, IContextMenuCB*, ITEMIDLIST*, IShellFolder*, uint, ITEMIDLIST**, IUnknown*, uint, HKEY*, int> )(lpVtbl[3]))((IDefaultFolderMenuInitialize*)Unsafe.AsPointer(ref this), hwnd, pcmcb, pidlFolder, psf, cidl, apidl, punkAssociation, cKeys, aKeys);
    }

    /// <include file='IDefaultFolderMenuInitialize.xml' path='doc/member[@name="IDefaultFolderMenuInitialize.SetMenuRestrictions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetMenuRestrictions(DEFAULT_FOLDER_MENU_RESTRICTIONS dfmrValues)
    {
        return ((delegate* unmanaged<IDefaultFolderMenuInitialize*, DEFAULT_FOLDER_MENU_RESTRICTIONS, int> )(lpVtbl[4]))((IDefaultFolderMenuInitialize*)Unsafe.AsPointer(ref this), dfmrValues);
    }

    /// <include file='IDefaultFolderMenuInitialize.xml' path='doc/member[@name="IDefaultFolderMenuInitialize.GetMenuRestrictions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMenuRestrictions(DEFAULT_FOLDER_MENU_RESTRICTIONS dfmrMask, DEFAULT_FOLDER_MENU_RESTRICTIONS* pdfmrValues)
    {
        return ((delegate* unmanaged<IDefaultFolderMenuInitialize*, DEFAULT_FOLDER_MENU_RESTRICTIONS, DEFAULT_FOLDER_MENU_RESTRICTIONS*, int> )(lpVtbl[5]))((IDefaultFolderMenuInitialize*)Unsafe.AsPointer(ref this), dfmrMask, pdfmrValues);
    }

    /// <include file='IDefaultFolderMenuInitialize.xml' path='doc/member[@name="IDefaultFolderMenuInitialize.SetHandlerClsid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetHandlerClsid([NativeTypeName("const IID &")] Guid* rclsid)
    {
        return ((delegate* unmanaged<IDefaultFolderMenuInitialize*, Guid*, int> )(lpVtbl[6]))((IDefaultFolderMenuInitialize*)Unsafe.AsPointer(ref this), rclsid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(HWND hwnd, IContextMenuCB* pcmcb, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, IShellFolder* psf, uint cidl, [NativeTypeName("LPCITEMIDLIST *")] ITEMIDLIST** apidl, IUnknown* punkAssociation, uint cKeys, [NativeTypeName("const HKEY *")] HKEY* aKeys);
        [VtblIndex(4)]
        HRESULT SetMenuRestrictions(DEFAULT_FOLDER_MENU_RESTRICTIONS dfmrValues);
        [VtblIndex(5)]
        HRESULT GetMenuRestrictions(DEFAULT_FOLDER_MENU_RESTRICTIONS dfmrMask, DEFAULT_FOLDER_MENU_RESTRICTIONS* pdfmrValues);
        [VtblIndex(6)]
        HRESULT SetHandlerClsid([NativeTypeName("const IID &")] Guid* rclsid);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;
        [NativeTypeName("HRESULT (HWND, IContextMenuCB *, LPCITEMIDLIST, IShellFolder *, UINT, LPCITEMIDLIST *, IUnknown *, UINT, const HKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, IContextMenuCB*, ITEMIDLIST*, IShellFolder*, uint, ITEMIDLIST**, IUnknown*, uint, HKEY*, int> Initialize;
        [NativeTypeName("HRESULT (DEFAULT_FOLDER_MENU_RESTRICTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DEFAULT_FOLDER_MENU_RESTRICTIONS, int> SetMenuRestrictions;
        [NativeTypeName("HRESULT (DEFAULT_FOLDER_MENU_RESTRICTIONS, DEFAULT_FOLDER_MENU_RESTRICTIONS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DEFAULT_FOLDER_MENU_RESTRICTIONS, DEFAULT_FOLDER_MENU_RESTRICTIONS*, int> GetMenuRestrictions;
        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetHandlerClsid;
    }
}