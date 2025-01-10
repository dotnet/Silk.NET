// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("93E5A4E0-2D50-11D2-ABFA-00A0C9C6E38D")]
[NativeTypeName("struct ICaptureGraphBuilder2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICaptureGraphBuilder2 : ICaptureGraphBuilder2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICaptureGraphBuilder2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICaptureGraphBuilder2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFiltergraph(IGraphBuilder pfg)
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder2, IGraphBuilder, int>)((*lpVtbl)[3]))(
            this,
            pfg
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFiltergraph(IGraphBuilder* ppfg)
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder2, IGraphBuilder*, int>)((*lpVtbl)[4]))(
            this,
            ppfg
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOutputFileName(
        [NativeTypeName("const GUID *")] Guid* pType,
        [NativeTypeName("LPCOLESTR")] ushort* lpstrFile,
        IBaseFilter* ppf,
        IFileSinkFilter* ppSink
    )
    {
        return (
            (delegate* unmanaged<
                ICaptureGraphBuilder2,
                Guid*,
                ushort*,
                IBaseFilter*,
                IFileSinkFilter*,
                int>)((*lpVtbl)[5])
        )(this, pType, lpstrFile, ppf, ppSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindInterface(
        [NativeTypeName("const GUID *")] Guid* pCategory,
        [NativeTypeName("const GUID *")] Guid* pType,
        IBaseFilter pf,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppint
    )
    {
        return (
            (delegate* unmanaged<
                ICaptureGraphBuilder2,
                Guid*,
                Guid*,
                IBaseFilter,
                Guid*,
                void**,
                int>)((*lpVtbl)[6])
        )(this, pCategory, pType, pf, riid, ppint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RenderStream(
        [NativeTypeName("const GUID *")] Guid* pCategory,
        [NativeTypeName("const GUID *")] Guid* pType,
        IUnknown pSource,
        IBaseFilter pfCompressor,
        IBaseFilter pfRenderer
    )
    {
        return (
            (delegate* unmanaged<
                ICaptureGraphBuilder2,
                Guid*,
                Guid*,
                IUnknown,
                IBaseFilter,
                IBaseFilter,
                int>)((*lpVtbl)[7])
        )(this, pCategory, pType, pSource, pfCompressor, pfRenderer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ControlStream(
        [NativeTypeName("const GUID *")] Guid* pCategory,
        [NativeTypeName("const GUID *")] Guid* pType,
        IBaseFilter pFilter,
        [NativeTypeName("REFERENCE_TIME *")] long* pstart,
        [NativeTypeName("REFERENCE_TIME *")] long* pstop,
        [NativeTypeName("WORD")] ushort wStartCookie,
        [NativeTypeName("WORD")] ushort wStopCookie
    )
    {
        return (
            (delegate* unmanaged<
                ICaptureGraphBuilder2,
                Guid*,
                Guid*,
                IBaseFilter,
                long*,
                long*,
                ushort,
                ushort,
                int>)((*lpVtbl)[8])
        )(this, pCategory, pType, pFilter, pstart, pstop, wStartCookie, wStopCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AllocCapFile(
        [NativeTypeName("LPCOLESTR")] ushort* lpstr,
        [NativeTypeName("DWORDLONG")] ulong dwlSize
    )
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder2, ushort*, ulong, int>)((*lpVtbl)[9]))(
            this,
            lpstr,
            dwlSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CopyCaptureFile(
        [NativeTypeName("LPOLESTR")] ushort* lpwstrOld,
        [NativeTypeName("LPOLESTR")] ushort* lpwstrNew,
        int fAllowEscAbort,
        IAMCopyCaptureFileProgress pCallback
    )
    {
        return (
            (delegate* unmanaged<
                ICaptureGraphBuilder2,
                ushort*,
                ushort*,
                int,
                IAMCopyCaptureFileProgress,
                int>)((*lpVtbl)[10])
        )(this, lpwstrOld, lpwstrNew, fAllowEscAbort, pCallback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT FindPin(
        IUnknown pSource,
        PIN_DIRECTION pindir,
        [NativeTypeName("const GUID *")] Guid* pCategory,
        [NativeTypeName("const GUID *")] Guid* pType,
        BOOL fUnconnected,
        int num,
        IPin* ppPin
    )
    {
        return (
            (delegate* unmanaged<
                ICaptureGraphBuilder2,
                IUnknown,
                PIN_DIRECTION,
                Guid*,
                Guid*,
                BOOL,
                int,
                IPin*,
                int>)((*lpVtbl)[11])
        )(this, pSource, pindir, pCategory, pType, fUnconnected, num, ppPin);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetFiltergraph(IGraphBuilder pfg);

        [VtblIndex(4)]
        HRESULT GetFiltergraph(IGraphBuilder* ppfg);

        [VtblIndex(5)]
        HRESULT SetOutputFileName(
            [NativeTypeName("const GUID *")] Guid* pType,
            [NativeTypeName("LPCOLESTR")] ushort* lpstrFile,
            IBaseFilter* ppf,
            IFileSinkFilter* ppSink
        );

        [VtblIndex(6)]
        HRESULT FindInterface(
            [NativeTypeName("const GUID *")] Guid* pCategory,
            [NativeTypeName("const GUID *")] Guid* pType,
            IBaseFilter pf,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppint
        );

        [VtblIndex(7)]
        HRESULT RenderStream(
            [NativeTypeName("const GUID *")] Guid* pCategory,
            [NativeTypeName("const GUID *")] Guid* pType,
            IUnknown pSource,
            IBaseFilter pfCompressor,
            IBaseFilter pfRenderer
        );

        [VtblIndex(8)]
        HRESULT ControlStream(
            [NativeTypeName("const GUID *")] Guid* pCategory,
            [NativeTypeName("const GUID *")] Guid* pType,
            IBaseFilter pFilter,
            [NativeTypeName("REFERENCE_TIME *")] long* pstart,
            [NativeTypeName("REFERENCE_TIME *")] long* pstop,
            [NativeTypeName("WORD")] ushort wStartCookie,
            [NativeTypeName("WORD")] ushort wStopCookie
        );

        [VtblIndex(9)]
        HRESULT AllocCapFile(
            [NativeTypeName("LPCOLESTR")] ushort* lpstr,
            [NativeTypeName("DWORDLONG")] ulong dwlSize
        );

        [VtblIndex(10)]
        HRESULT CopyCaptureFile(
            [NativeTypeName("LPOLESTR")] ushort* lpwstrOld,
            [NativeTypeName("LPOLESTR")] ushort* lpwstrNew,
            int fAllowEscAbort,
            IAMCopyCaptureFileProgress pCallback
        );

        [VtblIndex(11)]
        HRESULT FindPin(
            IUnknown pSource,
            PIN_DIRECTION pindir,
            [NativeTypeName("const GUID *")] Guid* pCategory,
            [NativeTypeName("const GUID *")] Guid* pType,
            BOOL fUnconnected,
            int num,
            IPin* ppPin
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

        [NativeTypeName("HRESULT (IGraphBuilder *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IGraphBuilder, int> SetFiltergraph;

        [NativeTypeName("HRESULT (IGraphBuilder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IGraphBuilder*, int> GetFiltergraph;

        [NativeTypeName(
            "HRESULT (const GUID *, LPCOLESTR, IBaseFilter **, IFileSinkFilter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            ushort*,
            IBaseFilter*,
            IFileSinkFilter*,
            int> SetOutputFileName;

        [NativeTypeName(
            "HRESULT (const GUID *, const GUID *, IBaseFilter *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            Guid*,
            IBaseFilter,
            Guid*,
            void**,
            int> FindInterface;

        [NativeTypeName(
            "HRESULT (const GUID *, const GUID *, IUnknown *, IBaseFilter *, IBaseFilter *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            Guid*,
            IUnknown,
            IBaseFilter,
            IBaseFilter,
            int> RenderStream;

        [NativeTypeName(
            "HRESULT (const GUID *, const GUID *, IBaseFilter *, REFERENCE_TIME *, REFERENCE_TIME *, WORD, WORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            Guid*,
            IBaseFilter,
            long*,
            long*,
            ushort,
            ushort,
            int> ControlStream;

        [NativeTypeName("HRESULT (LPCOLESTR, DWORDLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ulong, int> AllocCapFile;

        [NativeTypeName(
            "HRESULT (LPOLESTR, LPOLESTR, int, IAMCopyCaptureFileProgress *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            int,
            IAMCopyCaptureFileProgress,
            int> CopyCaptureFile;

        [NativeTypeName(
            "HRESULT (IUnknown *, PIN_DIRECTION, const GUID *, const GUID *, BOOL, int, IPin **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            PIN_DIRECTION,
            Guid*,
            Guid*,
            BOOL,
            int,
            IPin*,
            int> FindPin;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICaptureGraphBuilder2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICaptureGraphBuilder2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICaptureGraphBuilder2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICaptureGraphBuilder2(Silk.NET.Windows.IUnknown value)
    {
        return new ICaptureGraphBuilder2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICaptureGraphBuilder2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICaptureGraphBuilder2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICaptureGraphBuilder2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
