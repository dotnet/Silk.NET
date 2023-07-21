// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFWorkQueueServicesEx.xml' path='doc/member[@name="IMFWorkQueueServicesEx"]/*' />
[Guid("96BF961B-40FE-42F1-BA9D-320238B49700")]
[NativeTypeName("struct IMFWorkQueueServicesEx : IMFWorkQueueServices")]
[NativeInheritance("IMFWorkQueueServices")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFWorkQueueServicesEx : IMFWorkQueueServicesEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFWorkQueueServicesEx));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint>)(lpVtbl[1]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint>)(lpVtbl[2]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFWorkQueueServices.BeginRegisterTopologyWorkQueuesWithMMCSS" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginRegisterTopologyWorkQueuesWithMMCSS(IMFAsyncCallback* pCallback, IUnknown* pState)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[3]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), pCallback, pState);
    }

    /// <inheritdoc cref="IMFWorkQueueServices.EndRegisterTopologyWorkQueuesWithMMCSS" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndRegisterTopologyWorkQueuesWithMMCSS(IMFAsyncResult* pResult)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, IMFAsyncResult*, int>)(lpVtbl[4]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <inheritdoc cref="IMFWorkQueueServices.BeginUnregisterTopologyWorkQueuesWithMMCSS" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT BeginUnregisterTopologyWorkQueuesWithMMCSS(IMFAsyncCallback* pCallback, IUnknown* pState)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[5]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), pCallback, pState);
    }

    /// <inheritdoc cref="IMFWorkQueueServices.EndUnregisterTopologyWorkQueuesWithMMCSS" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EndUnregisterTopologyWorkQueuesWithMMCSS(IMFAsyncResult* pResult)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, IMFAsyncResult*, int>)(lpVtbl[6]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <inheritdoc cref="IMFWorkQueueServices.GetTopologyWorkQueueMMCSSClass" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTopologyWorkQueueMMCSSClass([NativeTypeName("DWORD")] uint dwTopologyWorkQueueId, [NativeTypeName("LPWSTR")] ushort* pwszClass, [NativeTypeName("DWORD *")] uint* pcchClass)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, ushort*, uint*, int>)(lpVtbl[7]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwTopologyWorkQueueId, pwszClass, pcchClass);
    }

    /// <inheritdoc cref="IMFWorkQueueServices.GetTopologyWorkQueueMMCSSTaskId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetTopologyWorkQueueMMCSSTaskId([NativeTypeName("DWORD")] uint dwTopologyWorkQueueId, [NativeTypeName("DWORD *")] uint* pdwTaskId)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, uint*, int>)(lpVtbl[8]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwTopologyWorkQueueId, pdwTaskId);
    }

    /// <inheritdoc cref="IMFWorkQueueServices.BeginRegisterPlatformWorkQueueWithMMCSS" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT BeginRegisterPlatformWorkQueueWithMMCSS([NativeTypeName("DWORD")] uint dwPlatformWorkQueue, [NativeTypeName("LPCWSTR")] ushort* wszClass, [NativeTypeName("DWORD")] uint dwTaskId, IMFAsyncCallback* pCallback, IUnknown* pState)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, ushort*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[9]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwPlatformWorkQueue, wszClass, dwTaskId, pCallback, pState);
    }

    /// <inheritdoc cref="IMFWorkQueueServices.EndRegisterPlatformWorkQueueWithMMCSS" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EndRegisterPlatformWorkQueueWithMMCSS(IMFAsyncResult* pResult, [NativeTypeName("DWORD *")] uint* pdwTaskId)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, IMFAsyncResult*, uint*, int>)(lpVtbl[10]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), pResult, pdwTaskId);
    }

    /// <inheritdoc cref="IMFWorkQueueServices.BeginUnregisterPlatformWorkQueueWithMMCSS" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT BeginUnregisterPlatformWorkQueueWithMMCSS([NativeTypeName("DWORD")] uint dwPlatformWorkQueue, IMFAsyncCallback* pCallback, IUnknown* pState)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[11]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwPlatformWorkQueue, pCallback, pState);
    }

    /// <inheritdoc cref="IMFWorkQueueServices.EndUnregisterPlatformWorkQueueWithMMCSS" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EndUnregisterPlatformWorkQueueWithMMCSS(IMFAsyncResult* pResult)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, IMFAsyncResult*, int>)(lpVtbl[12]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <inheritdoc cref="IMFWorkQueueServices.GetPlaftormWorkQueueMMCSSClass" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetPlaftormWorkQueueMMCSSClass([NativeTypeName("DWORD")] uint dwPlatformWorkQueueId, [NativeTypeName("LPWSTR")] ushort* pwszClass, [NativeTypeName("DWORD *")] uint* pcchClass)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, ushort*, uint*, int>)(lpVtbl[13]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwPlatformWorkQueueId, pwszClass, pcchClass);
    }

    /// <inheritdoc cref="IMFWorkQueueServices.GetPlatformWorkQueueMMCSSTaskId" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetPlatformWorkQueueMMCSSTaskId([NativeTypeName("DWORD")] uint dwPlatformWorkQueueId, [NativeTypeName("DWORD *")] uint* pdwTaskId)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, uint*, int>)(lpVtbl[14]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwPlatformWorkQueueId, pdwTaskId);
    }

    /// <include file='IMFWorkQueueServicesEx.xml' path='doc/member[@name="IMFWorkQueueServicesEx.GetTopologyWorkQueueMMCSSPriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetTopologyWorkQueueMMCSSPriority([NativeTypeName("DWORD")] uint dwTopologyWorkQueueId, [NativeTypeName("LONG *")] int* plPriority)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, int*, int>)(lpVtbl[15]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwTopologyWorkQueueId, plPriority);
    }

    /// <include file='IMFWorkQueueServicesEx.xml' path='doc/member[@name="IMFWorkQueueServicesEx.BeginRegisterPlatformWorkQueueWithMMCSSEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT BeginRegisterPlatformWorkQueueWithMMCSSEx([NativeTypeName("DWORD")] uint dwPlatformWorkQueue, [NativeTypeName("LPCWSTR")] ushort* wszClass, [NativeTypeName("DWORD")] uint dwTaskId, [NativeTypeName("LONG")] int lPriority, IMFAsyncCallback* pCallback, IUnknown* pState)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, ushort*, uint, int, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[16]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwPlatformWorkQueue, wszClass, dwTaskId, lPriority, pCallback, pState);
    }

    /// <include file='IMFWorkQueueServicesEx.xml' path='doc/member[@name="IMFWorkQueueServicesEx.GetPlatformWorkQueueMMCSSPriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetPlatformWorkQueueMMCSSPriority([NativeTypeName("DWORD")] uint dwPlatformWorkQueueId, [NativeTypeName("LONG *")] int* plPriority)
    {
        return ((delegate* unmanaged<IMFWorkQueueServicesEx*, uint, int*, int>)(lpVtbl[17]))((IMFWorkQueueServicesEx*)Unsafe.AsPointer(ref this), dwPlatformWorkQueueId, plPriority);
    }

    public interface Interface : IMFWorkQueueServices.Interface
    {
        [VtblIndex(15)]
        HRESULT GetTopologyWorkQueueMMCSSPriority([NativeTypeName("DWORD")] uint dwTopologyWorkQueueId, [NativeTypeName("LONG *")] int* plPriority);

        [VtblIndex(16)]
        HRESULT BeginRegisterPlatformWorkQueueWithMMCSSEx([NativeTypeName("DWORD")] uint dwPlatformWorkQueue, [NativeTypeName("LPCWSTR")] ushort* wszClass, [NativeTypeName("DWORD")] uint dwTaskId, [NativeTypeName("LONG")] int lPriority, IMFAsyncCallback* pCallback, IUnknown* pState);

        [VtblIndex(17)]
        HRESULT GetPlatformWorkQueueMMCSSPriority([NativeTypeName("DWORD")] uint dwPlatformWorkQueueId, [NativeTypeName("LONG *")] int* plPriority);
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

        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncCallback*, IUnknown*, int> BeginRegisterTopologyWorkQueuesWithMMCSS;

        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, int> EndRegisterTopologyWorkQueuesWithMMCSS;

        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncCallback*, IUnknown*, int> BeginUnregisterTopologyWorkQueuesWithMMCSS;

        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, int> EndUnregisterTopologyWorkQueuesWithMMCSS;

        [NativeTypeName("HRESULT (DWORD, LPWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetTopologyWorkQueueMMCSSClass;

        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetTopologyWorkQueueMMCSSTaskId;

        [NativeTypeName("HRESULT (DWORD, LPCWSTR, DWORD, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, IMFAsyncCallback*, IUnknown*, int> BeginRegisterPlatformWorkQueueWithMMCSS;

        [NativeTypeName("HRESULT (IMFAsyncResult *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, uint*, int> EndRegisterPlatformWorkQueueWithMMCSS;

        [NativeTypeName("HRESULT (DWORD, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMFAsyncCallback*, IUnknown*, int> BeginUnregisterPlatformWorkQueueWithMMCSS;

        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, int> EndUnregisterPlatformWorkQueueWithMMCSS;

        [NativeTypeName("HRESULT (DWORD, LPWSTR, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetPlaftormWorkQueueMMCSSClass;

        [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetPlatformWorkQueueMMCSSTaskId;

        [NativeTypeName("HRESULT (DWORD, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int*, int> GetTopologyWorkQueueMMCSSPriority;

        [NativeTypeName("HRESULT (DWORD, LPCWSTR, DWORD, LONG, IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, int, IMFAsyncCallback*, IUnknown*, int> BeginRegisterPlatformWorkQueueWithMMCSSEx;

        [NativeTypeName("HRESULT (DWORD, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int*, int> GetPlatformWorkQueueMMCSSPriority;
    }
}
