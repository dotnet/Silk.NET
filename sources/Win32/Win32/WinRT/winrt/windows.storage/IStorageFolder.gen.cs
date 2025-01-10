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

[Guid("72D1CB78-B3EF-4F75-A80B-6FD9DAE2944B")]
[NativeTypeName("struct IStorageFolder : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageFolder : IStorageFolder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageFolder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageFolder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStorageFolder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageFolder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStorageFolder, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStorageFolder, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStorageFolder, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFileAsyncOverloadDefaultOptions(
        HSTRING desiredName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IStorageFolder, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, desiredName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFileAsync(
        HSTRING desiredName,
        [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")]
            CreationCollisionOption options,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFolder,
                HSTRING,
                CreationCollisionOption,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, desiredName, options, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFolderAsyncOverloadDefaultOptions(
        HSTRING desiredName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IStorageFolder, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, desiredName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFolderAsync(
        HSTRING desiredName,
        [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")]
            CreationCollisionOption options,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFolder,
                HSTRING,
                CreationCollisionOption,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[9])
        )(this, desiredName, options, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFileAsync(
        HSTRING name,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IStorageFolder, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, name, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFolderAsync(
        HSTRING name,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IStorageFolder, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, name, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetItemAsync(
        HSTRING name,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CIStorageItem_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IStorageFolder, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[12]
            )
        )(this, name, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFilesAsyncOverloadDefaultOptionsStartAndCount(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IStorageFolder, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[13])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetFoldersAsyncOverloadDefaultOptionsStartAndCount(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IStorageFolder, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[14])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetItemsAsyncOverloadDefaultStartAndCount(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IStorageFolder, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[15])
        )(this, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFileAsyncOverloadDefaultOptions(
            HSTRING desiredName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT CreateFileAsync(
            HSTRING desiredName,
            [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")]
                CreationCollisionOption options,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(8)]
        HRESULT CreateFolderAsyncOverloadDefaultOptions(
            HSTRING desiredName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(9)]
        HRESULT CreateFolderAsync(
            HSTRING desiredName,
            [NativeTypeName("ABI::Windows::Storage::CreationCollisionOption")]
                CreationCollisionOption options,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(10)]
        HRESULT GetFileAsync(
            HSTRING name,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(11)]
        HRESULT GetFolderAsync(
            HSTRING name,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(12)]
        HRESULT GetItemAsync(
            HSTRING name,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CIStorageItem_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(13)]
        HRESULT GetFilesAsyncOverloadDefaultOptionsStartAndCount(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(14)]
        HRESULT GetFoldersAsyncOverloadDefaultOptionsStartAndCount(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(15)]
        HRESULT GetItemsAsyncOverloadDefaultStartAndCount(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **"
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateFileAsyncOverloadDefaultOptions;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::CreationCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            CreationCollisionOption,
            IAsyncOperation<IntPtr>**,
            int> CreateFileAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateFolderAsyncOverloadDefaultOptions;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::CreationCollisionOption, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            CreationCollisionOption,
            IAsyncOperation<IntPtr>**,
            int> CreateFolderAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetFileAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetFolderAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CIStorageItem_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetItemAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> GetFilesAsyncOverloadDefaultOptionsStartAndCount;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> GetFoldersAsyncOverloadDefaultOptionsStartAndCount;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IntPtr>**,
            int> GetItemsAsyncOverloadDefaultStartAndCount;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageFolder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageFolder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageFolder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageFolder(Silk.NET.WinRT.IInspectable value)
    {
        return new IStorageFolder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageFolder"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageFolder"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStorageFolder value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageFolder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageFolder(Silk.NET.Windows.IUnknown value)
    {
        return new IStorageFolder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageFolder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageFolder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorageFolder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
