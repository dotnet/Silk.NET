// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLVideoElement.xml' path='doc/member[@name="IHTMLVideoElement"]/*'/>
[Guid("30510709-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLVideoElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLVideoElement : IHTMLVideoElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLVideoElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, uint> )(lpVtbl[1]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, uint> )(lpVtbl[2]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, uint*, int> )(lpVtbl[3]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLVideoElement.xml' path='doc/member[@name="IHTMLVideoElement.put_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_width([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, int, int> )(lpVtbl[7]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLVideoElement.xml' path='doc/member[@name="IHTMLVideoElement.get_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_width([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, int*, int> )(lpVtbl[8]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLVideoElement.xml' path='doc/member[@name="IHTMLVideoElement.put_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_height([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, int, int> )(lpVtbl[9]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLVideoElement.xml' path='doc/member[@name="IHTMLVideoElement.get_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_height([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, int*, int> )(lpVtbl[10]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLVideoElement.xml' path='doc/member[@name="IHTMLVideoElement.get_videoWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_videoWidth([NativeTypeName("ULONG *")] uint* p)
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, uint*, int> )(lpVtbl[11]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLVideoElement.xml' path='doc/member[@name="IHTMLVideoElement.get_videoHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_videoHeight([NativeTypeName("ULONG *")] uint* p)
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, uint*, int> )(lpVtbl[12]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLVideoElement.xml' path='doc/member[@name="IHTMLVideoElement.put_poster"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_poster([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, ushort*, int> )(lpVtbl[13]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLVideoElement.xml' path='doc/member[@name="IHTMLVideoElement.get_poster"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_poster([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLVideoElement*, ushort**, int> )(lpVtbl[14]))((IHTMLVideoElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_width([NativeTypeName("long")] int v);
        [VtblIndex(8)]
        HRESULT get_width([NativeTypeName("long *")] int* p);
        [VtblIndex(9)]
        HRESULT put_height([NativeTypeName("long")] int v);
        [VtblIndex(10)]
        HRESULT get_height([NativeTypeName("long *")] int* p);
        [VtblIndex(11)]
        HRESULT get_videoWidth([NativeTypeName("ULONG *")] uint* p);
        [VtblIndex(12)]
        HRESULT get_videoHeight([NativeTypeName("ULONG *")] uint* p);
        [VtblIndex(13)]
        HRESULT put_poster([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(14)]
        HRESULT get_poster([NativeTypeName("BSTR *")] ushort** p);
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
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_width;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_width;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_height;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_height;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_videoWidth;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_videoHeight;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_poster;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_poster;
    }
}