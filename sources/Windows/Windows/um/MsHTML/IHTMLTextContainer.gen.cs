// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLTextContainer.xml' path='doc/member[@name="IHTMLTextContainer"]/*'/>
[Guid("3050F230-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLTextContainer : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLTextContainer : IHTMLTextContainer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLTextContainer));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, uint> )(lpVtbl[1]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, uint> )(lpVtbl[2]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, uint*, int> )(lpVtbl[3]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLTextContainer.xml' path='doc/member[@name="IHTMLTextContainer.createControlRange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT createControlRange(IDispatch** range)
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, IDispatch**, int> )(lpVtbl[7]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), range);
    }

    /// <include file='IHTMLTextContainer.xml' path='doc/member[@name="IHTMLTextContainer.get_scrollHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_scrollHeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, int*, int> )(lpVtbl[8]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextContainer.xml' path='doc/member[@name="IHTMLTextContainer.get_scrollWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_scrollWidth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, int*, int> )(lpVtbl[9]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextContainer.xml' path='doc/member[@name="IHTMLTextContainer.put_scrollTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_scrollTop([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, int, int> )(lpVtbl[10]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextContainer.xml' path='doc/member[@name="IHTMLTextContainer.get_scrollTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_scrollTop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, int*, int> )(lpVtbl[11]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextContainer.xml' path='doc/member[@name="IHTMLTextContainer.put_scrollLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_scrollLeft([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, int, int> )(lpVtbl[12]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextContainer.xml' path='doc/member[@name="IHTMLTextContainer.get_scrollLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_scrollLeft([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, int*, int> )(lpVtbl[13]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTextContainer.xml' path='doc/member[@name="IHTMLTextContainer.put_onscroll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_onscroll(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, VARIANT, int> )(lpVtbl[14]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTextContainer.xml' path='doc/member[@name="IHTMLTextContainer.get_onscroll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_onscroll(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTextContainer*, VARIANT*, int> )(lpVtbl[15]))((IHTMLTextContainer*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT createControlRange(IDispatch** range);
        [VtblIndex(8)]
        HRESULT get_scrollHeight([NativeTypeName("long *")] int* p);
        [VtblIndex(9)]
        HRESULT get_scrollWidth([NativeTypeName("long *")] int* p);
        [VtblIndex(10)]
        HRESULT put_scrollTop([NativeTypeName("long")] int v);
        [VtblIndex(11)]
        HRESULT get_scrollTop([NativeTypeName("long *")] int* p);
        [VtblIndex(12)]
        HRESULT put_scrollLeft([NativeTypeName("long")] int v);
        [VtblIndex(13)]
        HRESULT get_scrollLeft([NativeTypeName("long *")] int* p);
        [VtblIndex(14)]
        HRESULT put_onscroll(VARIANT v);
        [VtblIndex(15)]
        HRESULT get_onscroll(VARIANT* p);
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
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> createControlRange;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_scrollHeight;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_scrollWidth;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_scrollTop;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_scrollTop;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_scrollLeft;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_scrollLeft;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onscroll;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onscroll;
    }
}