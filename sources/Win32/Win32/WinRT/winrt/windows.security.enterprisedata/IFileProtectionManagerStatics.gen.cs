// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.enterprisedata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5846FC9B-E613-426B-BB38-88CBA1DC9ADB")]
[NativeTypeName("struct IFileProtectionManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileProtectionManagerStatics
    : IFileProtectionManagerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileProtectionManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IFileProtectionManagerStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileProtectionManagerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileProtectionManagerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IFileProtectionManagerStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFileProtectionManagerStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IFileProtectionManagerStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ProtectAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem target,
        HSTRING identity,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IFileProtectionManagerStatics,
                IStorageItem,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, target, identity, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyProtectionAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem source,
        [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem target,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IFileProtectionManagerStatics,
                IStorageItem,
                IStorageItem,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[7])
        )(this, source, target, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetProtectionInfoAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem source,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IFileProtectionManagerStatics,
                IStorageItem,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, source, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SaveFileAsContainerAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile protectedFile,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerExportResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IFileProtectionManagerStatics,
                IStorageFile,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, protectedFile, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LoadFileFromContainerAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile containerFile,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IFileProtectionManagerStatics,
                IStorageFile,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, containerFile, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT LoadFileFromContainerWithTargetAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile containerFile,
        [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem target,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IFileProtectionManagerStatics,
                IStorageFile,
                IStorageItem,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[11])
        )(this, containerFile, target, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateProtectedAndOpenAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder parentFolder,
        HSTRING desiredName,
        HSTRING identity,
        [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")]
            CreationCollisionOption collisionOption,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedFileCreateResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IFileProtectionManagerStatics,
                IStorageFolder,
                HSTRING,
                HSTRING,
                CreationCollisionOption,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[12])
        )(this, parentFolder, desiredName, identity, collisionOption, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ProtectAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem target,
            HSTRING identity,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(7)]
        HRESULT CopyProtectionAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem source,
            [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem target,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(8)]
        HRESULT GetProtectionInfoAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem source,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(9)]
        HRESULT SaveFileAsContainerAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile protectedFile,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerExportResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(10)]
        HRESULT LoadFileFromContainerAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile containerFile,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(11)]
        HRESULT LoadFileFromContainerWithTargetAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile containerFile,
            [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem target,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(12)]
        HRESULT CreateProtectedAndOpenAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")] IStorageFolder parentFolder,
            HSTRING desiredName,
            HSTRING identity,
            [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")]
                CreationCollisionOption collisionOption,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedFileCreateResult_t **"
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
            "HRESULT (ABI::Windows::Storage::IStorageItem *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageItem,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> ProtectAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageItem *, ABI::Windows::Storage::IStorageItem *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageItem,
            IStorageItem,
            IAsyncOperation<byte>**,
            int> CopyProtectionAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageItem *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionInfo_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageItem,
            IAsyncOperation<IntPtr>**,
            int> GetProtectionInfoAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerExportResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IAsyncOperation<IntPtr>**,
            int> SaveFileAsContainerAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IAsyncOperation<IntPtr>**,
            int> LoadFileFromContainerAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::IStorageItem *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedContainerImportResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IStorageItem,
            IAsyncOperation<IntPtr>**,
            int> LoadFileFromContainerWithTargetAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder *, HSTRING, HSTRING, ABI::Windows::Storage::CreationCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CProtectedFileCreateResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFolder,
            HSTRING,
            HSTRING,
            CreationCollisionOption,
            IAsyncOperation<IntPtr>**,
            int> CreateProtectedAndOpenAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileProtectionManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileProtectionManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFileProtectionManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFileProtectionManagerStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IFileProtectionManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileProtectionManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFileProtectionManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFileProtectionManagerStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileProtectionManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileProtectionManagerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IFileProtectionManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileProtectionManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileProtectionManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileProtectionManagerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
