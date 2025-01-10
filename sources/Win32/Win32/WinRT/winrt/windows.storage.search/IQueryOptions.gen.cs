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

[Guid("1E5E46EE-0F45-4838-A8E9-D0479D446C30")]
[NativeTypeName("struct IQueryOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IQueryOptions : IQueryOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQueryOptions));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IQueryOptions, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IQueryOptions, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IQueryOptions, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IQueryOptions, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IQueryOptions, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IQueryOptions, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FileTypeFilter(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IQueryOptions, IVector<HSTRING>**, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_FolderDepth(
        [NativeTypeName("ABI::Windows::Storage::Search::FolderDepth *")] FolderDepth* value
    )
    {
        return ((delegate* unmanaged<IQueryOptions, FolderDepth*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_FolderDepth(
        [NativeTypeName("ABI::Windows::Storage::Search::FolderDepth")] FolderDepth value
    )
    {
        return ((delegate* unmanaged<IQueryOptions, FolderDepth, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ApplicationSearchFilter(HSTRING* value)
    {
        return ((delegate* unmanaged<IQueryOptions, HSTRING*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ApplicationSearchFilter(HSTRING value)
    {
        return ((delegate* unmanaged<IQueryOptions, HSTRING, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_UserSearchFilter(HSTRING* value)
    {
        return ((delegate* unmanaged<IQueryOptions, HSTRING*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_UserSearchFilter(HSTRING value)
    {
        return ((delegate* unmanaged<IQueryOptions, HSTRING, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Language(HSTRING* value)
    {
        return ((delegate* unmanaged<IQueryOptions, HSTRING*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_Language(HSTRING value)
    {
        return ((delegate* unmanaged<IQueryOptions, HSTRING, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IndexerOption(
        [NativeTypeName("ABI::Windows::Storage::Search::IndexerOption *")] IndexerOption* value
    )
    {
        return ((delegate* unmanaged<IQueryOptions, IndexerOption*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_IndexerOption(
        [NativeTypeName("ABI::Windows::Storage::Search::IndexerOption")] IndexerOption value
    )
    {
        return ((delegate* unmanaged<IQueryOptions, IndexerOption, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_SortOrder(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CSearch__CSortEntry_t **"
        )]
            IVector<SortEntry>** value
    )
    {
        return ((delegate* unmanaged<IQueryOptions, IVector<SortEntry>**, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_GroupPropertyName(HSTRING* value)
    {
        return ((delegate* unmanaged<IQueryOptions, HSTRING*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_DateStackOption(
        [NativeTypeName("ABI::Windows::Storage::Search::DateStackOption *")] DateStackOption* value
    )
    {
        return ((delegate* unmanaged<IQueryOptions, DateStackOption*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SaveToString(HSTRING* value)
    {
        return ((delegate* unmanaged<IQueryOptions, HSTRING*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT LoadFromString(HSTRING value)
    {
        return ((delegate* unmanaged<IQueryOptions, HSTRING, int>)((*lpVtbl)[21]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetThumbnailPrefetch(
        [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")] ThumbnailMode mode,
        [NativeTypeName("UINT32")] uint requestedSize,
        [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailOptions")]
            ThumbnailOptions options
    )
    {
        return (
            (delegate* unmanaged<IQueryOptions, ThumbnailMode, uint, ThumbnailOptions, int>)(
                (*lpVtbl)[22]
            )
        )(this, mode, requestedSize, options);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetPropertyPrefetch(
        [NativeTypeName("ABI::Windows::Storage::FileProperties::PropertyPrefetchOptions")]
            PropertyPrefetchOptions options,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* propertiesToRetrieve
    )
    {
        return (
            (delegate* unmanaged<IQueryOptions, PropertyPrefetchOptions, IIterable<HSTRING>*, int>)(
                (*lpVtbl)[23]
            )
        )(this, options, propertiesToRetrieve);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FileTypeFilter(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
        );

        [VtblIndex(7)]
        HRESULT get_FolderDepth(
            [NativeTypeName("ABI::Windows::Storage::Search::FolderDepth *")] FolderDepth* value
        );

        [VtblIndex(8)]
        HRESULT put_FolderDepth(
            [NativeTypeName("ABI::Windows::Storage::Search::FolderDepth")] FolderDepth value
        );

        [VtblIndex(9)]
        HRESULT get_ApplicationSearchFilter(HSTRING* value);

        [VtblIndex(10)]
        HRESULT put_ApplicationSearchFilter(HSTRING value);

        [VtblIndex(11)]
        HRESULT get_UserSearchFilter(HSTRING* value);

        [VtblIndex(12)]
        HRESULT put_UserSearchFilter(HSTRING value);

        [VtblIndex(13)]
        HRESULT get_Language(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_Language(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_IndexerOption(
            [NativeTypeName("ABI::Windows::Storage::Search::IndexerOption *")] IndexerOption* value
        );

        [VtblIndex(16)]
        HRESULT put_IndexerOption(
            [NativeTypeName("ABI::Windows::Storage::Search::IndexerOption")] IndexerOption value
        );

        [VtblIndex(17)]
        HRESULT get_SortOrder(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CSearch__CSortEntry_t **"
            )]
                IVector<SortEntry>** value
        );

        [VtblIndex(18)]
        HRESULT get_GroupPropertyName(HSTRING* value);

        [VtblIndex(19)]
        HRESULT get_DateStackOption(
            [NativeTypeName("ABI::Windows::Storage::Search::DateStackOption *")]
                DateStackOption* value
        );

        [VtblIndex(20)]
        HRESULT SaveToString(HSTRING* value);

        [VtblIndex(21)]
        HRESULT LoadFromString(HSTRING value);

        [VtblIndex(22)]
        HRESULT SetThumbnailPrefetch(
            [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailMode")]
                ThumbnailMode mode,
            [NativeTypeName("UINT32")] uint requestedSize,
            [NativeTypeName("ABI::Windows::Storage::FileProperties::ThumbnailOptions")]
                ThumbnailOptions options
        );

        [VtblIndex(23)]
        HRESULT SetPropertyPrefetch(
            [NativeTypeName("ABI::Windows::Storage::FileProperties::PropertyPrefetchOptions")]
                PropertyPrefetchOptions options,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* propertiesToRetrieve
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_FileTypeFilter;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::FolderDepth *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FolderDepth*, int> get_FolderDepth;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::FolderDepth) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FolderDepth, int> put_FolderDepth;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ApplicationSearchFilter;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_ApplicationSearchFilter;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_UserSearchFilter;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_UserSearchFilter;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Language;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Language;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::IndexerOption *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IndexerOption*, int> get_IndexerOption;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::IndexerOption) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IndexerOption, int> put_IndexerOption;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CSearch__CSortEntry_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<SortEntry>**, int> get_SortOrder;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_GroupPropertyName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::DateStackOption *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DateStackOption*, int> get_DateStackOption;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> SaveToString;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> LoadFromString;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::FileProperties::ThumbnailMode, UINT32, ABI::Windows::Storage::FileProperties::ThumbnailOptions) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ThumbnailMode,
            uint,
            ThumbnailOptions,
            int> SetThumbnailPrefetch;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::FileProperties::PropertyPrefetchOptions, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PropertyPrefetchOptions,
            IIterable<HSTRING>*,
            int> SetPropertyPrefetch;
    }

    /// <summary>Initializes a new instance of the <see cref = "IQueryOptions"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IQueryOptions(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IQueryOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IQueryOptions(Silk.NET.WinRT.IInspectable value)
    {
        return new IQueryOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IQueryOptions"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IQueryOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IQueryOptions value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IQueryOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IQueryOptions(Silk.NET.Windows.IUnknown value)
    {
        return new IQueryOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IQueryOptions"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IQueryOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IQueryOptions value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
