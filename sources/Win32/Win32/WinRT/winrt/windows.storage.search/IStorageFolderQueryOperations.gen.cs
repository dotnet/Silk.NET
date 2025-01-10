// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("CB43CCC9-446B-4A4F-BE97-757771BE5203")]
[NativeTypeName("struct IStorageFolderQueryOperations : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageFolderQueryOperations
    : IStorageFolderQueryOperations.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageFolderQueryOperations));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IStorageFolderQueryOperations, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IStorageFolderQueryOperations, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageFolderQueryOperations, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IStorageFolderQueryOperations, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStorageFolderQueryOperations, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IStorageFolderQueryOperations, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetIndexedStateAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CSearch__CIndexedState_t **"
        )]
            IAsyncOperation<IndexedState>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFolderQueryOperations,
                IAsyncOperation<IndexedState>**,
                int>)((*lpVtbl)[6])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFileQueryOverloadDefault(
        [NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")]
            IStorageFileQueryResult* value
    )
    {
        return (
            (delegate* unmanaged<IStorageFolderQueryOperations, IStorageFileQueryResult*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateFileQuery(
        [NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query,
        [NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")]
            IStorageFileQueryResult* value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFolderQueryOperations,
                CommonFileQuery,
                IStorageFileQueryResult*,
                int>)((*lpVtbl)[8])
        )(this, query, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFileQueryWithOptions(
        [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")]
            IQueryOptions queryOptions,
        [NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")]
            IStorageFileQueryResult* value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFolderQueryOperations,
                IQueryOptions,
                IStorageFileQueryResult*,
                int>)((*lpVtbl)[9])
        )(this, queryOptions, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateFolderQueryOverloadDefault(
        [NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")]
            IStorageFolderQueryResult* value
    )
    {
        return (
            (delegate* unmanaged<IStorageFolderQueryOperations, IStorageFolderQueryResult*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateFolderQuery(
        [NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")]
            CommonFolderQuery query,
        [NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")]
            IStorageFolderQueryResult* value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFolderQueryOperations,
                CommonFolderQuery,
                IStorageFolderQueryResult*,
                int>)((*lpVtbl)[11])
        )(this, query, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateFolderQueryWithOptions(
        [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")]
            IQueryOptions queryOptions,
        [NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")]
            IStorageFolderQueryResult* value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFolderQueryOperations,
                IQueryOptions,
                IStorageFolderQueryResult*,
                int>)((*lpVtbl)[12])
        )(this, queryOptions, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateItemQuery(
        [NativeTypeName("ABI::Windows::Storage::Search::IStorageItemQueryResult **")]
            IStorageItemQueryResult* value
    )
    {
        return (
            (delegate* unmanaged<IStorageFolderQueryOperations, IStorageItemQueryResult*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateItemQueryWithOptions(
        [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")]
            IQueryOptions queryOptions,
        [NativeTypeName("ABI::Windows::Storage::Search::IStorageItemQueryResult **")]
            IStorageItemQueryResult* value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFolderQueryOperations,
                IQueryOptions,
                IStorageItemQueryResult*,
                int>)((*lpVtbl)[14])
        )(this, queryOptions, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetFilesAsync(
        [NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query,
        [NativeTypeName("UINT32")] uint startIndex,
        [NativeTypeName("UINT32")] uint maxItemsToRetrieve,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFolderQueryOperations,
                CommonFileQuery,
                uint,
                uint,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[15])
        )(this, query, startIndex, maxItemsToRetrieve, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetFilesAsyncOverloadDefaultStartAndCount(
        [NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFolderQueryOperations,
                CommonFileQuery,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[16])
        )(this, query, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetFoldersAsync(
        [NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")]
            CommonFolderQuery query,
        [NativeTypeName("UINT32")] uint startIndex,
        [NativeTypeName("UINT32")] uint maxItemsToRetrieve,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFolderQueryOperations,
                CommonFolderQuery,
                uint,
                uint,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[17])
        )(this, query, startIndex, maxItemsToRetrieve, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetFoldersAsyncOverloadDefaultStartAndCount(
        [NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")]
            CommonFolderQuery query,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFolderQueryOperations,
                CommonFolderQuery,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[18])
        )(this, query, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetItemsAsync(
        [NativeTypeName("UINT32")] uint startIndex,
        [NativeTypeName("UINT32")] uint maxItemsToRetrieve,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageFolderQueryOperations,
                uint,
                uint,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[19])
        )(this, startIndex, maxItemsToRetrieve, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AreQueryOptionsSupported(
        [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")]
            IQueryOptions queryOptions,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return (
            (delegate* unmanaged<IStorageFolderQueryOperations, IQueryOptions, byte*, int>)(
                (*lpVtbl)[20]
            )
        )(this, queryOptions, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT IsCommonFolderQuerySupported(
        [NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")]
            CommonFolderQuery query,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return (
            (delegate* unmanaged<IStorageFolderQueryOperations, CommonFolderQuery, byte*, int>)(
                (*lpVtbl)[21]
            )
        )(this, query, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT IsCommonFileQuerySupported(
        [NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query,
        [NativeTypeName("boolean *")] byte* value
    )
    {
        return (
            (delegate* unmanaged<IStorageFolderQueryOperations, CommonFileQuery, byte*, int>)(
                (*lpVtbl)[22]
            )
        )(this, query, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetIndexedStateAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CSearch__CIndexedState_t **"
            )]
                IAsyncOperation<IndexedState>** operation
        );

        [VtblIndex(7)]
        HRESULT CreateFileQueryOverloadDefault(
            [NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")]
                IStorageFileQueryResult* value
        );

        [VtblIndex(8)]
        HRESULT CreateFileQuery(
            [NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")]
                CommonFileQuery query,
            [NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")]
                IStorageFileQueryResult* value
        );

        [VtblIndex(9)]
        HRESULT CreateFileQueryWithOptions(
            [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")]
                IQueryOptions queryOptions,
            [NativeTypeName("ABI::Windows::Storage::Search::IStorageFileQueryResult **")]
                IStorageFileQueryResult* value
        );

        [VtblIndex(10)]
        HRESULT CreateFolderQueryOverloadDefault(
            [NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")]
                IStorageFolderQueryResult* value
        );

        [VtblIndex(11)]
        HRESULT CreateFolderQuery(
            [NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")]
                CommonFolderQuery query,
            [NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")]
                IStorageFolderQueryResult* value
        );

        [VtblIndex(12)]
        HRESULT CreateFolderQueryWithOptions(
            [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")]
                IQueryOptions queryOptions,
            [NativeTypeName("ABI::Windows::Storage::Search::IStorageFolderQueryResult **")]
                IStorageFolderQueryResult* value
        );

        [VtblIndex(13)]
        HRESULT CreateItemQuery(
            [NativeTypeName("ABI::Windows::Storage::Search::IStorageItemQueryResult **")]
                IStorageItemQueryResult* value
        );

        [VtblIndex(14)]
        HRESULT CreateItemQueryWithOptions(
            [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")]
                IQueryOptions queryOptions,
            [NativeTypeName("ABI::Windows::Storage::Search::IStorageItemQueryResult **")]
                IStorageItemQueryResult* value
        );

        [VtblIndex(15)]
        HRESULT GetFilesAsync(
            [NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")]
                CommonFileQuery query,
            [NativeTypeName("UINT32")] uint startIndex,
            [NativeTypeName("UINT32")] uint maxItemsToRetrieve,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(16)]
        HRESULT GetFilesAsyncOverloadDefaultStartAndCount(
            [NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")]
                CommonFileQuery query,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(17)]
        HRESULT GetFoldersAsync(
            [NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")]
                CommonFolderQuery query,
            [NativeTypeName("UINT32")] uint startIndex,
            [NativeTypeName("UINT32")] uint maxItemsToRetrieve,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(18)]
        HRESULT GetFoldersAsyncOverloadDefaultStartAndCount(
            [NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")]
                CommonFolderQuery query,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(19)]
        HRESULT GetItemsAsync(
            [NativeTypeName("UINT32")] uint startIndex,
            [NativeTypeName("UINT32")] uint maxItemsToRetrieve,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(20)]
        HRESULT AreQueryOptionsSupported(
            [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")]
                IQueryOptions queryOptions,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(21)]
        HRESULT IsCommonFolderQuerySupported(
            [NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")]
                CommonFolderQuery query,
            [NativeTypeName("boolean *")] byte* value
        );

        [VtblIndex(22)]
        HRESULT IsCommonFileQuerySupported(
            [NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")]
                CommonFileQuery query,
            [NativeTypeName("boolean *")] byte* value
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
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CSearch__CIndexedState_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<IndexedState>**,
            int> GetIndexedStateAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::IStorageFileQueryResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFileQueryResult*,
            int> CreateFileQueryOverloadDefault;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::CommonFileQuery, ABI::Windows::Storage::Search::IStorageFileQueryResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CommonFileQuery,
            IStorageFileQueryResult*,
            int> CreateFileQuery;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::IQueryOptions *, ABI::Windows::Storage::Search::IStorageFileQueryResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IQueryOptions,
            IStorageFileQueryResult*,
            int> CreateFileQueryWithOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::IStorageFolderQueryResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFolderQueryResult*,
            int> CreateFolderQueryOverloadDefault;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::CommonFolderQuery, ABI::Windows::Storage::Search::IStorageFolderQueryResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CommonFolderQuery,
            IStorageFolderQueryResult*,
            int> CreateFolderQuery;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::IQueryOptions *, ABI::Windows::Storage::Search::IStorageFolderQueryResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IQueryOptions,
            IStorageFolderQueryResult*,
            int> CreateFolderQueryWithOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::IStorageItemQueryResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageItemQueryResult*, int> CreateItemQuery;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::IQueryOptions *, ABI::Windows::Storage::Search::IStorageItemQueryResult **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IQueryOptions,
            IStorageItemQueryResult*,
            int> CreateItemQueryWithOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::CommonFileQuery, UINT32, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CommonFileQuery,
            uint,
            uint,
            IAsyncOperation<IntPtr>**,
            int> GetFilesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::CommonFileQuery, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFile_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CommonFileQuery,
            IAsyncOperation<IntPtr>**,
            int> GetFilesAsyncOverloadDefaultStartAndCount;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::CommonFolderQuery, UINT32, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CommonFolderQuery,
            uint,
            uint,
            IAsyncOperation<IntPtr>**,
            int> GetFoldersAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::CommonFolderQuery, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CStorageFolder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CommonFolderQuery,
            IAsyncOperation<IntPtr>**,
            int> GetFoldersAsyncOverloadDefaultStartAndCount;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CStorage__CIStorageItem_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            IAsyncOperation<IntPtr>**,
            int> GetItemsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::IQueryOptions *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IQueryOptions, byte*, int> AreQueryOptionsSupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::CommonFolderQuery, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CommonFolderQuery,
            byte*,
            int> IsCommonFolderQuerySupported;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::CommonFileQuery, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CommonFileQuery, byte*, int> IsCommonFileQuerySupported;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageFolderQueryOperations"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageFolderQueryOperations(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageFolderQueryOperations"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageFolderQueryOperations(Silk.NET.WinRT.IInspectable value)
    {
        return new IStorageFolderQueryOperations(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageFolderQueryOperations"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageFolderQueryOperations"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStorageFolderQueryOperations value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageFolderQueryOperations"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageFolderQueryOperations(Silk.NET.Windows.IUnknown value)
    {
        return new IStorageFolderQueryOperations(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageFolderQueryOperations"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageFolderQueryOperations"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorageFolderQueryOperations value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
