// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("19FE2A91-73AA-4D51-8A9D-56CCF7DB7F54")]
[NativeTypeName("struct IRegionOfInterest2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRegionOfInterest2 : IRegionOfInterest2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRegionOfInterest2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRegionOfInterest2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRegionOfInterest2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRegionOfInterest2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IRegionOfInterest2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IRegionOfInterest2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IRegionOfInterest2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Type(
        [NativeTypeName("ABI::Windows::Media::Devices::RegionOfInterestType *")]
            RegionOfInterestType* value
    )
    {
        return (
            (delegate* unmanaged<IRegionOfInterest2, RegionOfInterestType*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Type(
        [NativeTypeName("ABI::Windows::Media::Devices::RegionOfInterestType")]
            RegionOfInterestType value
    )
    {
        return ((delegate* unmanaged<IRegionOfInterest2, RegionOfInterestType, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BoundsNormalized([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IRegionOfInterest2, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BoundsNormalized([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IRegionOfInterest2, byte, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Weight([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IRegionOfInterest2, uint*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Weight([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IRegionOfInterest2, uint, int>)((*lpVtbl)[11]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Type(
            [NativeTypeName("ABI::Windows::Media::Devices::RegionOfInterestType *")]
                RegionOfInterestType* value
        );

        [VtblIndex(7)]
        HRESULT put_Type(
            [NativeTypeName("ABI::Windows::Media::Devices::RegionOfInterestType")]
                RegionOfInterestType value
        );

        [VtblIndex(8)]
        HRESULT get_BoundsNormalized([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_BoundsNormalized([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_Weight([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT put_Weight([NativeTypeName("UINT32")] uint value);
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
            "HRESULT (ABI::Windows::Media::Devices::RegionOfInterestType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RegionOfInterestType*, int> get_Type;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Devices::RegionOfInterestType) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RegionOfInterestType, int> put_Type;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_BoundsNormalized;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_BoundsNormalized;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Weight;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_Weight;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRegionOfInterest2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRegionOfInterest2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRegionOfInterest2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRegionOfInterest2(Silk.NET.WinRT.IInspectable value)
    {
        return new IRegionOfInterest2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRegionOfInterest2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRegionOfInterest2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IRegionOfInterest2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRegionOfInterest2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRegionOfInterest2(Silk.NET.Windows.IUnknown value)
    {
        return new IRegionOfInterest2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRegionOfInterest2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRegionOfInterest2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRegionOfInterest2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
