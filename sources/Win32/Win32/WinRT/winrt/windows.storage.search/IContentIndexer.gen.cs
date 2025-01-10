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

[Guid("B1767F8D-F698-4982-B05F-3A6E8CAB01A2")]
[NativeTypeName("struct IContentIndexer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IContentIndexer : IContentIndexer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContentIndexer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContentIndexer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContentIndexer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContentIndexer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IContentIndexer, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IContentIndexer, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IContentIndexer, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddAsync(
        [NativeTypeName("ABI::Windows::Storage::Search::IIndexableContent *")]
            IIndexableContent indexableContent,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IContentIndexer, IIndexableContent, IAsyncAction*, int>)(
                (*lpVtbl)[6]
            )
        )(this, indexableContent, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UpdateAsync(
        [NativeTypeName("ABI::Windows::Storage::Search::IIndexableContent *")]
            IIndexableContent indexableContent,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IContentIndexer, IIndexableContent, IAsyncAction*, int>)(
                (*lpVtbl)[7]
            )
        )(this, indexableContent, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeleteAsync(
        HSTRING contentId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IContentIndexer, HSTRING, IAsyncAction*, int>)((*lpVtbl)[8]))(
            this,
            contentId,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DeleteMultipleAsync(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* contentIds,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IContentIndexer, IIterable<HSTRING>*, IAsyncAction*, int>)(
                (*lpVtbl)[9]
            )
        )(this, contentIds, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeleteAllAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IContentIndexer, IAsyncAction*, int>)((*lpVtbl)[10]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RetrievePropertiesAsync(
        HSTRING contentId,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* propertiesToRetrieve,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_IInspectable_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IContentIndexer,
                HSTRING,
                IIterable<HSTRING>*,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[11])
        )(this, contentId, propertiesToRetrieve, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Revision([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IContentIndexer, ulong*, int>)((*lpVtbl)[12]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT AddAsync(
            [NativeTypeName("ABI::Windows::Storage::Search::IIndexableContent *")]
                IIndexableContent indexableContent,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(7)]
        HRESULT UpdateAsync(
            [NativeTypeName("ABI::Windows::Storage::Search::IIndexableContent *")]
                IIndexableContent indexableContent,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(8)]
        HRESULT DeleteAsync(
            HSTRING contentId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(9)]
        HRESULT DeleteMultipleAsync(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* contentIds,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(10)]
        HRESULT DeleteAllAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(11)]
        HRESULT RetrievePropertiesAsync(
            HSTRING contentId,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* propertiesToRetrieve,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_IInspectable_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(12)]
        HRESULT get_Revision([NativeTypeName("UINT64 *")] ulong* value);
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
            "HRESULT (ABI::Windows::Storage::Search::IIndexableContent *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IIndexableContent, IAsyncAction*, int> AddAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::IIndexableContent *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IIndexableContent, IAsyncAction*, int> UpdateAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncAction*, int> DeleteAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IAsyncAction*,
            int> DeleteMultipleAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> DeleteAllAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_IInspectable_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IIterable<HSTRING>*,
            IAsyncOperation<IntPtr>**,
            int> RetrievePropertiesAsync;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_Revision;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContentIndexer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContentIndexer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IContentIndexer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IContentIndexer(Silk.NET.WinRT.IInspectable value)
    {
        return new IContentIndexer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContentIndexer"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IContentIndexer"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IContentIndexer value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContentIndexer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContentIndexer(Silk.NET.Windows.IUnknown value)
    {
        return new IContentIndexer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContentIndexer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContentIndexer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContentIndexer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
