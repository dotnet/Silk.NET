// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IShellIcon.xml' path='doc/member[@name="IShellIcon"]/*'/>
[Guid("000214E5-0000-0000-C000-000000000046")]
[NativeTypeName("struct IShellIcon : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellIcon : IShellIcon.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellIcon));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellIcon*, Guid*, void**, int> )(lpVtbl[0]))((IShellIcon*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellIcon*, uint> )(lpVtbl[1]))((IShellIcon*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellIcon*, uint> )(lpVtbl[2]))((IShellIcon*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellIcon.xml' path='doc/member[@name="IShellIcon.GetIconOf"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIconOf([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint flags, int* pIconIndex)
    {
        return ((delegate* unmanaged<IShellIcon*, ITEMIDLIST*, uint, int*, int> )(lpVtbl[3]))((IShellIcon*)Unsafe.AsPointer(ref this), pidl, flags, pIconIndex);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetIconOf([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint flags, int* pIconIndex);
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
        [NativeTypeName("HRESULT (LPCITEMIDLIST, UINT, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, uint, int*, int> GetIconOf;
    }
}