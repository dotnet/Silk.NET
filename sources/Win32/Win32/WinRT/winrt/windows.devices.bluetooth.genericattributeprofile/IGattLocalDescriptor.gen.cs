// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F48EBE06-789D-4A4B-8652-BD017B5D2FC6")]
[NativeTypeName("struct IGattLocalDescriptor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattLocalDescriptor : IGattLocalDescriptor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattLocalDescriptor));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGattLocalDescriptor, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGattLocalDescriptor, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGattLocalDescriptor, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IGattLocalDescriptor, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGattLocalDescriptor, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IGattLocalDescriptor, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Uuid(Guid* value)
    {
        return ((delegate* unmanaged<IGattLocalDescriptor, Guid*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StaticValue(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return ((delegate* unmanaged<IGattLocalDescriptor, IBuffer*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ReadProtectionLevel(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *"
        )]
            GattProtectionLevel* value
    )
    {
        return (
            (delegate* unmanaged<IGattLocalDescriptor, GattProtectionLevel*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_WriteProtectionLevel(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *"
        )]
            GattProtectionLevel* value
    )
    {
        return (
            (delegate* unmanaged<IGattLocalDescriptor, GattProtectionLevel*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ReadRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadRequestedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IGattLocalDescriptor,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ReadRequested(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IGattLocalDescriptor, EventRegistrationToken, int>)((*lpVtbl)[11])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT add_WriteRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteRequestedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IGattLocalDescriptor,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[12])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT remove_WriteRequested(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IGattLocalDescriptor, EventRegistrationToken, int>)((*lpVtbl)[13])
        )(this, token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Uuid(Guid* value);

        [VtblIndex(7)]
        HRESULT get_StaticValue(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
        );

        [VtblIndex(8)]
        HRESULT get_ReadProtectionLevel(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *"
            )]
                GattProtectionLevel* value
        );

        [VtblIndex(9)]
        HRESULT get_WriteProtectionLevel(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *"
            )]
                GattProtectionLevel* value
        );

        [VtblIndex(10)]
        HRESULT add_ReadRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadRequestedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(11)]
        HRESULT remove_ReadRequested(EventRegistrationToken token);

        [VtblIndex(12)]
        HRESULT add_WriteRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteRequestedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(13)]
        HRESULT remove_WriteRequested(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_Uuid;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> get_StaticValue;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GattProtectionLevel*, int> get_ReadProtectionLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::GattProtectionLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, GattProtectionLevel*, int> get_WriteProtectionLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattReadRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ReadRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ReadRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattLocalDescriptor_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattWriteRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_WriteRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_WriteRequested;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGattLocalDescriptor"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGattLocalDescriptor(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGattLocalDescriptor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGattLocalDescriptor(Silk.NET.WinRT.IInspectable value)
    {
        return new IGattLocalDescriptor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattLocalDescriptor"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGattLocalDescriptor"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGattLocalDescriptor value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGattLocalDescriptor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGattLocalDescriptor(Silk.NET.Windows.IUnknown value)
    {
        return new IGattLocalDescriptor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattLocalDescriptor"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGattLocalDescriptor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGattLocalDescriptor value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
