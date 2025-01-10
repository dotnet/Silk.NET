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

[Guid("7116AA34-5D6D-4B4A-96A3-EFA47D2A7E25")]
[NativeTypeName("struct ISmartCardCryptogramGenerator2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardCryptogramGenerator2
    : ISmartCardCryptogramGenerator2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardCryptogramGenerator2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramGenerator2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISmartCardCryptogramGenerator2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmartCardCryptogramGenerator2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramGenerator2, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmartCardCryptogramGenerator2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramGenerator2, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ValidateRequestApduAsync(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")]
            SmartCardUnlockPromptingBehavior promptingBehavior,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer apduToValidate,
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
                ISmartCardCryptogramGenerator2,
                SmartCardUnlockPromptingBehavior,
                IBuffer,
                IIterable<IntPtr>*,
                IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
                int>)((*lpVtbl)[6])
        )(this, promptingBehavior, apduToValidate, cryptogramPlacementSteps, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAllCryptogramStorageKeyCharacteristicsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramGenerator2, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[7]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAllCryptogramMaterialPackageCharacteristicsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramGenerator2, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetAllCryptogramMaterialPackageCharacteristicsWithStorageKeyAsync(
        HSTRING storageKeyName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGenerator2,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, storageKeyName, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetAllCryptogramMaterialCharacteristicsAsync(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")]
            SmartCardUnlockPromptingBehavior promptingBehavior,
        HSTRING materialPackageName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGenerator2,
                SmartCardUnlockPromptingBehavior,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, promptingBehavior, materialPackageName, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ValidateRequestApduAsync(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")]
                SmartCardUnlockPromptingBehavior promptingBehavior,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer apduToValidate,
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
        HRESULT GetAllCryptogramStorageKeyCharacteristicsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(8)]
        HRESULT GetAllCryptogramMaterialPackageCharacteristicsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(9)]
        HRESULT GetAllCryptogramMaterialPackageCharacteristicsWithStorageKeyAsync(
            HSTRING storageKeyName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(10)]
        HRESULT GetAllCryptogramMaterialCharacteristicsAsync(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")]
                SmartCardUnlockPromptingBehavior promptingBehavior,
            HSTRING materialPackageName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
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
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramPlacementStep_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardUnlockPromptingBehavior,
            IBuffer,
            IIterable<IntPtr>*,
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
            int> ValidateRequestApduAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramStorageKeyCharacteristicsResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> GetAllCryptogramStorageKeyCharacteristicsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> GetAllCryptogramMaterialPackageCharacteristicsAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialPackageCharacteristicsResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetAllCryptogramMaterialPackageCharacteristicsWithStorageKeyAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGetAllCryptogramMaterialCharacteristicsResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardUnlockPromptingBehavior,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetAllCryptogramMaterialCharacteristicsAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardCryptogramGenerator2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardCryptogramGenerator2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardCryptogramGenerator2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardCryptogramGenerator2(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISmartCardCryptogramGenerator2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardCryptogramGenerator2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardCryptogramGenerator2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISmartCardCryptogramGenerator2 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardCryptogramGenerator2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardCryptogramGenerator2(Silk.NET.Windows.IUnknown value)
    {
        return new ISmartCardCryptogramGenerator2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardCryptogramGenerator2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardCryptogramGenerator2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmartCardCryptogramGenerator2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
