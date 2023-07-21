// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10sdklayers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue"]/*' />
[Guid("1B940B17-2642-4D1F-AB1F-B99BAD0C395F")]
[NativeTypeName("struct ID3D10InfoQueue : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D10InfoQueue : ID3D10InfoQueue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10InfoQueue));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, Guid*, void**, int>)(lpVtbl[0]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, uint>)(lpVtbl[1]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, uint>)(lpVtbl[2]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.SetMessageCountLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMessageCountLimit([NativeTypeName("UINT64")] ulong MessageCountLimit)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, ulong, int>)(lpVtbl[3]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), MessageCountLimit);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.ClearStoredMessages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void ClearStoredMessages()
    {
        ((delegate* unmanaged<ID3D10InfoQueue*, void>)(lpVtbl[4]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetMessageW"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMessageW([NativeTypeName("UINT64")] ulong MessageIndex, D3D10_MESSAGE* pMessage, [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, ulong, D3D10_MESSAGE*, nuint*, int>)(lpVtbl[5]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), MessageIndex, pMessage, pMessageByteLength);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetNumMessagesAllowedByStorageFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesAllowedByStorageFilter()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, ulong>)(lpVtbl[6]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetNumMessagesDeniedByStorageFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesDeniedByStorageFilter()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, ulong>)(lpVtbl[7]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetNumStoredMessages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumStoredMessages()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, ulong>)(lpVtbl[8]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetNumStoredMessagesAllowedByRetrievalFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumStoredMessagesAllowedByRetrievalFilter()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, ulong>)(lpVtbl[9]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetNumMessagesDiscardedByMessageCountLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesDiscardedByMessageCountLimit()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, ulong>)(lpVtbl[10]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetMessageCountLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("UINT64")]
    public ulong GetMessageCountLimit()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, ulong>)(lpVtbl[11]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.AddStorageFilterEntries"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddStorageFilterEntries(D3D10_INFO_QUEUE_FILTER* pFilter)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, D3D10_INFO_QUEUE_FILTER*, int>)(lpVtbl[12]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetStorageFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetStorageFilter(D3D10_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, D3D10_INFO_QUEUE_FILTER*, nuint*, int>)(lpVtbl[13]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.ClearStorageFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void ClearStorageFilter()
    {
        ((delegate* unmanaged<ID3D10InfoQueue*, void>)(lpVtbl[14]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.PushEmptyStorageFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT PushEmptyStorageFilter()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, int>)(lpVtbl[15]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.PushCopyOfStorageFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT PushCopyOfStorageFilter()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, int>)(lpVtbl[16]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.PushStorageFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT PushStorageFilter(D3D10_INFO_QUEUE_FILTER* pFilter)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, D3D10_INFO_QUEUE_FILTER*, int>)(lpVtbl[17]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.PopStorageFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void PopStorageFilter()
    {
        ((delegate* unmanaged<ID3D10InfoQueue*, void>)(lpVtbl[18]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetStorageFilterStackSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public uint GetStorageFilterStackSize()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, uint>)(lpVtbl[19]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.AddRetrievalFilterEntries"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AddRetrievalFilterEntries(D3D10_INFO_QUEUE_FILTER* pFilter)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, D3D10_INFO_QUEUE_FILTER*, int>)(lpVtbl[20]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetRetrievalFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetRetrievalFilter(D3D10_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, D3D10_INFO_QUEUE_FILTER*, nuint*, int>)(lpVtbl[21]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), pFilter, pFilterByteLength);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.ClearRetrievalFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public void ClearRetrievalFilter()
    {
        ((delegate* unmanaged<ID3D10InfoQueue*, void>)(lpVtbl[22]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.PushEmptyRetrievalFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT PushEmptyRetrievalFilter()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, int>)(lpVtbl[23]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.PushCopyOfRetrievalFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT PushCopyOfRetrievalFilter()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, int>)(lpVtbl[24]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.PushRetrievalFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PushRetrievalFilter(D3D10_INFO_QUEUE_FILTER* pFilter)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, D3D10_INFO_QUEUE_FILTER*, int>)(lpVtbl[25]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.PopRetrievalFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public void PopRetrievalFilter()
    {
        ((delegate* unmanaged<ID3D10InfoQueue*, void>)(lpVtbl[26]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetRetrievalFilterStackSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public uint GetRetrievalFilterStackSize()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, uint>)(lpVtbl[27]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.AddMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT AddMessage(D3D10_MESSAGE_CATEGORY Category, D3D10_MESSAGE_SEVERITY Severity, D3D10_MESSAGE_ID ID, [NativeTypeName("LPCSTR")] sbyte* pDescription)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, D3D10_MESSAGE_CATEGORY, D3D10_MESSAGE_SEVERITY, D3D10_MESSAGE_ID, sbyte*, int>)(lpVtbl[28]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), Category, Severity, ID, pDescription);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.AddApplicationMessage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT AddApplicationMessage(D3D10_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, D3D10_MESSAGE_SEVERITY, sbyte*, int>)(lpVtbl[29]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), Severity, pDescription);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.SetBreakOnCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetBreakOnCategory(D3D10_MESSAGE_CATEGORY Category, BOOL bEnable)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, D3D10_MESSAGE_CATEGORY, BOOL, int>)(lpVtbl[30]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), Category, bEnable);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.SetBreakOnSeverity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT SetBreakOnSeverity(D3D10_MESSAGE_SEVERITY Severity, BOOL bEnable)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, D3D10_MESSAGE_SEVERITY, BOOL, int>)(lpVtbl[31]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), Severity, bEnable);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.SetBreakOnID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT SetBreakOnID(D3D10_MESSAGE_ID ID, BOOL bEnable)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, D3D10_MESSAGE_ID, BOOL, int>)(lpVtbl[32]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), ID, bEnable);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetBreakOnCategory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public BOOL GetBreakOnCategory(D3D10_MESSAGE_CATEGORY Category)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, D3D10_MESSAGE_CATEGORY, int>)(lpVtbl[33]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), Category);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetBreakOnSeverity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public BOOL GetBreakOnSeverity(D3D10_MESSAGE_SEVERITY Severity)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, D3D10_MESSAGE_SEVERITY, int>)(lpVtbl[34]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), Severity);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetBreakOnID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public BOOL GetBreakOnID(D3D10_MESSAGE_ID ID)
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, D3D10_MESSAGE_ID, int>)(lpVtbl[35]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), ID);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.SetMuteDebugOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public void SetMuteDebugOutput(BOOL bMute)
    {
        ((delegate* unmanaged<ID3D10InfoQueue*, BOOL, void>)(lpVtbl[36]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this), bMute);
    }

    /// <include file='ID3D10InfoQueue.xml' path='doc/member[@name="ID3D10InfoQueue.GetMuteDebugOutput"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public BOOL GetMuteDebugOutput()
    {
        return ((delegate* unmanaged<ID3D10InfoQueue*, int>)(lpVtbl[37]))((ID3D10InfoQueue*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetMessageCountLimit([NativeTypeName("UINT64")] ulong MessageCountLimit);

        [VtblIndex(4)]
        void ClearStoredMessages();

        [VtblIndex(5)]
        HRESULT GetMessageW([NativeTypeName("UINT64")] ulong MessageIndex, D3D10_MESSAGE* pMessage, [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength);

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
        HRESULT GetStorageFilter(D3D10_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength);

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
        HRESULT GetRetrievalFilter(D3D10_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength);

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
        HRESULT AddMessage(D3D10_MESSAGE_CATEGORY Category, D3D10_MESSAGE_SEVERITY Severity, D3D10_MESSAGE_ID ID, [NativeTypeName("LPCSTR")] sbyte* pDescription);

        [VtblIndex(29)]
        HRESULT AddApplicationMessage(D3D10_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription);

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
        public delegate* unmanaged<TSelf*, D3D10_INFO_QUEUE_FILTER*, nuint*, int> GetRetrievalFilter;

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

        [NativeTypeName("HRESULT (D3D10_MESSAGE_CATEGORY, D3D10_MESSAGE_SEVERITY, D3D10_MESSAGE_ID, LPCSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_MESSAGE_CATEGORY, D3D10_MESSAGE_SEVERITY, D3D10_MESSAGE_ID, sbyte*, int> AddMessage;

        [NativeTypeName("HRESULT (D3D10_MESSAGE_SEVERITY, LPCSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D10_MESSAGE_SEVERITY, sbyte*, int> AddApplicationMessage;

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
}
