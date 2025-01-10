// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("D67441C7-672A-476F-9E82-CD55B44949CE")]
[NativeTypeName("struct IDXGIInfoQueue : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDXGIInfoQueue : IDXGIInfoQueue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIInfoQueue));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDXGIInfoQueue, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMessageCountLimit(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        [NativeTypeName("UINT64")] ulong MessageCountLimit
    )
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, ulong, int>)((*lpVtbl)[3]))(
            this,
            Producer,
            MessageCountLimit
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void ClearStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        ((delegate* unmanaged<IDXGIInfoQueue, Guid, void>)((*lpVtbl)[4]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMessage(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        [NativeTypeName("UINT64")] ulong MessageIndex,
        DXGI_INFO_QUEUE_MESSAGE* pMessage,
        [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIInfoQueue,
                Guid,
                ulong,
                DXGI_INFO_QUEUE_MESSAGE*,
                nuint*,
                int>)((*lpVtbl)[5])
        )(this, Producer, MessageIndex, pMessage, pMessageByteLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumStoredMessagesAllowedByRetrievalFilters(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
    )
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, ulong>)((*lpVtbl)[6]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, ulong>)((*lpVtbl)[7]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesDiscardedByMessageCountLimit(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
    )
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, ulong>)((*lpVtbl)[8]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT64")]
    public ulong GetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, ulong>)((*lpVtbl)[9]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesAllowedByStorageFilter(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
    )
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, ulong>)((*lpVtbl)[10]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesDeniedByStorageFilter(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
    )
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, ulong>)((*lpVtbl)[11]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddStorageFilterEntries(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        DXGI_INFO_QUEUE_FILTER* pFilter
    )
    {
        return (
            (delegate* unmanaged<IDXGIInfoQueue, Guid, DXGI_INFO_QUEUE_FILTER*, int>)((*lpVtbl)[12])
        )(this, Producer, pFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetStorageFilter(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        DXGI_INFO_QUEUE_FILTER* pFilter,
        [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength
    )
    {
        return (
            (delegate* unmanaged<IDXGIInfoQueue, Guid, DXGI_INFO_QUEUE_FILTER*, nuint*, int>)(
                (*lpVtbl)[13]
            )
        )(this, Producer, pFilter, pFilterByteLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void ClearStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        ((delegate* unmanaged<IDXGIInfoQueue, Guid, void>)((*lpVtbl)[14]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT PushEmptyStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, int>)((*lpVtbl)[15]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT PushDenyAllStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, int>)((*lpVtbl)[16]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT PushCopyOfStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, int>)((*lpVtbl)[17]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT PushStorageFilter(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        DXGI_INFO_QUEUE_FILTER* pFilter
    )
    {
        return (
            (delegate* unmanaged<IDXGIInfoQueue, Guid, DXGI_INFO_QUEUE_FILTER*, int>)((*lpVtbl)[18])
        )(this, Producer, pFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void PopStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        ((delegate* unmanaged<IDXGIInfoQueue, Guid, void>)((*lpVtbl)[19]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public uint GetStorageFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, uint>)((*lpVtbl)[20]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT AddRetrievalFilterEntries(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        DXGI_INFO_QUEUE_FILTER* pFilter
    )
    {
        return (
            (delegate* unmanaged<IDXGIInfoQueue, Guid, DXGI_INFO_QUEUE_FILTER*, int>)((*lpVtbl)[21])
        )(this, Producer, pFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetRetrievalFilter(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        DXGI_INFO_QUEUE_FILTER* pFilter,
        [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength
    )
    {
        return (
            (delegate* unmanaged<IDXGIInfoQueue, Guid, DXGI_INFO_QUEUE_FILTER*, nuint*, int>)(
                (*lpVtbl)[22]
            )
        )(this, Producer, pFilter, pFilterByteLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void ClearRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        ((delegate* unmanaged<IDXGIInfoQueue, Guid, void>)((*lpVtbl)[23]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT PushEmptyRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, int>)((*lpVtbl)[24]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PushDenyAllRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, int>)((*lpVtbl)[25]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT PushCopyOfRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, int>)((*lpVtbl)[26]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT PushRetrievalFilter(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        DXGI_INFO_QUEUE_FILTER* pFilter
    )
    {
        return (
            (delegate* unmanaged<IDXGIInfoQueue, Guid, DXGI_INFO_QUEUE_FILTER*, int>)((*lpVtbl)[27])
        )(this, Producer, pFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public void PopRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        ((delegate* unmanaged<IDXGIInfoQueue, Guid, void>)((*lpVtbl)[28]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public uint GetRetrievalFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, uint>)((*lpVtbl)[29]))(this, Producer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT AddMessage(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category,
        DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity,
        [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID,
        [NativeTypeName("LPCSTR")] sbyte* pDescription
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIInfoQueue,
                Guid,
                DXGI_INFO_QUEUE_MESSAGE_CATEGORY,
                DXGI_INFO_QUEUE_MESSAGE_SEVERITY,
                int,
                sbyte*,
                int>)((*lpVtbl)[30])
        )(this, Producer, Category, Severity, ID, pDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT AddApplicationMessage(
        DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity,
        [NativeTypeName("LPCSTR")] sbyte* pDescription
    )
    {
        return (
            (delegate* unmanaged<IDXGIInfoQueue, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, sbyte*, int>)(
                (*lpVtbl)[31]
            )
        )(this, Severity, pDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT SetBreakOnCategory(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category,
        BOOL bEnable
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIInfoQueue,
                Guid,
                DXGI_INFO_QUEUE_MESSAGE_CATEGORY,
                BOOL,
                int>)((*lpVtbl)[32])
        )(this, Producer, Category, bEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SetBreakOnSeverity(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity,
        BOOL bEnable
    )
    {
        return (
            (delegate* unmanaged<
                IDXGIInfoQueue,
                Guid,
                DXGI_INFO_QUEUE_MESSAGE_SEVERITY,
                BOOL,
                int>)((*lpVtbl)[33])
        )(this, Producer, Severity, bEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT SetBreakOnID(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID,
        BOOL bEnable
    )
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, int, BOOL, int>)((*lpVtbl)[34]))(
            this,
            Producer,
            ID,
            bEnable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public BOOL GetBreakOnCategory(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category
    )
    {
        return (
            (delegate* unmanaged<IDXGIInfoQueue, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, int>)(
                (*lpVtbl)[35]
            )
        )(this, Producer, Category);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public BOOL GetBreakOnSeverity(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity
    )
    {
        return (
            (delegate* unmanaged<IDXGIInfoQueue, Guid, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int>)(
                (*lpVtbl)[36]
            )
        )(this, Producer, Severity);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public BOOL GetBreakOnID(
        [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
        [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID
    )
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, int, int>)((*lpVtbl)[37]))(
            this,
            Producer,
            ID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public void SetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, BOOL bMute)
    {
        ((delegate* unmanaged<IDXGIInfoQueue, Guid, BOOL, void>)((*lpVtbl)[38]))(
            this,
            Producer,
            bMute
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public BOOL GetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue, Guid, int>)((*lpVtbl)[39]))(this, Producer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetMessageCountLimit(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [NativeTypeName("UINT64")] ulong MessageCountLimit
        );

        [VtblIndex(4)]
        void ClearStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(5)]
        HRESULT GetMessage(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [NativeTypeName("UINT64")] ulong MessageIndex,
            DXGI_INFO_QUEUE_MESSAGE* pMessage,
            [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength
        );

        [VtblIndex(6)]
        [return: NativeTypeName("UINT64")]
        ulong GetNumStoredMessagesAllowedByRetrievalFilters(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [VtblIndex(7)]
        [return: NativeTypeName("UINT64")]
        ulong GetNumStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(8)]
        [return: NativeTypeName("UINT64")]
        ulong GetNumMessagesDiscardedByMessageCountLimit(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer
        );

        [VtblIndex(9)]
        [return: NativeTypeName("UINT64")]
        ulong GetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(10)]
        [return: NativeTypeName("UINT64")]
        ulong GetNumMessagesAllowedByStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(11)]
        [return: NativeTypeName("UINT64")]
        ulong GetNumMessagesDeniedByStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(12)]
        HRESULT AddStorageFilterEntries(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            DXGI_INFO_QUEUE_FILTER* pFilter
        );

        [VtblIndex(13)]
        HRESULT GetStorageFilter(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            DXGI_INFO_QUEUE_FILTER* pFilter,
            [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength
        );

        [VtblIndex(14)]
        void ClearStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(15)]
        HRESULT PushEmptyStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(16)]
        HRESULT PushDenyAllStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(17)]
        HRESULT PushCopyOfStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(18)]
        HRESULT PushStorageFilter(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            DXGI_INFO_QUEUE_FILTER* pFilter
        );

        [VtblIndex(19)]
        void PopStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(20)]
        uint GetStorageFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(21)]
        HRESULT AddRetrievalFilterEntries(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            DXGI_INFO_QUEUE_FILTER* pFilter
        );

        [VtblIndex(22)]
        HRESULT GetRetrievalFilter(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            DXGI_INFO_QUEUE_FILTER* pFilter,
            [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength
        );

        [VtblIndex(23)]
        void ClearRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(24)]
        HRESULT PushEmptyRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(25)]
        HRESULT PushDenyAllRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(26)]
        HRESULT PushCopyOfRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(27)]
        HRESULT PushRetrievalFilter(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            DXGI_INFO_QUEUE_FILTER* pFilter
        );

        [VtblIndex(28)]
        void PopRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(29)]
        uint GetRetrievalFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);

        [VtblIndex(30)]
        HRESULT AddMessage(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category,
            DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity,
            [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID,
            [NativeTypeName("LPCSTR")] sbyte* pDescription
        );

        [VtblIndex(31)]
        HRESULT AddApplicationMessage(
            DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity,
            [NativeTypeName("LPCSTR")] sbyte* pDescription
        );

        [VtblIndex(32)]
        HRESULT SetBreakOnCategory(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category,
            BOOL bEnable
        );

        [VtblIndex(33)]
        HRESULT SetBreakOnSeverity(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity,
            BOOL bEnable
        );

        [VtblIndex(34)]
        HRESULT SetBreakOnID(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID,
            BOOL bEnable
        );

        [VtblIndex(35)]
        BOOL GetBreakOnCategory(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category
        );

        [VtblIndex(36)]
        BOOL GetBreakOnSeverity(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity
        );

        [VtblIndex(37)]
        BOOL GetBreakOnID(
            [NativeTypeName("DXGI_DEBUG_ID")] Guid Producer,
            [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID
        );

        [VtblIndex(38)]
        void SetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, BOOL bMute);

        [VtblIndex(39)]
        BOOL GetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
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

        [NativeTypeName("HRESULT (DXGI_DEBUG_ID, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, ulong, int> SetMessageCountLimit;

        [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, void> ClearStoredMessages;

        [NativeTypeName(
            "HRESULT (DXGI_DEBUG_ID, UINT64, DXGI_INFO_QUEUE_MESSAGE *, SIZE_T *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            ulong,
            DXGI_INFO_QUEUE_MESSAGE*,
            nuint*,
            int> GetMessage;

        [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            ulong> GetNumStoredMessagesAllowedByRetrievalFilters;

        [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, ulong> GetNumStoredMessages;

        [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, ulong> GetNumMessagesDiscardedByMessageCountLimit;

        [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, ulong> GetMessageCountLimit;

        [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, ulong> GetNumMessagesAllowedByStorageFilter;

        [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, ulong> GetNumMessagesDeniedByStorageFilter;

        [NativeTypeName(
            "HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            DXGI_INFO_QUEUE_FILTER*,
            int> AddStorageFilterEntries;

        [NativeTypeName(
            "HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            DXGI_INFO_QUEUE_FILTER*,
            nuint*,
            int> GetStorageFilter;

        [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, void> ClearStorageFilter;

        [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> PushEmptyStorageFilter;

        [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> PushDenyAllStorageFilter;

        [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> PushCopyOfStorageFilter;

        [NativeTypeName(
            "HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid, DXGI_INFO_QUEUE_FILTER*, int> PushStorageFilter;

        [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, void> PopStorageFilter;

        [NativeTypeName("UINT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, uint> GetStorageFilterStackSize;

        [NativeTypeName(
            "HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            DXGI_INFO_QUEUE_FILTER*,
            int> AddRetrievalFilterEntries;

        [NativeTypeName(
            "HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            DXGI_INFO_QUEUE_FILTER*,
            nuint*,
            int> GetRetrievalFilter;

        [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, void> ClearRetrievalFilter;

        [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> PushEmptyRetrievalFilter;

        [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> PushDenyAllRetrievalFilter;

        [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> PushCopyOfRetrievalFilter;

        [NativeTypeName(
            "HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid, DXGI_INFO_QUEUE_FILTER*, int> PushRetrievalFilter;

        [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, void> PopRetrievalFilter;

        [NativeTypeName("UINT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, uint> GetRetrievalFilterStackSize;

        [NativeTypeName(
            "HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, DXGI_INFO_QUEUE_MESSAGE_ID, LPCSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            DXGI_INFO_QUEUE_MESSAGE_CATEGORY,
            DXGI_INFO_QUEUE_MESSAGE_SEVERITY,
            int,
            sbyte*,
            int> AddMessage;

        [NativeTypeName(
            "HRESULT (DXGI_INFO_QUEUE_MESSAGE_SEVERITY, LPCSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DXGI_INFO_QUEUE_MESSAGE_SEVERITY,
            sbyte*,
            int> AddApplicationMessage;

        [NativeTypeName(
            "HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, BOOL) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            DXGI_INFO_QUEUE_MESSAGE_CATEGORY,
            BOOL,
            int> SetBreakOnCategory;

        [NativeTypeName(
            "HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, BOOL) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            DXGI_INFO_QUEUE_MESSAGE_SEVERITY,
            BOOL,
            int> SetBreakOnSeverity;

        [NativeTypeName(
            "HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_ID, BOOL) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid, int, BOOL, int> SetBreakOnID;

        [NativeTypeName(
            "BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            DXGI_INFO_QUEUE_MESSAGE_CATEGORY,
            int> GetBreakOnCategory;

        [NativeTypeName(
            "BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_SEVERITY) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            DXGI_INFO_QUEUE_MESSAGE_SEVERITY,
            int> GetBreakOnSeverity;

        [NativeTypeName(
            "BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_ID) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid, int, int> GetBreakOnID;

        [NativeTypeName("void (DXGI_DEBUG_ID, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, BOOL, void> SetMuteDebugOutput;

        [NativeTypeName("BOOL (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> GetMuteDebugOutput;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDXGIInfoQueue"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDXGIInfoQueue(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDXGIInfoQueue"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDXGIInfoQueue(Silk.NET.Windows.IUnknown value)
    {
        return new IDXGIInfoQueue(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDXGIInfoQueue"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDXGIInfoQueue"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDXGIInfoQueue value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
