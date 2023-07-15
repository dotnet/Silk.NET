// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IFilterGraph3.xml' path='doc/member[@name="IFilterGraph3"]/*'/>
[Guid("AAF38154-B80B-422F-91E6-B66467509A07")]
[NativeTypeName("struct IFilterGraph3 : IFilterGraph2")]
[NativeInheritance("IFilterGraph2")]
public unsafe partial struct IFilterGraph3 : IFilterGraph3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFilterGraph3));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFilterGraph3*, Guid*, void**, int> )(lpVtbl[0]))((IFilterGraph3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFilterGraph3*, uint> )(lpVtbl[1]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFilterGraph3*, uint> )(lpVtbl[2]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IFilterGraph.AddFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddFilter(IBaseFilter* pFilter, [NativeTypeName("LPCWSTR")] ushort* pName)
    {
        return ((delegate* unmanaged<IFilterGraph3*, IBaseFilter*, ushort*, int> )(lpVtbl[3]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pFilter, pName);
    }

    /// <inheritdoc cref = "IFilterGraph.RemoveFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveFilter(IBaseFilter* pFilter)
    {
        return ((delegate* unmanaged<IFilterGraph3*, IBaseFilter*, int> )(lpVtbl[4]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pFilter);
    }

    /// <inheritdoc cref = "IFilterGraph.EnumFilters"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumFilters(IEnumFilters** ppEnum)
    {
        return ((delegate* unmanaged<IFilterGraph3*, IEnumFilters**, int> )(lpVtbl[5]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <inheritdoc cref = "IFilterGraph.FindFilterByName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindFilterByName([NativeTypeName("LPCWSTR")] ushort* pName, IBaseFilter** ppFilter)
    {
        return ((delegate* unmanaged<IFilterGraph3*, ushort*, IBaseFilter**, int> )(lpVtbl[6]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pName, ppFilter);
    }

    /// <inheritdoc cref = "IFilterGraph.ConnectDirect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConnectDirect(IPin* ppinOut, IPin* ppinIn, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged<IFilterGraph3*, IPin*, IPin*, AM_MEDIA_TYPE*, int> )(lpVtbl[7]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppinOut, ppinIn, pmt);
    }

    /// <inheritdoc cref = "IFilterGraph.Reconnect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reconnect(IPin* ppin)
    {
        return ((delegate* unmanaged<IFilterGraph3*, IPin*, int> )(lpVtbl[8]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppin);
    }

    /// <inheritdoc cref = "IFilterGraph.Disconnect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Disconnect(IPin* ppin)
    {
        return ((delegate* unmanaged<IFilterGraph3*, IPin*, int> )(lpVtbl[9]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppin);
    }

    /// <inheritdoc cref = "IFilterGraph.SetDefaultSyncSource"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetDefaultSyncSource()
    {
        return ((delegate* unmanaged<IFilterGraph3*, int> )(lpVtbl[10]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IGraphBuilder.Connect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Connect(IPin* ppinOut, IPin* ppinIn)
    {
        return ((delegate* unmanaged<IFilterGraph3*, IPin*, IPin*, int> )(lpVtbl[11]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppinOut, ppinIn);
    }

    /// <inheritdoc cref = "IGraphBuilder.Render"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Render(IPin* ppinOut)
    {
        return ((delegate* unmanaged<IFilterGraph3*, IPin*, int> )(lpVtbl[12]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppinOut);
    }

    /// <inheritdoc cref = "IGraphBuilder.RenderFile"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RenderFile([NativeTypeName("LPCWSTR")] ushort* lpcwstrFile, [NativeTypeName("LPCWSTR")] ushort* lpcwstrPlayList)
    {
        return ((delegate* unmanaged<IFilterGraph3*, ushort*, ushort*, int> )(lpVtbl[13]))((IFilterGraph3*)Unsafe.AsPointer(ref this), lpcwstrFile, lpcwstrPlayList);
    }

    /// <inheritdoc cref = "IGraphBuilder.AddSourceFilter"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT AddSourceFilter([NativeTypeName("LPCWSTR")] ushort* lpcwstrFileName, [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName, IBaseFilter** ppFilter)
    {
        return ((delegate* unmanaged<IFilterGraph3*, ushort*, ushort*, IBaseFilter**, int> )(lpVtbl[14]))((IFilterGraph3*)Unsafe.AsPointer(ref this), lpcwstrFileName, lpcwstrFilterName, ppFilter);
    }

    /// <inheritdoc cref = "IGraphBuilder.SetLogFile"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetLogFile([NativeTypeName("DWORD_PTR")] nuint hFile)
    {
        return ((delegate* unmanaged<IFilterGraph3*, nuint, int> )(lpVtbl[15]))((IFilterGraph3*)Unsafe.AsPointer(ref this), hFile);
    }

    /// <inheritdoc cref = "IGraphBuilder.Abort"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Abort()
    {
        return ((delegate* unmanaged<IFilterGraph3*, int> )(lpVtbl[16]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IGraphBuilder.ShouldOperationContinue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ShouldOperationContinue()
    {
        return ((delegate* unmanaged<IFilterGraph3*, int> )(lpVtbl[17]))((IFilterGraph3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IFilterGraph2.AddSourceFilterForMoniker"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT AddSourceFilterForMoniker(IMoniker* pMoniker, IBindCtx* pCtx, [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName, IBaseFilter** ppFilter)
    {
        return ((delegate* unmanaged<IFilterGraph3*, IMoniker*, IBindCtx*, ushort*, IBaseFilter**, int> )(lpVtbl[18]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pMoniker, pCtx, lpcwstrFilterName, ppFilter);
    }

    /// <inheritdoc cref = "IFilterGraph2.ReconnectEx"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ReconnectEx(IPin* ppin, [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt)
    {
        return ((delegate* unmanaged<IFilterGraph3*, IPin*, AM_MEDIA_TYPE*, int> )(lpVtbl[19]))((IFilterGraph3*)Unsafe.AsPointer(ref this), ppin, pmt);
    }

    /// <inheritdoc cref = "IFilterGraph2.RenderEx"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT RenderEx(IPin* pPinOut, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pvContext)
    {
        return ((delegate* unmanaged<IFilterGraph3*, IPin*, uint, uint*, int> )(lpVtbl[20]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pPinOut, dwFlags, pvContext);
    }

    /// <include file='IFilterGraph3.xml' path='doc/member[@name="IFilterGraph3.SetSyncSourceEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetSyncSourceEx(IReferenceClock* pClockForMostOfFilterGraph, IReferenceClock* pClockForFilter, IBaseFilter* pFilter)
    {
        return ((delegate* unmanaged<IFilterGraph3*, IReferenceClock*, IReferenceClock*, IBaseFilter*, int> )(lpVtbl[21]))((IFilterGraph3*)Unsafe.AsPointer(ref this), pClockForMostOfFilterGraph, pClockForFilter, pFilter);
    }

    public interface Interface : IFilterGraph2.Interface
    {
        [VtblIndex(21)]
        HRESULT SetSyncSourceEx(IReferenceClock* pClockForMostOfFilterGraph, IReferenceClock* pClockForFilter, IBaseFilter* pFilter);
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
        [NativeTypeName("HRESULT (IBaseFilter *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter*, ushort*, int> AddFilter;
        [NativeTypeName("HRESULT (IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter*, int> RemoveFilter;
        [NativeTypeName("HRESULT (IEnumFilters **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumFilters**, int> EnumFilters;
        [NativeTypeName("HRESULT (LPCWSTR, IBaseFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IBaseFilter**, int> FindFilterByName;
        [NativeTypeName("HRESULT (IPin *, IPin *, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, IPin*, AM_MEDIA_TYPE*, int> ConnectDirect;
        [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, int> Reconnect;
        [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, int> Disconnect;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetDefaultSyncSource;
        [NativeTypeName("HRESULT (IPin *, IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, IPin*, int> Connect;
        [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, int> Render;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> RenderFile;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IBaseFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IBaseFilter**, int> AddSourceFilter;
        [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, int> SetLogFile;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Abort;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ShouldOperationContinue;
        [NativeTypeName("HRESULT (IMoniker *, IBindCtx *, LPCWSTR, IBaseFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker*, IBindCtx*, ushort*, IBaseFilter**, int> AddSourceFilterForMoniker;
        [NativeTypeName("HRESULT (IPin *, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, AM_MEDIA_TYPE*, int> ReconnectEx;
        [NativeTypeName("HRESULT (IPin *, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin*, uint, uint*, int> RenderEx;
        [NativeTypeName("HRESULT (IReferenceClock *, IReferenceClock *, IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IReferenceClock*, IReferenceClock*, IBaseFilter*, int> SetSyncSourceEx;
    }
}