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

[Guid("256BBC3D-1C5D-4260-8C75-9144CFB78BA9")]
[NativeTypeName("struct IFileRevocationManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager."
)]
public unsafe partial struct IFileRevocationManagerStatics
    : IFileRevocationManagerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileRevocationManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IFileRevocationManagerStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileRevocationManagerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileRevocationManagerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IFileRevocationManagerStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFileRevocationManagerStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IFileRevocationManagerStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager."
    )]
    public HRESULT ProtectAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem storageItem,
        HSTRING enterpriseIdentity,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionStatus_t **"
        )]
            IAsyncOperation<FileProtectionStatus>** result
    )
    {
        return (
            (delegate* unmanaged<
                IFileRevocationManagerStatics,
                IStorageItem,
                HSTRING,
                IAsyncOperation<FileProtectionStatus>**,
                int>)((*lpVtbl)[6])
        )(this, storageItem, enterpriseIdentity, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager."
    )]
    public HRESULT CopyProtectionAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem sourceStorageItem,
        [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem targetStorageItem,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IFileRevocationManagerStatics,
                IStorageItem,
                IStorageItem,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[7])
        )(this, sourceStorageItem, targetStorageItem, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager."
    )]
    public HRESULT Revoke(HSTRING enterpriseIdentity)
    {
        return ((delegate* unmanaged<IFileRevocationManagerStatics, HSTRING, int>)((*lpVtbl)[8]))(
            this,
            enterpriseIdentity
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete(
        "FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager."
    )]
    public HRESULT GetStatusAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem storageItem,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionStatus_t **"
        )]
            IAsyncOperation<FileProtectionStatus>** result
    )
    {
        return (
            (delegate* unmanaged<
                IFileRevocationManagerStatics,
                IStorageItem,
                IAsyncOperation<FileProtectionStatus>**,
                int>)((*lpVtbl)[9])
        )(this, storageItem, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager."
        )]
        HRESULT ProtectAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem storageItem,
            HSTRING enterpriseIdentity,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionStatus_t **"
            )]
                IAsyncOperation<FileProtectionStatus>** result
        );

        [VtblIndex(7)]
        [Obsolete(
            "FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager."
        )]
        HRESULT CopyProtectionAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageItem *")]
                IStorageItem sourceStorageItem,
            [NativeTypeName("ABI::Windows::Storage::IStorageItem *")]
                IStorageItem targetStorageItem,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(8)]
        [Obsolete(
            "FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager."
        )]
        HRESULT Revoke(HSTRING enterpriseIdentity);

        [VtblIndex(9)]
        [Obsolete(
            "FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager."
        )]
        HRESULT GetStatusAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageItem *")] IStorageItem storageItem,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionStatus_t **"
            )]
                IAsyncOperation<FileProtectionStatus>** result
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
            "HRESULT (ABI::Windows::Storage::IStorageItem *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionStatus_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager."
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageItem,
            HSTRING,
            IAsyncOperation<FileProtectionStatus>**,
            int> ProtectAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageItem *, ABI::Windows::Storage::IStorageItem *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager."
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageItem,
            IStorageItem,
            IAsyncOperation<byte>**,
            int> CopyProtectionAsync;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        [Obsolete(
            "FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager."
        )]
        public delegate* unmanaged<TSelf*, HSTRING, int> Revoke;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageItem *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CFileProtectionStatus_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "FileRevocationManager might be unavailable after Windows 10. Instead, use FileProtectionManager."
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageItem,
            IAsyncOperation<FileProtectionStatus>**,
            int> GetStatusAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileRevocationManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileRevocationManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFileRevocationManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFileRevocationManagerStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IFileRevocationManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileRevocationManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFileRevocationManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFileRevocationManagerStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileRevocationManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileRevocationManagerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IFileRevocationManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileRevocationManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileRevocationManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileRevocationManagerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
