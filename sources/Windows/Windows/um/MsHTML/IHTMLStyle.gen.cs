// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle"]/*'/>
[Guid("3050F25E-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLStyle : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLStyle : IHTMLStyle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLStyle));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLStyle*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLStyle*, uint> )(lpVtbl[1]))((IHTMLStyle*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLStyle*, uint> )(lpVtbl[2]))((IHTMLStyle*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLStyle*, uint*, int> )(lpVtbl[3]))((IHTMLStyle*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLStyle*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IHTMLStyle*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLStyle*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IHTMLStyle*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLStyle*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IHTMLStyle*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_fontFamily"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_fontFamily([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[7]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_fontFamily"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_fontFamily([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[8]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_fontStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_fontStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[9]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_fontStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_fontStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[10]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_fontVariant"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_fontVariant([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[11]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_fontVariant"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_fontVariant([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[12]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_fontWeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_fontWeight([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[13]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_fontWeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_fontWeight([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[14]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_fontSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_fontSize(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[15]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_fontSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_fontSize(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[16]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_font"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_font([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[17]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_font"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_font([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[18]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_color"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_color(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[19]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_color"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_color(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[20]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_background"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_background([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[21]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_background"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_background([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[22]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_backgroundColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_backgroundColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[23]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_backgroundColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_backgroundColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[24]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_backgroundImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_backgroundImage([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[25]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_backgroundImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_backgroundImage([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[26]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_backgroundRepeat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_backgroundRepeat([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[27]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_backgroundRepeat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_backgroundRepeat([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[28]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_backgroundAttachment"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_backgroundAttachment([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[29]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_backgroundAttachment"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_backgroundAttachment([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[30]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_backgroundPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_backgroundPosition([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[31]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_backgroundPosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_backgroundPosition([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[32]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_backgroundPositionX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_backgroundPositionX(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[33]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_backgroundPositionX"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_backgroundPositionX(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[34]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_backgroundPositionY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT put_backgroundPositionY(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[35]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_backgroundPositionY"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_backgroundPositionY(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[36]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_wordSpacing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT put_wordSpacing(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[37]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_wordSpacing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_wordSpacing(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[38]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_letterSpacing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT put_letterSpacing(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[39]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_letterSpacing"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_letterSpacing(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[40]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_textDecoration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT put_textDecoration([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[41]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_textDecoration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT get_textDecoration([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[42]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_textDecorationNone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT put_textDecorationNone([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, short, int> )(lpVtbl[43]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_textDecorationNone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_textDecorationNone([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, short*, int> )(lpVtbl[44]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_textDecorationUnderline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT put_textDecorationUnderline([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, short, int> )(lpVtbl[45]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_textDecorationUnderline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT get_textDecorationUnderline([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, short*, int> )(lpVtbl[46]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_textDecorationOverline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT put_textDecorationOverline([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, short, int> )(lpVtbl[47]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_textDecorationOverline"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT get_textDecorationOverline([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, short*, int> )(lpVtbl[48]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_textDecorationLineThrough"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT put_textDecorationLineThrough([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, short, int> )(lpVtbl[49]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_textDecorationLineThrough"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT get_textDecorationLineThrough([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, short*, int> )(lpVtbl[50]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_textDecorationBlink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT put_textDecorationBlink([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, short, int> )(lpVtbl[51]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_textDecorationBlink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT get_textDecorationBlink([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, short*, int> )(lpVtbl[52]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_verticalAlign"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT put_verticalAlign(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[53]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_verticalAlign"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT get_verticalAlign(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[54]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_textTransform"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT put_textTransform([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[55]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_textTransform"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT get_textTransform([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[56]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_textAlign"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT put_textAlign([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[57]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_textAlign"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT get_textAlign([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[58]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_textIndent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT put_textIndent(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[59]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_textIndent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_textIndent(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[60]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_lineHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT put_lineHeight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[61]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_lineHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_lineHeight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[62]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_marginTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT put_marginTop(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[63]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_marginTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT get_marginTop(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[64]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_marginRight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT put_marginRight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[65]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_marginRight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT get_marginRight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[66]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_marginBottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT put_marginBottom(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[67]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_marginBottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT get_marginBottom(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[68]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_marginLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT put_marginLeft(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[69]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_marginLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT get_marginLeft(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[70]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_margin"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT put_margin([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[71]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_margin"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT get_margin([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[72]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_paddingTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT put_paddingTop(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[73]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_paddingTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT get_paddingTop(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[74]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_paddingRight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT put_paddingRight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[75]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_paddingRight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT get_paddingRight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[76]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_paddingBottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT put_paddingBottom(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[77]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_paddingBottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT get_paddingBottom(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[78]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_paddingLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT put_paddingLeft(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[79]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_paddingLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public HRESULT get_paddingLeft(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[80]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_padding"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public HRESULT put_padding([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[81]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_padding"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT get_padding([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[82]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_border"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public HRESULT put_border([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[83]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_border"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    public HRESULT get_border([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[84]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT put_borderTop([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[85]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT get_borderTop([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[86]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderRight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT put_borderRight([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[87]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderRight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT get_borderRight([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[88]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderBottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT put_borderBottom([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[89]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderBottom"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public HRESULT get_borderBottom([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[90]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT put_borderLeft([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[91]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT get_borderLeft([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[92]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT put_borderColor([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[93]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT get_borderColor([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[94]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderTopColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(95)]
    public HRESULT put_borderTopColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[95]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderTopColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(96)]
    public HRESULT get_borderTopColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[96]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderRightColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(97)]
    public HRESULT put_borderRightColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[97]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderRightColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(98)]
    public HRESULT get_borderRightColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[98]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderBottomColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(99)]
    public HRESULT put_borderBottomColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[99]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderBottomColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(100)]
    public HRESULT get_borderBottomColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[100]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderLeftColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(101)]
    public HRESULT put_borderLeftColor(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[101]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderLeftColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(102)]
    public HRESULT get_borderLeftColor(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[102]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(103)]
    public HRESULT put_borderWidth([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[103]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(104)]
    public HRESULT get_borderWidth([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[104]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderTopWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(105)]
    public HRESULT put_borderTopWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[105]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderTopWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(106)]
    public HRESULT get_borderTopWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[106]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderRightWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(107)]
    public HRESULT put_borderRightWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[107]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderRightWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(108)]
    public HRESULT get_borderRightWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[108]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderBottomWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(109)]
    public HRESULT put_borderBottomWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[109]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderBottomWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(110)]
    public HRESULT get_borderBottomWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[110]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderLeftWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(111)]
    public HRESULT put_borderLeftWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[111]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderLeftWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(112)]
    public HRESULT get_borderLeftWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[112]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(113)]
    public HRESULT put_borderStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[113]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(114)]
    public HRESULT get_borderStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[114]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderTopStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(115)]
    public HRESULT put_borderTopStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[115]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderTopStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(116)]
    public HRESULT get_borderTopStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[116]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderRightStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(117)]
    public HRESULT put_borderRightStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[117]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderRightStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(118)]
    public HRESULT get_borderRightStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[118]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderBottomStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(119)]
    public HRESULT put_borderBottomStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[119]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderBottomStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(120)]
    public HRESULT get_borderBottomStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[120]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_borderLeftStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(121)]
    public HRESULT put_borderLeftStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[121]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_borderLeftStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(122)]
    public HRESULT get_borderLeftStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[122]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(123)]
    public HRESULT put_width(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[123]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_width"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(124)]
    public HRESULT get_width(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[124]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(125)]
    public HRESULT put_height(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[125]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_height"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(126)]
    public HRESULT get_height(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[126]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_styleFloat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(127)]
    public HRESULT put_styleFloat([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[127]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_styleFloat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(128)]
    public HRESULT get_styleFloat([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[128]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_clear"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(129)]
    public HRESULT put_clear([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[129]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_clear"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(130)]
    public HRESULT get_clear([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[130]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_display"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(131)]
    public HRESULT put_display([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[131]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_display"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(132)]
    public HRESULT get_display([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[132]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_visibility"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(133)]
    public HRESULT put_visibility([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[133]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_visibility"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(134)]
    public HRESULT get_visibility([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[134]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_listStyleType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(135)]
    public HRESULT put_listStyleType([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[135]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_listStyleType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(136)]
    public HRESULT get_listStyleType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[136]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_listStylePosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(137)]
    public HRESULT put_listStylePosition([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[137]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_listStylePosition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(138)]
    public HRESULT get_listStylePosition([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[138]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_listStyleImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(139)]
    public HRESULT put_listStyleImage([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[139]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_listStyleImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(140)]
    public HRESULT get_listStyleImage([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[140]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_listStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(141)]
    public HRESULT put_listStyle([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[141]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_listStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(142)]
    public HRESULT get_listStyle([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[142]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_whiteSpace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(143)]
    public HRESULT put_whiteSpace([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[143]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_whiteSpace"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(144)]
    public HRESULT get_whiteSpace([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[144]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_top"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(145)]
    public HRESULT put_top(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[145]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_top"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(146)]
    public HRESULT get_top(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[146]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_left"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(147)]
    public HRESULT put_left(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[147]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_left"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(148)]
    public HRESULT get_left(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[148]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_position"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(149)]
    public HRESULT get_position([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[149]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_zIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(150)]
    public HRESULT put_zIndex(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT, int> )(lpVtbl[150]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_zIndex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(151)]
    public HRESULT get_zIndex(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, VARIANT*, int> )(lpVtbl[151]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_overflow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(152)]
    public HRESULT put_overflow([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[152]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_overflow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(153)]
    public HRESULT get_overflow([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[153]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_pageBreakBefore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(154)]
    public HRESULT put_pageBreakBefore([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[154]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_pageBreakBefore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(155)]
    public HRESULT get_pageBreakBefore([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[155]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_pageBreakAfter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(156)]
    public HRESULT put_pageBreakAfter([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[156]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_pageBreakAfter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(157)]
    public HRESULT get_pageBreakAfter([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[157]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_cssText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(158)]
    public HRESULT put_cssText([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[158]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_cssText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(159)]
    public HRESULT get_cssText([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[159]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_pixelTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(160)]
    public HRESULT put_pixelTop([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, int, int> )(lpVtbl[160]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_pixelTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(161)]
    public HRESULT get_pixelTop([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, int*, int> )(lpVtbl[161]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_pixelLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(162)]
    public HRESULT put_pixelLeft([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, int, int> )(lpVtbl[162]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_pixelLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(163)]
    public HRESULT get_pixelLeft([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, int*, int> )(lpVtbl[163]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_pixelWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(164)]
    public HRESULT put_pixelWidth([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, int, int> )(lpVtbl[164]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_pixelWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(165)]
    public HRESULT get_pixelWidth([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, int*, int> )(lpVtbl[165]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_pixelHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(166)]
    public HRESULT put_pixelHeight([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, int, int> )(lpVtbl[166]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_pixelHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(167)]
    public HRESULT get_pixelHeight([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, int*, int> )(lpVtbl[167]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_posTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(168)]
    public HRESULT put_posTop(float v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, float, int> )(lpVtbl[168]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_posTop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(169)]
    public HRESULT get_posTop(float* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, float*, int> )(lpVtbl[169]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_posLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(170)]
    public HRESULT put_posLeft(float v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, float, int> )(lpVtbl[170]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_posLeft"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(171)]
    public HRESULT get_posLeft(float* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, float*, int> )(lpVtbl[171]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_posWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(172)]
    public HRESULT put_posWidth(float v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, float, int> )(lpVtbl[172]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_posWidth"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(173)]
    public HRESULT get_posWidth(float* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, float*, int> )(lpVtbl[173]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_posHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(174)]
    public HRESULT put_posHeight(float v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, float, int> )(lpVtbl[174]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_posHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(175)]
    public HRESULT get_posHeight(float* p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, float*, int> )(lpVtbl[175]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_cursor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(176)]
    public HRESULT put_cursor([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[176]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_cursor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(177)]
    public HRESULT get_cursor([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[177]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_clip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(178)]
    public HRESULT put_clip([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[178]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_clip"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(179)]
    public HRESULT get_clip([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[179]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.put_filter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(180)]
    public HRESULT put_filter([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int> )(lpVtbl[180]))((IHTMLStyle*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.get_filter"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(181)]
    public HRESULT get_filter([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[181]))((IHTMLStyle*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.setAttribute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(182)]
    public HRESULT setAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT AttributeValue, [NativeTypeName("LONG")] int lFlags = 1)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, VARIANT, int, int> )(lpVtbl[182]))((IHTMLStyle*)Unsafe.AsPointer(ref this), strAttributeName, AttributeValue, lFlags);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.getAttribute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(183)]
    public HRESULT getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, VARIANT* AttributeValue)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int, VARIANT*, int> )(lpVtbl[183]))((IHTMLStyle*)Unsafe.AsPointer(ref this), strAttributeName, lFlags, AttributeValue);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.removeAttribute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(184)]
    public HRESULT removeAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort*, int, short*, int> )(lpVtbl[184]))((IHTMLStyle*)Unsafe.AsPointer(ref this), strAttributeName, lFlags, pfSuccess);
    }

    /// <include file='IHTMLStyle.xml' path='doc/member[@name="IHTMLStyle.toString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(185)]
    public HRESULT toString([NativeTypeName("BSTR *")] ushort** String)
    {
        return ((delegate* unmanaged<IHTMLStyle*, ushort**, int> )(lpVtbl[185]))((IHTMLStyle*)Unsafe.AsPointer(ref this), String);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_fontFamily([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(8)]
        HRESULT get_fontFamily([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(9)]
        HRESULT put_fontStyle([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(10)]
        HRESULT get_fontStyle([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(11)]
        HRESULT put_fontVariant([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(12)]
        HRESULT get_fontVariant([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(13)]
        HRESULT put_fontWeight([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(14)]
        HRESULT get_fontWeight([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(15)]
        HRESULT put_fontSize(VARIANT v);
        [VtblIndex(16)]
        HRESULT get_fontSize(VARIANT* p);
        [VtblIndex(17)]
        HRESULT put_font([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(18)]
        HRESULT get_font([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(19)]
        HRESULT put_color(VARIANT v);
        [VtblIndex(20)]
        HRESULT get_color(VARIANT* p);
        [VtblIndex(21)]
        HRESULT put_background([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(22)]
        HRESULT get_background([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(23)]
        HRESULT put_backgroundColor(VARIANT v);
        [VtblIndex(24)]
        HRESULT get_backgroundColor(VARIANT* p);
        [VtblIndex(25)]
        HRESULT put_backgroundImage([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(26)]
        HRESULT get_backgroundImage([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(27)]
        HRESULT put_backgroundRepeat([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(28)]
        HRESULT get_backgroundRepeat([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(29)]
        HRESULT put_backgroundAttachment([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(30)]
        HRESULT get_backgroundAttachment([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(31)]
        HRESULT put_backgroundPosition([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(32)]
        HRESULT get_backgroundPosition([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(33)]
        HRESULT put_backgroundPositionX(VARIANT v);
        [VtblIndex(34)]
        HRESULT get_backgroundPositionX(VARIANT* p);
        [VtblIndex(35)]
        HRESULT put_backgroundPositionY(VARIANT v);
        [VtblIndex(36)]
        HRESULT get_backgroundPositionY(VARIANT* p);
        [VtblIndex(37)]
        HRESULT put_wordSpacing(VARIANT v);
        [VtblIndex(38)]
        HRESULT get_wordSpacing(VARIANT* p);
        [VtblIndex(39)]
        HRESULT put_letterSpacing(VARIANT v);
        [VtblIndex(40)]
        HRESULT get_letterSpacing(VARIANT* p);
        [VtblIndex(41)]
        HRESULT put_textDecoration([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(42)]
        HRESULT get_textDecoration([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(43)]
        HRESULT put_textDecorationNone([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(44)]
        HRESULT get_textDecorationNone([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(45)]
        HRESULT put_textDecorationUnderline([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(46)]
        HRESULT get_textDecorationUnderline([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(47)]
        HRESULT put_textDecorationOverline([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(48)]
        HRESULT get_textDecorationOverline([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(49)]
        HRESULT put_textDecorationLineThrough([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(50)]
        HRESULT get_textDecorationLineThrough([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(51)]
        HRESULT put_textDecorationBlink([NativeTypeName("VARIANT_BOOL")] short v);
        [VtblIndex(52)]
        HRESULT get_textDecorationBlink([NativeTypeName("VARIANT_BOOL *")] short* p);
        [VtblIndex(53)]
        HRESULT put_verticalAlign(VARIANT v);
        [VtblIndex(54)]
        HRESULT get_verticalAlign(VARIANT* p);
        [VtblIndex(55)]
        HRESULT put_textTransform([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(56)]
        HRESULT get_textTransform([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(57)]
        HRESULT put_textAlign([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(58)]
        HRESULT get_textAlign([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(59)]
        HRESULT put_textIndent(VARIANT v);
        [VtblIndex(60)]
        HRESULT get_textIndent(VARIANT* p);
        [VtblIndex(61)]
        HRESULT put_lineHeight(VARIANT v);
        [VtblIndex(62)]
        HRESULT get_lineHeight(VARIANT* p);
        [VtblIndex(63)]
        HRESULT put_marginTop(VARIANT v);
        [VtblIndex(64)]
        HRESULT get_marginTop(VARIANT* p);
        [VtblIndex(65)]
        HRESULT put_marginRight(VARIANT v);
        [VtblIndex(66)]
        HRESULT get_marginRight(VARIANT* p);
        [VtblIndex(67)]
        HRESULT put_marginBottom(VARIANT v);
        [VtblIndex(68)]
        HRESULT get_marginBottom(VARIANT* p);
        [VtblIndex(69)]
        HRESULT put_marginLeft(VARIANT v);
        [VtblIndex(70)]
        HRESULT get_marginLeft(VARIANT* p);
        [VtblIndex(71)]
        HRESULT put_margin([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(72)]
        HRESULT get_margin([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(73)]
        HRESULT put_paddingTop(VARIANT v);
        [VtblIndex(74)]
        HRESULT get_paddingTop(VARIANT* p);
        [VtblIndex(75)]
        HRESULT put_paddingRight(VARIANT v);
        [VtblIndex(76)]
        HRESULT get_paddingRight(VARIANT* p);
        [VtblIndex(77)]
        HRESULT put_paddingBottom(VARIANT v);
        [VtblIndex(78)]
        HRESULT get_paddingBottom(VARIANT* p);
        [VtblIndex(79)]
        HRESULT put_paddingLeft(VARIANT v);
        [VtblIndex(80)]
        HRESULT get_paddingLeft(VARIANT* p);
        [VtblIndex(81)]
        HRESULT put_padding([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(82)]
        HRESULT get_padding([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(83)]
        HRESULT put_border([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(84)]
        HRESULT get_border([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(85)]
        HRESULT put_borderTop([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(86)]
        HRESULT get_borderTop([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(87)]
        HRESULT put_borderRight([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(88)]
        HRESULT get_borderRight([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(89)]
        HRESULT put_borderBottom([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(90)]
        HRESULT get_borderBottom([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(91)]
        HRESULT put_borderLeft([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(92)]
        HRESULT get_borderLeft([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(93)]
        HRESULT put_borderColor([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(94)]
        HRESULT get_borderColor([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(95)]
        HRESULT put_borderTopColor(VARIANT v);
        [VtblIndex(96)]
        HRESULT get_borderTopColor(VARIANT* p);
        [VtblIndex(97)]
        HRESULT put_borderRightColor(VARIANT v);
        [VtblIndex(98)]
        HRESULT get_borderRightColor(VARIANT* p);
        [VtblIndex(99)]
        HRESULT put_borderBottomColor(VARIANT v);
        [VtblIndex(100)]
        HRESULT get_borderBottomColor(VARIANT* p);
        [VtblIndex(101)]
        HRESULT put_borderLeftColor(VARIANT v);
        [VtblIndex(102)]
        HRESULT get_borderLeftColor(VARIANT* p);
        [VtblIndex(103)]
        HRESULT put_borderWidth([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(104)]
        HRESULT get_borderWidth([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(105)]
        HRESULT put_borderTopWidth(VARIANT v);
        [VtblIndex(106)]
        HRESULT get_borderTopWidth(VARIANT* p);
        [VtblIndex(107)]
        HRESULT put_borderRightWidth(VARIANT v);
        [VtblIndex(108)]
        HRESULT get_borderRightWidth(VARIANT* p);
        [VtblIndex(109)]
        HRESULT put_borderBottomWidth(VARIANT v);
        [VtblIndex(110)]
        HRESULT get_borderBottomWidth(VARIANT* p);
        [VtblIndex(111)]
        HRESULT put_borderLeftWidth(VARIANT v);
        [VtblIndex(112)]
        HRESULT get_borderLeftWidth(VARIANT* p);
        [VtblIndex(113)]
        HRESULT put_borderStyle([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(114)]
        HRESULT get_borderStyle([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(115)]
        HRESULT put_borderTopStyle([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(116)]
        HRESULT get_borderTopStyle([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(117)]
        HRESULT put_borderRightStyle([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(118)]
        HRESULT get_borderRightStyle([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(119)]
        HRESULT put_borderBottomStyle([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(120)]
        HRESULT get_borderBottomStyle([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(121)]
        HRESULT put_borderLeftStyle([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(122)]
        HRESULT get_borderLeftStyle([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(123)]
        HRESULT put_width(VARIANT v);
        [VtblIndex(124)]
        HRESULT get_width(VARIANT* p);
        [VtblIndex(125)]
        HRESULT put_height(VARIANT v);
        [VtblIndex(126)]
        HRESULT get_height(VARIANT* p);
        [VtblIndex(127)]
        HRESULT put_styleFloat([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(128)]
        HRESULT get_styleFloat([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(129)]
        HRESULT put_clear([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(130)]
        HRESULT get_clear([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(131)]
        HRESULT put_display([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(132)]
        HRESULT get_display([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(133)]
        HRESULT put_visibility([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(134)]
        HRESULT get_visibility([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(135)]
        HRESULT put_listStyleType([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(136)]
        HRESULT get_listStyleType([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(137)]
        HRESULT put_listStylePosition([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(138)]
        HRESULT get_listStylePosition([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(139)]
        HRESULT put_listStyleImage([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(140)]
        HRESULT get_listStyleImage([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(141)]
        HRESULT put_listStyle([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(142)]
        HRESULT get_listStyle([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(143)]
        HRESULT put_whiteSpace([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(144)]
        HRESULT get_whiteSpace([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(145)]
        HRESULT put_top(VARIANT v);
        [VtblIndex(146)]
        HRESULT get_top(VARIANT* p);
        [VtblIndex(147)]
        HRESULT put_left(VARIANT v);
        [VtblIndex(148)]
        HRESULT get_left(VARIANT* p);
        [VtblIndex(149)]
        HRESULT get_position([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(150)]
        HRESULT put_zIndex(VARIANT v);
        [VtblIndex(151)]
        HRESULT get_zIndex(VARIANT* p);
        [VtblIndex(152)]
        HRESULT put_overflow([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(153)]
        HRESULT get_overflow([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(154)]
        HRESULT put_pageBreakBefore([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(155)]
        HRESULT get_pageBreakBefore([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(156)]
        HRESULT put_pageBreakAfter([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(157)]
        HRESULT get_pageBreakAfter([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(158)]
        HRESULT put_cssText([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(159)]
        HRESULT get_cssText([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(160)]
        HRESULT put_pixelTop([NativeTypeName("long")] int v);
        [VtblIndex(161)]
        HRESULT get_pixelTop([NativeTypeName("long *")] int* p);
        [VtblIndex(162)]
        HRESULT put_pixelLeft([NativeTypeName("long")] int v);
        [VtblIndex(163)]
        HRESULT get_pixelLeft([NativeTypeName("long *")] int* p);
        [VtblIndex(164)]
        HRESULT put_pixelWidth([NativeTypeName("long")] int v);
        [VtblIndex(165)]
        HRESULT get_pixelWidth([NativeTypeName("long *")] int* p);
        [VtblIndex(166)]
        HRESULT put_pixelHeight([NativeTypeName("long")] int v);
        [VtblIndex(167)]
        HRESULT get_pixelHeight([NativeTypeName("long *")] int* p);
        [VtblIndex(168)]
        HRESULT put_posTop(float v);
        [VtblIndex(169)]
        HRESULT get_posTop(float* p);
        [VtblIndex(170)]
        HRESULT put_posLeft(float v);
        [VtblIndex(171)]
        HRESULT get_posLeft(float* p);
        [VtblIndex(172)]
        HRESULT put_posWidth(float v);
        [VtblIndex(173)]
        HRESULT get_posWidth(float* p);
        [VtblIndex(174)]
        HRESULT put_posHeight(float v);
        [VtblIndex(175)]
        HRESULT get_posHeight(float* p);
        [VtblIndex(176)]
        HRESULT put_cursor([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(177)]
        HRESULT get_cursor([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(178)]
        HRESULT put_clip([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(179)]
        HRESULT get_clip([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(180)]
        HRESULT put_filter([NativeTypeName("BSTR")] ushort* v);
        [VtblIndex(181)]
        HRESULT get_filter([NativeTypeName("BSTR *")] ushort** p);
        [VtblIndex(182)]
        HRESULT setAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, VARIANT AttributeValue, [NativeTypeName("LONG")] int lFlags = 1);
        [VtblIndex(183)]
        HRESULT getAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, VARIANT* AttributeValue);
        [VtblIndex(184)]
        HRESULT removeAttribute([NativeTypeName("BSTR")] ushort* strAttributeName, [NativeTypeName("LONG")] int lFlags, [NativeTypeName("VARIANT_BOOL *")] short* pfSuccess);
        [VtblIndex(185)]
        HRESULT toString([NativeTypeName("BSTR *")] ushort** String);
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
        public delegate* unmanaged<TSelf*, ushort*, int> put_fontFamily;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fontFamily;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_fontStyle;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fontStyle;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_fontVariant;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fontVariant;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_fontWeight;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fontWeight;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_fontSize;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_fontSize;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_font;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_font;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_color;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_color;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_background;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_background;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_backgroundColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_backgroundColor;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_backgroundImage;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_backgroundImage;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_backgroundRepeat;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_backgroundRepeat;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_backgroundAttachment;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_backgroundAttachment;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_backgroundPosition;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_backgroundPosition;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_backgroundPositionX;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_backgroundPositionX;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_backgroundPositionY;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_backgroundPositionY;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_wordSpacing;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_wordSpacing;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_letterSpacing;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_letterSpacing;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textDecoration;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textDecoration;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_textDecorationNone;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_textDecorationNone;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_textDecorationUnderline;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_textDecorationUnderline;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_textDecorationOverline;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_textDecorationOverline;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_textDecorationLineThrough;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_textDecorationLineThrough;
        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_textDecorationBlink;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_textDecorationBlink;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_verticalAlign;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_verticalAlign;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textTransform;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textTransform;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textAlign;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textAlign;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_textIndent;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_textIndent;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_lineHeight;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_lineHeight;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_marginTop;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_marginTop;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_marginRight;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_marginRight;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_marginBottom;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_marginBottom;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_marginLeft;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_marginLeft;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_margin;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_margin;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_paddingTop;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_paddingTop;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_paddingRight;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_paddingRight;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_paddingBottom;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_paddingBottom;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_paddingLeft;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_paddingLeft;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_padding;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_padding;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_border;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_border;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderTop;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderTop;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderRight;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderRight;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderBottom;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderBottom;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderLeft;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderLeft;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderColor;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderColor;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderTopColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderTopColor;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderRightColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderRightColor;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderBottomColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderBottomColor;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderLeftColor;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderLeftColor;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderWidth;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderWidth;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderTopWidth;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderTopWidth;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderRightWidth;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderRightWidth;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderBottomWidth;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderBottomWidth;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_borderLeftWidth;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_borderLeftWidth;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderStyle;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderStyle;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderTopStyle;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderTopStyle;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderRightStyle;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderRightStyle;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderBottomStyle;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderBottomStyle;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_borderLeftStyle;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_borderLeftStyle;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_width;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_width;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_height;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_height;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_styleFloat;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_styleFloat;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_clear;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_clear;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_display;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_display;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_visibility;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_visibility;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_listStyleType;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_listStyleType;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_listStylePosition;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_listStylePosition;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_listStyleImage;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_listStyleImage;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_listStyle;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_listStyle;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_whiteSpace;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_whiteSpace;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_top;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_top;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_left;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_left;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_position;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_zIndex;
        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_zIndex;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_overflow;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_overflow;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_pageBreakBefore;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_pageBreakBefore;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_pageBreakAfter;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_pageBreakAfter;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_cssText;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_cssText;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_pixelTop;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_pixelTop;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_pixelLeft;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_pixelLeft;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_pixelWidth;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_pixelWidth;
        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_pixelHeight;
        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_pixelHeight;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_posTop;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_posTop;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_posLeft;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_posLeft;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_posWidth;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_posWidth;
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_posHeight;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_posHeight;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_cursor;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_cursor;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_clip;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_clip;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_filter;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_filter;
        [NativeTypeName("HRESULT (BSTR, VARIANT, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, int, int> setAttribute;
        [NativeTypeName("HRESULT (BSTR, LONG, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, VARIANT*, int> getAttribute;
        [NativeTypeName("HRESULT (BSTR, LONG, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, short*, int> removeAttribute;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> toString;
    }
}