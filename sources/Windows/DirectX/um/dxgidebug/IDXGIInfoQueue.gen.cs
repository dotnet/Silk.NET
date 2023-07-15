// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue"]/*'/>
[Guid("D67441C7-672A-476F-9E82-CD55B44949CE")]
[NativeTypeName("struct IDXGIInfoQueue : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDXGIInfoQueue : IDXGIInfoQueue.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDXGIInfoQueue));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid*, void**, int> )(lpVtbl[0]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, uint> )(lpVtbl[1]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, uint> )(lpVtbl[2]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.SetMessageCountLimit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageCountLimit)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong, int> )(lpVtbl[3]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, MessageCountLimit);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.ClearStoredMessages"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void ClearStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void> )(lpVtbl[4]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMessage([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageIndex, DXGI_INFO_QUEUE_MESSAGE* pMessage, [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong, DXGI_INFO_QUEUE_MESSAGE*, nuint*, int> )(lpVtbl[5]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, MessageIndex, pMessage, pMessageByteLength);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetNumStoredMessagesAllowedByRetrievalFilters"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumStoredMessagesAllowedByRetrievalFilters([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong> )(lpVtbl[6]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetNumStoredMessages"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong> )(lpVtbl[7]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetNumMessagesDiscardedByMessageCountLimit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesDiscardedByMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong> )(lpVtbl[8]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetMessageCountLimit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT64")]
    public ulong GetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong> )(lpVtbl[9]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetNumMessagesAllowedByStorageFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesAllowedByStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong> )(lpVtbl[10]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetNumMessagesDeniedByStorageFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("UINT64")]
    public ulong GetNumMessagesDeniedByStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, ulong> )(lpVtbl[11]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.AddStorageFilterEntries"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddStorageFilterEntries([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int> )(lpVtbl[12]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetStorageFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, nuint*, int> )(lpVtbl[13]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter, pFilterByteLength);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.ClearStorageFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void ClearStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void> )(lpVtbl[14]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.PushEmptyStorageFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT PushEmptyStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int> )(lpVtbl[15]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.PushDenyAllStorageFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT PushDenyAllStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int> )(lpVtbl[16]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.PushCopyOfStorageFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT PushCopyOfStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int> )(lpVtbl[17]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.PushStorageFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT PushStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int> )(lpVtbl[18]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.PopStorageFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public void PopStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void> )(lpVtbl[19]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetStorageFilterStackSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public uint GetStorageFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, uint> )(lpVtbl[20]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.AddRetrievalFilterEntries"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT AddRetrievalFilterEntries([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int> )(lpVtbl[21]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetRetrievalFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, nuint*, int> )(lpVtbl[22]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter, pFilterByteLength);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.ClearRetrievalFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public void ClearRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void> )(lpVtbl[23]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.PushEmptyRetrievalFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT PushEmptyRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int> )(lpVtbl[24]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.PushDenyAllRetrievalFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT PushDenyAllRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int> )(lpVtbl[25]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.PushCopyOfRetrievalFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT PushCopyOfRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int> )(lpVtbl[26]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.PushRetrievalFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT PushRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_FILTER*, int> )(lpVtbl[27]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, pFilter);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.PopRetrievalFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public void PopRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        ((delegate* unmanaged<IDXGIInfoQueue*, Guid, void> )(lpVtbl[28]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetRetrievalFilterStackSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public uint GetRetrievalFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, uint> )(lpVtbl[29]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.AddMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT AddMessage([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("LPCSTR")] sbyte* pDescription)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int, sbyte*, int> )(lpVtbl[30]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category, Severity, ID, pDescription);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.AddApplicationMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT AddApplicationMessage(DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, sbyte*, int> )(lpVtbl[31]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Severity, pDescription);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.SetBreakOnCategory"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT SetBreakOnCategory([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, BOOL bEnable)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, BOOL, int> )(lpVtbl[32]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category, bEnable);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.SetBreakOnSeverity"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SetBreakOnSeverity([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, BOOL bEnable)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, BOOL, int> )(lpVtbl[33]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Severity, bEnable);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.SetBreakOnID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT SetBreakOnID([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, BOOL bEnable)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int, BOOL, int> )(lpVtbl[34]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, ID, bEnable);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetBreakOnCategory"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public BOOL GetBreakOnCategory([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, int> )(lpVtbl[35]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Category);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetBreakOnSeverity"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public BOOL GetBreakOnSeverity([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int> )(lpVtbl[36]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, Severity);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetBreakOnID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public BOOL GetBreakOnID([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int, int> )(lpVtbl[37]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, ID);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.SetMuteDebugOutput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public void SetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, BOOL bMute)
    {
        ((delegate* unmanaged<IDXGIInfoQueue*, Guid, BOOL, void> )(lpVtbl[38]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer, bMute);
    }

    /// <include file='IDXGIInfoQueue.xml' path='doc/member[@name="IDXGIInfoQueue.GetMuteDebugOutput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public BOOL GetMuteDebugOutput([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer)
    {
        return ((delegate* unmanaged<IDXGIInfoQueue*, Guid, int> )(lpVtbl[39]))((IDXGIInfoQueue*)Unsafe.AsPointer(ref this), Producer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageCountLimit);
        [VtblIndex(4)]
        void ClearStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(5)]
        HRESULT GetMessage([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("UINT64")] ulong MessageIndex, DXGI_INFO_QUEUE_MESSAGE* pMessage, [NativeTypeName("SIZE_T *")] nuint* pMessageByteLength);
        [VtblIndex(6)]
        [return: NativeTypeName("UINT64")]
        ulong GetNumStoredMessagesAllowedByRetrievalFilters([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(7)]
        [return: NativeTypeName("UINT64")]
        ulong GetNumStoredMessages([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(8)]
        [return: NativeTypeName("UINT64")]
        ulong GetNumMessagesDiscardedByMessageCountLimit([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
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
        HRESULT AddStorageFilterEntries([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter);
        [VtblIndex(13)]
        HRESULT GetStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength);
        [VtblIndex(14)]
        void ClearStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(15)]
        HRESULT PushEmptyStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(16)]
        HRESULT PushDenyAllStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(17)]
        HRESULT PushCopyOfStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(18)]
        HRESULT PushStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter);
        [VtblIndex(19)]
        void PopStorageFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(20)]
        uint GetStorageFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(21)]
        HRESULT AddRetrievalFilterEntries([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter);
        [VtblIndex(22)]
        HRESULT GetRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter, [NativeTypeName("SIZE_T *")] nuint* pFilterByteLength);
        [VtblIndex(23)]
        void ClearRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(24)]
        HRESULT PushEmptyRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(25)]
        HRESULT PushDenyAllRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(26)]
        HRESULT PushCopyOfRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(27)]
        HRESULT PushRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_FILTER* pFilter);
        [VtblIndex(28)]
        void PopRetrievalFilter([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(29)]
        uint GetRetrievalFilterStackSize([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer);
        [VtblIndex(30)]
        HRESULT AddMessage([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, [NativeTypeName("LPCSTR")] sbyte* pDescription);
        [VtblIndex(31)]
        HRESULT AddApplicationMessage(DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, [NativeTypeName("LPCSTR")] sbyte* pDescription);
        [VtblIndex(32)]
        HRESULT SetBreakOnCategory([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category, BOOL bEnable);
        [VtblIndex(33)]
        HRESULT SetBreakOnSeverity([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity, BOOL bEnable);
        [VtblIndex(34)]
        HRESULT SetBreakOnID([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID, BOOL bEnable);
        [VtblIndex(35)]
        BOOL GetBreakOnCategory([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_CATEGORY Category);
        [VtblIndex(36)]
        BOOL GetBreakOnSeverity([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, DXGI_INFO_QUEUE_MESSAGE_SEVERITY Severity);
        [VtblIndex(37)]
        BOOL GetBreakOnID([NativeTypeName("DXGI_DEBUG_ID")] Guid Producer, [NativeTypeName("DXGI_INFO_QUEUE_MESSAGE_ID")] int ID);
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
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID, UINT64, DXGI_INFO_QUEUE_MESSAGE *, SIZE_T *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, ulong, DXGI_INFO_QUEUE_MESSAGE*, nuint*, int> GetMessage;
        [NativeTypeName("UINT64 (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, ulong> GetNumStoredMessagesAllowedByRetrievalFilters;
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
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, DXGI_INFO_QUEUE_FILTER*, int> AddStorageFilterEntries;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, DXGI_INFO_QUEUE_FILTER*, nuint*, int> GetStorageFilter;
        [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, void> ClearStorageFilter;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> PushEmptyStorageFilter;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> PushDenyAllStorageFilter;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> PushCopyOfStorageFilter;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, DXGI_INFO_QUEUE_FILTER*, int> PushStorageFilter;
        [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, void> PopStorageFilter;
        [NativeTypeName("UINT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, uint> GetStorageFilterStackSize;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, DXGI_INFO_QUEUE_FILTER*, int> AddRetrievalFilterEntries;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *, SIZE_T *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, DXGI_INFO_QUEUE_FILTER*, nuint*, int> GetRetrievalFilter;
        [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, void> ClearRetrievalFilter;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> PushEmptyRetrievalFilter;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> PushDenyAllRetrievalFilter;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> PushCopyOfRetrievalFilter;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_FILTER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, DXGI_INFO_QUEUE_FILTER*, int> PushRetrievalFilter;
        [NativeTypeName("void (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, void> PopRetrievalFilter;
        [NativeTypeName("UINT (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, uint> GetRetrievalFilterStackSize;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, DXGI_INFO_QUEUE_MESSAGE_ID, LPCSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int, sbyte*, int> AddMessage;
        [NativeTypeName("HRESULT (DXGI_INFO_QUEUE_MESSAGE_SEVERITY, LPCSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, sbyte*, int> AddApplicationMessage;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, BOOL, int> SetBreakOnCategory;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, BOOL, int> SetBreakOnSeverity;
        [NativeTypeName("HRESULT (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_ID, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int, BOOL, int> SetBreakOnID;
        [NativeTypeName("BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_CATEGORY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, DXGI_INFO_QUEUE_MESSAGE_CATEGORY, int> GetBreakOnCategory;
        [NativeTypeName("BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_SEVERITY) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, DXGI_INFO_QUEUE_MESSAGE_SEVERITY, int> GetBreakOnSeverity;
        [NativeTypeName("BOOL (DXGI_DEBUG_ID, DXGI_INFO_QUEUE_MESSAGE_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int, int> GetBreakOnID;
        [NativeTypeName("void (DXGI_DEBUG_ID, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, BOOL, void> SetMuteDebugOutput;
        [NativeTypeName("BOOL (DXGI_DEBUG_ID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> GetMuteDebugOutput;
    }
}