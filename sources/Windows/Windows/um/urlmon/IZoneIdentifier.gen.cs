// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IZoneIdentifier.xml' path='doc/member[@name="IZoneIdentifier"]/*'/>
[Guid("CD45F185-1B21-48E2-967B-EAD743A8914E")]
[NativeTypeName("struct IZoneIdentifier : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IZoneIdentifier : IZoneIdentifier.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IZoneIdentifier));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IZoneIdentifier*, Guid*, void**, int> )(lpVtbl[0]))((IZoneIdentifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IZoneIdentifier*, uint> )(lpVtbl[1]))((IZoneIdentifier*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IZoneIdentifier*, uint> )(lpVtbl[2]))((IZoneIdentifier*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IZoneIdentifier.xml' path='doc/member[@name="IZoneIdentifier.GetId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetId([NativeTypeName("DWORD *")] uint* pdwZone)
    {
        return ((delegate* unmanaged<IZoneIdentifier*, uint*, int> )(lpVtbl[3]))((IZoneIdentifier*)Unsafe.AsPointer(ref this), pdwZone);
    }

    /// <include file='IZoneIdentifier.xml' path='doc/member[@name="IZoneIdentifier.SetId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetId([NativeTypeName("DWORD")] uint dwZone)
    {
        return ((delegate* unmanaged<IZoneIdentifier*, uint, int> )(lpVtbl[4]))((IZoneIdentifier*)Unsafe.AsPointer(ref this), dwZone);
    }

    /// <include file='IZoneIdentifier.xml' path='doc/member[@name="IZoneIdentifier.Remove"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Remove()
    {
        return ((delegate* unmanaged<IZoneIdentifier*, int> )(lpVtbl[5]))((IZoneIdentifier*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetId([NativeTypeName("DWORD *")] uint* pdwZone);
        [VtblIndex(4)]
        HRESULT SetId([NativeTypeName("DWORD")] uint dwZone);
        [VtblIndex(5)]
        HRESULT Remove();
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
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetId;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetId;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Remove;
    }
}