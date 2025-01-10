// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A868A9-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IGraphBuilder : IFilterGraph")]
[NativeInheritance("IFilterGraph")]
public unsafe partial struct IGraphBuilder : IGraphBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGraphBuilder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGraphBuilder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGraphBuilder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGraphBuilder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddFilter(IBaseFilter pFilter, [NativeTypeName("LPCWSTR")] ushort* pName)
    {
        return ((delegate* unmanaged<IGraphBuilder, IBaseFilter, ushort*, int>)((*lpVtbl)[3]))(
            this,
            pFilter,
            pName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveFilter(IBaseFilter pFilter)
    {
        return ((delegate* unmanaged<IGraphBuilder, IBaseFilter, int>)((*lpVtbl)[4]))(
            this,
            pFilter
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumFilters(IEnumFilters* ppEnum)
    {
        return ((delegate* unmanaged<IGraphBuilder, IEnumFilters*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IGraphBuilder, ushort*, IBaseFilter*, int>)((*lpVtbl)[6]))(
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
            (delegate* unmanaged<IGraphBuilder, IPin, IPin, AM_MEDIA_TYPE*, int>)((*lpVtbl)[7])
        )(this, ppinOut, ppinIn, pmt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Reconnect(IPin ppin)
    {
        return ((delegate* unmanaged<IGraphBuilder, IPin, int>)((*lpVtbl)[8]))(this, ppin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Disconnect(IPin ppin)
    {
        return ((delegate* unmanaged<IGraphBuilder, IPin, int>)((*lpVtbl)[9]))(this, ppin);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetDefaultSyncSource()
    {
        return ((delegate* unmanaged<IGraphBuilder, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Connect(IPin ppinOut, IPin ppinIn)
    {
        return ((delegate* unmanaged<IGraphBuilder, IPin, IPin, int>)((*lpVtbl)[11]))(
            this,
            ppinOut,
            ppinIn
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Render(IPin ppinOut)
    {
        return ((delegate* unmanaged<IGraphBuilder, IPin, int>)((*lpVtbl)[12]))(this, ppinOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RenderFile(
        [NativeTypeName("LPCWSTR")] ushort* lpcwstrFile,
        [NativeTypeName("LPCWSTR")] ushort* lpcwstrPlayList
    )
    {
        return ((delegate* unmanaged<IGraphBuilder, ushort*, ushort*, int>)((*lpVtbl)[13]))(
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
            (delegate* unmanaged<IGraphBuilder, ushort*, ushort*, IBaseFilter*, int>)((*lpVtbl)[14])
        )(this, lpcwstrFileName, lpcwstrFilterName, ppFilter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetLogFile([NativeTypeName("DWORD_PTR")] nuint hFile)
    {
        return ((delegate* unmanaged<IGraphBuilder, nuint, int>)((*lpVtbl)[15]))(this, hFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT Abort()
    {
        return ((delegate* unmanaged<IGraphBuilder, int>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ShouldOperationContinue()
    {
        return ((delegate* unmanaged<IGraphBuilder, int>)((*lpVtbl)[17]))(this);
    }

    public interface Interface : IFilterGraph.Interface
    {
        [VtblIndex(11)]
        HRESULT Connect(IPin ppinOut, IPin ppinIn);

        [VtblIndex(12)]
        HRESULT Render(IPin ppinOut);

        [VtblIndex(13)]
        HRESULT RenderFile(
            [NativeTypeName("LPCWSTR")] ushort* lpcwstrFile,
            [NativeTypeName("LPCWSTR")] ushort* lpcwstrPlayList
        );

        [VtblIndex(14)]
        HRESULT AddSourceFilter(
            [NativeTypeName("LPCWSTR")] ushort* lpcwstrFileName,
            [NativeTypeName("LPCWSTR")] ushort* lpcwstrFilterName,
            IBaseFilter* ppFilter
        );

        [VtblIndex(15)]
        HRESULT SetLogFile([NativeTypeName("DWORD_PTR")] nuint hFile);

        [VtblIndex(16)]
        HRESULT Abort();

        [VtblIndex(17)]
        HRESULT ShouldOperationContinue();
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IGraphBuilder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGraphBuilder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IFilterGraph"/> to <see cref = "IGraphBuilder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IFilterGraph"/> instance to be converted </param>
    public static explicit operator IGraphBuilder(Silk.NET.Windows.IFilterGraph value)
    {
        return new IGraphBuilder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGraphBuilder"/> to <see cref = "Silk.NET.Windows.IFilterGraph"/>.</summary>
    /// <param name = "value">The <see cref = "IGraphBuilder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IFilterGraph(IGraphBuilder value)
    {
        return new Silk.NET.Windows.IFilterGraph(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGraphBuilder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGraphBuilder(Silk.NET.Windows.IUnknown value)
    {
        return new IGraphBuilder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGraphBuilder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGraphBuilder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGraphBuilder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
