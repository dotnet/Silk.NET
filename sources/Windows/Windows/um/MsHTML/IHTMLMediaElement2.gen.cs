// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLMediaElement2.xml' path='doc/member[@name="IHTMLMediaElement2"]/*'/>
[Guid("30510809-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLMediaElement2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLMediaElement2 : IHTMLMediaElement2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLMediaElement2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, uint> )(lpVtbl[1]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, uint> )(lpVtbl[2]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, uint*, int> )(lpVtbl[3]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLMediaElement2.xml' path='doc/member[@name="IHTMLMediaElement2.put_currentTimeDouble"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_currentTimeDouble(double v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, double, int> )(lpVtbl[7]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMediaElement2.xml' path='doc/member[@name="IHTMLMediaElement2.get_currentTimeDouble"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_currentTimeDouble(double* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, double*, int> )(lpVtbl[8]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMediaElement2.xml' path='doc/member[@name="IHTMLMediaElement2.get_initialTimeDouble"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_initialTimeDouble(double* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, double*, int> )(lpVtbl[9]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMediaElement2.xml' path='doc/member[@name="IHTMLMediaElement2.get_durationDouble"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_durationDouble(double* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, double*, int> )(lpVtbl[10]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMediaElement2.xml' path='doc/member[@name="IHTMLMediaElement2.put_defaultPlaybackRateDouble"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_defaultPlaybackRateDouble(double v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, double, int> )(lpVtbl[11]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMediaElement2.xml' path='doc/member[@name="IHTMLMediaElement2.get_defaultPlaybackRateDouble"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_defaultPlaybackRateDouble(double* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, double*, int> )(lpVtbl[12]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMediaElement2.xml' path='doc/member[@name="IHTMLMediaElement2.put_playbackRateDouble"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_playbackRateDouble(double v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, double, int> )(lpVtbl[13]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMediaElement2.xml' path='doc/member[@name="IHTMLMediaElement2.get_playbackRateDouble"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_playbackRateDouble(double* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, double*, int> )(lpVtbl[14]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMediaElement2.xml' path='doc/member[@name="IHTMLMediaElement2.put_volumeDouble"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_volumeDouble(double v)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, double, int> )(lpVtbl[15]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMediaElement2.xml' path='doc/member[@name="IHTMLMediaElement2.get_volumeDouble"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_volumeDouble(double* p)
    {
        return ((delegate* unmanaged<IHTMLMediaElement2*, double*, int> )(lpVtbl[16]))((IHTMLMediaElement2*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_currentTimeDouble(double v);
        [VtblIndex(8)]
        HRESULT get_currentTimeDouble(double* p);
        [VtblIndex(9)]
        HRESULT get_initialTimeDouble(double* p);
        [VtblIndex(10)]
        HRESULT get_durationDouble(double* p);
        [VtblIndex(11)]
        HRESULT put_defaultPlaybackRateDouble(double v);
        [VtblIndex(12)]
        HRESULT get_defaultPlaybackRateDouble(double* p);
        [VtblIndex(13)]
        HRESULT put_playbackRateDouble(double v);
        [VtblIndex(14)]
        HRESULT get_playbackRateDouble(double* p);
        [VtblIndex(15)]
        HRESULT put_volumeDouble(double v);
        [VtblIndex(16)]
        HRESULT get_volumeDouble(double* p);
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
        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_currentTimeDouble;
        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_currentTimeDouble;
        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_initialTimeDouble;
        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_durationDouble;
        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_defaultPlaybackRateDouble;
        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_defaultPlaybackRateDouble;
        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_playbackRateDouble;
        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_playbackRateDouble;
        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_volumeDouble;
        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_volumeDouble;
    }
}