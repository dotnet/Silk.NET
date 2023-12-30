// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12sdklayers.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D12InfoQueue1.xml' path='doc/member[@name="ID3D12InfoQueue1"]/*'/>
[Guid("2852DD88-B484-4C0C-B6B1-67168500E600")]
[NativeTypeName("struct ID3D12InfoQueue1 : ID3D12InfoQueue")]
[NativeInheritance("ID3D12InfoQueue")]
public unsafe partial struct ID3D12InfoQueue1 : ID3D12InfoQueue1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12InfoQueue1));
    public void** lpVtbl;

    /// <inheritdoc cref = "IUnknown.QueryInterface"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, Guid*, void**, int>)(lpVtbl[0]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this),
            riid,
            ppvObject
        );
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, uint>)(lpVtbl[1]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "IUnknown.Release"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, uint>)(lpVtbl[2]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.SetMessageCountLimit"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMessageCountLimit([NativeTypeName("UINT64")] ulong MessageCountLimit)
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, ulong, int>)(lpVtbl[3]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this),
            MessageCountLimit
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.ClearStoredMessages"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void ClearStoredMessages()
    {
        ((delegate* unmanaged<ID3D12InfoQueue1*, void>)(lpVtbl[4]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetMessage"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMessage(
        [NativeTypeName("UINT64")] ulong MessageIndex,
        D3D12_MESSAGE* pMessage,
        [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength
    )
    {
        return (
            (delegate* unmanaged<ID3D12InfoQueue1*, ulong, D3D12_MESSAGE*, nuint*, int>)(lpVtbl[5])
        )(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this),
            MessageIndex,
            pMessage,
            pMessageByteLength
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetNumMessagesAllowedByStorageFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesAllowedByStorageFilter()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, ulong>)(lpVtbl[6]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetNumMessagesDeniedByStorageFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesDeniedByStorageFilter()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, ulong>)(lpVtbl[7]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetNumStoredMessages"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumStoredMessages()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, ulong>)(lpVtbl[8]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetNumStoredMessagesAllowedByRetrievalFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumStoredMessagesAllowedByRetrievalFilter()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, ulong>)(lpVtbl[9]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetNumMessagesDiscardedByMessageCountLimit"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesDiscardedByMessageCountLimit()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, ulong>)(lpVtbl[10]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetMessageCountLimit"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("UINT64")]
    public ulong GetMessageCountLimit()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, ulong>)(lpVtbl[11]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.AddStorageFilterEntries"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddStorageFilterEntries(D3D12_INFO_QUEUE_FILTER* pFilter)
    {
        return (
            (delegate* unmanaged<ID3D12InfoQueue1*, D3D12_INFO_QUEUE_FILTER*, int>)(lpVtbl[12])
        )((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetStorageFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetStorageFilter(
        D3D12_INFO_QUEUE_FILTER* pFilter,
        [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength
    )
    {
        return (
            (delegate* unmanaged<ID3D12InfoQueue1*, D3D12_INFO_QUEUE_FILTER*, nuint*, int>)(
                lpVtbl[13]
            )
        )((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.ClearStorageFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void ClearStorageFilter()
    {
        ((delegate* unmanaged<ID3D12InfoQueue1*, void>)(lpVtbl[14]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.PushEmptyStorageFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT PushEmptyStorageFilter()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, int>)(lpVtbl[15]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.PushCopyOfStorageFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT PushCopyOfStorageFilter()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, int>)(lpVtbl[16]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.PushStorageFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT PushStorageFilter(D3D12_INFO_QUEUE_FILTER* pFilter)
    {
        return (
            (delegate* unmanaged<ID3D12InfoQueue1*, D3D12_INFO_QUEUE_FILTER*, int>)(lpVtbl[17])
        )((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.PopStorageFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void PopStorageFilter()
    {
        ((delegate* unmanaged<ID3D12InfoQueue1*, void>)(lpVtbl[18]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetStorageFilterStackSize"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public uint GetStorageFilterStackSize()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, uint>)(lpVtbl[19]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.AddRetrievalFilterEntries"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AddRetrievalFilterEntries(D3D12_INFO_QUEUE_FILTER* pFilter)
    {
        return (
            (delegate* unmanaged<ID3D12InfoQueue1*, D3D12_INFO_QUEUE_FILTER*, int>)(lpVtbl[20])
        )((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetRetrievalFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetRetrievalFilter(
        D3D12_INFO_QUEUE_FILTER* pFilter,
        [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength
    )
    {
        return (
            (delegate* unmanaged<ID3D12InfoQueue1*, D3D12_INFO_QUEUE_FILTER*, nuint*, int>)(
                lpVtbl[21]
            )
        )((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.ClearRetrievalFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void ClearRetrievalFilter()
    {
        ((delegate* unmanaged<ID3D12InfoQueue1*, void>)(lpVtbl[22]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.PushEmptyRetrievalFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT PushEmptyRetrievalFilter()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, int>)(lpVtbl[23]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.PushCopyOfRetrievalFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT PushCopyOfRetrievalFilter()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, int>)(lpVtbl[24]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.PushRetrievalFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PushRetrievalFilter(D3D12_INFO_QUEUE_FILTER* pFilter)
    {
        return (
            (delegate* unmanaged<ID3D12InfoQueue1*, D3D12_INFO_QUEUE_FILTER*, int>)(lpVtbl[25])
        )((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.PopRetrievalFilter"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public void PopRetrievalFilter()
    {
        ((delegate* unmanaged<ID3D12InfoQueue1*, void>)(lpVtbl[26]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetRetrievalFilterStackSize"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public uint GetRetrievalFilterStackSize()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, uint>)(lpVtbl[27]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.AddMessage"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT AddMessage(
        D3D12_MESSAGE_CATEGORY Category,
        D3D12_MESSAGE_SEVERITY Severity,
        D3D12_MESSAGE_ID ID,
        [NativeTypeName("LPCSTR")] sbyte* pDescription
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12InfoQueue1*,
                D3D12_MESSAGE_CATEGORY,
                D3D12_MESSAGE_SEVERITY,
                D3D12_MESSAGE_ID,
                sbyte*,
                int>)(lpVtbl[28])
        )((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), Category, Severity, ID, pDescription);
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.AddApplicationMessage"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT AddApplicationMessage(
        D3D12_MESSAGE_SEVERITY Severity,
        [NativeTypeName("LPCSTR")] sbyte* pDescription
    )
    {
        return (
            (delegate* unmanaged<ID3D12InfoQueue1*, D3D12_MESSAGE_SEVERITY, sbyte*, int>)(
                lpVtbl[29]
            )
        )((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), Severity, pDescription);
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.SetBreakOnCategory"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetBreakOnCategory(D3D12_MESSAGE_CATEGORY Category, BOOL bEnable)
    {
        return (
            (delegate* unmanaged<ID3D12InfoQueue1*, D3D12_MESSAGE_CATEGORY, BOOL, int>)(lpVtbl[30])
        )((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), Category, bEnable);
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.SetBreakOnSeverity"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetBreakOnSeverity(D3D12_MESSAGE_SEVERITY Severity, BOOL bEnable)
    {
        return (
            (delegate* unmanaged<ID3D12InfoQueue1*, D3D12_MESSAGE_SEVERITY, BOOL, int>)(lpVtbl[31])
        )((ID3D12InfoQueue1*)Unsafe.AsPointer(ref this), Severity, bEnable);
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.SetBreakOnID"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT SetBreakOnID(D3D12_MESSAGE_ID ID, BOOL bEnable)
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, D3D12_MESSAGE_ID, BOOL, int>)(lpVtbl[32]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this),
            ID,
            bEnable
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetBreakOnCategory"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public BOOL GetBreakOnCategory(D3D12_MESSAGE_CATEGORY Category)
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, D3D12_MESSAGE_CATEGORY, int>)(lpVtbl[33]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this),
            Category
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetBreakOnSeverity"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public BOOL GetBreakOnSeverity(D3D12_MESSAGE_SEVERITY Severity)
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, D3D12_MESSAGE_SEVERITY, int>)(lpVtbl[34]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this),
            Severity
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetBreakOnID"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public BOOL GetBreakOnID(D3D12_MESSAGE_ID ID)
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, D3D12_MESSAGE_ID, int>)(lpVtbl[35]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this),
            ID
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.SetMuteDebugOutput"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void SetMuteDebugOutput(BOOL bMute)
    {
        ((delegate* unmanaged<ID3D12InfoQueue1*, BOOL, void>)(lpVtbl[36]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this),
            bMute
        );
    }

    /// <inheritdoc cref = "ID3D12InfoQueue.GetMuteDebugOutput"/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public BOOL GetMuteDebugOutput()
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, int>)(lpVtbl[37]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this)
        );
    }

    /// <include file='ID3D12InfoQueue1.xml' path='doc/member[@name="ID3D12InfoQueue1.RegisterMessageCallback"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT RegisterMessageCallback(
        [NativeTypeName("D3D12MessageFunc")]
            delegate* unmanaged<
            D3D12_MESSAGE_CATEGORY,
            D3D12_MESSAGE_SEVERITY,
            D3D12_MESSAGE_ID,
            sbyte*,
            void*,
            void> CallbackFunc,
        D3D12_MESSAGE_CALLBACK_FLAGS CallbackFilterFlags,
        void* pContext,
        [NativeTypeName("DWORD *")] uint* pCallbackCookie
    )
    {
        return (
            (delegate* unmanaged<
                ID3D12InfoQueue1*,
                delegate* unmanaged<
                    D3D12_MESSAGE_CATEGORY,
                    D3D12_MESSAGE_SEVERITY,
                    D3D12_MESSAGE_ID,
                    sbyte*,
                    void*,
                    void>,
                D3D12_MESSAGE_CALLBACK_FLAGS,
                void*,
                uint*,
                int>)(lpVtbl[38])
        )(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this),
            CallbackFunc,
            CallbackFilterFlags,
            pContext,
            pCallbackCookie
        );
    }

    /// <include file='ID3D12InfoQueue1.xml' path='doc/member[@name="ID3D12InfoQueue1.UnregisterMessageCallback"]/*'/>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT UnregisterMessageCallback([NativeTypeName("DWORD")] uint CallbackCookie)
    {
        return ((delegate* unmanaged<ID3D12InfoQueue1*, uint, int>)(lpVtbl[39]))(
            (ID3D12InfoQueue1*)Unsafe.AsPointer(ref this),
            CallbackCookie
        );
    }

    public interface Interface : ID3D12InfoQueue.Interface
    {
        [VtblIndex(39)]
        HRESULT UnregisterMessageCallback([NativeTypeName("DWORD")] uint CallbackCookie);
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

        [NativeTypeName("HRESULT (UINT64, D3D12_MESSAGE *, SIZE_T *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, D3D12_MESSAGE*, nuint*, int> GetMessage;

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

        [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_INFO_QUEUE_FILTER*, int> AddStorageFilterEntries;

        [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_INFO_QUEUE_FILTER*, nuint*, int> GetStorageFilter;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> ClearStorageFilter;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PushEmptyStorageFilter;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PushCopyOfStorageFilter;

        [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_INFO_QUEUE_FILTER*, int> PushStorageFilter;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> PopStorageFilter;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetStorageFilterStackSize;

        [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_INFO_QUEUE_FILTER*, int> AddRetrievalFilterEntries;

        [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_INFO_QUEUE_FILTER*,
            nuint*,
            int> GetRetrievalFilter;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> ClearRetrievalFilter;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PushEmptyRetrievalFilter;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PushCopyOfRetrievalFilter;

        [NativeTypeName("HRESULT (D3D12_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_INFO_QUEUE_FILTER*, int> PushRetrievalFilter;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> PopRetrievalFilter;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetRetrievalFilterStackSize;

        [NativeTypeName(
            "HRESULT (D3D12_MESSAGE_CATEGORY, D3D12_MESSAGE_SEVERITY, D3D12_MESSAGE_ID, LPCSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3D12_MESSAGE_CATEGORY,
            D3D12_MESSAGE_SEVERITY,
            D3D12_MESSAGE_ID,
            sbyte*,
            int> AddMessage;

        [NativeTypeName("HRESULT (D3D12_MESSAGE_SEVERITY, LPCSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            D3D12_MESSAGE_SEVERITY,
            sbyte*,
            int> AddApplicationMessage;

        [NativeTypeName("HRESULT (D3D12_MESSAGE_CATEGORY, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_MESSAGE_CATEGORY, BOOL, int> SetBreakOnCategory;

        [NativeTypeName("HRESULT (D3D12_MESSAGE_SEVERITY, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_MESSAGE_SEVERITY, BOOL, int> SetBreakOnSeverity;

        [NativeTypeName("HRESULT (D3D12_MESSAGE_ID, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_MESSAGE_ID, BOOL, int> SetBreakOnID;

        [NativeTypeName("BOOL (D3D12_MESSAGE_CATEGORY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_MESSAGE_CATEGORY, int> GetBreakOnCategory;

        [NativeTypeName("BOOL (D3D12_MESSAGE_SEVERITY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_MESSAGE_SEVERITY, int> GetBreakOnSeverity;

        [NativeTypeName("BOOL (D3D12_MESSAGE_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_MESSAGE_ID, int> GetBreakOnID;

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetMuteDebugOutput;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetMuteDebugOutput;

        [NativeTypeName(
            "HRESULT (D3D12MessageFunc, D3D12_MESSAGE_CALLBACK_FLAGS, void *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            delegate* unmanaged<
                D3D12_MESSAGE_CATEGORY,
                D3D12_MESSAGE_SEVERITY,
                D3D12_MESSAGE_ID,
                sbyte*,
                void*,
                void>,
            D3D12_MESSAGE_CALLBACK_FLAGS,
            void*,
            uint*,
            int> RegisterMessageCallback;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnregisterMessageCallback;
    }
}
