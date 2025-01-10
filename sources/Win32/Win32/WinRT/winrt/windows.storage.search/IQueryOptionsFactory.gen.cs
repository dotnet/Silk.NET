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

[Guid("032E1F8C-A9C1-4E71-8011-0DEE9D4811A3")]
[NativeTypeName("struct IQueryOptionsFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IQueryOptionsFactory : IQueryOptionsFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQueryOptionsFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IQueryOptionsFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IQueryOptionsFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IQueryOptionsFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IQueryOptionsFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IQueryOptionsFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IQueryOptionsFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateCommonFileQuery(
        [NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")] CommonFileQuery query,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* fileTypeFilter,
        [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")]
            IQueryOptions* queryOptions
    )
    {
        return (
            (delegate* unmanaged<
                IQueryOptionsFactory,
                CommonFileQuery,
                IIterable<HSTRING>*,
                IQueryOptions*,
                int>)((*lpVtbl)[6])
        )(this, query, fileTypeFilter, queryOptions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateCommonFolderQuery(
        [NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")]
            CommonFolderQuery query,
        [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")]
            IQueryOptions* queryOptions
    )
    {
        return (
            (delegate* unmanaged<IQueryOptionsFactory, CommonFolderQuery, IQueryOptions*, int>)(
                (*lpVtbl)[7]
            )
        )(this, query, queryOptions);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateCommonFileQuery(
            [NativeTypeName("ABI::Windows::Storage::Search::CommonFileQuery")]
                CommonFileQuery query,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* fileTypeFilter,
            [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")]
                IQueryOptions* queryOptions
        );

        [VtblIndex(7)]
        HRESULT CreateCommonFolderQuery(
            [NativeTypeName("ABI::Windows::Storage::Search::CommonFolderQuery")]
                CommonFolderQuery query,
            [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")]
                IQueryOptions* queryOptions
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
            "HRESULT (ABI::Windows::Storage::Search::CommonFileQuery, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Search::IQueryOptions **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CommonFileQuery,
            IIterable<HSTRING>*,
            IQueryOptions*,
            int> CreateCommonFileQuery;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::CommonFolderQuery, ABI::Windows::Storage::Search::IQueryOptions **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CommonFolderQuery,
            IQueryOptions*,
            int> CreateCommonFolderQuery;
    }

    /// <summary>Initializes a new instance of the <see cref = "IQueryOptionsFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IQueryOptionsFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IQueryOptionsFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IQueryOptionsFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new IQueryOptionsFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IQueryOptionsFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IQueryOptionsFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IQueryOptionsFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IQueryOptionsFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IQueryOptionsFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IQueryOptionsFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IQueryOptionsFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IQueryOptionsFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IQueryOptionsFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
