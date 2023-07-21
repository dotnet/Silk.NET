// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl"]/*' />
[Guid("56A868B1-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IMediaControl : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IMediaControl : IMediaControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaControl));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaControl*, Guid*, void**, int>)(lpVtbl[0]))((IMediaControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaControl*, uint>)(lpVtbl[1]))((IMediaControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaControl*, uint>)(lpVtbl[2]))((IMediaControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IMediaControl*, uint*, int>)(lpVtbl[3]))((IMediaControl*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IMediaControl*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IMediaControl*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IMediaControl*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IMediaControl*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IMediaControl*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IMediaControl*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.Run"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Run()
    {
        return ((delegate* unmanaged<IMediaControl*, int>)(lpVtbl[7]))((IMediaControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.Pause"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IMediaControl*, int>)(lpVtbl[8]))((IMediaControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IMediaControl*, int>)(lpVtbl[9]))((IMediaControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.GetState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetState([NativeTypeName("LONG")] int msTimeout, [NativeTypeName("OAFilterState *")] int* pfs)
    {
        return ((delegate* unmanaged<IMediaControl*, int, int*, int>)(lpVtbl[10]))((IMediaControl*)Unsafe.AsPointer(ref this), msTimeout, pfs);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.RenderFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RenderFile([NativeTypeName("BSTR")] ushort* strFilename)
    {
        return ((delegate* unmanaged<IMediaControl*, ushort*, int>)(lpVtbl[11]))((IMediaControl*)Unsafe.AsPointer(ref this), strFilename);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.AddSourceFilter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddSourceFilter([NativeTypeName("BSTR")] ushort* strFilename, IDispatch** ppUnk)
    {
        return ((delegate* unmanaged<IMediaControl*, ushort*, IDispatch**, int>)(lpVtbl[12]))((IMediaControl*)Unsafe.AsPointer(ref this), strFilename, ppUnk);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.get_FilterCollection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_FilterCollection(IDispatch** ppUnk)
    {
        return ((delegate* unmanaged<IMediaControl*, IDispatch**, int>)(lpVtbl[13]))((IMediaControl*)Unsafe.AsPointer(ref this), ppUnk);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.get_RegFilterCollection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_RegFilterCollection(IDispatch** ppUnk)
    {
        return ((delegate* unmanaged<IMediaControl*, IDispatch**, int>)(lpVtbl[14]))((IMediaControl*)Unsafe.AsPointer(ref this), ppUnk);
    }

    /// <include file='IMediaControl.xml' path='doc/member[@name="IMediaControl.StopWhenReady"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT StopWhenReady()
    {
        return ((delegate* unmanaged<IMediaControl*, int>)(lpVtbl[15]))((IMediaControl*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT Run();

        [VtblIndex(8)]
        HRESULT Pause();

        [VtblIndex(9)]
        HRESULT Stop();

        [VtblIndex(10)]
        HRESULT GetState([NativeTypeName("LONG")] int msTimeout, [NativeTypeName("OAFilterState *")] int* pfs);

        [VtblIndex(11)]
        HRESULT RenderFile([NativeTypeName("BSTR")] ushort* strFilename);

        [VtblIndex(12)]
        HRESULT AddSourceFilter([NativeTypeName("BSTR")] ushort* strFilename, IDispatch** ppUnk);

        [VtblIndex(13)]
        HRESULT get_FilterCollection(IDispatch** ppUnk);

        [VtblIndex(14)]
        HRESULT get_RegFilterCollection(IDispatch** ppUnk);

        [VtblIndex(15)]
        HRESULT StopWhenReady();
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Run;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (LONG, OAFilterState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int*, int> GetState;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> RenderFile;

        [NativeTypeName("HRESULT (BSTR, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IDispatch**, int> AddSourceFilter;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_FilterCollection;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_RegFilterCollection;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> StopWhenReady;
    }
}
