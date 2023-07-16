// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2"]/*'/>
[Guid("3050F4A2-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLStyle2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLStyle2 : IHTMLStyle2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLStyle2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLStyle2*, uint> )(lpVtbl[1]))((IHTMLStyle2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLStyle2*, uint> )(lpVtbl[2]))((IHTMLStyle2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, uint*, int> )(lpVtbl[3]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_tableLayout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_tableLayout([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[7]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_tableLayout"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_tableLayout([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[8]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_borderCollapse"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_borderCollapse([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[9]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_borderCollapse"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_borderCollapse([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[10]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_direction"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_direction([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[11]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_direction"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_direction([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[12]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_behavior"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_behavior([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[13]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_behavior"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_behavior([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[14]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.setExpression"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT setExpression([NativeTypeName("BSTR")] ushort* propname, [NativeTypeName("BSTR")] ushort* expression, [NativeTypeName("BSTR")] ushort* language = null)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, ushort*, ushort*, int> )(lpVtbl[15]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), propname, expression, language);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.getExpression"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT getExpression([NativeTypeName("BSTR")] ushort* propname, VARIANT* expression)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, VARIANT*, int> )(lpVtbl[16]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), propname, expression);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.removeExpression"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT removeExpression([NativeTypeName("BSTR")] ushort* propname, [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, short*, int> )(lpVtbl[17]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), propname, pfSuccess);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_position"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_position([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[18]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_position"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_position([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[19]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_unicodeBidi"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_unicodeBidi([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[20]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_unicodeBidi"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_unicodeBidi([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[21]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_bottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_bottom(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, VARIANT, int> )(lpVtbl[22]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_bottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_bottom(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, VARIANT*, int> )(lpVtbl[23]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_right"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_right(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, VARIANT, int> )(lpVtbl[24]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_right"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_right(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, VARIANT*, int> )(lpVtbl[25]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_pixelBottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_pixelBottom([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, int, int> )(lpVtbl[26]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_pixelBottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_pixelBottom([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, int*, int> )(lpVtbl[27]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_pixelRight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_pixelRight([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, int, int> )(lpVtbl[28]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_pixelRight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_pixelRight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, int*, int> )(lpVtbl[29]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_posBottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_posBottom(float v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, float, int> )(lpVtbl[30]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_posBottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_posBottom(float* p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, float*, int> )(lpVtbl[31]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_posRight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_posRight(float v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, float, int> )(lpVtbl[32]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_posRight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_posRight(float* p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, float*, int> )(lpVtbl[33]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_imeMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_imeMode([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[34]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_imeMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_imeMode([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[35]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_rubyAlign"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_rubyAlign([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[36]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_rubyAlign"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_rubyAlign([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[37]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_rubyPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_rubyPosition([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[38]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_rubyPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_rubyPosition([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[39]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_rubyOverhang"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_rubyOverhang([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[40]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_rubyOverhang"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_rubyOverhang([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[41]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_layoutGridChar"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT put_layoutGridChar(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, VARIANT, int> )(lpVtbl[42]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_layoutGridChar"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_layoutGridChar(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, VARIANT*, int> )(lpVtbl[43]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_layoutGridLine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT put_layoutGridLine(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, VARIANT, int> )(lpVtbl[44]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_layoutGridLine"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_layoutGridLine(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, VARIANT*, int> )(lpVtbl[45]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_layoutGridMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT put_layoutGridMode([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[46]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_layoutGridMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT get_layoutGridMode([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[47]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_layoutGridType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT put_layoutGridType([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[48]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_layoutGridType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT get_layoutGridType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[49]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_layoutGrid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT put_layoutGrid([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[50]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_layoutGrid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT get_layoutGrid([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[51]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_wordBreak"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT put_wordBreak([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[52]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_wordBreak"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT get_wordBreak([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[53]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_lineBreak"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT put_lineBreak([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[54]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_lineBreak"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT get_lineBreak([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[55]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_textJustify"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT put_textJustify([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[56]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_textJustify"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT get_textJustify([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[57]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_textJustifyTrim"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT put_textJustifyTrim([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[58]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_textJustifyTrim"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_textJustifyTrim([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[59]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_textKashida"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT put_textKashida(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, VARIANT, int> )(lpVtbl[60]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_textKashida"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT get_textKashida(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, VARIANT*, int> )(lpVtbl[61]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_textAutospace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT put_textAutospace([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[62]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_textAutospace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_textAutospace([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[63]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_overflowX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT put_overflowX([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[64]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_overflowX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT get_overflowX([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[65]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_overflowY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT put_overflowY([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[66]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_overflowY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT get_overflowY([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[67]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.put_accelerator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT put_accelerator([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort*, int> )(lpVtbl[68]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle2.xml' path='doc/member[@name="IHTMLStyle2.get_accelerator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT get_accelerator([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle2*, ushort**, int> )(lpVtbl[69]))((IHTMLStyle2*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_tableLayout([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_tableLayout([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT put_borderCollapse([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(10)]
        HRESULT get_borderCollapse([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT put_direction([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(12)]
        HRESULT get_direction([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT put_behavior([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(14)]
        HRESULT get_behavior([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(15)]
        HRESULT setExpression([NativeTypeName("BSTR")] ushort* propname, [NativeTypeName("BSTR")] ushort* expression, [NativeTypeName("BSTR")] ushort* language = null);
        [VtblIndex(16)]
        HRESULT getExpression([NativeTypeName("BSTR")] ushort* propname, VARIANT* expression);
        [VtblIndex(17)]
        HRESULT removeExpression([NativeTypeName("BSTR")] ushort* propname, [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess);
        [VtblIndex(18)]
        HRESULT put_position([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(19)]
        HRESULT get_position([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(20)]
        HRESULT put_unicodeBidi([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(21)]
        HRESULT get_unicodeBidi([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(22)]
        HRESULT put_bottom(VARIANT v);
        [VtblIndex(23)]
        HRESULT get_bottom(VARIANT* p);
        [VtblIndex(24)]
        HRESULT put_right(VARIANT v);
        [VtblIndex(25)]
        HRESULT get_right(VARIANT* p);
        [VtblIndex(26)]
        HRESULT put_pixelBottom([NativeTypeName("long")] int v);
        [VtblIndex(27)]
        HRESULT get_pixelBottom([NativeTypeName("long *")] int* p);
        [VtblIndex(28)]
        HRESULT put_pixelRight([NativeTypeName("long")] int v);
        [VtblIndex(29)]
        HRESULT get_pixelRight([NativeTypeName("long *")] int* p);
        [VtblIndex(30)]
        HRESULT put_posBottom(float v);
        [VtblIndex(31)]
        HRESULT get_posBottom(float* p);
        [VtblIndex(32)]
        HRESULT put_posRight(float v);
        [VtblIndex(33)]
        HRESULT get_posRight(float* p);
        [VtblIndex(34)]
        HRESULT put_imeMode([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(35)]
        HRESULT get_imeMode([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(36)]
        HRESULT put_rubyAlign([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(37)]
        HRESULT get_rubyAlign([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(38)]
        HRESULT put_rubyPosition([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(39)]
        HRESULT get_rubyPosition([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(40)]
        HRESULT put_rubyOverhang([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(41)]
        HRESULT get_rubyOverhang([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(42)]
        HRESULT put_layoutGridChar(VARIANT v);
        [VtblIndex(43)]
        HRESULT get_layoutGridChar(VARIANT* p);
        [VtblIndex(44)]
        HRESULT put_layoutGridLine(VARIANT v);
        [VtblIndex(45)]
        HRESULT get_layoutGridLine(VARIANT* p);
        [VtblIndex(46)]
        HRESULT put_layoutGridMode([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(47)]
        HRESULT get_layoutGridMode([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(48)]
        HRESULT put_layoutGridType([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(49)]
        HRESULT get_layoutGridType([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(50)]
        HRESULT put_layoutGrid([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(51)]
        HRESULT get_layoutGrid([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(52)]
        HRESULT put_wordBreak([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(53)]
        HRESULT get_wordBreak([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(54)]
        HRESULT put_lineBreak([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(55)]
        HRESULT get_lineBreak([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(56)]
        HRESULT put_textJustify([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(57)]
        HRESULT get_textJustify([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(58)]
        HRESULT put_textJustifyTrim([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(59)]
        HRESULT get_textJustifyTrim([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(60)]
        HRESULT put_textKashida(VARIANT v);
        [VtblIndex(61)]
        HRESULT get_textKashida(VARIANT* p);
        [VtblIndex(62)]
        HRESULT put_textAutospace([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(63)]
        HRESULT get_textAutospace([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(64)]
        HRESULT put_overflowX([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(65)]
        HRESULT get_overflowX([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(66)]
        HRESULT put_overflowY([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(67)]
        HRESULT get_overflowY([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(68)]
        HRESULT put_accelerator([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(69)]
        HRESULT get_accelerator([NativeTypeName("BSTR *")] ushort** p);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_tableLayout;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_tableLayout;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderCollapse;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderCollapse;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_direction;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_direction;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_behavior;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_behavior;
        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, int> setExpression;
        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> getExpression;
        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> removeExpression;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_position;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_position;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_unicodeBidi;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_unicodeBidi;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_bottom;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_bottom;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_right;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_right;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_pixelBottom;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_pixelBottom;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_pixelRight;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_pixelRight;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_posBottom;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_posBottom;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_posRight;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_posRight;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_imeMode;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_imeMode;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_rubyAlign;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_rubyAlign;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_rubyPosition;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_rubyPosition;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_rubyOverhang;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_rubyOverhang;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_layoutGridChar;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_layoutGridChar;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_layoutGridLine;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_layoutGridLine;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_layoutGridMode;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_layoutGridMode;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_layoutGridType;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_layoutGridType;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_layoutGrid;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_layoutGrid;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_wordBreak;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_wordBreak;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_lineBreak;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_lineBreak;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textJustify;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textJustify;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textJustifyTrim;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textJustifyTrim;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_textKashida;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_textKashida;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textAutospace;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textAutospace;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_overflowX;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_overflowX;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_overflowY;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_overflowY;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_accelerator;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_accelerator;
    }
}