// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLTextRangeMetrics.xml' path='doc/member[@name="IHTMLTextRangeMetrics"]/*'/>
[Guid("3050F40B-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLTextRangeMetrics : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLTextRangeMetrics : IHTMLTextRangeMetrics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLTextRangeMetrics));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLTextRangeMetrics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics*, uint> )(lpVtbl[1]))((IHTMLTextRangeMetrics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics*, uint> )(lpVtbl[2]))((IHTMLTextRangeMetrics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics*, uint*, int> )(lpVtbl[3]))((IHTMLTextRangeMetrics*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLTextRangeMetrics*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLTextRangeMetrics*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLTextRangeMetrics*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLTextRangeMetrics.xml' path='doc/member[@name="IHTMLTextRangeMetrics.get_offsetTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_offsetTop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics*, int*, int> )(lpVtbl[7]))((IHTMLTextRangeMetrics*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextRangeMetrics.xml' path='doc/member[@name="IHTMLTextRangeMetrics.get_offsetLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_offsetLeft([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics*, int*, int> )(lpVtbl[8]))((IHTMLTextRangeMetrics*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextRangeMetrics.xml' path='doc/member[@name="IHTMLTextRangeMetrics.get_boundingTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_boundingTop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics*, int*, int> )(lpVtbl[9]))((IHTMLTextRangeMetrics*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextRangeMetrics.xml' path='doc/member[@name="IHTMLTextRangeMetrics.get_boundingLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_boundingLeft([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics*, int*, int> )(lpVtbl[10]))((IHTMLTextRangeMetrics*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextRangeMetrics.xml' path='doc/member[@name="IHTMLTextRangeMetrics.get_boundingWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_boundingWidth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics*, int*, int> )(lpVtbl[11]))((IHTMLTextRangeMetrics*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextRangeMetrics.xml' path='doc/member[@name="IHTMLTextRangeMetrics.get_boundingHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_boundingHeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTextRangeMetrics*, int*, int> )(lpVtbl[12]))((IHTMLTextRangeMetrics*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_offsetTop([NativeTypeName("long *")] int* p);
        [VtblIndex(8)]
        HRESULT get_offsetLeft([NativeTypeName("long *")] int* p);
        [VtblIndex(9)]
        HRESULT get_boundingTop([NativeTypeName("long *")] int* p);
        [VtblIndex(10)]
        HRESULT get_boundingLeft([NativeTypeName("long *")] int* p);
        [VtblIndex(11)]
        HRESULT get_boundingWidth([NativeTypeName("long *")] int* p);
        [VtblIndex(12)]
        HRESULT get_boundingHeight([NativeTypeName("long *")] int* p);
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
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_offsetTop;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_offsetLeft;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_boundingTop;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_boundingLeft;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_boundingWidth;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_boundingHeight;
    }
}