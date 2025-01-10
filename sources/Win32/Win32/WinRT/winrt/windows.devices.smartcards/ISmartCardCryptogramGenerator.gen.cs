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

[Guid("E39F587B-EDD3-4E49-B594-0FF5E4D0C76F")]
[NativeTypeName("struct ISmartCardCryptogramGenerator : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardCryptogramGenerator
    : ISmartCardCryptogramGenerator.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardCryptogramGenerator));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramGenerator, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISmartCardCryptogramGenerator, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmartCardCryptogramGenerator, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramGenerator, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmartCardCryptogramGenerator, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISmartCardCryptogramGenerator, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SupportedCryptogramMaterialTypes(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialType_t **"
        )]
            IVectorView<SmartCardCryptogramMaterialType>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGenerator,
                IVectorView<SmartCardCryptogramMaterialType>**,
                int>)((*lpVtbl)[6])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SupportedCryptogramAlgorithms(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **"
        )]
            IVectorView<SmartCardCryptogramAlgorithm>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGenerator,
                IVectorView<SmartCardCryptogramAlgorithm>**,
                int>)((*lpVtbl)[7])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SupportedCryptogramMaterialPackageFormats(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageFormat_t **"
        )]
            IVectorView<SmartCardCryptogramMaterialPackageFormat>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGenerator,
                IVectorView<SmartCardCryptogramMaterialPackageFormat>**,
                int>)((*lpVtbl)[8])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SupportedCryptogramMaterialPackageConfirmationResponseFormats(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageConfirmationResponseFormat_t **"
        )]
            IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGenerator,
                IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>**,
                int>)((*lpVtbl)[9])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_SupportedSmartCardCryptogramStorageKeyCapabilities(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyCapabilities_t **"
        )]
            IVectorView<SmartCardCryptogramStorageKeyCapabilities>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGenerator,
                IVectorView<SmartCardCryptogramStorageKeyCapabilities>**,
                int>)((*lpVtbl)[10])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteCryptogramMaterialStorageKeyAsync(
        HSTRING storageKeyName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **"
        )]
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGenerator,
                HSTRING,
                IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
                int>)((*lpVtbl)[11])
        )(this, storageKeyName, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateCryptogramMaterialStorageKeyAsync(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")]
            SmartCardUnlockPromptingBehavior promptingBehavior,
        HSTRING storageKeyName,
        [NativeTypeName(
            "ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyAlgorithm"
        )]
            SmartCardCryptogramStorageKeyAlgorithm algorithm,
        [NativeTypeName(
            "ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyCapabilities"
        )]
            SmartCardCryptogramStorageKeyCapabilities capabilities,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **"
        )]
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGenerator,
                SmartCardUnlockPromptingBehavior,
                HSTRING,
                SmartCardCryptogramStorageKeyAlgorithm,
                SmartCardCryptogramStorageKeyCapabilities,
                IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
                int>)((*lpVtbl)[12])
        )(this, promptingBehavior, storageKeyName, algorithm, capabilities, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RequestCryptogramMaterialStorageKeyInfoAsync(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")]
            SmartCardUnlockPromptingBehavior promptingBehavior,
        HSTRING storageKeyName,
        [NativeTypeName(
            "ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType"
        )]
            CryptographicPublicKeyBlobType format,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyInfo_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGenerator,
                SmartCardUnlockPromptingBehavior,
                HSTRING,
                CryptographicPublicKeyBlobType,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[13])
        )(this, promptingBehavior, storageKeyName, format, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ImportCryptogramMaterialPackageAsync(
        [NativeTypeName(
            "ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageFormat"
        )]
            SmartCardCryptogramMaterialPackageFormat format,
        HSTRING storageKeyName,
        HSTRING materialPackageName,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")]
            IBuffer cryptogramMaterialPackage,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **"
        )]
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGenerator,
                SmartCardCryptogramMaterialPackageFormat,
                HSTRING,
                HSTRING,
                IBuffer,
                IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
                int>)((*lpVtbl)[14])
        )(this, format, storageKeyName, materialPackageName, cryptogramMaterialPackage, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT TryProvePossessionOfCryptogramMaterialPackageAsync(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")]
            SmartCardUnlockPromptingBehavior promptingBehavior,
        [NativeTypeName(
            "ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageConfirmationResponseFormat"
        )]
            SmartCardCryptogramMaterialPackageConfirmationResponseFormat responseFormat,
        HSTRING materialPackageName,
        HSTRING materialName,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer challenge,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPossessionProof_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGenerator,
                SmartCardUnlockPromptingBehavior,
                SmartCardCryptogramMaterialPackageConfirmationResponseFormat,
                HSTRING,
                HSTRING,
                IBuffer,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[15])
        )(
            this,
            promptingBehavior,
            responseFormat,
            materialPackageName,
            materialName,
            challenge,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RequestUnlockCryptogramMaterialForUseAsync(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")]
            SmartCardUnlockPromptingBehavior promptingBehavior,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **"
        )]
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGenerator,
                SmartCardUnlockPromptingBehavior,
                IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
                int>)((*lpVtbl)[16])
        )(this, promptingBehavior, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT DeleteCryptogramMaterialPackageAsync(
        HSTRING materialPackageName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **"
        )]
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardCryptogramGenerator,
                HSTRING,
                IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
                int>)((*lpVtbl)[17])
        )(this, materialPackageName, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SupportedCryptogramMaterialTypes(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialType_t **"
            )]
                IVectorView<SmartCardCryptogramMaterialType>** result
        );

        [VtblIndex(7)]
        HRESULT get_SupportedCryptogramAlgorithms(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **"
            )]
                IVectorView<SmartCardCryptogramAlgorithm>** result
        );

        [VtblIndex(8)]
        HRESULT get_SupportedCryptogramMaterialPackageFormats(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageFormat_t **"
            )]
                IVectorView<SmartCardCryptogramMaterialPackageFormat>** result
        );

        [VtblIndex(9)]
        HRESULT get_SupportedCryptogramMaterialPackageConfirmationResponseFormats(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageConfirmationResponseFormat_t **"
            )]
                IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>** result
        );

        [VtblIndex(10)]
        HRESULT get_SupportedSmartCardCryptogramStorageKeyCapabilities(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyCapabilities_t **"
            )]
                IVectorView<SmartCardCryptogramStorageKeyCapabilities>** result
        );

        [VtblIndex(11)]
        HRESULT DeleteCryptogramMaterialStorageKeyAsync(
            HSTRING storageKeyName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **"
            )]
                IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result
        );

        [VtblIndex(12)]
        HRESULT CreateCryptogramMaterialStorageKeyAsync(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")]
                SmartCardUnlockPromptingBehavior promptingBehavior,
            HSTRING storageKeyName,
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyAlgorithm"
            )]
                SmartCardCryptogramStorageKeyAlgorithm algorithm,
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyCapabilities"
            )]
                SmartCardCryptogramStorageKeyCapabilities capabilities,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **"
            )]
                IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result
        );

        [VtblIndex(13)]
        HRESULT RequestCryptogramMaterialStorageKeyInfoAsync(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")]
                SmartCardUnlockPromptingBehavior promptingBehavior,
            HSTRING storageKeyName,
            [NativeTypeName(
                "ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType"
            )]
                CryptographicPublicKeyBlobType format,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyInfo_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(14)]
        HRESULT ImportCryptogramMaterialPackageAsync(
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageFormat"
            )]
                SmartCardCryptogramMaterialPackageFormat format,
            HSTRING storageKeyName,
            HSTRING materialPackageName,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")]
                IBuffer cryptogramMaterialPackage,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **"
            )]
                IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result
        );

        [VtblIndex(15)]
        HRESULT TryProvePossessionOfCryptogramMaterialPackageAsync(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")]
                SmartCardUnlockPromptingBehavior promptingBehavior,
            [NativeTypeName(
                "ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageConfirmationResponseFormat"
            )]
                SmartCardCryptogramMaterialPackageConfirmationResponseFormat responseFormat,
            HSTRING materialPackageName,
            HSTRING materialName,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer challenge,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPossessionProof_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(16)]
        HRESULT RequestUnlockCryptogramMaterialForUseAsync(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior")]
                SmartCardUnlockPromptingBehavior promptingBehavior,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **"
            )]
                IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>** result
        );

        [VtblIndex(17)]
        HRESULT DeleteCryptogramMaterialPackageAsync(
            HSTRING materialPackageName,
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialType_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<SmartCardCryptogramMaterialType>**,
            int> get_SupportedCryptogramMaterialTypes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramAlgorithm_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<SmartCardCryptogramAlgorithm>**,
            int> get_SupportedCryptogramAlgorithms;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageFormat_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<SmartCardCryptogramMaterialPackageFormat>**,
            int> get_SupportedCryptogramMaterialPackageFormats;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPackageConfirmationResponseFormat_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<SmartCardCryptogramMaterialPackageConfirmationResponseFormat>**,
            int> get_SupportedCryptogramMaterialPackageConfirmationResponseFormats;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyCapabilities_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVectorView<SmartCardCryptogramStorageKeyCapabilities>**,
            int> get_SupportedSmartCardCryptogramStorageKeyCapabilities;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
            int> DeleteCryptogramMaterialStorageKeyAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior, HSTRING, ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyAlgorithm, ABI::Windows::Devices::SmartCards::SmartCardCryptogramStorageKeyCapabilities, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardUnlockPromptingBehavior,
            HSTRING,
            SmartCardCryptogramStorageKeyAlgorithm,
            SmartCardCryptogramStorageKeyCapabilities,
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
            int> CreateCryptogramMaterialStorageKeyAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior, HSTRING, ABI::Windows::Security::Cryptography::Core::CryptographicPublicKeyBlobType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramStorageKeyInfo_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardUnlockPromptingBehavior,
            HSTRING,
            CryptographicPublicKeyBlobType,
            IAsyncOperation<IntPtr>**,
            int> RequestCryptogramMaterialStorageKeyInfoAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageFormat, HSTRING, HSTRING, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardCryptogramMaterialPackageFormat,
            HSTRING,
            HSTRING,
            IBuffer,
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
            int> ImportCryptogramMaterialPackageAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior, ABI::Windows::Devices::SmartCards::SmartCardCryptogramMaterialPackageConfirmationResponseFormat, HSTRING, HSTRING, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramMaterialPossessionProof_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardUnlockPromptingBehavior,
            SmartCardCryptogramMaterialPackageConfirmationResponseFormat,
            HSTRING,
            HSTRING,
            IBuffer,
            IAsyncOperation<IntPtr>**,
            int> TryProvePossessionOfCryptogramMaterialPackageAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardUnlockPromptingBehavior, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardUnlockPromptingBehavior,
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
            int> RequestUnlockCryptogramMaterialForUseAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CDevices__CSmartCards__CSmartCardCryptogramGeneratorOperationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus>**,
            int> DeleteCryptogramMaterialPackageAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardCryptogramGenerator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardCryptogramGenerator(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardCryptogramGenerator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardCryptogramGenerator(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmartCardCryptogramGenerator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardCryptogramGenerator"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardCryptogramGenerator"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmartCardCryptogramGenerator value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardCryptogramGenerator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardCryptogramGenerator(Silk.NET.Windows.IUnknown value)
    {
        return new ISmartCardCryptogramGenerator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardCryptogramGenerator"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardCryptogramGenerator"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmartCardCryptogramGenerator value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
