// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IFolderFilter.xml' path='doc/member[@name="IFolderFilter"]/*'/>
[Guid("9CC22886-DC8E-11D2-B1D0-00C04F8EEB3E")]
[NativeTypeName("struct IFolderFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFolderFilter : IFolderFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFolderFilter));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFolderFilter*, Guid*, void**, int> )(lpVtbl[0]))((IFolderFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFolderFilter*, uint> )(lpVtbl[1]))((IFolderFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFolderFilter*, uint> )(lpVtbl[2]))((IFolderFilter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFolderFilter.xml' path='doc/member[@name="IFolderFilter.ShouldShow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ShouldShow(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem)
    {
        return ((delegate* unmanaged<IFolderFilter*, IShellFolder*, ITEMIDLIST*, ITEMIDLIST*, int> )(lpVtbl[3]))((IFolderFilter*)Unsafe.AsPointer(ref this), psf, pidlFolder, pidlItem);
    }

    /// <include file='IFolderFilter.xml' path='doc/member[@name="IFolderFilter.GetEnumFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEnumFlags(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, HWND* phwnd, [NativeTypeName("DWORD *")] uint* pgrfFlags)
    {
        return ((delegate* unmanaged<IFolderFilter*, IShellFolder*, ITEMIDLIST*, HWND*, uint*, int> )(lpVtbl[4]))((IFolderFilter*)Unsafe.AsPointer(ref this), psf, pidlFolder, phwnd, pgrfFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ShouldShow(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlItem);
        [VtblIndex(4)]
        HRESULT GetEnumFlags(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlFolder, HWND* phwnd, [NativeTypeName("DWORD *")] uint* pgrfFlags);
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
        [NativeTypeName("HRESULT (IShellFolder *, LPCITEMIDLIST, LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellFolder*, ITEMIDLIST*, ITEMIDLIST*, int> ShouldShow;
        [NativeTypeName("HRESULT (IShellFolder *, LPCITEMIDLIST, HWND *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellFolder*, ITEMIDLIST*, HWND*, uint*, int> GetEnumFlags;
    }
}