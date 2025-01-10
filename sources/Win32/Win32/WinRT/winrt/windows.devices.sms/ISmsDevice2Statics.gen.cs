// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("65C78325-1031-491E-8FB6-EF9991AFE363")]
[NativeTypeName("struct ISmsDevice2Statics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmsDevice2Statics : ISmsDevice2Statics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsDevice2Statics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmsDevice2Statics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmsDevice2Statics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmsDevice2Statics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISmsDevice2Statics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmsDevice2Statics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISmsDevice2Statics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDeviceSelector(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmsDevice2Statics, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FromId(
        HSTRING deviceId,
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice2 **")] ISmsDevice2* value
    )
    {
        return (
            (delegate* unmanaged<ISmsDevice2Statics, HSTRING, ISmsDevice2*, int>)((*lpVtbl)[7])
        )(this, deviceId, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDefault(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice2 **")] ISmsDevice2* value
    )
    {
        return ((delegate* unmanaged<ISmsDevice2Statics, ISmsDevice2*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FromParentId(
        HSTRING parentDeviceId,
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice2 **")] ISmsDevice2* value
    )
    {
        return (
            (delegate* unmanaged<ISmsDevice2Statics, HSTRING, ISmsDevice2*, int>)((*lpVtbl)[9])
        )(this, parentDeviceId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetDeviceSelector(HSTRING* value);

        [VtblIndex(7)]
        HRESULT FromId(
            HSTRING deviceId,
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice2 **")] ISmsDevice2* value
        );

        [VtblIndex(8)]
        HRESULT GetDefault(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice2 **")] ISmsDevice2* value
        );

        [VtblIndex(9)]
        HRESULT FromParentId(
            HSTRING parentDeviceId,
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice2 **")] ISmsDevice2* value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Devices::Sms::ISmsDevice2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, ISmsDevice2*, int> FromId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsDevice2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISmsDevice2*, int> GetDefault;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Devices::Sms::ISmsDevice2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, ISmsDevice2*, int> FromParentId;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmsDevice2Statics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmsDevice2Statics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmsDevice2Statics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmsDevice2Statics(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmsDevice2Statics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsDevice2Statics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsDevice2Statics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmsDevice2Statics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmsDevice2Statics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmsDevice2Statics(Silk.NET.Windows.IUnknown value)
    {
        return new ISmsDevice2Statics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsDevice2Statics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsDevice2Statics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmsDevice2Statics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
