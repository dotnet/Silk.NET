// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("0F3121AC-D609-51A1-96F3-FB00D1819252")]
[NativeTypeName("struct IPhoneLineTransportDeviceStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneLineTransportDeviceStatics
    : IPhoneLineTransportDeviceStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneLineTransportDeviceStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPhoneLineTransportDeviceStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPhoneLineTransportDeviceStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPhoneLineTransportDeviceStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IPhoneLineTransportDeviceStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IPhoneLineTransportDeviceStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IPhoneLineTransportDeviceStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromId(
        HSTRING id,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineTransportDevice **")]
            IPhoneLineTransportDevice* result
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneLineTransportDeviceStatics,
                HSTRING,
                IPhoneLineTransportDevice*,
                int>)((*lpVtbl)[6])
        )(this, id, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeviceSelector(HSTRING* result)
    {
        return (
            (delegate* unmanaged<IPhoneLineTransportDeviceStatics, HSTRING*, int>)((*lpVtbl)[7])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeviceSelectorForPhoneLineTransport(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineTransport")]
            PhoneLineTransport transport,
        HSTRING* result
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneLineTransportDeviceStatics,
                PhoneLineTransport,
                HSTRING*,
                int>)((*lpVtbl)[8])
        )(this, transport, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromId(
            HSTRING id,
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneLineTransportDevice **")]
                IPhoneLineTransportDevice* result
        );

        [VtblIndex(7)]
        HRESULT GetDeviceSelector(HSTRING* result);

        [VtblIndex(8)]
        HRESULT GetDeviceSelectorForPhoneLineTransport(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::PhoneLineTransport")]
                PhoneLineTransport transport,
            HSTRING* result
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
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Calls::IPhoneLineTransportDevice **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IPhoneLineTransportDevice*, int> FromId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetDeviceSelector;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::PhoneLineTransport, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PhoneLineTransport,
            HSTRING*,
            int> GetDeviceSelectorForPhoneLineTransport;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPhoneLineTransportDeviceStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPhoneLineTransportDeviceStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPhoneLineTransportDeviceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPhoneLineTransportDeviceStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IPhoneLineTransportDeviceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneLineTransportDeviceStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneLineTransportDeviceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IPhoneLineTransportDeviceStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPhoneLineTransportDeviceStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPhoneLineTransportDeviceStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPhoneLineTransportDeviceStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneLineTransportDeviceStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneLineTransportDeviceStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPhoneLineTransportDeviceStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
