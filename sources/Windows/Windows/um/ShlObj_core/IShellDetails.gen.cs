// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IShellDetails.xml' path='doc/member[@name="IShellDetails"]/*' />
[Guid("000214EC-0000-0000-C000-000000000046")]
[NativeTypeName("struct IShellDetails : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellDetails : IShellDetails.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellDetails));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellDetails*, Guid*, void**, int>)(lpVtbl[0]))((IShellDetails*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellDetails*, uint>)(lpVtbl[1]))((IShellDetails*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellDetails*, uint>)(lpVtbl[2]))((IShellDetails*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellDetails.xml' path='doc/member[@name="IShellDetails.GetDetailsOf"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDetailsOf([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint iColumn, SHELLDETAILS* pDetails)
    {
        return ((delegate* unmanaged<IShellDetails*, ITEMIDLIST*, uint, SHELLDETAILS*, int>)(lpVtbl[3]))((IShellDetails*)Unsafe.AsPointer(ref this), pidl, iColumn, pDetails);
    }

    /// <include file='IShellDetails.xml' path='doc/member[@name="IShellDetails.ColumnClick"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ColumnClick(uint iColumn)
    {
        return ((delegate* unmanaged<IShellDetails*, uint, int>)(lpVtbl[4]))((IShellDetails*)Unsafe.AsPointer(ref this), iColumn);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDetailsOf([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, uint iColumn, SHELLDETAILS* pDetails);

        [VtblIndex(4)]
        HRESULT ColumnClick(uint iColumn);
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

        [NativeTypeName("HRESULT (LPCITEMIDLIST, UINT, SHELLDETAILS *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, uint, SHELLDETAILS*, int> GetDetailsOf;

        [NativeTypeName("HRESULT (UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> ColumnClick;
    }
}
