// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IApplicationDestinations.xml' path='doc/member[@name="IApplicationDestinations"]/*'/>
[Guid("12337D35-94C6-48A0-BCE7-6A9C69D4D600")]
[NativeTypeName("struct IApplicationDestinations : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IApplicationDestinations : IApplicationDestinations.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationDestinations));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApplicationDestinations*, Guid*, void**, int> )(lpVtbl[0]))((IApplicationDestinations*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IApplicationDestinations*, uint> )(lpVtbl[1]))((IApplicationDestinations*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationDestinations*, uint> )(lpVtbl[2]))((IApplicationDestinations*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IApplicationDestinations.xml' path='doc/member[@name="IApplicationDestinations.SetAppID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAppID([NativeTypeName("LPCWSTR")] ushort* pszAppID)
    {
        return ((delegate* unmanaged<IApplicationDestinations*, ushort*, int> )(lpVtbl[3]))((IApplicationDestinations*)Unsafe.AsPointer(ref this), pszAppID);
    }

    /// <include file='IApplicationDestinations.xml' path='doc/member[@name="IApplicationDestinations.RemoveDestination"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveDestination(IUnknown* punk)
    {
        return ((delegate* unmanaged<IApplicationDestinations*, IUnknown*, int> )(lpVtbl[4]))((IApplicationDestinations*)Unsafe.AsPointer(ref this), punk);
    }

    /// <include file='IApplicationDestinations.xml' path='doc/member[@name="IApplicationDestinations.RemoveAllDestinations"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemoveAllDestinations()
    {
        return ((delegate* unmanaged<IApplicationDestinations*, int> )(lpVtbl[5]))((IApplicationDestinations*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAppID([NativeTypeName("LPCWSTR")] ushort* pszAppID);
        [VtblIndex(4)]
        HRESULT RemoveDestination(IUnknown* punk);
        [VtblIndex(5)]
        HRESULT RemoveAllDestinations();
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
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetAppID;
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> RemoveDestination;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllDestinations;
    }
}