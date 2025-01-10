// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("36B73882-C2C8-11CF-8B46-00805F6CEF60")]
[NativeTypeName("struct IFilterGraph2 : IGraphBuilder")]
[NativeInheritance("IGraphBuilder")]
public unsafe partial struct IFilterGraph2 : IFilterGraph2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFilterGraph2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFilterGraph2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFilterGraph2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFilterGraph2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddFilter(IBaseFilter pFilter, [NativeTypeName("LPCWSTR")] ushort* pName)
    {
        return ((delegate* unmanaged<IFilterGraph2, IBaseFilter, ushort*, int>)((*lpVtbl)[3]))(
            this,
            pFilter,
            pName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveFilter(IBaseFilter pFilter)
    {
        return ((delegate* unmanaged<IFilterGraph2, IBaseFilter, int>)((*lpVtbl)[4]))(
            this,
            pFilter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumFilters(IEnumFilters* ppEnum)
    {
        return ((delegate* unmanaged<IFilterGraph2, IEnumFilters*, int>)((*lpVtbl)[5]))(
            this,
            ppEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindFilterByName(
        [NativeTypeName("LPCWSTR")] ushort* pName,
        IBaseFilter* ppFilter
    )
    {
        return ((delegate* unmanaged<IFilterGraph2, ushort*, IBaseFilter*, int>)((*lpVtbl)[6]))(
            this,
            pName,
            ppFilter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConnectDirect(
        IPin ppinOut,
        IPin ppinIn,
        [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt
    )
    {
        return (
            (delegate* unmanaged<IFilterGraph2, IPin, IPin, AM_MEDIA_TYPE*, int>)((*lpVtbl)[7])
        )(this, ppinOut, ppinIn, pmt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reconnect(IPin ppin)
    {
        return ((delegate* unmanaged<IFilterGraph2, IPin, int>)((*lpVtbl)[8]))(this, ppin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Disconnect(IPin ppin)
    {
        return ((delegate* unmanaged<IFilterGraph2, IPin, int>)((*lpVtbl)[9]))(this, ppin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetDefaultSyncSource()
    {
        return ((delegate* unmanaged<IFilterGraph2, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Connect(IPin ppinOut, IPin ppinIn)
    {
        return ((delegate* unmanaged<IFilterGraph2, IPin, IPin, int>)((*lpVtbl)[11]))(
            this,
            ppinOut,
            ppinIn
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Render(IPin ppinOut)
    {
        return ((delegate* unmanaged<IFilterGraph2, IPin, int>)((*lpVtbl)[12]))(this, ppinOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RenderFile(
        [NativeTypeName("LPCWSTR")] ushort* lpcwstrFile,
        [NativeTypeName("LPCWSTR")] ushort* lpcwstrPlayList
    )
    {
        return ((delegate* unmanaged<IFilterGraph2, ushort*, ushort*, int>)((*lpVtbl)[13]))(
            this,
            lpcwstrFile,
            lpcwstrPlayList
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT AddSourceFilter(
        [NativeTypeName("LPCWSTR")] ushort* lpcwstrFileName,
        [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName,
        IBaseFilter* ppFilter
    )
    {
        return (
            (delegate* unmanaged<IFilterGraph2, ushort*, ushort*, IBaseFilter*, int>)((*lpVtbl)[14])
        )(this, lpcwstrFileName, lpcwstrFilterName, ppFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetLogFile([NativeTypeName("DWORD_PTR")] nuint hFile)
    {
        return ((delegate* unmanaged<IFilterGraph2, nuint, int>)((*lpVtbl)[15]))(this, hFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Abort()
    {
        return ((delegate* unmanaged<IFilterGraph2, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ShouldOperationContinue()
    {
        return ((delegate* unmanaged<IFilterGraph2, int>)((*lpVtbl)[17]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT AddSourceFilterForMoniker(
        IMoniker pMoniker,
        IBindCtx pCtx,
        [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName,
        IBaseFilter* ppFilter
    )
    {
        return (
            (delegate* unmanaged<IFilterGraph2, IMoniker, IBindCtx, ushort*, IBaseFilter*, int>)(
                (*lpVtbl)[18]
            )
        )(this, pMoniker, pCtx, lpcwstrFilterName, ppFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ReconnectEx(
        IPin ppin,
        [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt
    )
    {
        return ((delegate* unmanaged<IFilterGraph2, IPin, AM_MEDIA_TYPE*, int>)((*lpVtbl)[19]))(
            this,
            ppin,
            pmt
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT RenderEx(
        IPin pPinOut,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("DWORD *")] uint* pvContext
    )
    {
        return ((delegate* unmanaged<IFilterGraph2, IPin, uint, uint*, int>)((*lpVtbl)[20]))(
            this,
            pPinOut,
            dwFlags,
            pvContext
        );
    }

    public interface Interface : IGraphBuilder.Interface
    {
        [VtblIndex(18)]
        HRESULT AddSourceFilterForMoniker(
            IMoniker pMoniker,
            IBindCtx pCtx,
            [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName,
            IBaseFilter* ppFilter
        );

        [VtblIndex(19)]
        HRESULT ReconnectEx(
            IPin ppin,
            [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt
        );

        [VtblIndex(20)]
        HRESULT RenderEx(
            IPin pPinOut,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("DWORD *")] uint* pvContext
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

        [NativeTypeName("HRESULT (IBaseFilter *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter, ushort*, int> AddFilter;

        [NativeTypeName("HRESULT (IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBaseFilter, int> RemoveFilter;

        [NativeTypeName("HRESULT (IEnumFilters **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumFilters*, int> EnumFilters;

        [NativeTypeName("HRESULT (LPCWSTR, IBaseFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IBaseFilter*, int> FindFilterByName;

        [NativeTypeName("HRESULT (IPin *, IPin *, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin, IPin, AM_MEDIA_TYPE*, int> ConnectDirect;

        [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin, int> Reconnect;

        [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin, int> Disconnect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SetDefaultSyncSource;

        [NativeTypeName("HRESULT (IPin *, IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin, IPin, int> Connect;

        [NativeTypeName("HRESULT (IPin *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin, int> Render;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> RenderFile;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, IBaseFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IBaseFilter*, int> AddSourceFilter;

        [NativeTypeName("HRESULT (DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, int> SetLogFile;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Abort;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ShouldOperationContinue;

        [NativeTypeName(
            "HRESULT (IMoniker *, IBindCtx *, LPCWSTR, IBaseFilter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMoniker,
            IBindCtx,
            ushort*,
            IBaseFilter*,
            int> AddSourceFilterForMoniker;

        [NativeTypeName("HRESULT (IPin *, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin, AM_MEDIA_TYPE*, int> ReconnectEx;

        [NativeTypeName("HRESULT (IPin *, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPin, uint, uint*, int> RenderEx;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFilterGraph2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFilterGraph2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IGraphBuilder"/> to <see cref = "IFilterGraph2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IGraphBuilder"/> instance to be converted </param>
    public static explicit operator IFilterGraph2(Silk.NET.Windows.IGraphBuilder value)
    {
        return new IFilterGraph2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFilterGraph2"/> to <see cref = "Silk.NET.Windows.IGraphBuilder"/>.</summary>
    /// <param name = "value">The <see cref = "IFilterGraph2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IGraphBuilder(IFilterGraph2 value)
    {
        return new Silk.NET.Windows.IGraphBuilder(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IFilterGraph"/> to <see cref = "IFilterGraph2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IFilterGraph"/> instance to be converted </param>
    public static explicit operator IFilterGraph2(Silk.NET.Windows.IFilterGraph value)
    {
        return new IFilterGraph2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFilterGraph2"/> to <see cref = "Silk.NET.Windows.IFilterGraph"/>.</summary>
    /// <param name = "value">The <see cref = "IFilterGraph2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IFilterGraph(IFilterGraph2 value)
    {
        return new Silk.NET.Windows.IFilterGraph(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFilterGraph2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFilterGraph2(Silk.NET.Windows.IUnknown value)
    {
        return new IFilterGraph2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFilterGraph2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFilterGraph2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFilterGraph2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
