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

[Guid("B6149B74-9144-4EE4-8A8A-30B5F361430E")]
[NativeTypeName("struct IDataProtectionManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataProtectionManagerStatics
    : IDataProtectionManagerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataProtectionManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDataProtectionManagerStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDataProtectionManagerStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataProtectionManagerStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IDataProtectionManagerStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDataProtectionManagerStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IDataProtectionManagerStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ProtectAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
        HSTRING identity,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CBufferProtectUnprotectResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IDataProtectionManagerStatics,
                IBuffer,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, data, identity, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UnprotectAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CBufferProtectUnprotectResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IDataProtectionManagerStatics,
                IBuffer,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, data, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ProtectStreamAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")]
            IInputStream unprotectedStream,
        HSTRING identity,
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
            IOutputStream protectedStream,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IDataProtectionManagerStatics,
                IInputStream,
                HSTRING,
                IOutputStream,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, unprotectedStream, identity, protectedStream, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UnprotectStreamAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")]
            IInputStream protectedStream,
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
            IOutputStream unprotectedStream,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IDataProtectionManagerStatics,
                IInputStream,
                IOutputStream,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, protectedStream, unprotectedStream, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetProtectionInfoAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer protectedData,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IDataProtectionManagerStatics,
                IBuffer,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, protectedData, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStreamProtectionInfoAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")]
            IInputStream protectedStream,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IDataProtectionManagerStatics,
                IInputStream,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[11])
        )(this, protectedStream, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ProtectAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
            HSTRING identity,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CBufferProtectUnprotectResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(7)]
        HRESULT UnprotectAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer data,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CBufferProtectUnprotectResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(8)]
        HRESULT ProtectStreamAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")]
                IInputStream unprotectedStream,
            HSTRING identity,
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
                IOutputStream protectedStream,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(9)]
        HRESULT UnprotectStreamAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")]
                IInputStream protectedStream,
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
                IOutputStream unprotectedStream,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(10)]
        HRESULT GetProtectionInfoAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer protectedData,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(11)]
        HRESULT GetStreamProtectionInfoAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")]
                IInputStream protectedStream,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **"
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
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CBufferProtectUnprotectResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> ProtectAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CBufferProtectUnprotectResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, IAsyncOperation<IntPtr>**, int> UnprotectAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IInputStream *, HSTRING, ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInputStream,
            HSTRING,
            IOutputStream,
            IAsyncOperation<IntPtr>**,
            int> ProtectStreamAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInputStream,
            IOutputStream,
            IAsyncOperation<IntPtr>**,
            int> UnprotectStreamAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBuffer,
            IAsyncOperation<IntPtr>**,
            int> GetProtectionInfoAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSecurity__CEnterpriseData__CDataProtectionInfo_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInputStream,
            IAsyncOperation<IntPtr>**,
            int> GetStreamProtectionInfoAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataProtectionManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataProtectionManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDataProtectionManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDataProtectionManagerStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IDataProtectionManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataProtectionManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDataProtectionManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDataProtectionManagerStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataProtectionManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataProtectionManagerStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IDataProtectionManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataProtectionManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataProtectionManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataProtectionManagerStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
