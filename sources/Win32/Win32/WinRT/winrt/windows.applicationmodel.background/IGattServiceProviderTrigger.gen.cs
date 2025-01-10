// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("DDC6A3E9-1557-4BD8-8542-468AA0C696F6")]
[NativeTypeName("struct IGattServiceProviderTrigger : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattServiceProviderTrigger
    : IGattServiceProviderTrigger.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattServiceProviderTrigger));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IGattServiceProviderTrigger, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGattServiceProviderTrigger, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGattServiceProviderTrigger, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IGattServiceProviderTrigger, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGattServiceProviderTrigger, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGattServiceProviderTrigger, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TriggerId(HSTRING* value)
    {
        return ((delegate* unmanaged<IGattServiceProviderTrigger, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Service(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalService **"
        )]
            IGattLocalService* value
    )
    {
        return (
            (delegate* unmanaged<IGattServiceProviderTrigger, IGattLocalService*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_AdvertisingParameters(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters *"
        )]
            IGattServiceProviderAdvertisingParameters value
    )
    {
        return (
            (delegate* unmanaged<
                IGattServiceProviderTrigger,
                IGattServiceProviderAdvertisingParameters,
                int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AdvertisingParameters(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters **"
        )]
            IGattServiceProviderAdvertisingParameters* value
    )
    {
        return (
            (delegate* unmanaged<
                IGattServiceProviderTrigger,
                IGattServiceProviderAdvertisingParameters*,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TriggerId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Service(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalService **"
            )]
                IGattLocalService* value
        );

        [VtblIndex(8)]
        HRESULT put_AdvertisingParameters(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters *"
            )]
                IGattServiceProviderAdvertisingParameters value
        );

        [VtblIndex(9)]
        HRESULT get_AdvertisingParameters(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters **"
            )]
                IGattServiceProviderAdvertisingParameters* value
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_TriggerId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattLocalService **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IGattLocalService*, int> get_Service;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IGattServiceProviderAdvertisingParameters,
            int> put_AdvertisingParameters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattServiceProviderAdvertisingParameters **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IGattServiceProviderAdvertisingParameters*,
            int> get_AdvertisingParameters;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGattServiceProviderTrigger"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGattServiceProviderTrigger(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGattServiceProviderTrigger"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGattServiceProviderTrigger(Silk.NET.WinRT.IInspectable value)
    {
        return new IGattServiceProviderTrigger(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattServiceProviderTrigger"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGattServiceProviderTrigger"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGattServiceProviderTrigger value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGattServiceProviderTrigger"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGattServiceProviderTrigger(Silk.NET.Windows.IUnknown value)
    {
        return new IGattServiceProviderTrigger(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattServiceProviderTrigger"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGattServiceProviderTrigger"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGattServiceProviderTrigger value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
