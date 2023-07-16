// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement"]/*'/>
[Guid("3050F2B5-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLMarqueeElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLMarqueeElement : IHTMLMarqueeElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLMarqueeElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, uint> )(lpVtbl[1]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, uint> )(lpVtbl[2]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, uint*, int> )(lpVtbl[3]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.put_bgColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_bgColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int> )(lpVtbl[7]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.get_bgColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_bgColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int> )(lpVtbl[8]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.put_scrollDelay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_scrollDelay([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int> )(lpVtbl[9]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.get_scrollDelay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_scrollDelay([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int> )(lpVtbl[10]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.put_direction"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_direction([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, ushort*, int> )(lpVtbl[11]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.get_direction"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_direction([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, ushort**, int> )(lpVtbl[12]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.put_behavior"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_behavior([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, ushort*, int> )(lpVtbl[13]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.get_behavior"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_behavior([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, ushort**, int> )(lpVtbl[14]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.put_scrollAmount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_scrollAmount([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int> )(lpVtbl[15]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.get_scrollAmount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_scrollAmount([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int> )(lpVtbl[16]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.put_loop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_loop([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int> )(lpVtbl[17]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.get_loop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_loop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int> )(lpVtbl[18]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.put_vspace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_vspace([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int> )(lpVtbl[19]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.get_vspace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_vspace([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int> )(lpVtbl[20]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.put_hspace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_hspace([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, int, int> )(lpVtbl[21]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.get_hspace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_hspace([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, int*, int> )(lpVtbl[22]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.put_onfinish"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_onfinish(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int> )(lpVtbl[23]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.get_onfinish"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_onfinish(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int> )(lpVtbl[24]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.put_onstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_onstart(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int> )(lpVtbl[25]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.get_onstart"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_onstart(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int> )(lpVtbl[26]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.put_onbounce"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_onbounce(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int> )(lpVtbl[27]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.get_onbounce"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_onbounce(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int> )(lpVtbl[28]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.put_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_width(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int> )(lpVtbl[29]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.get_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_width(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int> )(lpVtbl[30]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.put_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_height(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT, int> )(lpVtbl[31]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.get_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_height(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, VARIANT*, int> )(lpVtbl[32]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.put_trueSpeed"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_trueSpeed([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, short, int> )(lpVtbl[33]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.get_trueSpeed"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_trueSpeed([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, short*, int> )(lpVtbl[34]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.start"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT start()
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, int> )(lpVtbl[35]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLMarqueeElement.xml' path='doc/member[@name="IHTMLMarqueeElement.stop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT stop()
    {
        return ((delegate* unmanaged<IHTMLMarqueeElement*, int> )(lpVtbl[36]))((IHTMLMarqueeElement*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_bgColor(VARIANT v);
        [VtblIndex(8)]
        HRESULT get_bgColor(VARIANT* p);
        [VtblIndex(9)]
        HRESULT put_scrollDelay([NativeTypeName("long")] int v);
        [VtblIndex(10)]
        HRESULT get_scrollDelay([NativeTypeName("long *")] int* p);
        [VtblIndex(11)]
        HRESULT put_direction([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(12)]
        HRESULT get_direction([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT put_behavior([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(14)]
        HRESULT get_behavior([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(15)]
        HRESULT put_scrollAmount([NativeTypeName("long")] int v);
        [VtblIndex(16)]
        HRESULT get_scrollAmount([NativeTypeName("long *")] int* p);
        [VtblIndex(17)]
        HRESULT put_loop([NativeTypeName("long")] int v);
        [VtblIndex(18)]
        HRESULT get_loop([NativeTypeName("long *")] int* p);
        [VtblIndex(19)]
        HRESULT put_vspace([NativeTypeName("long")] int v);
        [VtblIndex(20)]
        HRESULT get_vspace([NativeTypeName("long *")] int* p);
        [VtblIndex(21)]
        HRESULT put_hspace([NativeTypeName("long")] int v);
        [VtblIndex(22)]
        HRESULT get_hspace([NativeTypeName("long *")] int* p);
        [VtblIndex(23)]
        HRESULT put_onfinish(VARIANT v);
        [VtblIndex(24)]
        HRESULT get_onfinish(VARIANT* p);
        [VtblIndex(25)]
        HRESULT put_onstart(VARIANT v);
        [VtblIndex(26)]
        HRESULT get_onstart(VARIANT* p);
        [VtblIndex(27)]
        HRESULT put_onbounce(VARIANT v);
        [VtblIndex(28)]
        HRESULT get_onbounce(VARIANT* p);
        [VtblIndex(29)]
        HRESULT put_width(VARIANT v);
        [VtblIndex(30)]
        HRESULT get_width(VARIANT* p);
        [VtblIndex(31)]
        HRESULT put_height(VARIANT v);
        [VtblIndex(32)]
        HRESULT get_height(VARIANT* p);
        [VtblIndex(33)]
        HRESULT put_trueSpeed([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(34)]
        HRESULT get_trueSpeed([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(35)]
        HRESULT start();
        [VtblIndex(36)]
        HRESULT stop();
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
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_bgColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_bgColor;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_scrollDelay;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_scrollDelay;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_direction;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_direction;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_behavior;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_behavior;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_scrollAmount;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_scrollAmount;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_loop;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_loop;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_vspace;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_vspace;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_hspace;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_hspace;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onfinish;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onfinish;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onstart;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onstart;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onbounce;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onbounce;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_width;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_width;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_height;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_height;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_trueSpeed;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_trueSpeed;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> start;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> stop;
    }
}