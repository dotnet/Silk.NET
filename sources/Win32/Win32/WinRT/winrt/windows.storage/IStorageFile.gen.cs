// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FA3F6186-4214-428C-A64C-14C9AC7315EA")]
[NativeTypeName("struct IStorageFile : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageFile : IStorageFile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageFile));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageFile, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStorageFile, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageFile, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStorageFile, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStorageFile, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStorageFile, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FileType(HSTRING* value)
    {
        return ((delegate* unmanaged<IStorageFile, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ContentType(HSTRING* value)
    {
        return ((delegate* unmanaged<IStorageFile, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OpenAsync(
        [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IStorageFile, FileAccessMode, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, accessMode, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OpenTransactedWriteAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return ((delegate* unmanaged<IStorageFile, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[9]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CopyOverloadDefaultNameAndOptions(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")]
            IStorageFolder destinationFolder,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IStorageFile, IStorageFolder, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, destinationFolder, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CopyOverloadDefaultOptions(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")]
            IStorageFolder destinationFolder,
        HSTRING desiredNewName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFile,
                IStorageFolder,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[11])
        )(this, destinationFolder, desiredNewName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CopyOverload(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")]
            IStorageFolder destinationFolder,
        HSTRING desiredNewName,
        [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")] NameCollisionOption option,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFile,
                IStorageFolder,
                HSTRING,
                NameCollisionOption,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[12])
        )(this, destinationFolder, desiredNewName, option, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CopyAndReplaceAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile fileToReplace,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IStorageFile, IStorageFile, IAsyncAction*, int>)((*lpVtbl)[13])
        )(this, fileToReplace, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT MoveOverloadDefaultNameAndOptions(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")]
            IStorageFolder destinationFolder,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IStorageFile, IStorageFolder, IAsyncAction*, int>)((*lpVtbl)[14])
        )(this, destinationFolder, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT MoveOverloadDefaultOptions(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")]
            IStorageFolder destinationFolder,
        HSTRING desiredNewName,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IStorageFile, IStorageFolder, HSTRING, IAsyncAction*, int>)(
                (*lpVtbl)[15]
            )
        )(this, destinationFolder, desiredNewName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT MoveOverload(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")]
            IStorageFolder destinationFolder,
        HSTRING desiredNewName,
        [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")] NameCollisionOption option,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFile,
                IStorageFolder,
                HSTRING,
                NameCollisionOption,
                IAsyncAction*,
                int>)((*lpVtbl)[16])
        )(this, destinationFolder, desiredNewName, option, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT MoveAndReplaceAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile fileToReplace,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IStorageFile, IStorageFile, IAsyncAction*, int>)((*lpVtbl)[17])
        )(this, fileToReplace, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FileType(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ContentType(HSTRING* value);

        [VtblIndex(8)]
        HRESULT OpenAsync(
            [NativeTypeName("ABI::Windows::Storage::FileAccessMode")] FileAccessMode accessMode,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(9)]
        HRESULT OpenTransactedWriteAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(10)]
        HRESULT CopyOverloadDefaultNameAndOptions(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")]
                IStorageFolder destinationFolder,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(11)]
        HRESULT CopyOverloadDefaultOptions(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")]
                IStorageFolder destinationFolder,
            HSTRING desiredNewName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(12)]
        HRESULT CopyOverload(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")]
                IStorageFolder destinationFolder,
            HSTRING desiredNewName,
            [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")]
                NameCollisionOption option,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(13)]
        HRESULT CopyAndReplaceAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile fileToReplace,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(14)]
        HRESULT MoveOverloadDefaultNameAndOptions(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")]
                IStorageFolder destinationFolder,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(15)]
        HRESULT MoveOverloadDefaultOptions(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")]
                IStorageFolder destinationFolder,
            HSTRING desiredNewName,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(16)]
        HRESULT MoveOverload(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder *")]
                IStorageFolder destinationFolder,
            HSTRING desiredNewName,
            [NativeTypeName("ABI::Windows::Storage::NameCollisionOption")]
                NameCollisionOption option,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(17)]
        HRESULT MoveAndReplaceAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile fileToReplace,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_FileType;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ContentType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::FileAccessMode, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIRandomAccessStream_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            FileAccessMode,
            IAsyncOperation<IntPtr>**,
            int> OpenAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageStreamTransaction_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> OpenTransactedWriteAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFolder,
            IAsyncOperation<IntPtr>**,
            int> CopyOverloadDefaultNameAndOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFolder,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CopyOverloadDefaultOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder *, HSTRING, ABI::Windows::Storage::NameCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFolder,
            HSTRING,
            NameCollisionOption,
            IAsyncOperation<IntPtr>**,
            int> CopyOverload;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFile, IAsyncAction*, int> CopyAndReplaceAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFolder,
            IAsyncAction*,
            int> MoveOverloadDefaultNameAndOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFolder,
            HSTRING,
            IAsyncAction*,
            int> MoveOverloadDefaultOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder *, HSTRING, ABI::Windows::Storage::NameCollisionOption, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFolder,
            HSTRING,
            NameCollisionOption,
            IAsyncAction*,
            int> MoveOverload;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFile, IAsyncAction*, int> MoveAndReplaceAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageFile"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageFile(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageFile"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageFile(Silk.NET.WinRT.IInspectable value)
    {
        return new IStorageFile(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageFile"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageFile"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStorageFile value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageFile"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageFile(Silk.NET.Windows.IUnknown value)
    {
        return new IStorageFile(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageFile"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageFile"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorageFile value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
