// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("03A1EB8E-32BF-4245-8502-114D08A9CB88")]
[NativeTypeName("struct IGraphConfig : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IGraphConfig : IGraphConfig.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGraphConfig));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGraphConfig, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGraphConfig, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGraphConfig, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Reconnect(
        IPin pOutputPin,
        IPin pInputPin,
        [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmtFirstConnection,
        IBaseFilter pUsingFilter,
        HANDLE hAbortEvent,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<
                IGraphConfig,
                IPin,
                IPin,
                AM_MEDIA_TYPE*,
                IBaseFilter,
                HANDLE,
                uint,
                int>)((*lpVtbl)[3])
        )(this, pOutputPin, pInputPin, pmtFirstConnection, pUsingFilter, hAbortEvent, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Reconfigure(
        IGraphConfigCallback pCallback,
        [NativeTypeName("PVOID")] void* pvContext,
        [NativeTypeName("DWORD")] uint dwFlags,
        HANDLE hAbortEvent
    )
    {
        return (
            (delegate* unmanaged<IGraphConfig, IGraphConfigCallback, void*, uint, HANDLE, int>)(
                (*lpVtbl)[4]
            )
        )(this, pCallback, pvContext, dwFlags, hAbortEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddFilterToCache(IBaseFilter pFilter)
    {
        return ((delegate* unmanaged<IGraphConfig, IBaseFilter, int>)((*lpVtbl)[5]))(this, pFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumCacheFilter(IEnumFilters* pEnum)
    {
        return ((delegate* unmanaged<IGraphConfig, IEnumFilters*, int>)((*lpVtbl)[6]))(this, pEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveFilterFromCache(IBaseFilter pFilter)
    {
        return ((delegate* unmanaged<IGraphConfig, IBaseFilter, int>)((*lpVtbl)[7]))(this, pFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStartTime([NativeTypeName("REFERENCE_TIME *")] long* prtStart)
    {
        return ((delegate* unmanaged<IGraphConfig, long*, int>)((*lpVtbl)[8]))(this, prtStart);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT PushThroughData(IPin pOutputPin, IPinConnection pConnection, HANDLE hEventAbort)
    {
        return (
            (delegate* unmanaged<IGraphConfig, IPin, IPinConnection, HANDLE, int>)((*lpVtbl)[9])
        )(this, pOutputPin, pConnection, hEventAbort);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetFilterFlags(IBaseFilter pFilter, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IGraphConfig, IBaseFilter, uint, int>)((*lpVtbl)[10]))(
            this,
            pFilter,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFilterFlags(IBaseFilter pFilter, [NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IGraphConfig, IBaseFilter, uint*, int>)((*lpVtbl)[11]))(
            this,
            pFilter,
            pdwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT RemoveFilterEx(IBaseFilter pFilter, [NativeTypeName("DWORD")] uint Flags)
    {
        return ((delegate* unmanaged<IGraphConfig, IBaseFilter, uint, int>)((*lpVtbl)[12]))(
            this,
            pFilter,
            Flags
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Reconnect(
            IPin pOutputPin,
            IPin pInputPin,
            [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmtFirstConnection,
            IBaseFilter pUsingFilter,
            HANDLE hAbortEvent,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(4)]
        HRESULT Reconfigure(
            IGraphConfigCallback pCallback,
            [NativeTypeName("PVOID")] void* pvContext,
            [NativeTypeName("DWORD")] uint dwFlags,
            HANDLE hAbortEvent
        );

        [VtblIndex(5)]
        HRESULT AddFilterToCache(IBaseFilter pFilter);

        [VtblIndex(6)]
        HRESULT EnumCacheFilter(IEnumFilters* pEnum);

        [VtblIndex(7)]
        HRESULT RemoveFilterFromCache(IBaseFilter pFilter);

        [VtblIndex(8)]
        HRESULT GetStartTime([NativeTypeName("REFERENCE_TIME *")] long* prtStart);

        [VtblIndex(9)]
        HRESULT PushThroughData(IPin pOutputPin, IPinConnection pConnection, HANDLE hEventAbort);

        [VtblIndex(10)]
        HRESULT SetFilterFlags(IBaseFilter pFilter, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(11)]
        HRESULT GetFilterFlags(IBaseFilter pFilter, [NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(12)]
        HRESULT RemoveFilterEx(IBaseFilter pFilter, [NativeTypeName("DWORD")] uint Flags);
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

        [NativeTypeName(
            "HRESULT (IPin *, IPin *, const AM_MEDIA_TYPE *, IBaseFilter *, HANDLE, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IPin,
            IPin,
            AM_MEDIA_TYPE*,
            IBaseFilter,
            HANDLE,
            uint,
            int> Reconnect;

        [NativeTypeName(
            "HRESULT (IGraphConfigCallback *, PVOID, DWORD, HANDLE) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IGraphConfigCallback,
            void*,
            uint,
            HANDLE,
            int> Reconfigure;

        [NativeTypeName("HRESULT (IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter, int> AddFilterToCache;

        [NativeTypeName("HRESULT (IEnumFilters **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumFilters*, int> EnumCacheFilter;

        [NativeTypeName("HRESULT (IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter, int> RemoveFilterFromCache;

        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetStartTime;

        [NativeTypeName("HRESULT (IPin *, IPinConnection *, HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin, IPinConnection, HANDLE, int> PushThroughData;

        [NativeTypeName("HRESULT (IBaseFilter *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter, uint, int> SetFilterFlags;

        [NativeTypeName("HRESULT (IBaseFilter *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter, uint*, int> GetFilterFlags;

        [NativeTypeName("HRESULT (IBaseFilter *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter, uint, int> RemoveFilterEx;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGraphConfig"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGraphConfig(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGraphConfig"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGraphConfig(Silk.NET.Windows.IUnknown value)
    {
        return new IGraphConfig(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGraphConfig"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGraphConfig"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGraphConfig value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
