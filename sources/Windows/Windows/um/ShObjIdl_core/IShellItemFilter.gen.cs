// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IShellItemFilter.xml' path='doc/member[@name="IShellItemFilter"]/*'/>
[Guid("2659B475-EEB8-48B7-8F07-B378810F48CF")]
[NativeTypeName("struct IShellItemFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellItemFilter : IShellItemFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellItemFilter));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellItemFilter*, Guid*, void**, int> )(lpVtbl[0]))((IShellItemFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellItemFilter*, uint> )(lpVtbl[1]))((IShellItemFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellItemFilter*, uint> )(lpVtbl[2]))((IShellItemFilter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellItemFilter.xml' path='doc/member[@name="IShellItemFilter.IncludeItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IncludeItem(IShellItem* psi)
    {
        return ((delegate* unmanaged<IShellItemFilter*, IShellItem*, int> )(lpVtbl[3]))((IShellItemFilter*)Unsafe.AsPointer(ref this), psi);
    }

    /// <include file='IShellItemFilter.xml' path='doc/member[@name="IShellItemFilter.GetEnumFlagsForItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEnumFlagsForItem(IShellItem* psi, [NativeTypeName("SHCONTF *")] uint* pgrfFlags)
    {
        return ((delegate* unmanaged<IShellItemFilter*, IShellItem*, uint*, int> )(lpVtbl[4]))((IShellItemFilter*)Unsafe.AsPointer(ref this), psi, pgrfFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IncludeItem(IShellItem* psi);
        [VtblIndex(4)]
        HRESULT GetEnumFlagsForItem(IShellItem* psi, [NativeTypeName("SHCONTF *")] uint* pgrfFlags);
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
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> IncludeItem;
        [NativeTypeName("HRESULT (IShellItem *, SHCONTF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, uint*, int> GetEnumFlagsForItem;
    }
}