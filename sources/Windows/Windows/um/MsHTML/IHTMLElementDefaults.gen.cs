// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults"]/*'/>
[Guid("3050F6C9-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLElementDefaults : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLElementDefaults : IHTMLElementDefaults.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLElementDefaults));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, uint> )(lpVtbl[1]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, uint> )(lpVtbl[2]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, uint*, int> )(lpVtbl[3]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.get_style"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_style(IHTMLStyle** p)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, IHTMLStyle**, int> )(lpVtbl[7]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.put_tabStop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_tabStop([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, short, int> )(lpVtbl[8]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.get_tabStop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_tabStop([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, short*, int> )(lpVtbl[9]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.put_viewInheritStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_viewInheritStyle([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, short, int> )(lpVtbl[10]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.get_viewInheritStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_viewInheritStyle([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, short*, int> )(lpVtbl[11]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.put_viewMasterTab"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_viewMasterTab([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, short, int> )(lpVtbl[12]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.get_viewMasterTab"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_viewMasterTab([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, short*, int> )(lpVtbl[13]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.put_scrollSegmentX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_scrollSegmentX([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, int, int> )(lpVtbl[14]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.get_scrollSegmentX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_scrollSegmentX([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, int*, int> )(lpVtbl[15]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.put_scrollSegmentY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_scrollSegmentY([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, int, int> )(lpVtbl[16]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.get_scrollSegmentY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_scrollSegmentY([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, int*, int> )(lpVtbl[17]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.put_isMultiLine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_isMultiLine([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, short, int> )(lpVtbl[18]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.get_isMultiLine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_isMultiLine([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, short*, int> )(lpVtbl[19]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.put_contentEditable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_contentEditable([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, ushort*, int> )(lpVtbl[20]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.get_contentEditable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_contentEditable([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, ushort**, int> )(lpVtbl[21]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.put_canHaveHTML"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_canHaveHTML([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, short, int> )(lpVtbl[22]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.get_canHaveHTML"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_canHaveHTML([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, short*, int> )(lpVtbl[23]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.putref_viewLink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT putref_viewLink(IHTMLDocument* v)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, IHTMLDocument*, int> )(lpVtbl[24]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.get_viewLink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_viewLink(IHTMLDocument** p)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, IHTMLDocument**, int> )(lpVtbl[25]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.put_frozen"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_frozen([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, short, int> )(lpVtbl[26]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLElementDefaults.xml' path='doc/member[@name="IHTMLElementDefaults.get_frozen"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_frozen([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLElementDefaults*, short*, int> )(lpVtbl[27]))((IHTMLElementDefaults*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_style(IHTMLStyle** p);
        [VtblIndex(8)]
        HRESULT put_tabStop([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(9)]
        HRESULT get_tabStop([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(10)]
        HRESULT put_viewInheritStyle([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(11)]
        HRESULT get_viewInheritStyle([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(12)]
        HRESULT put_viewMasterTab([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(13)]
        HRESULT get_viewMasterTab([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(14)]
        HRESULT put_scrollSegmentX([NativeTypeName("long")] int v);
        [VtblIndex(15)]
        HRESULT get_scrollSegmentX([NativeTypeName("long *")] int* p);
        [VtblIndex(16)]
        HRESULT put_scrollSegmentY([NativeTypeName("long")] int v);
        [VtblIndex(17)]
        HRESULT get_scrollSegmentY([NativeTypeName("long *")] int* p);
        [VtblIndex(18)]
        HRESULT put_isMultiLine([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(19)]
        HRESULT get_isMultiLine([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(20)]
        HRESULT put_contentEditable([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(21)]
        HRESULT get_contentEditable([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(22)]
        HRESULT put_canHaveHTML([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(23)]
        HRESULT get_canHaveHTML([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(24)]
        HRESULT putref_viewLink(IHTMLDocument* v);
        [VtblIndex(25)]
        HRESULT get_viewLink(IHTMLDocument** p);
        [VtblIndex(26)]
        HRESULT put_frozen([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(27)]
        HRESULT get_frozen([NativeTypeName("VARIANT_BOOL *")] short* p);
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
        [NativeTypeName("HRESULT (IHTMLStyle **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLStyle**, int> get_style;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_tabStop;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_tabStop;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_viewInheritStyle;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_viewInheritStyle;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_viewMasterTab;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_viewMasterTab;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_scrollSegmentX;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_scrollSegmentX;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_scrollSegmentY;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_scrollSegmentY;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_isMultiLine;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_isMultiLine;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_contentEditable;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_contentEditable;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_canHaveHTML;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_canHaveHTML;
        [NativeTypeName("HRESULT (IHTMLDocument *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDocument*, int> putref_viewLink;
        [NativeTypeName("HRESULT (IHTMLDocument **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDocument**, int> get_viewLink;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_frozen;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_frozen;
    }
}