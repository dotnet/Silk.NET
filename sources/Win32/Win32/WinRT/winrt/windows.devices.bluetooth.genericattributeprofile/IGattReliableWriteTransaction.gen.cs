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

[Guid("63A66F07-1AEA-4C4C-A50F-97BAE474B348")]
[NativeTypeName("struct IGattReliableWriteTransaction : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IGattReliableWriteTransaction
    : IGattReliableWriteTransaction.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGattReliableWriteTransaction));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IGattReliableWriteTransaction, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGattReliableWriteTransaction, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGattReliableWriteTransaction, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IGattReliableWriteTransaction, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IGattReliableWriteTransaction, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IGattReliableWriteTransaction, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT WriteValue(
        [NativeTypeName(
            "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattCharacteristic *"
        )]
            IGattCharacteristic characteristic,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value
    )
    {
        return (
            (delegate* unmanaged<IGattReliableWriteTransaction, IGattCharacteristic, IBuffer, int>)(
                (*lpVtbl)[6]
            )
        )(this, characteristic, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CommitAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **"
        )]
            IAsyncOperation<GattCommunicationStatus>** asyncOp
    )
    {
        return (
            (delegate* unmanaged<
                IGattReliableWriteTransaction,
                IAsyncOperation<GattCommunicationStatus>**,
                int>)((*lpVtbl)[7])
        )(this, asyncOp);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT WriteValue(
            [NativeTypeName(
                "ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattCharacteristic *"
            )]
                IGattCharacteristic characteristic,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer value
        );

        [VtblIndex(7)]
        HRESULT CommitAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **"
            )]
                IAsyncOperation<GattCommunicationStatus>** asyncOp
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
            "HRESULT (ABI::Windows::Devices::Bluetooth::GenericAttributeProfile::IGattCharacteristic *, ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IGattCharacteristic, IBuffer, int> WriteValue;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CBluetooth__CGenericAttributeProfile__CGattCommunicationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<GattCommunicationStatus>**,
            int> CommitAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGattReliableWriteTransaction"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGattReliableWriteTransaction(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IGattReliableWriteTransaction"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IGattReliableWriteTransaction(Silk.NET.WinRT.IInspectable value)
    {
        return new IGattReliableWriteTransaction(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattReliableWriteTransaction"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IGattReliableWriteTransaction"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IGattReliableWriteTransaction value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGattReliableWriteTransaction"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGattReliableWriteTransaction(Silk.NET.Windows.IUnknown value)
    {
        return new IGattReliableWriteTransaction(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGattReliableWriteTransaction"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGattReliableWriteTransaction"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGattReliableWriteTransaction value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
