// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EB5E760C-09EF-45C0-B510-70830CE31E6A")]
[NativeTypeName("struct IZoneIdentifier2 : IZoneIdentifier")]
[NativeInheritance("IZoneIdentifier")]
public unsafe partial struct IZoneIdentifier2 : IZoneIdentifier2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IZoneIdentifier2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IZoneIdentifier2, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IZoneIdentifier2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IZoneIdentifier2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetId([NativeTypeName("DWORD *")] uint* pdwZone)
    {
        return ((delegate* unmanaged<IZoneIdentifier2, uint*, int>)((*lpVtbl)[3]))(this, pdwZone);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetId([NativeTypeName("DWORD")] uint dwZone)
    {
        return ((delegate* unmanaged<IZoneIdentifier2, uint, int>)((*lpVtbl)[4]))(this, dwZone);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Remove()
    {
        return ((delegate* unmanaged<IZoneIdentifier2, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetLastWriterPackageFamilyName(
        [NativeTypeName("LPWSTR *")] ushort** packageFamilyName
    )
    {
        return ((delegate* unmanaged<IZoneIdentifier2, ushort**, int>)((*lpVtbl)[6]))(
            this,
            packageFamilyName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetLastWriterPackageFamilyName(
        [NativeTypeName("LPCWSTR")] ushort* packageFamilyName
    )
    {
        return ((delegate* unmanaged<IZoneIdentifier2, ushort*, int>)((*lpVtbl)[7]))(
            this,
            packageFamilyName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveLastWriterPackageFamilyName()
    {
        return ((delegate* unmanaged<IZoneIdentifier2, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAppZoneId([NativeTypeName("DWORD *")] uint* zone)
    {
        return ((delegate* unmanaged<IZoneIdentifier2, uint*, int>)((*lpVtbl)[9]))(this, zone);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetAppZoneId([NativeTypeName("DWORD")] uint zone)
    {
        return ((delegate* unmanaged<IZoneIdentifier2, uint, int>)((*lpVtbl)[10]))(this, zone);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RemoveAppZoneId()
    {
        return ((delegate* unmanaged<IZoneIdentifier2, int>)((*lpVtbl)[11]))(this);
    }

    public interface Interface : IZoneIdentifier.Interface
    {
        [VtblIndex(6)]
        HRESULT GetLastWriterPackageFamilyName(
            [NativeTypeName("LPWSTR *")] ushort** packageFamilyName
        );

        [VtblIndex(7)]
        HRESULT SetLastWriterPackageFamilyName(
            [NativeTypeName("LPCWSTR")] ushort* packageFamilyName
        );

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

    /// <summary>Initializes a new instance of the <see cref = "IZoneIdentifier2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IZoneIdentifier2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IZoneIdentifier"/> to <see cref = "IZoneIdentifier2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IZoneIdentifier"/> instance to be converted </param>
    public static explicit operator IZoneIdentifier2(Silk.NET.Windows.IZoneIdentifier value)
    {
        return new IZoneIdentifier2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IZoneIdentifier2"/> to <see cref = "Silk.NET.Windows.IZoneIdentifier"/>.</summary>
    /// <param name = "value">The <see cref = "IZoneIdentifier2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IZoneIdentifier(IZoneIdentifier2 value)
    {
        return new Silk.NET.Windows.IZoneIdentifier(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IZoneIdentifier2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IZoneIdentifier2(Silk.NET.Windows.IUnknown value)
    {
        return new IZoneIdentifier2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IZoneIdentifier2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IZoneIdentifier2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IZoneIdentifier2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
