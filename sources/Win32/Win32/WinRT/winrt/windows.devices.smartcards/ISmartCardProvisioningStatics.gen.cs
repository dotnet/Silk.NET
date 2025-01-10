// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("13882848-0D13-4E70-9735-51DAECA5254F")]
[NativeTypeName("struct ISmartCardProvisioningStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardProvisioningStatics
    : ISmartCardProvisioningStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardProvisioningStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISmartCardProvisioningStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISmartCardProvisioningStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmartCardProvisioningStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISmartCardProvisioningStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmartCardProvisioningStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISmartCardProvisioningStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FromSmartCardAsync(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCard *")] ISmartCard card,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardProvisioningStatics,
                ISmartCard,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, card, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestVirtualSmartCardCreationAsync(
        HSTRING friendlyName,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer administrativeKey,
        [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *")]
            ISmartCardPinPolicy pinPolicy,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardProvisioningStatics,
                HSTRING,
                IBuffer,
                ISmartCardPinPolicy,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, friendlyName, administrativeKey, pinPolicy, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RequestVirtualSmartCardCreationAsyncWithCardId(
        HSTRING friendlyName,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer administrativeKey,
        [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *")]
            ISmartCardPinPolicy pinPolicy,
        Guid cardId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardProvisioningStatics,
                HSTRING,
                IBuffer,
                ISmartCardPinPolicy,
                Guid,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, friendlyName, administrativeKey, pinPolicy, cardId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestVirtualSmartCardDeletionAsync(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCard *")] ISmartCard card,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardProvisioningStatics,
                ISmartCard,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[9])
        )(this, card, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FromSmartCardAsync(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCard *")] ISmartCard card,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(7)]
        HRESULT RequestVirtualSmartCardCreationAsync(
            HSTRING friendlyName,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer administrativeKey,
            [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *")]
                ISmartCardPinPolicy pinPolicy,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(8)]
        HRESULT RequestVirtualSmartCardCreationAsyncWithCardId(
            HSTRING friendlyName,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer administrativeKey,
            [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *")]
                ISmartCardPinPolicy pinPolicy,
            Guid cardId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(9)]
        HRESULT RequestVirtualSmartCardDeletionAsync(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCard *")] ISmartCard card,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
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
            "HRESULT (ABI::Windows::Devices::SmartCards::ISmartCard *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISmartCard,
            IAsyncOperation<IntPtr>**,
            int> FromSmartCardAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IBuffer,
            ISmartCardPinPolicy,
            IAsyncOperation<IntPtr>**,
            int> RequestVirtualSmartCardCreationAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Devices::SmartCards::ISmartCardPinPolicy *, GUID, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardProvisioning_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IBuffer,
            ISmartCardPinPolicy,
            Guid,
            IAsyncOperation<IntPtr>**,
            int> RequestVirtualSmartCardCreationAsyncWithCardId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::ISmartCard *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISmartCard,
            IAsyncOperation<byte>**,
            int> RequestVirtualSmartCardDeletionAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardProvisioningStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardProvisioningStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardProvisioningStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardProvisioningStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmartCardProvisioningStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardProvisioningStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardProvisioningStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmartCardProvisioningStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardProvisioningStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardProvisioningStatics(Silk.NET.Windows.IUnknown value)
    {
        return new ISmartCardProvisioningStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardProvisioningStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardProvisioningStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmartCardProvisioningStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
