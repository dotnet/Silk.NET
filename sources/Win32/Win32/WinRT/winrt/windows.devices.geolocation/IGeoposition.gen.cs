// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.geolocation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C18D0454-7D41-4FF7-A957-9DFFB4EF7F5B")]
[NativeTypeName("struct IGeoposition : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGeoposition : IGeoposition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGeoposition));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGeoposition, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGeoposition, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGeoposition, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGeoposition, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGeoposition, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGeoposition, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Coordinate(
        [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocoordinate **")]
            IGeocoordinate* value
    )
    {
        return ((delegate* unmanaged<IGeoposition, IGeocoordinate*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_CivicAddress(
        [NativeTypeName("ABI::Windows::Devices::Geolocation::ICivicAddress **")]
            ICivicAddress* value
    )
    {
        return ((delegate* unmanaged<IGeoposition, ICivicAddress*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Coordinate(
            [NativeTypeName("ABI::Windows::Devices::Geolocation::IGeocoordinate **")]
                IGeocoordinate* value
        );

        [VtblIndex(7)]
        HRESULT get_CivicAddress(
            [NativeTypeName("ABI::Windows::Devices::Geolocation::ICivicAddress **")]
                ICivicAddress* value
        );
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Geolocation::IGeocoordinate **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IGeocoordinate*, int> get_Coordinate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Geolocation::ICivicAddress **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICivicAddress*, int> get_CivicAddress;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGeoposition"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGeoposition(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGeoposition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGeoposition(Silk.NET.WinRT.IInspectable value)
    {
        return new IGeoposition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeoposition"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGeoposition"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGeoposition value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGeoposition"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGeoposition(Silk.NET.Windows.IUnknown value)
    {
        return new IGeoposition(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGeoposition"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGeoposition"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGeoposition value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
