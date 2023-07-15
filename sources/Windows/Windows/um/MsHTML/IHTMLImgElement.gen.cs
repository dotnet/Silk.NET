// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement"]/*'/>
[Guid("3050F240-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLImgElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLImgElement : IHTMLImgElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLImgElement));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLImgElement*, uint> )(lpVtbl[1]))((IHTMLImgElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLImgElement*, uint> )(lpVtbl[2]))((IHTMLImgElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, uint*, int> )(lpVtbl[3]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_isMap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_isMap([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, short, int> )(lpVtbl[7]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_isMap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_isMap([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, short*, int> )(lpVtbl[8]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_useMap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_useMap([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort*, int> )(lpVtbl[9]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_useMap"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_useMap([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[10]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_mimeType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_mimeType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[11]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_fileSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_fileSize([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[12]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_fileCreatedDate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_fileCreatedDate([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[13]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_fileModifiedDate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[14]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_fileUpdatedDate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[15]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_protocol"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_protocol([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[16]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_href"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_href([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[17]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_nameProp"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_nameProp([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[18]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_border"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_border(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, VARIANT, int> )(lpVtbl[19]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_border"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_border(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, VARIANT*, int> )(lpVtbl[20]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_vspace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_vspace([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, int, int> )(lpVtbl[21]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_vspace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_vspace([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, int*, int> )(lpVtbl[22]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_hspace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_hspace([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, int, int> )(lpVtbl[23]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_hspace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_hspace([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, int*, int> )(lpVtbl[24]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_alt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_alt([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort*, int> )(lpVtbl[25]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_alt"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_alt([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[26]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_src"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_src([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort*, int> )(lpVtbl[27]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_src"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_src([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[28]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_lowsrc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_lowsrc([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort*, int> )(lpVtbl[29]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_lowsrc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_lowsrc([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[30]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_vrml"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_vrml([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort*, int> )(lpVtbl[31]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_vrml"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_vrml([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[32]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_dynsrc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_dynsrc([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort*, int> )(lpVtbl[33]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_dynsrc"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_dynsrc([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[34]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_readyState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[35]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_complete"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_complete([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, short*, int> )(lpVtbl[36]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_loop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_loop(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, VARIANT, int> )(lpVtbl[37]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_loop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_loop(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, VARIANT*, int> )(lpVtbl[38]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_align"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_align([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort*, int> )(lpVtbl[39]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_align"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_align([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[40]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_onload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_onload(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, VARIANT, int> )(lpVtbl[41]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_onload"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_onload(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, VARIANT*, int> )(lpVtbl[42]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_onerror"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_onerror(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, VARIANT, int> )(lpVtbl[43]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_onerror"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_onerror(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, VARIANT*, int> )(lpVtbl[44]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_onabort"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_onabort(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, VARIANT, int> )(lpVtbl[45]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_onabort"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_onabort(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, VARIANT*, int> )(lpVtbl[46]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT put_name([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort*, int> )(lpVtbl[47]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_name"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_name([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[48]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT put_width([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, int, int> )(lpVtbl[49]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_width([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, int*, int> )(lpVtbl[50]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT put_height([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, int, int> )(lpVtbl[51]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_height([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, int*, int> )(lpVtbl[52]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.put_start"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT put_start([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort*, int> )(lpVtbl[53]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLImgElement.xml' path='doc/member[@name="IHTMLImgElement.get_start"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_start([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLImgElement*, ushort**, int> )(lpVtbl[54]))((IHTMLImgElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_isMap([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(8)]
        HRESULT get_isMap([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(9)]
        HRESULT put_useMap([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(10)]
        HRESULT get_useMap([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT get_mimeType([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(12)]
        HRESULT get_fileSize([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT get_fileCreatedDate([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(14)]
        HRESULT get_fileModifiedDate([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(15)]
        HRESULT get_fileUpdatedDate([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(16)]
        HRESULT get_protocol([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(17)]
        HRESULT get_href([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(18)]
        HRESULT get_nameProp([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(19)]
        HRESULT put_border(VARIANT v);
        [VtblIndex(20)]
        HRESULT get_border(VARIANT* p);
        [VtblIndex(21)]
        HRESULT put_vspace([NativeTypeName("long")] int v);
        [VtblIndex(22)]
        HRESULT get_vspace([NativeTypeName("long *")] int* p);
        [VtblIndex(23)]
        HRESULT put_hspace([NativeTypeName("long")] int v);
        [VtblIndex(24)]
        HRESULT get_hspace([NativeTypeName("long *")] int* p);
        [VtblIndex(25)]
        HRESULT put_alt([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(26)]
        HRESULT get_alt([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(27)]
        HRESULT put_src([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(28)]
        HRESULT get_src([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(29)]
        HRESULT put_lowsrc([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(30)]
        HRESULT get_lowsrc([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(31)]
        HRESULT put_vrml([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(32)]
        HRESULT get_vrml([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(33)]
        HRESULT put_dynsrc([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(34)]
        HRESULT get_dynsrc([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(35)]
        HRESULT get_readyState([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(36)]
        HRESULT get_complete([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(37)]
        HRESULT put_loop(VARIANT v);
        [VtblIndex(38)]
        HRESULT get_loop(VARIANT* p);
        [VtblIndex(39)]
        HRESULT put_align([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(40)]
        HRESULT get_align([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(41)]
        HRESULT put_onload(VARIANT v);
        [VtblIndex(42)]
        HRESULT get_onload(VARIANT* p);
        [VtblIndex(43)]
        HRESULT put_onerror(VARIANT v);
        [VtblIndex(44)]
        HRESULT get_onerror(VARIANT* p);
        [VtblIndex(45)]
        HRESULT put_onabort(VARIANT v);
        [VtblIndex(46)]
        HRESULT get_onabort(VARIANT* p);
        [VtblIndex(47)]
        HRESULT put_name([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(48)]
        HRESULT get_name([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(49)]
        HRESULT put_width([NativeTypeName("long")] int v);
        [VtblIndex(50)]
        HRESULT get_width([NativeTypeName("long *")] int* p);
        [VtblIndex(51)]
        HRESULT put_height([NativeTypeName("long")] int v);
        [VtblIndex(52)]
        HRESULT get_height([NativeTypeName("long *")] int* p);
        [VtblIndex(53)]
        HRESULT put_start([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(54)]
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
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_isMap;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_isMap;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_useMap;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_useMap;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_mimeType;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fileSize;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fileCreatedDate;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fileModifiedDate;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fileUpdatedDate;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_protocol;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_href;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_nameProp;
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