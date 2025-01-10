// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2F907DB8-B40E-422B-8545-CB1910A61C52")]
[NativeTypeName("struct IPhoneCallHistoryStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPhoneCallHistoryStore : IPhoneCallHistoryStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPhoneCallHistoryStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPhoneCallHistoryStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPhoneCallHistoryStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPhoneCallHistoryStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPhoneCallHistoryStore, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPhoneCallHistoryStore, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPhoneCallHistoryStore, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetEntryAsync(
        HSTRING callHistoryEntryId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IPhoneCallHistoryStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, callHistoryEntryId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEntryReader(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryReader **")]
            IPhoneCallHistoryEntryReader* result
    )
    {
        return (
            (delegate* unmanaged<IPhoneCallHistoryStore, IPhoneCallHistoryEntryReader*, int>)(
                (*lpVtbl)[7]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetEntryReaderWithOptions(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryQueryOptions *"
        )]
            IPhoneCallHistoryEntryQueryOptions queryOptions,
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryReader **")]
            IPhoneCallHistoryEntryReader* result
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneCallHistoryStore,
                IPhoneCallHistoryEntryQueryOptions,
                IPhoneCallHistoryEntryReader*,
                int>)((*lpVtbl)[8])
        )(this, queryOptions, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SaveEntryAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *")]
            IPhoneCallHistoryEntry callHistoryEntry,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneCallHistoryStore,
                IPhoneCallHistoryEntry,
                IAsyncAction*,
                int>)((*lpVtbl)[9])
        )(this, callHistoryEntry, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeleteEntryAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *")]
            IPhoneCallHistoryEntry callHistoryEntry,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneCallHistoryStore,
                IPhoneCallHistoryEntry,
                IAsyncAction*,
                int>)((*lpVtbl)[10])
        )(this, callHistoryEntry, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteEntriesAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t *"
        )]
            IIterable<IntPtr>* callHistoryEntries,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<IPhoneCallHistoryStore, IIterable<IntPtr>*, IAsyncAction*, int>)(
                (*lpVtbl)[11]
            )
        )(this, callHistoryEntries, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT MarkEntryAsSeenAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *")]
            IPhoneCallHistoryEntry callHistoryEntry,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneCallHistoryStore,
                IPhoneCallHistoryEntry,
                IAsyncAction*,
                int>)((*lpVtbl)[12])
        )(this, callHistoryEntry, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT MarkEntriesAsSeenAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t *"
        )]
            IIterable<IntPtr>* callHistoryEntries,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<IPhoneCallHistoryStore, IIterable<IntPtr>*, IAsyncAction*, int>)(
                (*lpVtbl)[13]
            )
        )(this, callHistoryEntries, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetUnseenCountAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
            IAsyncOperation<uint>** result
    )
    {
        return (
            (delegate* unmanaged<IPhoneCallHistoryStore, IAsyncOperation<uint>**, int>)(
                (*lpVtbl)[14]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT MarkAllAsSeenAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return ((delegate* unmanaged<IPhoneCallHistoryStore, IAsyncAction*, int>)((*lpVtbl)[15]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetSourcesUnseenCountAsync(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* sourceIds,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
            IAsyncOperation<uint>** result
    )
    {
        return (
            (delegate* unmanaged<
                IPhoneCallHistoryStore,
                IIterable<HSTRING>*,
                IAsyncOperation<uint>**,
                int>)((*lpVtbl)[16])
        )(this, sourceIds, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT MarkSourcesAsSeenAsync(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* sourceIds,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<IPhoneCallHistoryStore, IIterable<HSTRING>*, IAsyncAction*, int>)(
                (*lpVtbl)[17]
            )
        )(this, sourceIds, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetEntryAsync(
            HSTRING callHistoryEntryId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(7)]
        HRESULT GetEntryReader(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryReader **"
            )]
                IPhoneCallHistoryEntryReader* result
        );

        [VtblIndex(8)]
        HRESULT GetEntryReaderWithOptions(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryQueryOptions *"
            )]
                IPhoneCallHistoryEntryQueryOptions queryOptions,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryReader **"
            )]
                IPhoneCallHistoryEntryReader* result
        );

        [VtblIndex(9)]
        HRESULT SaveEntryAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *")]
                IPhoneCallHistoryEntry callHistoryEntry,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(10)]
        HRESULT DeleteEntryAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *")]
                IPhoneCallHistoryEntry callHistoryEntry,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(11)]
        HRESULT DeleteEntriesAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t *"
            )]
                IIterable<IntPtr>* callHistoryEntries,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(12)]
        HRESULT MarkEntryAsSeenAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *")]
                IPhoneCallHistoryEntry callHistoryEntry,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(13)]
        HRESULT MarkEntriesAsSeenAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t *"
            )]
                IIterable<IntPtr>* callHistoryEntries,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(14)]
        HRESULT GetUnseenCountAsync(
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
                IAsyncOperation<uint>** result
        );

        [VtblIndex(15)]
        HRESULT MarkAllAsSeenAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(16)]
        HRESULT GetSourcesUnseenCountAsync(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* sourceIds,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
                IAsyncOperation<uint>** result
        );

        [VtblIndex(17)]
        HRESULT MarkSourcesAsSeenAsync(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* sourceIds,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetEntryAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPhoneCallHistoryEntryReader*, int> GetEntryReader;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryQueryOptions *, ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntryReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IPhoneCallHistoryEntryQueryOptions,
            IPhoneCallHistoryEntryReader*,
            int> GetEntryReaderWithOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IPhoneCallHistoryEntry,
            IAsyncAction*,
            int> SaveEntryAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IPhoneCallHistoryEntry,
            IAsyncAction*,
            int> DeleteEntryAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IAsyncAction*,
            int> DeleteEntriesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Calls::IPhoneCallHistoryEntry *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IPhoneCallHistoryEntry,
            IAsyncAction*,
            int> MarkEntryAsSeenAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CCalls__CPhoneCallHistoryEntry_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IAsyncAction*,
            int> MarkEntriesAsSeenAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<uint>**, int> GetUnseenCountAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> MarkAllAsSeenAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IAsyncOperation<uint>**,
            int> GetSourcesUnseenCountAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IAsyncAction*,
            int> MarkSourcesAsSeenAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPhoneCallHistoryStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPhoneCallHistoryStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPhoneCallHistoryStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPhoneCallHistoryStore(Silk.NET.WinRT.IInspectable value)
    {
        return new IPhoneCallHistoryStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneCallHistoryStore"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneCallHistoryStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPhoneCallHistoryStore value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPhoneCallHistoryStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPhoneCallHistoryStore(Silk.NET.Windows.IUnknown value)
    {
        return new IPhoneCallHistoryStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPhoneCallHistoryStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPhoneCallHistoryStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPhoneCallHistoryStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
