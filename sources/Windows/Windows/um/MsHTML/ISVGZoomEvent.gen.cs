// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISVGZoomEvent.xml' path='doc/member[@name="ISVGZoomEvent"]/*'/>
[Guid("3051054E-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGZoomEvent : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGZoomEvent : ISVGZoomEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGZoomEvent));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGZoomEvent*, Guid*, void**, int> )(lpVtbl[0]))((ISVGZoomEvent*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGZoomEvent*, uint> )(lpVtbl[1]))((ISVGZoomEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGZoomEvent*, uint> )(lpVtbl[2]))((ISVGZoomEvent*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGZoomEvent*, uint*, int> )(lpVtbl[3]))((ISVGZoomEvent*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGZoomEvent*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((ISVGZoomEvent*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGZoomEvent*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((ISVGZoomEvent*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGZoomEvent*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((ISVGZoomEvent*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGZoomEvent.xml' path='doc/member[@name="ISVGZoomEvent.get_zoomRectScreen"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_zoomRectScreen(ISVGRect** p)
    {
        return ((delegate* unmanaged<ISVGZoomEvent*, ISVGRect**, int> )(lpVtbl[7]))((ISVGZoomEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGZoomEvent.xml' path='doc/member[@name="ISVGZoomEvent.get_previousScale"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_previousScale(float* p)
    {
        return ((delegate* unmanaged<ISVGZoomEvent*, float*, int> )(lpVtbl[8]))((ISVGZoomEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGZoomEvent.xml' path='doc/member[@name="ISVGZoomEvent.get_previousTranslate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_previousTranslate(ISVGPoint** p)
    {
        return ((delegate* unmanaged<ISVGZoomEvent*, ISVGPoint**, int> )(lpVtbl[9]))((ISVGZoomEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGZoomEvent.xml' path='doc/member[@name="ISVGZoomEvent.get_newScale"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_newScale(float* p)
    {
        return ((delegate* unmanaged<ISVGZoomEvent*, float*, int> )(lpVtbl[10]))((ISVGZoomEvent*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGZoomEvent.xml' path='doc/member[@name="ISVGZoomEvent.get_newTranslate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_newTranslate(ISVGPoint** p)
    {
        return ((delegate* unmanaged<ISVGZoomEvent*, ISVGPoint**, int> )(lpVtbl[11]))((ISVGZoomEvent*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_zoomRectScreen(ISVGRect** p);
        [VtblIndex(8)]
        HRESULT get_previousScale(float* p);
        [VtblIndex(9)]
        HRESULT get_previousTranslate(ISVGPoint** p);
        [VtblIndex(10)]
        HRESULT get_newScale(float* p);
        [VtblIndex(11)]
        HRESULT get_newTranslate(ISVGPoint** p);
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
        [NativeTypeName("HRESULT (ISVGRect **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGRect**, int> get_zoomRectScreen;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_previousScale;
        [NativeTypeName("HRESULT (ISVGPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGPoint**, int> get_previousTranslate;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_newScale;
        [NativeTypeName("HRESULT (ISVGPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGPoint**, int> get_newTranslate;
    }
}