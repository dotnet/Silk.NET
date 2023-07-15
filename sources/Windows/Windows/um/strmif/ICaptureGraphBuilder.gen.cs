// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ICaptureGraphBuilder.xml' path='doc/member[@name="ICaptureGraphBuilder"]/*'/>
[Guid("BF87B6E0-8C27-11D0-B3F0-00AA003761C5")]
[NativeTypeName("struct ICaptureGraphBuilder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICaptureGraphBuilder : ICaptureGraphBuilder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICaptureGraphBuilder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder*, Guid*, void**, int> )(lpVtbl[0]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder*, uint> )(lpVtbl[1]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder*, uint> )(lpVtbl[2]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICaptureGraphBuilder.xml' path='doc/member[@name="ICaptureGraphBuilder.SetFiltergraph"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFiltergraph(IGraphBuilder* pfg)
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder*, IGraphBuilder*, int> )(lpVtbl[3]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), pfg);
    }

    /// <include file='ICaptureGraphBuilder.xml' path='doc/member[@name="ICaptureGraphBuilder.GetFiltergraph"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFiltergraph(IGraphBuilder** ppfg)
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder*, IGraphBuilder**, int> )(lpVtbl[4]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), ppfg);
    }

    /// <include file='ICaptureGraphBuilder.xml' path='doc/member[@name="ICaptureGraphBuilder.SetOutputFileName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOutputFileName([NativeTypeName("const GUID *")] Guid* pType, [NativeTypeName("LPCOLESTR")] ushort* lpstrFile, IBaseFilter** ppf, IFileSinkFilter** ppSink)
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder*, Guid*, ushort*, IBaseFilter**, IFileSinkFilter**, int> )(lpVtbl[5]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), pType, lpstrFile, ppf, ppSink);
    }

    /// <include file='ICaptureGraphBuilder.xml' path='doc/member[@name="ICaptureGraphBuilder.FindInterface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindInterface([NativeTypeName("const GUID *")] Guid* pCategory, IBaseFilter* pf, [NativeTypeName("const IID &")] Guid* riid, void** ppint)
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder*, Guid*, IBaseFilter*, Guid*, void**, int> )(lpVtbl[6]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), pCategory, pf, riid, ppint);
    }

    /// <include file='ICaptureGraphBuilder.xml' path='doc/member[@name="ICaptureGraphBuilder.RenderStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RenderStream([NativeTypeName("const GUID *")] Guid* pCategory, IUnknown* pSource, IBaseFilter* pfCompressor, IBaseFilter* pfRenderer)
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder*, Guid*, IUnknown*, IBaseFilter*, IBaseFilter*, int> )(lpVtbl[7]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), pCategory, pSource, pfCompressor, pfRenderer);
    }

    /// <include file='ICaptureGraphBuilder.xml' path='doc/member[@name="ICaptureGraphBuilder.ControlStream"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ControlStream([NativeTypeName("const GUID *")] Guid* pCategory, IBaseFilter* pFilter, [NativeTypeName("REFERENCE_TIME *")] long* pstart, [NativeTypeName("REFERENCE_TIME *")] long* pstop, [NativeTypeName("WORD")] ushort wStartCookie, [NativeTypeName("WORD")] ushort wStopCookie)
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder*, Guid*, IBaseFilter*, long*, long*, ushort, ushort, int> )(lpVtbl[8]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), pCategory, pFilter, pstart, pstop, wStartCookie, wStopCookie);
    }

    /// <include file='ICaptureGraphBuilder.xml' path='doc/member[@name="ICaptureGraphBuilder.AllocCapFile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT AllocCapFile([NativeTypeName("LPCOLESTR")] ushort* lpstr, [NativeTypeName("DWORDLONG")] ulong dwlSize)
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder*, ushort*, ulong, int> )(lpVtbl[9]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), lpstr, dwlSize);
    }

    /// <include file='ICaptureGraphBuilder.xml' path='doc/member[@name="ICaptureGraphBuilder.CopyCaptureFile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CopyCaptureFile([NativeTypeName("LPOLESTR")] ushort* lpwstrOld, [NativeTypeName("LPOLESTR")] ushort* lpwstrNew, int fAllowEscAbort, IAMCopyCaptureFileProgress* pCallback)
    {
        return ((delegate* unmanaged<ICaptureGraphBuilder*, ushort*, ushort*, int, IAMCopyCaptureFileProgress*, int> )(lpVtbl[10]))((ICaptureGraphBuilder*)Unsafe.AsPointer(ref this), lpwstrOld, lpwstrNew, fAllowEscAbort, pCallback);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetFiltergraph(IGraphBuilder* pfg);
        [VtblIndex(4)]
        HRESULT GetFiltergraph(IGraphBuilder** ppfg);
        [VtblIndex(5)]
        HRESULT SetOutputFileName([NativeTypeName("const GUID *")] Guid* pType, [NativeTypeName("LPCOLESTR")] ushort* lpstrFile, IBaseFilter** ppf, IFileSinkFilter** ppSink);
        [VtblIndex(6)]
        HRESULT FindInterface([NativeTypeName("const GUID *")] Guid* pCategory, IBaseFilter* pf, [NativeTypeName("const IID &")] Guid* riid, void** ppint);
        [VtblIndex(7)]
        HRESULT RenderStream([NativeTypeName("const GUID *")] Guid* pCategory, IUnknown* pSource, IBaseFilter* pfCompressor, IBaseFilter* pfRenderer);
        [VtblIndex(8)]
        HRESULT ControlStream([NativeTypeName("const GUID *")] Guid* pCategory, IBaseFilter* pFilter, [NativeTypeName("REFERENCE_TIME *")] long* pstart, [NativeTypeName("REFERENCE_TIME *")] long* pstop, [NativeTypeName("WORD")] ushort wStartCookie, [NativeTypeName("WORD")] ushort wStopCookie);
        [VtblIndex(9)]
        HRESULT AllocCapFile([NativeTypeName("LPCOLESTR")] ushort* lpstr, [NativeTypeName("DWORDLONG")] ulong dwlSize);
        [VtblIndex(10)]
        HRESULT CopyCaptureFile([NativeTypeName("LPOLESTR")] ushort* lpwstrOld, [NativeTypeName("LPOLESTR")] ushort* lpwstrNew, int fAllowEscAbort, IAMCopyCaptureFileProgress* pCallback);
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
        public delegate* unmanaged<TSelf*, IGraphBuilder*, int> SetFiltergraph;
        [NativeTypeName("HRESULT (IGraphBuilder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IGraphBuilder**, int> GetFiltergraph;
        [NativeTypeName("HRESULT (const GUID *, LPCOLESTR, IBaseFilter **, IFileSinkFilter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, IBaseFilter**, IFileSinkFilter**, int> SetOutputFileName;
        [NativeTypeName("HRESULT (const GUID *, IBaseFilter *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IBaseFilter*, Guid*, void**, int> FindInterface;
        [NativeTypeName("HRESULT (const GUID *, IUnknown *, IBaseFilter *, IBaseFilter *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, IBaseFilter*, IBaseFilter*, int> RenderStream;
        [NativeTypeName("HRESULT (const GUID *, IBaseFilter *, REFERENCE_TIME *, REFERENCE_TIME *, WORD, WORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IBaseFilter*, long*, long*, ushort, ushort, int> ControlStream;
        [NativeTypeName("HRESULT (LPCOLESTR, DWORDLONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ulong, int> AllocCapFile;
        [NativeTypeName("HRESULT (LPOLESTR, LPOLESTR, int, IAMCopyCaptureFileProgress *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int, IAMCopyCaptureFileProgress*, int> CopyCaptureFile;
    }
}