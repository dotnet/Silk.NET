// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IZoneIdentifier2.xml' path='doc/member[@name="IZoneIdentifier2"]/*'/>
[Guid("EB5E760C-09EF-45C0-B510-70830CE31E6A")]
[NativeTypeName("struct IZoneIdentifier2 : IZoneIdentifier")]
[NativeInheritance("IZoneIdentifier")]
public unsafe partial struct IZoneIdentifier2 : IZoneIdentifier2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IZoneIdentifier2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IZoneIdentifier2*, Guid*, void**, int> )(lpVtbl[0]))((IZoneIdentifier2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IZoneIdentifier2*, uint> )(lpVtbl[1]))((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IZoneIdentifier2*, uint> )(lpVtbl[2]))((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IZoneIdentifier.GetId"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetId([NativeTypeName("DWORD *")] uint* pdwZone)
    {
        return ((delegate* unmanaged<IZoneIdentifier2*, uint*, int> )(lpVtbl[3]))((IZoneIdentifier2*)Unsafe.AsPointer(ref this), pdwZone);
    }

    /// <inheritdoc cref = "IZoneIdentifier.SetId"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetId([NativeTypeName("DWORD")] uint dwZone)
    {
        return ((delegate* unmanaged<IZoneIdentifier2*, uint, int> )(lpVtbl[4]))((IZoneIdentifier2*)Unsafe.AsPointer(ref this), dwZone);
    }

    /// <inheritdoc cref = "IZoneIdentifier.Remove"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Remove()
    {
        return ((delegate* unmanaged<IZoneIdentifier2*, int> )(lpVtbl[5]))((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IZoneIdentifier2.xml' path='doc/member[@name="IZoneIdentifier2.GetLastWriterPackageFamilyName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetLastWriterPackageFamilyName([NativeTypeName("LPWSTR *")] ushort** packageFamilyName)
    {
        return ((delegate* unmanaged<IZoneIdentifier2*, ushort**, int> )(lpVtbl[6]))((IZoneIdentifier2*)Unsafe.AsPointer(ref this), packageFamilyName);
    }

    /// <include file='IZoneIdentifier2.xml' path='doc/member[@name="IZoneIdentifier2.SetLastWriterPackageFamilyName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetLastWriterPackageFamilyName([NativeTypeName("LPCWSTR")] ushort* packageFamilyName)
    {
        return ((delegate* unmanaged<IZoneIdentifier2*, ushort*, int> )(lpVtbl[7]))((IZoneIdentifier2*)Unsafe.AsPointer(ref this), packageFamilyName);
    }

    /// <include file='IZoneIdentifier2.xml' path='doc/member[@name="IZoneIdentifier2.RemoveLastWriterPackageFamilyName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveLastWriterPackageFamilyName()
    {
        return ((delegate* unmanaged<IZoneIdentifier2*, int> )(lpVtbl[8]))((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IZoneIdentifier2.xml' path='doc/member[@name="IZoneIdentifier2.GetAppZoneId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAppZoneId([NativeTypeName("DWORD *")] uint* zone)
    {
        return ((delegate* unmanaged<IZoneIdentifier2*, uint*, int> )(lpVtbl[9]))((IZoneIdentifier2*)Unsafe.AsPointer(ref this), zone);
    }

    /// <include file='IZoneIdentifier2.xml' path='doc/member[@name="IZoneIdentifier2.SetAppZoneId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetAppZoneId([NativeTypeName("DWORD")] uint zone)
    {
        return ((delegate* unmanaged<IZoneIdentifier2*, uint, int> )(lpVtbl[10]))((IZoneIdentifier2*)Unsafe.AsPointer(ref this), zone);
    }

    /// <include file='IZoneIdentifier2.xml' path='doc/member[@name="IZoneIdentifier2.RemoveAppZoneId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RemoveAppZoneId()
    {
        return ((delegate* unmanaged<IZoneIdentifier2*, int> )(lpVtbl[11]))((IZoneIdentifier2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IZoneIdentifier.Interface
    {
        [VtblIndex(6)]
        HRESULT GetLastWriterPackageFamilyName([NativeTypeName("LPWSTR *")] ushort** packageFamilyName);
        [VtblIndex(7)]
        HRESULT SetLastWriterPackageFamilyName([NativeTypeName("LPCWSTR")] ushort* packageFamilyName);
        [VtblIndex(8)]
        HRESULT RemoveLastWriterPackageFamilyName();
        [VtblIndex(9)]
        HRESULT GetAppZoneId([NativeTypeName("DWORD *")] uint* zone);
        [VtblIndex(10)]
        HRESULT SetAppZoneId([NativeTypeName("DWORD")] uint zone);
        [VtblIndex(11)]
        HRESULT RemoveAppZoneId();
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
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetLastWriterPackageFamilyName;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetLastWriterPackageFamilyName;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveLastWriterPackageFamilyName;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetAppZoneId;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetAppZoneId;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAppZoneId;
    }
}