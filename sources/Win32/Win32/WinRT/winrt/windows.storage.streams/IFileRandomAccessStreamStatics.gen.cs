// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("73550107-3B57-4B5D-8345-554D2FC621F0")]
[NativeTypeName("struct IFileRandomAccessStreamStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileRandomAccessStreamStatics
    : IFileRandomAccessStreamStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileRandomAccessStreamStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IFileRandomAccessStreamStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileRandomAccessStreamStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileRandomAccessStreamStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IFileRandomAccessStreamStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFileRandomAccessStreamStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IFileRandomAccessStreamStatics, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OpenAsync(
        HSTRING filePath,
        [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IFileRandomAccessStreamStatics,
                HSTRING,
                FileAccessMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, filePath, accessMode, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OpenWithOptionsAsync(
        HSTRING filePath,
        [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode,
        [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")]
            StorageOpenOptions sharingOptions,
        [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")]
            FileOpenDisposition openDisposition,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IFileRandomAccessStreamStatics,
                HSTRING,
                FileAccessMode,
                StorageOpenOptions,
                FileOpenDisposition,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, filePath, accessMode, sharingOptions, openDisposition, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OpenTransactedWriteAsync(
        HSTRING filePath,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IFileRandomAccessStreamStatics,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, filePath, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OpenTransactedWriteWithOptionsAsync(
        HSTRING filePath,
        [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")]
            StorageOpenOptions openOptions,
        [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")]
            FileOpenDisposition openDisposition,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IFileRandomAccessStreamStatics,
                HSTRING,
                StorageOpenOptions,
                FileOpenDisposition,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, filePath, openOptions, openDisposition, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OpenForUserAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        HSTRING filePath,
        [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IFileRandomAccessStreamStatics,
                IUser,
                HSTRING,
                FileAccessMode,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[10])
        )(this, user, filePath, accessMode, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT OpenForUserWithOptionsAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        HSTRING filePath,
        [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode,
        [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")]
            StorageOpenOptions sharingOptions,
        [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")]
            FileOpenDisposition openDisposition,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IFileRandomAccessStreamStatics,
                IUser,
                HSTRING,
                FileAccessMode,
                StorageOpenOptions,
                FileOpenDisposition,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[11])
        )(this, user, filePath, accessMode, sharingOptions, openDisposition, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT OpenTransactedWriteForUserAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        HSTRING filePath,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IFileRandomAccessStreamStatics,
                IUser,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[12])
        )(this, user, filePath, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT OpenTransactedWriteForUserWithOptionsAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        HSTRING filePath,
        [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")]
            StorageOpenOptions openOptions,
        [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")]
            FileOpenDisposition openDisposition,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IFileRandomAccessStreamStatics,
                IUser,
                HSTRING,
                StorageOpenOptions,
                FileOpenDisposition,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[13])
        )(this, user, filePath, openOptions, openDisposition, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT OpenAsync(
            HSTRING filePath,
            [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT OpenWithOptionsAsync(
            HSTRING filePath,
            [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode,
            [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")]
                StorageOpenOptions sharingOptions,
            [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")]
                FileOpenDisposition openDisposition,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(8)]
        HRESULT OpenTransactedWriteAsync(
            HSTRING filePath,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(9)]
        HRESULT OpenTransactedWriteWithOptionsAsync(
            HSTRING filePath,
            [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")]
                StorageOpenOptions openOptions,
            [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")]
                FileOpenDisposition openDisposition,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(10)]
        HRESULT OpenForUserAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            HSTRING filePath,
            [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(11)]
        HRESULT OpenForUserWithOptionsAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            HSTRING filePath,
            [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode,
            [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")]
                StorageOpenOptions sharingOptions,
            [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")]
                FileOpenDisposition openDisposition,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(12)]
        HRESULT OpenTransactedWriteForUserAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            HSTRING filePath,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(13)]
        HRESULT OpenTransactedWriteForUserWithOptionsAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            HSTRING filePath,
            [NativeTypeName("ABI::Windows::Storage::StorageOpenOptions")]
                StorageOpenOptions openOptions,
            [NativeTypeName("ABI::Windows::Storage::Streams::FileOpenDisposition")]
                FileOpenDisposition openDisposition,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **"
            )]
                IAsyncOperation<IntPtr>** operation
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
            "HRESULT (HSTRING, ABI::Windows::Storage::FileAccessMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            FileAccessMode,
            IAsyncOperation<IntPtr>**,
            int> OpenAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::FileAccessMode, ABI::Windows::Storage::StorageOpenOptions, ABI::Windows::Storage::Streams::FileOpenDisposition, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            FileAccessMode,
            StorageOpenOptions,
            FileOpenDisposition,
            IAsyncOperation<IntPtr>**,
            int> OpenWithOptionsAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> OpenTransactedWriteAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::StorageOpenOptions, ABI::Windows::Storage::Streams::FileOpenDisposition, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            StorageOpenOptions,
            FileOpenDisposition,
            IAsyncOperation<IntPtr>**,
            int> OpenTransactedWriteWithOptionsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Storage::FileAccessMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            HSTRING,
            FileAccessMode,
            IAsyncOperation<IntPtr>**,
            int> OpenForUserAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Storage::FileAccessMode, ABI::Windows::Storage::StorageOpenOptions, ABI::Windows::Storage::Streams::FileOpenDisposition, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            HSTRING,
            FileAccessMode,
            StorageOpenOptions,
            FileOpenDisposition,
            IAsyncOperation<IntPtr>**,
            int> OpenForUserWithOptionsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> OpenTransactedWriteForUserAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::Storage::StorageOpenOptions, ABI::Windows::Storage::Streams::FileOpenDisposition, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            HSTRING,
            StorageOpenOptions,
            FileOpenDisposition,
            IAsyncOperation<IntPtr>**,
            int> OpenTransactedWriteForUserWithOptionsAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileRandomAccessStreamStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileRandomAccessStreamStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFileRandomAccessStreamStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFileRandomAccessStreamStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IFileRandomAccessStreamStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileRandomAccessStreamStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFileRandomAccessStreamStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IFileRandomAccessStreamStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileRandomAccessStreamStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileRandomAccessStreamStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IFileRandomAccessStreamStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileRandomAccessStreamStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileRandomAccessStreamStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileRandomAccessStreamStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
