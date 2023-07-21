// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4"]/*' />
[Guid("D6100F3B-27C8-4132-AFEA-F0E4B1E00060")]
[NativeTypeName("struct IHTMLCSSStyleDeclaration4 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLCSSStyleDeclaration4 : IHTMLCSSStyleDeclaration4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLCSSStyleDeclaration4));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, uint>)(lpVtbl[1]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, uint>)(lpVtbl[2]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, uint*, int>)(lpVtbl[3]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitAppearance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_webkitAppearance([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[7]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitAppearance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_webkitAppearance([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[8]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitUserSelect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_webkitUserSelect([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[9]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitUserSelect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_webkitUserSelect([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[10]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBoxAlign"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_webkitBoxAlign([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[11]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBoxAlign"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_webkitBoxAlign([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[12]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBoxOrdinalGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_webkitBoxOrdinalGroup(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT, int>)(lpVtbl[13]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBoxOrdinalGroup"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_webkitBoxOrdinalGroup(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT*, int>)(lpVtbl[14]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBoxPack"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_webkitBoxPack([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[15]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBoxPack"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_webkitBoxPack([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[16]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBoxFlex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_webkitBoxFlex(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT, int>)(lpVtbl[17]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBoxFlex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_webkitBoxFlex(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT*, int>)(lpVtbl[18]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBoxOrient"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_webkitBoxOrient([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[19]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBoxOrient"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_webkitBoxOrient([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[20]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBoxDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_webkitBoxDirection([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[21]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBoxDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_webkitBoxDirection([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[22]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_webkitTransform([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[23]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_webkitTransform([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[24]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBackgroundSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_webkitBackgroundSize([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[25]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBackgroundSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_webkitBackgroundSize([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[26]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBackfaceVisibility"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_webkitBackfaceVisibility([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[27]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBackfaceVisibility"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_webkitBackfaceVisibility([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[28]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitAnimation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_webkitAnimation([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[29]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitAnimation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_webkitAnimation([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[30]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitTransition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_webkitTransition([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[31]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitTransition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_webkitTransition([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[32]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitAnimationName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_webkitAnimationName([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[33]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitAnimationName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_webkitAnimationName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[34]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitAnimationDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_webkitAnimationDuration([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[35]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitAnimationDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_webkitAnimationDuration([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[36]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitAnimationTimingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_webkitAnimationTimingFunction([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[37]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitAnimationTimingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_webkitAnimationTimingFunction([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[38]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitAnimationDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_webkitAnimationDelay([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[39]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitAnimationDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_webkitAnimationDelay([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[40]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitAnimationIterationCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_webkitAnimationIterationCount([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[41]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitAnimationIterationCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_webkitAnimationIterationCount([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[42]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitAnimationDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_webkitAnimationDirection([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[43]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitAnimationDirection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_webkitAnimationDirection([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[44]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitAnimationPlayState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_webkitAnimationPlayState([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[45]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitAnimationPlayState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_webkitAnimationPlayState([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[46]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitTransitionProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT put_webkitTransitionProperty([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[47]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitTransitionProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_webkitTransitionProperty([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[48]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitTransitionDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT put_webkitTransitionDuration([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[49]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitTransitionDuration"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_webkitTransitionDuration([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[50]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitTransitionTimingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT put_webkitTransitionTimingFunction([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[51]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitTransitionTimingFunction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_webkitTransitionTimingFunction([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[52]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitTransitionDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT put_webkitTransitionDelay([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[53]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitTransitionDelay"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_webkitTransitionDelay([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[54]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBackgroundAttachment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT put_webkitBackgroundAttachment([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[55]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBackgroundAttachment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_webkitBackgroundAttachment([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[56]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT put_webkitBackgroundColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT, int>)(lpVtbl[57]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBackgroundColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_webkitBackgroundColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT*, int>)(lpVtbl[58]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBackgroundClip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT put_webkitBackgroundClip([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[59]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBackgroundClip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_webkitBackgroundClip([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[60]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBackgroundImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT put_webkitBackgroundImage([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[61]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBackgroundImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_webkitBackgroundImage([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[62]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBackgroundRepeat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT put_webkitBackgroundRepeat([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[63]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBackgroundRepeat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT get_webkitBackgroundRepeat([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[64]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBackgroundOrigin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT put_webkitBackgroundOrigin([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[65]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBackgroundOrigin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT get_webkitBackgroundOrigin([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[66]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBackgroundPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT put_webkitBackgroundPosition([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[67]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBackgroundPosition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT get_webkitBackgroundPosition([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[68]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBackgroundPositionX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT put_webkitBackgroundPositionX(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT, int>)(lpVtbl[69]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBackgroundPositionX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT get_webkitBackgroundPositionX(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT*, int>)(lpVtbl[70]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBackgroundPositionY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT put_webkitBackgroundPositionY(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT, int>)(lpVtbl[71]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBackgroundPositionY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT get_webkitBackgroundPositionY(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT*, int>)(lpVtbl[72]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBackground"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT put_webkitBackground([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[73]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBackground"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT get_webkitBackground([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[74]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitTransformOrigin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT put_webkitTransformOrigin([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[75]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitTransformOrigin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT get_webkitTransformOrigin([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[76]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_msTextSizeAdjust"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT put_msTextSizeAdjust(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT, int>)(lpVtbl[77]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_msTextSizeAdjust"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT get_msTextSizeAdjust(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT*, int>)(lpVtbl[78]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitTextSizeAdjust"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT put_webkitTextSizeAdjust(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT, int>)(lpVtbl[79]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitTextSizeAdjust"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT get_webkitTextSizeAdjust(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, VARIANT*, int>)(lpVtbl[80]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBorderImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT put_webkitBorderImage([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[81]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBorderImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT get_webkitBorderImage([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[82]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBorderImageSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT put_webkitBorderImageSource([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[83]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBorderImageSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT get_webkitBorderImageSource([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[84]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBorderImageSlice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT put_webkitBorderImageSlice([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[85]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBorderImageSlice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT get_webkitBorderImageSlice([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[86]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBorderImageWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT put_webkitBorderImageWidth([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[87]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBorderImageWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT get_webkitBorderImageWidth([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[88]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBorderImageOutset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT put_webkitBorderImageOutset([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[89]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBorderImageOutset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT get_webkitBorderImageOutset([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[90]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBorderImageRepeat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT put_webkitBorderImageRepeat([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[91]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBorderImageRepeat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT get_webkitBorderImageRepeat([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[92]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitBoxSizing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT put_webkitBoxSizing([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[93]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitBoxSizing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT get_webkitBoxSizing([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[94]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.put_webkitAnimationFillMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT put_webkitAnimationFillMode([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort*, int>)(lpVtbl[95]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLCSSStyleDeclaration4.xml' path='doc/member[@name="IHTMLCSSStyleDeclaration4.get_webkitAnimationFillMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT get_webkitAnimationFillMode([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLCSSStyleDeclaration4*, ushort**, int>)(lpVtbl[96]))((IHTMLCSSStyleDeclaration4*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_webkitAppearance([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(8)]
        HRESULT get_webkitAppearance([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT put_webkitUserSelect([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(10)]
        HRESULT get_webkitUserSelect([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT put_webkitBoxAlign([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(12)]
        HRESULT get_webkitBoxAlign([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(13)]
        HRESULT put_webkitBoxOrdinalGroup(VARIANT v);

        [VtblIndex(14)]
        HRESULT get_webkitBoxOrdinalGroup(VARIANT* p);

        [VtblIndex(15)]
        HRESULT put_webkitBoxPack([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(16)]
        HRESULT get_webkitBoxPack([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(17)]
        HRESULT put_webkitBoxFlex(VARIANT v);

        [VtblIndex(18)]
        HRESULT get_webkitBoxFlex(VARIANT* p);

        [VtblIndex(19)]
        HRESULT put_webkitBoxOrient([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(20)]
        HRESULT get_webkitBoxOrient([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(21)]
        HRESULT put_webkitBoxDirection([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(22)]
        HRESULT get_webkitBoxDirection([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(23)]
        HRESULT put_webkitTransform([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(24)]
        HRESULT get_webkitTransform([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(25)]
        HRESULT put_webkitBackgroundSize([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(26)]
        HRESULT get_webkitBackgroundSize([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(27)]
        HRESULT put_webkitBackfaceVisibility([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(28)]
        HRESULT get_webkitBackfaceVisibility([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(29)]
        HRESULT put_webkitAnimation([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(30)]
        HRESULT get_webkitAnimation([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(31)]
        HRESULT put_webkitTransition([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(32)]
        HRESULT get_webkitTransition([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(33)]
        HRESULT put_webkitAnimationName([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(34)]
        HRESULT get_webkitAnimationName([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(35)]
        HRESULT put_webkitAnimationDuration([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(36)]
        HRESULT get_webkitAnimationDuration([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(37)]
        HRESULT put_webkitAnimationTimingFunction([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(38)]
        HRESULT get_webkitAnimationTimingFunction([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(39)]
        HRESULT put_webkitAnimationDelay([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(40)]
        HRESULT get_webkitAnimationDelay([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(41)]
        HRESULT put_webkitAnimationIterationCount([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(42)]
        HRESULT get_webkitAnimationIterationCount([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(43)]
        HRESULT put_webkitAnimationDirection([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(44)]
        HRESULT get_webkitAnimationDirection([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(45)]
        HRESULT put_webkitAnimationPlayState([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(46)]
        HRESULT get_webkitAnimationPlayState([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(47)]
        HRESULT put_webkitTransitionProperty([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(48)]
        HRESULT get_webkitTransitionProperty([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(49)]
        HRESULT put_webkitTransitionDuration([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(50)]
        HRESULT get_webkitTransitionDuration([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(51)]
        HRESULT put_webkitTransitionTimingFunction([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(52)]
        HRESULT get_webkitTransitionTimingFunction([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(53)]
        HRESULT put_webkitTransitionDelay([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(54)]
        HRESULT get_webkitTransitionDelay([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(55)]
        HRESULT put_webkitBackgroundAttachment([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(56)]
        HRESULT get_webkitBackgroundAttachment([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(57)]
        HRESULT put_webkitBackgroundColor(VARIANT v);

        [VtblIndex(58)]
        HRESULT get_webkitBackgroundColor(VARIANT* p);

        [VtblIndex(59)]
        HRESULT put_webkitBackgroundClip([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(60)]
        HRESULT get_webkitBackgroundClip([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(61)]
        HRESULT put_webkitBackgroundImage([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(62)]
        HRESULT get_webkitBackgroundImage([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(63)]
        HRESULT put_webkitBackgroundRepeat([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(64)]
        HRESULT get_webkitBackgroundRepeat([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(65)]
        HRESULT put_webkitBackgroundOrigin([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(66)]
        HRESULT get_webkitBackgroundOrigin([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(67)]
        HRESULT put_webkitBackgroundPosition([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(68)]
        HRESULT get_webkitBackgroundPosition([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(69)]
        HRESULT put_webkitBackgroundPositionX(VARIANT v);

        [VtblIndex(70)]
        HRESULT get_webkitBackgroundPositionX(VARIANT* p);

        [VtblIndex(71)]
        HRESULT put_webkitBackgroundPositionY(VARIANT v);

        [VtblIndex(72)]
        HRESULT get_webkitBackgroundPositionY(VARIANT* p);

        [VtblIndex(73)]
        HRESULT put_webkitBackground([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(74)]
        HRESULT get_webkitBackground([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(75)]
        HRESULT put_webkitTransformOrigin([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(76)]
        HRESULT get_webkitTransformOrigin([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(77)]
        HRESULT put_msTextSizeAdjust(VARIANT v);

        [VtblIndex(78)]
        HRESULT get_msTextSizeAdjust(VARIANT* p);

        [VtblIndex(79)]
        HRESULT put_webkitTextSizeAdjust(VARIANT v);

        [VtblIndex(80)]
        HRESULT get_webkitTextSizeAdjust(VARIANT* p);

        [VtblIndex(81)]
        HRESULT put_webkitBorderImage([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(82)]
        HRESULT get_webkitBorderImage([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(83)]
        HRESULT put_webkitBorderImageSource([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(84)]
        HRESULT get_webkitBorderImageSource([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(85)]
        HRESULT put_webkitBorderImageSlice([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(86)]
        HRESULT get_webkitBorderImageSlice([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(87)]
        HRESULT put_webkitBorderImageWidth([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(88)]
        HRESULT get_webkitBorderImageWidth([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(89)]
        HRESULT put_webkitBorderImageOutset([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(90)]
        HRESULT get_webkitBorderImageOutset([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(91)]
        HRESULT put_webkitBorderImageRepeat([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(92)]
        HRESULT get_webkitBorderImageRepeat([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(93)]
        HRESULT put_webkitBoxSizing([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(94)]
        HRESULT get_webkitBoxSizing([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(95)]
        HRESULT put_webkitAnimationFillMode([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(96)]
        HRESULT get_webkitAnimationFillMode([NativeTypeName("BSTR *")] ushort** p);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitAppearance;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitAppearance;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitUserSelect;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitUserSelect;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBoxAlign;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBoxAlign;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_webkitBoxOrdinalGroup;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_webkitBoxOrdinalGroup;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBoxPack;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBoxPack;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_webkitBoxFlex;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_webkitBoxFlex;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBoxOrient;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBoxOrient;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBoxDirection;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBoxDirection;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitTransform;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitTransform;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBackgroundSize;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBackgroundSize;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBackfaceVisibility;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBackfaceVisibility;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitAnimation;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitAnimation;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitTransition;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitTransition;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitAnimationName;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitAnimationName;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitAnimationDuration;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitAnimationDuration;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitAnimationTimingFunction;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitAnimationTimingFunction;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitAnimationDelay;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitAnimationDelay;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitAnimationIterationCount;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitAnimationIterationCount;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitAnimationDirection;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitAnimationDirection;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitAnimationPlayState;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitAnimationPlayState;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitTransitionProperty;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitTransitionProperty;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitTransitionDuration;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitTransitionDuration;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitTransitionTimingFunction;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitTransitionTimingFunction;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitTransitionDelay;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitTransitionDelay;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBackgroundAttachment;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBackgroundAttachment;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_webkitBackgroundColor;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_webkitBackgroundColor;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBackgroundClip;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBackgroundClip;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBackgroundImage;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBackgroundImage;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBackgroundRepeat;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBackgroundRepeat;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBackgroundOrigin;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBackgroundOrigin;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBackgroundPosition;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBackgroundPosition;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_webkitBackgroundPositionX;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_webkitBackgroundPositionX;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_webkitBackgroundPositionY;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_webkitBackgroundPositionY;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBackground;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBackground;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitTransformOrigin;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitTransformOrigin;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_msTextSizeAdjust;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_msTextSizeAdjust;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_webkitTextSizeAdjust;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_webkitTextSizeAdjust;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBorderImage;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBorderImage;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBorderImageSource;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBorderImageSource;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBorderImageSlice;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBorderImageSlice;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBorderImageWidth;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBorderImageWidth;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBorderImageOutset;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBorderImageOutset;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBorderImageRepeat;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBorderImageRepeat;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitBoxSizing;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitBoxSizing;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_webkitAnimationFillMode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_webkitAnimationFillMode;
    }
}
