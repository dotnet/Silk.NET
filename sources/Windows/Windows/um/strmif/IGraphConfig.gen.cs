// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IGraphConfig.xml' path='doc/member[@name="IGraphConfig"]/*'/>
[Guid("03A1EB8E-32BF-4245-8502-114D08A9CB88")]
[NativeTypeName("struct IGraphConfig : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IGraphConfig : IGraphConfig.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGraphConfig));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGraphConfig*, Guid*, void**, int> )(lpVtbl[0]))((IGraphConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IGraphConfig*, uint> )(lpVtbl[1]))((IGraphConfig*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGraphConfig*, uint> )(lpVtbl[2]))((IGraphConfig*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IGraphConfig.xml' path='doc/member[@name="IGraphConfig.Reconnect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Reconnect(IPin* pOutputPin, IPin* pInputPin, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmtFirstConnection, IBaseFilter* pUsingFilter, HANDLE hAbortEvent, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IGraphConfig*, IPin*, IPin*, AM_MEDIA_TYPE*, IBaseFilter*, HANDLE, uint, int> )(lpVtbl[3]))((IGraphConfig*)Unsafe.AsPointer(ref this), pOutputPin, pInputPin, pmtFirstConnection, pUsingFilter, hAbortEvent, dwFlags);
    }

    /// <include file='IGraphConfig.xml' path='doc/member[@name="IGraphConfig.Reconfigure"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Reconfigure(IGraphConfigCallback* pCallback, [NativeTypeName("PVOID")] void* pvContext, [NativeTypeName("DWORD")] uint dwFlags, HANDLE hAbortEvent)
    {
        return ((delegate* unmanaged<IGraphConfig*, IGraphConfigCallback*, void*, uint, HANDLE, int> )(lpVtbl[4]))((IGraphConfig*)Unsafe.AsPointer(ref this), pCallback, pvContext, dwFlags, hAbortEvent);
    }

    /// <include file='IGraphConfig.xml' path='doc/member[@name="IGraphConfig.AddFilterToCache"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddFilterToCache(IBaseFilter* pFilter)
    {
        return ((delegate* unmanaged<IGraphConfig*, IBaseFilter*, int> )(lpVtbl[5]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <include file='IGraphConfig.xml' path='doc/member[@name="IGraphConfig.EnumCacheFilter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumCacheFilter(IEnumFilters** pEnum)
    {
        return ((delegate* unmanaged<IGraphConfig*, IEnumFilters**, int> )(lpVtbl[6]))((IGraphConfig*)Unsafe.AsPointer(ref this), pEnum);
    }

    /// <include file='IGraphConfig.xml' path='doc/member[@name="IGraphConfig.RemoveFilterFromCache"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveFilterFromCache(IBaseFilter* pFilter)
    {
        return ((delegate* unmanaged<IGraphConfig*, IBaseFilter*, int> )(lpVtbl[7]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <include file='IGraphConfig.xml' path='doc/member[@name="IGraphConfig.GetStartTime"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStartTime([NativeTypeName("REFERENCE_TIME *")] long* prtStart)
    {
        return ((delegate* unmanaged<IGraphConfig*, long*, int> )(lpVtbl[8]))((IGraphConfig*)Unsafe.AsPointer(ref this), prtStart);
    }

    /// <include file='IGraphConfig.xml' path='doc/member[@name="IGraphConfig.PushThroughData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT PushThroughData(IPin* pOutputPin, IPinConnection* pConnection, HANDLE hEventAbort)
    {
        return ((delegate* unmanaged<IGraphConfig*, IPin*, IPinConnection*, HANDLE, int> )(lpVtbl[9]))((IGraphConfig*)Unsafe.AsPointer(ref this), pOutputPin, pConnection, hEventAbort);
    }

    /// <include file='IGraphConfig.xml' path='doc/member[@name="IGraphConfig.SetFilterFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetFilterFlags(IBaseFilter* pFilter, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IGraphConfig*, IBaseFilter*, uint, int> )(lpVtbl[10]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter, dwFlags);
    }

    /// <include file='IGraphConfig.xml' path='doc/member[@name="IGraphConfig.GetFilterFlags"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFilterFlags(IBaseFilter* pFilter, [NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IGraphConfig*, IBaseFilter*, uint*, int> )(lpVtbl[11]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter, pdwFlags);
    }

    /// <include file='IGraphConfig.xml' path='doc/member[@name="IGraphConfig.RemoveFilterEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RemoveFilterEx(IBaseFilter* pFilter, [NativeTypeName("DWORD")] uint Flags)
    {
        return ((delegate* unmanaged<IGraphConfig*, IBaseFilter*, uint, int> )(lpVtbl[12]))((IGraphConfig*)Unsafe.AsPointer(ref this), pFilter, Flags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Reconnect(IPin* pOutputPin, IPin* pInputPin, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmtFirstConnection, IBaseFilter* pUsingFilter, HANDLE hAbortEvent, [NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(4)]
        HRESULT Reconfigure(IGraphConfigCallback* pCallback, [NativeTypeName("PVOID")] void* pvContext, [NativeTypeName("DWORD")] uint dwFlags, HANDLE hAbortEvent);
        [VtblIndex(5)]
        HRESULT AddFilterToCache(IBaseFilter* pFilter);
        [VtblIndex(6)]
        HRESULT EnumCacheFilter(IEnumFilters** pEnum);
        [VtblIndex(7)]
        HRESULT RemoveFilterFromCache(IBaseFilter* pFilter);
        [VtblIndex(8)]
        HRESULT GetStartTime([NativeTypeName("REFERENCE_TIME *")] long* prtStart);
        [VtblIndex(9)]
        HRESULT PushThroughData(IPin* pOutputPin, IPinConnection* pConnection, HANDLE hEventAbort);
        [VtblIndex(10)]
        HRESULT SetFilterFlags(IBaseFilter* pFilter, [NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(11)]
        HRESULT GetFilterFlags(IBaseFilter* pFilter, [NativeTypeName("DWORD *")] uint* pdwFlags);
        [VtblIndex(12)]
        HRESULT RemoveFilterEx(IBaseFilter* pFilter, [NativeTypeName("DWORD")] uint Flags);
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
        [NativeTypeName("HRESULT (IPin *, IPin *, const AM_MEDIA_TYPE *, IBaseFilter *, HANDLE, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, IPin*, AM_MEDIA_TYPE*, IBaseFilter*, HANDLE, uint, int> Reconnect;
        [NativeTypeName("HRESULT (IGraphConfigCallback *, PVOID, DWORD, HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IGraphConfigCallback*, void*, uint, HANDLE, int> Reconfigure;
        [NativeTypeName("HRESULT (IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter*, int> AddFilterToCache;
        [NativeTypeName("HRESULT (IEnumFilters **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumFilters**, int> EnumCacheFilter;
        [NativeTypeName("HRESULT (IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter*, int> RemoveFilterFromCache;
        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetStartTime;
        [NativeTypeName("HRESULT (IPin *, IPinConnection *, HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, IPinConnection*, HANDLE, int> PushThroughData;
        [NativeTypeName("HRESULT (IBaseFilter *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter*, uint, int> SetFilterFlags;
        [NativeTypeName("HRESULT (IBaseFilter *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter*, uint*, int> GetFilterFlags;
        [NativeTypeName("HRESULT (IBaseFilter *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter*, uint, int> RemoveFilterEx;
    }
}