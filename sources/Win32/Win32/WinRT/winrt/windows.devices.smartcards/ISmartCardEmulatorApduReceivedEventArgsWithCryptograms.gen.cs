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

[Guid("D550BAC7-B7BF-4E29-9294-0C4AC3C941BD")]
[NativeTypeName("struct ISmartCardEmulatorApduReceivedEventArgsWithCryptograms : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardEmulatorApduReceivedEventArgsWithCryptograms
    : ISmartCardEmulatorApduReceivedEventArgsWithCryptograms.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(
                ref Unsafe.AsRef(in IID_ISmartCardEmulatorApduReceivedEventArgsWithCryptograms)
            );
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<
                ISmartCardEmulatorApduReceivedEventArgsWithCryptograms,
                Guid*,
                void**,
                int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<ISmartCardEmulatorApduReceivedEventArgsWithCryptograms, uint>)(
                (*lpVtbl)[1]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<ISmartCardEmulatorApduReceivedEventArgsWithCryptograms, uint>)(
                (*lpVtbl)[2]
            )
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardEmulatorApduReceivedEventArgsWithCryptograms,
                uint*,
                Guid**,
                int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<
                ISmartCardEmulatorApduReceivedEventArgsWithCryptograms,
                HSTRING*,
                int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<
                ISmartCardEmulatorApduReceivedEventArgsWithCryptograms,
                TrustLevel*,
                int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryRespondWithCryptogramsAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer responseTemplate,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *"
        )]
            IIterable<IntPtr>* cryptogramPlacementSteps,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **"
        )]
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardEmulatorApduReceivedEventArgsWithCryptograms,
                IBuffer,
                IIterable<IntPtr>*,
                IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
                int>)((*lpVtbl)[6])
        )(this, responseTemplate, cryptogramPlacementSteps, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryRespondWithCryptogramsAndStateAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer responseTemplate,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *"
        )]
            IIterable<IntPtr>* cryptogramPlacementSteps,
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
            IReference<uint>* nextState,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **"
        )]
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardEmulatorApduReceivedEventArgsWithCryptograms,
                IBuffer,
                IIterable<IntPtr>*,
                IReference<uint>*,
                IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
                int>)((*lpVtbl)[7])
        )(this, responseTemplate, cryptogramPlacementSteps, nextState, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryRespondWithCryptogramsAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer responseTemplate,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *"
            )]
                IIterable<IntPtr>* cryptogramPlacementSteps,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **"
            )]
                IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result
        );

        [VtblIndex(7)]
        HRESULT TryRespondWithCryptogramsAndStateAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer responseTemplate,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *"
            )]
                IIterable<IntPtr>* cryptogramPlacementSteps,
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_UINT32_t *")]
                IReference<uint>* nextState,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **"
            )]
                IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result
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
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            IIterable<IntPtr>*,
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
            int> TryRespondWithCryptogramsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *, ABI::Windows::Foundation::__FIReference_1_UINT32_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            IIterable<IntPtr>*,
            IReference<uint>*,
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
            int> TryRespondWithCryptogramsAndStateAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardEmulatorApduReceivedEventArgsWithCryptograms"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardEmulatorApduReceivedEventArgsWithCryptograms(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardEmulatorApduReceivedEventArgsWithCryptograms"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardEmulatorApduReceivedEventArgsWithCryptograms(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISmartCardEmulatorApduReceivedEventArgsWithCryptograms(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardEmulatorApduReceivedEventArgsWithCryptograms"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardEmulatorApduReceivedEventArgsWithCryptograms"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISmartCardEmulatorApduReceivedEventArgsWithCryptograms value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardEmulatorApduReceivedEventArgsWithCryptograms"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardEmulatorApduReceivedEventArgsWithCryptograms(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISmartCardEmulatorApduReceivedEventArgsWithCryptograms(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardEmulatorApduReceivedEventArgsWithCryptograms"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardEmulatorApduReceivedEventArgsWithCryptograms"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISmartCardEmulatorApduReceivedEventArgsWithCryptograms value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
