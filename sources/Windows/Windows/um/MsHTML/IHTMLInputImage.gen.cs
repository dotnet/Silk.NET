// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage"]/*' />
[Guid("3050F2C2-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLInputImage : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLInputImage : IHTMLInputImage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLInputImage));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLInputImage*, uint>)(lpVtbl[1]))((IHTMLInputImage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLInputImage*, uint>)(lpVtbl[2]))((IHTMLInputImage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, uint*, int>)(lpVtbl[3]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_type"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_type([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort**, int>)(lpVtbl[7]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_disabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, short, int>)(lpVtbl[8]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_disabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, short*, int>)(lpVtbl[9]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_border"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_border(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, VARIANT, int>)(lpVtbl[10]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_border"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_border(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, VARIANT*, int>)(lpVtbl[11]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_vspace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_vspace([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, int, int>)(lpVtbl[12]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_vspace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_vspace([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, int*, int>)(lpVtbl[13]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_hspace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_hspace([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, int, int>)(lpVtbl[14]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_hspace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_hspace([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, int*, int>)(lpVtbl[15]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_alt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_alt([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort*, int>)(lpVtbl[16]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_alt"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_alt([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort**, int>)(lpVtbl[17]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_src"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_src([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort*, int>)(lpVtbl[18]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_src"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_src([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort**, int>)(lpVtbl[19]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_lowsrc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_lowsrc([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort*, int>)(lpVtbl[20]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_lowsrc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_lowsrc([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort**, int>)(lpVtbl[21]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_vrml"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_vrml([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort*, int>)(lpVtbl[22]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_vrml"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_vrml([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort**, int>)(lpVtbl[23]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_dynsrc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_dynsrc([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort*, int>)(lpVtbl[24]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_dynsrc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_dynsrc([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort**, int>)(lpVtbl[25]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_readyState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort**, int>)(lpVtbl[26]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_complete"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_complete([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, short*, int>)(lpVtbl[27]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_loop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_loop(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, VARIANT, int>)(lpVtbl[28]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_loop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_loop(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, VARIANT*, int>)(lpVtbl[29]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_align"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_align([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort*, int>)(lpVtbl[30]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_align"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_align([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort**, int>)(lpVtbl[31]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_onload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_onload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, VARIANT, int>)(lpVtbl[32]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_onload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_onload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, VARIANT*, int>)(lpVtbl[33]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_onerror"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_onerror(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, VARIANT, int>)(lpVtbl[34]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_onerror"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_onerror(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, VARIANT*, int>)(lpVtbl[35]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_onabort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_onabort(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, VARIANT, int>)(lpVtbl[36]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_onabort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_onabort(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, VARIANT*, int>)(lpVtbl[37]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort*, int>)(lpVtbl[38]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_name"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort**, int>)(lpVtbl[39]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_width([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, int, int>)(lpVtbl[40]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_width([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, int*, int>)(lpVtbl[41]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_height([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, int, int>)(lpVtbl[42]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_height([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, int*, int>)(lpVtbl[43]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.put_start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_start([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort*, int>)(lpVtbl[44]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLInputImage.xml' path='doc/member[@name="IHTMLInputImage.get_start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_start([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLInputImage*, ushort**, int>)(lpVtbl[45]))((IHTMLInputImage*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_type([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(8)]
        HRESULT put_disabled([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(9)]
        HRESULT get_disabled([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(10)]
        HRESULT put_border(VARIANT v);

        [VtblIndex(11)]
        HRESULT get_border(VARIANT* p);

        [VtblIndex(12)]
        HRESULT put_vspace([NativeTypeName("long")] int v);

        [VtblIndex(13)]
        HRESULT get_vspace([NativeTypeName("long *")] int* p);

        [VtblIndex(14)]
        HRESULT put_hspace([NativeTypeName("long")] int v);

        [VtblIndex(15)]
        HRESULT get_hspace([NativeTypeName("long *")] int* p);

        [VtblIndex(16)]
        HRESULT put_alt([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(17)]
        HRESULT get_alt([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(18)]
        HRESULT put_src([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(19)]
        HRESULT get_src([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(20)]
        HRESULT put_lowsrc([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(21)]
        HRESULT get_lowsrc([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(22)]
        HRESULT put_vrml([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(23)]
        HRESULT get_vrml([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(24)]
        HRESULT put_dynsrc([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(25)]
        HRESULT get_dynsrc([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(26)]
        HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(27)]
        HRESULT get_complete([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(28)]
        HRESULT put_loop(VARIANT v);

        [VtblIndex(29)]
        HRESULT get_loop(VARIANT* p);

        [VtblIndex(30)]
        HRESULT put_align([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(31)]
        HRESULT get_align([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(32)]
        HRESULT put_onload(VARIANT v);

        [VtblIndex(33)]
        HRESULT get_onload(VARIANT* p);

        [VtblIndex(34)]
        HRESULT put_onerror(VARIANT v);

        [VtblIndex(35)]
        HRESULT get_onerror(VARIANT* p);

        [VtblIndex(36)]
        HRESULT put_onabort(VARIANT v);

        [VtblIndex(37)]
        HRESULT get_onabort(VARIANT* p);

        [VtblIndex(38)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(39)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(40)]
        HRESULT put_width([NativeTypeName("long")] int v);

        [VtblIndex(41)]
        HRESULT get_width([NativeTypeName("long *")] int* p);

        [VtblIndex(42)]
        HRESULT put_height([NativeTypeName("long")] int v);

        [VtblIndex(43)]
        HRESULT get_height([NativeTypeName("long *")] int* p);

        [VtblIndex(44)]
        HRESULT put_start([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(45)]
        HRESULT get_start([NativeTypeName("BSTR *")] ushort** p);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_type;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_disabled;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_disabled;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_border;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_border;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_vspace;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_vspace;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_hspace;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_hspace;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_alt;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_alt;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_src;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_src;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_lowsrc;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_lowsrc;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_vrml;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_vrml;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_dynsrc;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_dynsrc;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_readyState;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_complete;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_loop;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_loop;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_align;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_align;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onload;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onload;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onerror;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onerror;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onabort;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_onabort;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_name;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_width;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_width;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_height;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_height;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_start;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_start;
    }
}
