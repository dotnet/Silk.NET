// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement"]/*' />
[Guid("3050F1D8-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLBodyElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLBodyElement : IHTMLBodyElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLBodyElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, uint>)(lpVtbl[1]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, uint>)(lpVtbl[2]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, uint*, int>)(lpVtbl[3]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_background"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_background([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, ushort*, int>)(lpVtbl[7]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_background"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_background([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, ushort**, int>)(lpVtbl[8]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_bgProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_bgProperties([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, ushort*, int>)(lpVtbl[9]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_bgProperties"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_bgProperties([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, ushort**, int>)(lpVtbl[10]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_leftMargin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_leftMargin(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[11]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_leftMargin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_leftMargin(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[12]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_topMargin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_topMargin(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[13]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_topMargin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_topMargin(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[14]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_rightMargin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_rightMargin(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[15]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_rightMargin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_rightMargin(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[16]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_bottomMargin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_bottomMargin(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[17]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_bottomMargin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_bottomMargin(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[18]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_noWrap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_noWrap([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, short, int>)(lpVtbl[19]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_noWrap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_noWrap([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, short*, int>)(lpVtbl[20]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_bgColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_bgColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[21]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_bgColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_bgColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[22]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_text(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[23]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_text"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_text(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[24]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_link"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_link(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[25]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_link"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_link(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[26]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_vLink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_vLink(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[27]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_vLink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_vLink(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[28]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_aLink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_aLink(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[29]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_aLink"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_aLink(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[30]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_onload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_onload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[31]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_onload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_onload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[32]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_onunload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_onunload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[33]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_onunload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_onunload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[34]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_scroll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_scroll([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, ushort*, int>)(lpVtbl[35]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_scroll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_scroll([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, ushort**, int>)(lpVtbl[36]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_onselect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_onselect(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[37]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_onselect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_onselect(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[38]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.put_onbeforeunload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_onbeforeunload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT, int>)(lpVtbl[39]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.get_onbeforeunload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_onbeforeunload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, VARIANT*, int>)(lpVtbl[40]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLBodyElement.xml' path='doc/member[@name="IHTMLBodyElement.createTextRange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT createTextRange(IHTMLTxtRange** range)
    {
        return ((delegate* unmanaged<IHTMLBodyElement*, IHTMLTxtRange**, int>)(lpVtbl[41]))((IHTMLBodyElement*)Unsafe.AsPointer(ref this), range);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_background([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(8)]
        HRESULT get_background([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT put_bgProperties([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(10)]
        HRESULT get_bgProperties([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT put_leftMargin(VARIANT v);

        [VtblIndex(12)]
        HRESULT get_leftMargin(VARIANT* p);

        [VtblIndex(13)]
        HRESULT put_topMargin(VARIANT v);

        [VtblIndex(14)]
        HRESULT get_topMargin(VARIANT* p);

        [VtblIndex(15)]
        HRESULT put_rightMargin(VARIANT v);

        [VtblIndex(16)]
        HRESULT get_rightMargin(VARIANT* p);

        [VtblIndex(17)]
        HRESULT put_bottomMargin(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_bottomMargin(VARIANT* p);

        [VtblIndex(19)]
        HRESULT put_noWrap([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(20)]
        HRESULT get_noWrap([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(21)]
        HRESULT put_bgColor(VARIANT v);

        [VtblIndex(22)]
        HRESULT get_bgColor(VARIANT* p);

        [VtblIndex(23)]
        HRESULT put_text(VARIANT v);

        [VtblIndex(24)]
        HRESULT get_text(VARIANT* p);

        [VtblIndex(25)]
        HRESULT put_link(VARIANT v);

        [VtblIndex(26)]
        HRESULT get_link(VARIANT* p);

        [VtblIndex(27)]
        HRESULT put_vLink(VARIANT v);

        [VtblIndex(28)]
        HRESULT get_vLink(VARIANT* p);

        [VtblIndex(29)]
        HRESULT put_aLink(VARIANT v);

        [VtblIndex(30)]
        HRESULT get_aLink(VARIANT* p);

        [VtblIndex(31)]
        HRESULT put_onload(VARIANT v);

        [VtblIndex(32)]
        HRESULT get_onload(VARIANT* p);

        [VtblIndex(33)]
        HRESULT put_onunload(VARIANT v);

        [VtblIndex(34)]
        HRESULT get_onunload(VARIANT* p);

        [VtblIndex(35)]
        HRESULT put_scroll([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(36)]
        HRESULT get_scroll([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(37)]
        HRESULT put_onselect(VARIANT v);

        [VtblIndex(38)]
        HRESULT get_onselect(VARIANT* p);

        [VtblIndex(39)]
        HRESULT put_onbeforeunload(VARIANT v);

        [VtblIndex(40)]
        HRESULT get_onbeforeunload(VARIANT* p);

        [VtblIndex(41)]
        HRESULT createTextRange(IHTMLTxtRange** range);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_background;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_background;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_bgProperties;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_bgProperties;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_leftMargin;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_leftMargin;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_topMargin;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_topMargin;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_rightMargin;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_rightMargin;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_bottomMargin;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_bottomMargin;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_noWrap;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_noWrap;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_bgColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_bgColor;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_text;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_text;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_link;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_link;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_vLink;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_vLink;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_aLink;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_aLink;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onload;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onload;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onunload;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onunload;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_scroll;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_scroll;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onselect;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onselect;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbeforeunload;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbeforeunload;

        [NativeTypeName("HRESULT (IHTMLTxtRange **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLTxtRange**, int> createTextRange;
    }
}
