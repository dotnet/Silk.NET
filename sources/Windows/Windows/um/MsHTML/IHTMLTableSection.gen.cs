// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLTableSection.xml' path='doc/member[@name="IHTMLTableSection"]/*'/>
[Guid("3050F23B-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLTableSection : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLTableSection : IHTMLTableSection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLTableSection));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLTableSection*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLTableSection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLTableSection*, uint> )(lpVtbl[1]))((IHTMLTableSection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLTableSection*, uint> )(lpVtbl[2]))((IHTMLTableSection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLTableSection*, uint*, int> )(lpVtbl[3]))((IHTMLTableSection*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLTableSection*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLTableSection*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLTableSection*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLTableSection*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLTableSection*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLTableSection*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLTableSection.xml' path='doc/member[@name="IHTMLTableSection.put_align"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_align([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTableSection*, ushort*, int> )(lpVtbl[7]))((IHTMLTableSection*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableSection.xml' path='doc/member[@name="IHTMLTableSection.get_align"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_align([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTableSection*, ushort**, int> )(lpVtbl[8]))((IHTMLTableSection*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableSection.xml' path='doc/member[@name="IHTMLTableSection.put_vAlign"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_vAlign([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLTableSection*, ushort*, int> )(lpVtbl[9]))((IHTMLTableSection*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableSection.xml' path='doc/member[@name="IHTMLTableSection.get_vAlign"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_vAlign([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLTableSection*, ushort**, int> )(lpVtbl[10]))((IHTMLTableSection*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableSection.xml' path='doc/member[@name="IHTMLTableSection.put_bgColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_bgColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLTableSection*, VARIANT, int> )(lpVtbl[11]))((IHTMLTableSection*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLTableSection.xml' path='doc/member[@name="IHTMLTableSection.get_bgColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_bgColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLTableSection*, VARIANT*, int> )(lpVtbl[12]))((IHTMLTableSection*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableSection.xml' path='doc/member[@name="IHTMLTableSection.get_rows"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_rows(IHTMLElementCollection** p)
    {
        return ((delegate* unmanaged<IHTMLTableSection*, IHTMLElementCollection**, int> )(lpVtbl[13]))((IHTMLTableSection*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLTableSection.xml' path='doc/member[@name="IHTMLTableSection.insertRow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT insertRow([NativeTypeName("long")] int index, IDispatch** row)
    {
        return ((delegate* unmanaged<IHTMLTableSection*, int, IDispatch**, int> )(lpVtbl[14]))((IHTMLTableSection*)Unsafe.AsPointer(ref this), index, row);
    }

    /// <include file='IHTMLTableSection.xml' path='doc/member[@name="IHTMLTableSection.deleteRow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT deleteRow([NativeTypeName("long")] int index = -1)
    {
        return ((delegate* unmanaged<IHTMLTableSection*, int, int> )(lpVtbl[15]))((IHTMLTableSection*)Unsafe.AsPointer(ref this), index);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_align([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_align([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT put_vAlign([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(10)]
        HRESULT get_vAlign([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT put_bgColor(VARIANT v);
        [VtblIndex(12)]
        HRESULT get_bgColor(VARIANT* p);
        [VtblIndex(13)]
        HRESULT get_rows(IHTMLElementCollection** p);
        [VtblIndex(14)]
        HRESULT insertRow([NativeTypeName("long")] int index, IDispatch** row);
        [VtblIndex(15)]
        HRESULT deleteRow([NativeTypeName("long")] int index = -1);
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
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_align;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_align;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_vAlign;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_vAlign;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_bgColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_bgColor;
        [NativeTypeName("HRESULT (IHTMLElementCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElementCollection**, int> get_rows;
        [NativeTypeName("HRESULT (long, IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IDispatch**, int> insertRow;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> deleteRow;
    }
}