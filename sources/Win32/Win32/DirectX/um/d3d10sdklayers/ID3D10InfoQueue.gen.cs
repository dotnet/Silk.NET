// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10sdklayers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("1B940B17-2642-4D1F-AB1F-B99BAD0C395F")]
[NativeTypeName("struct ID3D10InfoQueue : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D10InfoQueue : ID3D10InfoQueue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10InfoQueue));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D10InfoQueue, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMessageCountLimit([NativeTypeName("UINT64")] ulong MessageCountLimit)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, ulong, int>)((*lpVtbl)[3]))(
            this,
            MessageCountLimit
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void ClearStoredMessages()
    {
        ((delegate* unmanaged<ID3D10InfoQueue, void>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMessageW(
        [NativeTypeName("UINT64")] ulong MessageIndex,
        D3D10_MESSAGE* pMessage,
        [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength
    )
    {
        return (
            (delegate* unmanaged<ID3D10InfoQueue, ulong, D3D10_MESSAGE*, nuint*, int>)((*lpVtbl)[5])
        )(this, MessageIndex, pMessage, pMessageByteLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesAllowedByStorageFilter()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, ulong>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesDeniedByStorageFilter()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, ulong>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumStoredMessages()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, ulong>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumStoredMessagesAllowedByRetrievalFilter()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, ulong>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesDiscardedByMessageCountLimit()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, ulong>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("UINT64")]
    public ulong GetMessageCountLimit()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, ulong>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddStorageFilterEntries(D3D10_INFO_QUEUE_FILTER* pFilter)
    {
        return (
            (delegate* unmanaged<ID3D10InfoQueue, D3D10_INFO_QUEUE_FILTER*, int>)((*lpVtbl)[12])
        )(this, pFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetStorageFilter(
        D3D10_INFO_QUEUE_FILTER* pFilter,
        [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength
    )
    {
        return (
            (delegate* unmanaged<ID3D10InfoQueue, D3D10_INFO_QUEUE_FILTER*, nuint*, int>)(
                (*lpVtbl)[13]
            )
        )(this, pFilter, pFilterByteLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void ClearStorageFilter()
    {
        ((delegate* unmanaged<ID3D10InfoQueue, void>)((*lpVtbl)[14]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT PushEmptyStorageFilter()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT PushCopyOfStorageFilter()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT PushStorageFilter(D3D10_INFO_QUEUE_FILTER* pFilter)
    {
        return (
            (delegate* unmanaged<ID3D10InfoQueue, D3D10_INFO_QUEUE_FILTER*, int>)((*lpVtbl)[17])
        )(this, pFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void PopStorageFilter()
    {
        ((delegate* unmanaged<ID3D10InfoQueue, void>)((*lpVtbl)[18]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public uint GetStorageFilterStackSize()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, uint>)((*lpVtbl)[19]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AddRetrievalFilterEntries(D3D10_INFO_QUEUE_FILTER* pFilter)
    {
        return (
            (delegate* unmanaged<ID3D10InfoQueue, D3D10_INFO_QUEUE_FILTER*, int>)((*lpVtbl)[20])
        )(this, pFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetRetrievalFilter(
        D3D10_INFO_QUEUE_FILTER* pFilter,
        [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength
    )
    {
        return (
            (delegate* unmanaged<ID3D10InfoQueue, D3D10_INFO_QUEUE_FILTER*, nuint*, int>)(
                (*lpVtbl)[21]
            )
        )(this, pFilter, pFilterByteLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void ClearRetrievalFilter()
    {
        ((delegate* unmanaged<ID3D10InfoQueue, void>)((*lpVtbl)[22]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT PushEmptyRetrievalFilter()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, int>)((*lpVtbl)[23]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT PushCopyOfRetrievalFilter()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, int>)((*lpVtbl)[24]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PushRetrievalFilter(D3D10_INFO_QUEUE_FILTER* pFilter)
    {
        return (
            (delegate* unmanaged<ID3D10InfoQueue, D3D10_INFO_QUEUE_FILTER*, int>)((*lpVtbl)[25])
        )(this, pFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public void PopRetrievalFilter()
    {
        ((delegate* unmanaged<ID3D10InfoQueue, void>)((*lpVtbl)[26]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public uint GetRetrievalFilterStackSize()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, uint>)((*lpVtbl)[27]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT AddMessage(
        D3D10_MESSAGE_CATEGORY Category,
        D3D10_MESSAGE_SEVERITY Severity,
        D3D10_MESSAGE_ID ID,
        [NativeTypeName("LPCSTR")] sbyte* pDescription
    )
    {
        return (
            (delegate* unmanaged<
                ID3D10InfoQueue,
                D3D10_MESSAGE_CATEGORY,
                D3D10_MESSAGE_SEVERITY,
                D3D10_MESSAGE_ID,
                sbyte*,
                int>)((*lpVtbl)[28])
        )(this, Category, Severity, ID, pDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT AddApplicationMessage(
        D3D10_MESSAGE_SEVERITY Severity,
        [NativeTypeName("LPCSTR")] sbyte* pDescription
    )
    {
        return (
            (delegate* unmanaged<ID3D10InfoQueue, D3D10_MESSAGE_SEVERITY, sbyte*, int>)(
                (*lpVtbl)[29]
            )
        )(this, Severity, pDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetBreakOnCategory(D3D10_MESSAGE_CATEGORY Category, BOOL bEnable)
    {
        return (
            (delegate* unmanaged<ID3D10InfoQueue, D3D10_MESSAGE_CATEGORY, BOOL, int>)((*lpVtbl)[30])
        )(this, Category, bEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetBreakOnSeverity(D3D10_MESSAGE_SEVERITY Severity, BOOL bEnable)
    {
        return (
            (delegate* unmanaged<ID3D10InfoQueue, D3D10_MESSAGE_SEVERITY, BOOL, int>)((*lpVtbl)[31])
        )(this, Severity, bEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT SetBreakOnID(D3D10_MESSAGE_ID ID, BOOL bEnable)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, D3D10_MESSAGE_ID, BOOL, int>)((*lpVtbl)[32]))(
            this,
            ID,
            bEnable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public BOOL GetBreakOnCategory(D3D10_MESSAGE_CATEGORY Category)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, D3D10_MESSAGE_CATEGORY, int>)((*lpVtbl)[33]))(
            this,
            Category
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public BOOL GetBreakOnSeverity(D3D10_MESSAGE_SEVERITY Severity)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, D3D10_MESSAGE_SEVERITY, int>)((*lpVtbl)[34]))(
            this,
            Severity
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public BOOL GetBreakOnID(D3D10_MESSAGE_ID ID)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, D3D10_MESSAGE_ID, int>)((*lpVtbl)[35]))(
            this,
            ID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void SetMuteDebugOutput(BOOL bMute)
    {
        ((delegate* unmanaged<ID3D10InfoQueue, BOOL, void>)((*lpVtbl)[36]))(this, bMute);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public BOOL GetMuteDebugOutput()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue, int>)((*lpVtbl)[37]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetMessageCountLimit([NativeTypeName("UINT64")] ulong MessageCountLimit);

        [VtblIndex(4)]
        void ClearStoredMessages();

        [VtblIndex(5)]
        HRESULT GetMessageW(
            [NativeTypeName("UINT64")] ulong MessageIndex,
            D3D10_MESSAGE* pMessage,
            [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength
        );

        [VtblIndex(6)]
        [return: NativeTypeName("UINT64")]
        ulong GetNumMessagesAllowedByStorageFilter();

        [VtblIndex(7)]
        [return: NativeTypeName("UINT64")]
        ulong GetNumMessagesDeniedByStorageFilter();

        [VtblIndex(8)]
        [return: NativeTypeName("UINT64")]
        ulong GetNumStoredMessages();

        [VtblIndex(9)]
        [return: NativeTypeName("UINT64")]
        ulong GetNumStoredMessagesAllowedByRetrievalFilter();

        [VtblIndex(10)]
        [return: NativeTypeName("UINT64")]
        ulong GetNumMessagesDiscardedByMessageCountLimit();

        [VtblIndex(11)]
        [return: NativeTypeName("UINT64")]
        ulong GetMessageCountLimit();

        [VtblIndex(12)]
        HRESULT AddStorageFilterEntries(D3D10_INFO_QUEUE_FILTER* pFilter);

        [VtblIndex(13)]
        HRESULT GetStorageFilter(
            D3D10_INFO_QUEUE_FILTER* pFilter,
            [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength
        );

        [VtblIndex(14)]
        void ClearStorageFilter();

        [VtblIndex(15)]
        HRESULT PushEmptyStorageFilter();

        [VtblIndex(16)]
        HRESULT PushCopyOfStorageFilter();

        [VtblIndex(17)]
        HRESULT PushStorageFilter(D3D10_INFO_QUEUE_FILTER* pFilter);

        [VtblIndex(18)]
        void PopStorageFilter();

        [VtblIndex(19)]
        uint GetStorageFilterStackSize();

        [VtblIndex(20)]
        HRESULT AddRetrievalFilterEntries(D3D10_INFO_QUEUE_FILTER* pFilter);

        [VtblIndex(21)]
        HRESULT GetRetrievalFilter(
            D3D10_INFO_QUEUE_FILTER* pFilter,
            [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength
        );

        [VtblIndex(22)]
        void ClearRetrievalFilter();

        [VtblIndex(23)]
        HRESULT PushEmptyRetrievalFilter();

        [VtblIndex(24)]
        HRESULT PushCopyOfRetrievalFilter();

        [VtblIndex(25)]
        HRESULT PushRetrievalFilter(D3D10_INFO_QUEUE_FILTER* pFilter);

        [VtblIndex(26)]
        void PopRetrievalFilter();

        [VtblIndex(27)]
        uint GetRetrievalFilterStackSize();

        [VtblIndex(28)]
        HRESULT AddMessage(
            D3D10_MESSAGE_CATEGORY Category,
            D3D10_MESSAGE_SEVERITY Severity,
            D3D10_MESSAGE_ID ID,
            [NativeTypeName("LPCSTR")] sbyte* pDescription
        );

        [VtblIndex(29)]
        HRESULT AddApplicationMessage(
            D3D10_MESSAGE_SEVERITY Severity,
            [NativeTypeName("LPCSTR")] sbyte* pDescription
        );

        [VtblIndex(30)]
        HRESULT SetBreakOnCategory(D3D10_MESSAGE_CATEGORY Category, BOOL bEnable);

        [VtblIndex(31)]
        HRESULT SetBreakOnSeverity(D3D10_MESSAGE_SEVERITY Severity, BOOL bEnable);

        [VtblIndex(32)]
        HRESULT SetBreakOnID(D3D10_MESSAGE_ID ID, BOOL bEnable);

        [VtblIndex(33)]
        BOOL GetBreakOnCategory(D3D10_MESSAGE_CATEGORY Category);

        [VtblIndex(34)]
        BOOL GetBreakOnSeverity(D3D10_MESSAGE_SEVERITY Severity);

        [VtblIndex(35)]
        BOOL GetBreakOnID(D3D10_MESSAGE_ID ID);

        [VtblIndex(36)]
        void SetMuteDebugOutput(BOOL bMute);

        [VtblIndex(37)]
        BOOL GetMuteDebugOutput();
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

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> SetMessageCountLimit;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> ClearStoredMessages;

        [NativeTypeName("HRESULT (UINT64, D3D10_MESSAGE *, SIZE_T *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, D3D10_MESSAGE*, nuint*, int> GetMessageW;

        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetNumMessagesAllowedByStorageFilter;

        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetNumMessagesDeniedByStorageFilter;

        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetNumStoredMessages;

        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetNumStoredMessagesAllowedByRetrievalFilter;

        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetNumMessagesDiscardedByMessageCountLimit;

        [NativeTypeName("UINT64 () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong> GetMessageCountLimit;

        [NativeTypeName("HRESULT (D3D10_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_INFO_QUEUE_FILTER*, int> AddStorageFilterEntries;

        [NativeTypeName("HRESULT (D3D10_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_INFO_QUEUE_FILTER*, nuint*, int> GetStorageFilter;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> ClearStorageFilter;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PushEmptyStorageFilter;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PushCopyOfStorageFilter;

        [NativeTypeName("HRESULT (D3D10_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_INFO_QUEUE_FILTER*, int> PushStorageFilter;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> PopStorageFilter;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetStorageFilterStackSize;

        [NativeTypeName("HRESULT (D3D10_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_INFO_QUEUE_FILTER*, int> AddRetrievalFilterEntries;

        [NativeTypeName("HRESULT (D3D10_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D10_INFO_QUEUE_FILTER*,
            nuint*,
            int> GetRetrievalFilter;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> ClearRetrievalFilter;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PushEmptyRetrievalFilter;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PushCopyOfRetrievalFilter;

        [NativeTypeName("HRESULT (D3D10_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_INFO_QUEUE_FILTER*, int> PushRetrievalFilter;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> PopRetrievalFilter;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetRetrievalFilterStackSize;

        [NativeTypeName(
            "HRESULT (D3D10_MESSAGE_CATEGORY, D3D10_MESSAGE_SEVERITY, D3D10_MESSAGE_ID, LPCSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D10_MESSAGE_CATEGORY,
            D3D10_MESSAGE_SEVERITY,
            D3D10_MESSAGE_ID,
            sbyte*,
            int> AddMessage;

        [NativeTypeName("HRESULT (D3D10_MESSAGE_SEVERITY, LPCSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D10_MESSAGE_SEVERITY,
            sbyte*,
            int> AddApplicationMessage;

        [NativeTypeName("HRESULT (D3D10_MESSAGE_CATEGORY, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_MESSAGE_CATEGORY, BOOL, int> SetBreakOnCategory;

        [NativeTypeName("HRESULT (D3D10_MESSAGE_SEVERITY, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_MESSAGE_SEVERITY, BOOL, int> SetBreakOnSeverity;

        [NativeTypeName("HRESULT (D3D10_MESSAGE_ID, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_MESSAGE_ID, BOOL, int> SetBreakOnID;

        [NativeTypeName("BOOL (D3D10_MESSAGE_CATEGORY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_MESSAGE_CATEGORY, int> GetBreakOnCategory;

        [NativeTypeName("BOOL (D3D10_MESSAGE_SEVERITY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_MESSAGE_SEVERITY, int> GetBreakOnSeverity;

        [NativeTypeName("BOOL (D3D10_MESSAGE_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_MESSAGE_ID, int> GetBreakOnID;

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetMuteDebugOutput;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetMuteDebugOutput;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D10InfoQueue"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D10InfoQueue(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D10InfoQueue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D10InfoQueue(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D10InfoQueue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D10InfoQueue"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D10InfoQueue"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D10InfoQueue value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
