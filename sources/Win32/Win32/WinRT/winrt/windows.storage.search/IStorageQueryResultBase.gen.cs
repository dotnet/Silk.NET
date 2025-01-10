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

[Guid("C297D70D-7353-47AB-BA58-8C61425DC54B")]
[NativeTypeName("struct IStorageQueryResultBase : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageQueryResultBase
    : IStorageQueryResultBase.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageQueryResultBase));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageQueryResultBase, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStorageQueryResultBase, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageQueryResultBase, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStorageQueryResultBase, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStorageQueryResultBase, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStorageQueryResultBase, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetItemCountAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
            IAsyncOperation<uint>** operation
    )
    {
        return (
            (delegate* unmanaged<IStorageQueryResultBase, IAsyncOperation<uint>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Folder(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* container
    )
    {
        return ((delegate* unmanaged<IStorageQueryResultBase, IStorageFolder*, int>)((*lpVtbl)[7]))(
            this,
            container
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_ContentsChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CSearch__CIStorageQueryResultBase_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* eventCookie
    )
    {
        return (
            (delegate* unmanaged<
                IStorageQueryResultBase,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, handler, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_ContentsChanged(EventRegistrationToken eventCookie)
    {
        return (
            (delegate* unmanaged<IStorageQueryResultBase, EventRegistrationToken, int>)(
                (*lpVtbl)[9]
            )
        )(this, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_OptionsChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CSearch__CIStorageQueryResultBase_IInspectable_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* changedHandler,
        EventRegistrationToken* eventCookie
    )
    {
        return (
            (delegate* unmanaged<
                IStorageQueryResultBase,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, changedHandler, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_OptionsChanged(EventRegistrationToken eventCookie)
    {
        return (
            (delegate* unmanaged<IStorageQueryResultBase, EventRegistrationToken, int>)(
                (*lpVtbl)[11]
            )
        )(this, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT FindStartIndexAsync(
        IInspectable value,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
            IAsyncOperation<uint>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IStorageQueryResultBase,
                IInspectable,
                IAsyncOperation<uint>**,
                int>)((*lpVtbl)[12])
        )(this, value, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCurrentQueryOptions(
        [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")] IQueryOptions* value
    )
    {
        return ((delegate* unmanaged<IStorageQueryResultBase, IQueryOptions*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ApplyNewQueryOptions(
        [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")]
            IQueryOptions newQueryOptions
    )
    {
        return ((delegate* unmanaged<IStorageQueryResultBase, IQueryOptions, int>)((*lpVtbl)[14]))(
            this,
            newQueryOptions
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetItemCountAsync(
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
                IAsyncOperation<uint>** operation
        );

        [VtblIndex(7)]
        HRESULT get_Folder(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* container
        );

        [VtblIndex(8)]
        HRESULT add_ContentsChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CSearch__CIStorageQueryResultBase_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* eventCookie
        );

        [VtblIndex(9)]
        HRESULT remove_ContentsChanged(EventRegistrationToken eventCookie);

        [VtblIndex(10)]
        HRESULT add_OptionsChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CSearch__CIStorageQueryResultBase_IInspectable_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* changedHandler,
            EventRegistrationToken* eventCookie
        );

        [VtblIndex(11)]
        HRESULT remove_OptionsChanged(EventRegistrationToken eventCookie);

        [VtblIndex(12)]
        HRESULT FindStartIndexAsync(
            IInspectable value,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
                IAsyncOperation<uint>** operation
        );

        [VtblIndex(13)]
        HRESULT GetCurrentQueryOptions(
            [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions **")] IQueryOptions* value
        );

        [VtblIndex(14)]
        HRESULT ApplyNewQueryOptions(
            [NativeTypeName("ABI::Windows::Storage::Search::IQueryOptions *")]
                IQueryOptions newQueryOptions
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
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<uint>**, int> GetItemCountAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_Folder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CSearch__CIStorageQueryResultBase_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ContentsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ContentsChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CStorage__CSearch__CIStorageQueryResultBase_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_OptionsChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_OptionsChanged;

        [NativeTypeName(
            "HRESULT (IInspectable *, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IInspectable,
            IAsyncOperation<uint>**,
            int> FindStartIndexAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::IQueryOptions **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IQueryOptions*, int> GetCurrentQueryOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Search::IQueryOptions *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IQueryOptions, int> ApplyNewQueryOptions;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageQueryResultBase"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageQueryResultBase(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageQueryResultBase"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageQueryResultBase(Silk.NET.WinRT.IInspectable value)
    {
        return new IStorageQueryResultBase(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageQueryResultBase"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageQueryResultBase"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStorageQueryResultBase value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageQueryResultBase"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageQueryResultBase(Silk.NET.Windows.IUnknown value)
    {
        return new IStorageQueryResultBase(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageQueryResultBase"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageQueryResultBase"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorageQueryResultBase value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
