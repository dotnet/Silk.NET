// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D"]/*' />
[Guid("305106FF-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ICanvasRenderingContext2D : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ICanvasRenderingContext2D : ICanvasRenderingContext2D.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICanvasRenderingContext2D));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, Guid*, void**, int>)(lpVtbl[0]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, uint>)(lpVtbl[1]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, uint>)(lpVtbl[2]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, uint*, int>)(lpVtbl[3]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_canvas"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_canvas(IHTMLCanvasElement** p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, IHTMLCanvasElement**, int>)(lpVtbl[7]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.restore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT restore()
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[8]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.save"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT save()
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[9]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.rotate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT rotate(float angle)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[10]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), angle);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.scale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT scale(float x, float y)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, int>)(lpVtbl[11]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.setTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT setTransform(float m11, float m12, float m21, float m22, float dx, float dy)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, float, int>)(lpVtbl[12]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), m11, m12, m21, m22, dx, dy);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.transform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT transform(float m11, float m12, float m21, float m22, float dx, float dy)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, float, int>)(lpVtbl[13]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), m11, m12, m21, m22, dx, dy);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.translate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT translate(float x, float y)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, int>)(lpVtbl[14]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_globalAlpha"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_globalAlpha(float v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[15]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_globalAlpha"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_globalAlpha(float* p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[16]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_globalCompositeOperation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_globalCompositeOperation([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[17]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_globalCompositeOperation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_globalCompositeOperation([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[18]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_fillStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_fillStyle(VARIANT v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT, int>)(lpVtbl[19]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_fillStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_fillStyle(VARIANT* p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT*, int>)(lpVtbl[20]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_strokeStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_strokeStyle(VARIANT v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT, int>)(lpVtbl[21]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_strokeStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_strokeStyle(VARIANT* p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT*, int>)(lpVtbl[22]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.createLinearGradient"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT createLinearGradient(float x0, float y0, float x1, float y1, ICanvasGradient** ppCanvasGradient)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, ICanvasGradient**, int>)(lpVtbl[23]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x0, y0, x1, y1, ppCanvasGradient);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.createRadialGradient"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT createRadialGradient(float x0, float y0, float r0, float x1, float y1, float r1, ICanvasGradient** ppCanvasGradient)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, float, ICanvasGradient**, int>)(lpVtbl[24]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x0, y0, r0, x1, y1, r1, ppCanvasGradient);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.createPattern"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT createPattern(IDispatch* image, VARIANT repetition, ICanvasPattern** ppCanvasPattern)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, IDispatch*, VARIANT, ICanvasPattern**, int>)(lpVtbl[25]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), image, repetition, ppCanvasPattern);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_lineCap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT put_lineCap([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[26]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_lineCap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_lineCap([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[27]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_lineJoin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_lineJoin([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[28]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_lineJoin"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_lineJoin([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[29]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_lineWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_lineWidth(float v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[30]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_lineWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_lineWidth(float* p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[31]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_miterLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_miterLimit(float v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[32]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_miterLimit"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_miterLimit(float* p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[33]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_shadowBlur"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_shadowBlur(float v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[34]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_shadowBlur"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_shadowBlur(float* p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[35]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_shadowColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_shadowColor([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[36]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_shadowColor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_shadowColor([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[37]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_shadowOffsetX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_shadowOffsetX(float v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[38]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_shadowOffsetX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_shadowOffsetX(float* p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[39]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_shadowOffsetY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT put_shadowOffsetY(float v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, int>)(lpVtbl[40]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_shadowOffsetY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_shadowOffsetY(float* p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float*, int>)(lpVtbl[41]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.clearRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT clearRect(float x, float y, float w, float h)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[42]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, w, h);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.fillRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT fillRect(float x, float y, float w, float h)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[43]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, w, h);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.strokeRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT strokeRect(float x, float y, float w, float h)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[44]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, w, h);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.arc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT arc(float x, float y, float radius, float startAngle, float endAngle, BOOL anticlockwise)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, BOOL, int>)(lpVtbl[45]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, radius, startAngle, endAngle, anticlockwise);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.arcTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT arcTo(float x1, float y1, float x2, float y2, float radius)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, int>)(lpVtbl[46]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x1, y1, x2, y2, radius);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.beginPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT beginPath()
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[47]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.bezierCurveTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT bezierCurveTo(float cp1x, float cp1y, float cp2x, float cp2y, float x, float y)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, float, float, int>)(lpVtbl[48]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), cp1x, cp1y, cp2x, cp2y, x, y);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.clip"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT clip()
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[49]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.closePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT closePath()
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[50]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.fill"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT fill()
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[51]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.lineTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT lineTo(float x, float y)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, int>)(lpVtbl[52]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.moveTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT moveTo(float x, float y)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, int>)(lpVtbl[53]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.quadraticCurveTo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT quadraticCurveTo(float cpx, float cpy, float x, float y)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[54]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), cpx, cpy, x, y);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.rect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT rect(float x, float y, float w, float h)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, int>)(lpVtbl[55]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, w, h);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.stroke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT stroke()
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, int>)(lpVtbl[56]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.isPointInPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT isPointInPath(float x, float y, [NativeTypeName("VARIANT_BOOL *")] short* pResult)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, short*, int>)(lpVtbl[57]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), x, y, pResult);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_font"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT put_font([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[58]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_font"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_font([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[59]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_textAlign"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT put_textAlign([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[60]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_textAlign"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT get_textAlign([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[61]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.put_textBaseline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT put_textBaseline([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, int>)(lpVtbl[62]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.get_textBaseline"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT get_textBaseline([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort**, int>)(lpVtbl[63]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.fillText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT fillText([NativeTypeName("BSTR")] ushort* text, float x, float y, VARIANT maxWidth)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, float, float, VARIANT, int>)(lpVtbl[64]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), text, x, y, maxWidth);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.measureText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT measureText([NativeTypeName("BSTR")] ushort* text, ICanvasTextMetrics** ppCanvasTextMetrics)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, ICanvasTextMetrics**, int>)(lpVtbl[65]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), text, ppCanvasTextMetrics);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.strokeText"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT strokeText([NativeTypeName("BSTR")] ushort* text, float x, float y, VARIANT maxWidth)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ushort*, float, float, VARIANT, int>)(lpVtbl[66]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), text, x, y, maxWidth);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.drawImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT drawImage(IDispatch* pSrc, VARIANT a1, VARIANT a2, VARIANT a3, VARIANT a4, VARIANT a5, VARIANT a6, VARIANT a7, VARIANT a8)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, IDispatch*, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[67]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), pSrc, a1, a2, a3, a4, a5, a6, a7, a8);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.createImageData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT createImageData(VARIANT a1, VARIANT a2, ICanvasImageData** ppCanvasImageData)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, VARIANT, VARIANT, ICanvasImageData**, int>)(lpVtbl[68]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), a1, a2, ppCanvasImageData);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.getImageData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT getImageData(float sx, float sy, float sw, float sh, ICanvasImageData** ppCanvasImageData)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, float, float, float, float, ICanvasImageData**, int>)(lpVtbl[69]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), sx, sy, sw, sh, ppCanvasImageData);
    }

    /// <include file='ICanvasRenderingContext2D.xml' path='doc/member[@name="ICanvasRenderingContext2D.putImageData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT putImageData(ICanvasImageData* imagedata, float dx, float dy, VARIANT dirtyX, VARIANT dirtyY, VARIANT dirtyWidth, VARIANT dirtyHeight)
    {
        return ((delegate* unmanaged<ICanvasRenderingContext2D*, ICanvasImageData*, float, float, VARIANT, VARIANT, VARIANT, VARIANT, int>)(lpVtbl[70]))((ICanvasRenderingContext2D*)Unsafe.AsPointer(ref this), imagedata, dx, dy, dirtyX, dirtyY, dirtyWidth, dirtyHeight);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_canvas(IHTMLCanvasElement** p);

        [VtblIndex(8)]
        HRESULT restore();

        [VtblIndex(9)]
        HRESULT save();

        [VtblIndex(10)]
        HRESULT rotate(float angle);

        [VtblIndex(11)]
        HRESULT scale(float x, float y);

        [VtblIndex(12)]
        HRESULT setTransform(float m11, float m12, float m21, float m22, float dx, float dy);

        [VtblIndex(13)]
        HRESULT transform(float m11, float m12, float m21, float m22, float dx, float dy);

        [VtblIndex(14)]
        HRESULT translate(float x, float y);

        [VtblIndex(15)]
        HRESULT put_globalAlpha(float v);

        [VtblIndex(16)]
        HRESULT get_globalAlpha(float* p);

        [VtblIndex(17)]
        HRESULT put_globalCompositeOperation([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(18)]
        HRESULT get_globalCompositeOperation([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(19)]
        HRESULT put_fillStyle(VARIANT v);

        [VtblIndex(20)]
        HRESULT get_fillStyle(VARIANT* p);

        [VtblIndex(21)]
        HRESULT put_strokeStyle(VARIANT v);

        [VtblIndex(22)]
        HRESULT get_strokeStyle(VARIANT* p);

        [VtblIndex(23)]
        HRESULT createLinearGradient(float x0, float y0, float x1, float y1, ICanvasGradient** ppCanvasGradient);

        [VtblIndex(24)]
        HRESULT createRadialGradient(float x0, float y0, float r0, float x1, float y1, float r1, ICanvasGradient** ppCanvasGradient);

        [VtblIndex(25)]
        HRESULT createPattern(IDispatch* image, VARIANT repetition, ICanvasPattern** ppCanvasPattern);

        [VtblIndex(26)]
        HRESULT put_lineCap([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(27)]
        HRESULT get_lineCap([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(28)]
        HRESULT put_lineJoin([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(29)]
        HRESULT get_lineJoin([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(30)]
        HRESULT put_lineWidth(float v);

        [VtblIndex(31)]
        HRESULT get_lineWidth(float* p);

        [VtblIndex(32)]
        HRESULT put_miterLimit(float v);

        [VtblIndex(33)]
        HRESULT get_miterLimit(float* p);

        [VtblIndex(34)]
        HRESULT put_shadowBlur(float v);

        [VtblIndex(35)]
        HRESULT get_shadowBlur(float* p);

        [VtblIndex(36)]
        HRESULT put_shadowColor([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(37)]
        HRESULT get_shadowColor([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(38)]
        HRESULT put_shadowOffsetX(float v);

        [VtblIndex(39)]
        HRESULT get_shadowOffsetX(float* p);

        [VtblIndex(40)]
        HRESULT put_shadowOffsetY(float v);

        [VtblIndex(41)]
        HRESULT get_shadowOffsetY(float* p);

        [VtblIndex(42)]
        HRESULT clearRect(float x, float y, float w, float h);

        [VtblIndex(43)]
        HRESULT fillRect(float x, float y, float w, float h);

        [VtblIndex(44)]
        HRESULT strokeRect(float x, float y, float w, float h);

        [VtblIndex(45)]
        HRESULT arc(float x, float y, float radius, float startAngle, float endAngle, BOOL anticlockwise);

        [VtblIndex(46)]
        HRESULT arcTo(float x1, float y1, float x2, float y2, float radius);

        [VtblIndex(47)]
        HRESULT beginPath();

        [VtblIndex(48)]
        HRESULT bezierCurveTo(float cp1x, float cp1y, float cp2x, float cp2y, float x, float y);

        [VtblIndex(49)]
        HRESULT clip();

        [VtblIndex(50)]
        HRESULT closePath();

        [VtblIndex(51)]
        HRESULT fill();

        [VtblIndex(52)]
        HRESULT lineTo(float x, float y);

        [VtblIndex(53)]
        HRESULT moveTo(float x, float y);

        [VtblIndex(54)]
        HRESULT quadraticCurveTo(float cpx, float cpy, float x, float y);

        [VtblIndex(55)]
        HRESULT rect(float x, float y, float w, float h);

        [VtblIndex(56)]
        HRESULT stroke();

        [VtblIndex(57)]
        HRESULT isPointInPath(float x, float y, [NativeTypeName("VARIANT_BOOL *")] short* pResult);

        [VtblIndex(58)]
        HRESULT put_font([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(59)]
        HRESULT get_font([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(60)]
        HRESULT put_textAlign([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(61)]
        HRESULT get_textAlign([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(62)]
        HRESULT put_textBaseline([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(63)]
        HRESULT get_textBaseline([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(64)]
        HRESULT fillText([NativeTypeName("BSTR")] ushort* text, float x, float y, VARIANT maxWidth);

        [VtblIndex(65)]
        HRESULT measureText([NativeTypeName("BSTR")] ushort* text, ICanvasTextMetrics** ppCanvasTextMetrics);

        [VtblIndex(66)]
        HRESULT strokeText([NativeTypeName("BSTR")] ushort* text, float x, float y, VARIANT maxWidth);

        [VtblIndex(67)]
        HRESULT drawImage(IDispatch* pSrc, VARIANT a1, VARIANT a2, VARIANT a3, VARIANT a4, VARIANT a5, VARIANT a6, VARIANT a7, VARIANT a8);

        [VtblIndex(68)]
        HRESULT createImageData(VARIANT a1, VARIANT a2, ICanvasImageData** ppCanvasImageData);

        [VtblIndex(69)]
        HRESULT getImageData(float sx, float sy, float sw, float sh, ICanvasImageData** ppCanvasImageData);

        [VtblIndex(70)]
        HRESULT putImageData(ICanvasImageData* imagedata, float dx, float dy, VARIANT dirtyX, VARIANT dirtyY, VARIANT dirtyWidth, VARIANT dirtyHeight);
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

        [NativeTypeName("HRESULT (IHTMLCanvasElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLCanvasElement**, int> get_canvas;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> restore;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> save;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> rotate;

        [NativeTypeName("HRESULT (float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, int> scale;

        [NativeTypeName("HRESULT (float, float, float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, float, float, int> setTransform;

        [NativeTypeName("HRESULT (float, float, float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, float, float, int> transform;

        [NativeTypeName("HRESULT (float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, int> translate;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_globalAlpha;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_globalAlpha;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_globalCompositeOperation;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_globalCompositeOperation;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_fillStyle;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_fillStyle;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_strokeStyle;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_strokeStyle;

        [NativeTypeName("HRESULT (float, float, float, float, ICanvasGradient **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, ICanvasGradient**, int> createLinearGradient;

        [NativeTypeName("HRESULT (float, float, float, float, float, float, ICanvasGradient **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, float, float, ICanvasGradient**, int> createRadialGradient;

        [NativeTypeName("HRESULT (IDispatch *, VARIANT, ICanvasPattern **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, VARIANT, ICanvasPattern**, int> createPattern;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_lineCap;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_lineCap;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_lineJoin;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_lineJoin;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_lineWidth;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_lineWidth;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_miterLimit;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_miterLimit;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_shadowBlur;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_shadowBlur;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_shadowColor;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_shadowColor;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_shadowOffsetX;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_shadowOffsetX;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_shadowOffsetY;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_shadowOffsetY;

        [NativeTypeName("HRESULT (float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, int> clearRect;

        [NativeTypeName("HRESULT (float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, int> fillRect;

        [NativeTypeName("HRESULT (float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, int> strokeRect;

        [NativeTypeName("HRESULT (float, float, float, float, float, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, float, BOOL, int> arc;

        [NativeTypeName("HRESULT (float, float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, float, int> arcTo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> beginPath;

        [NativeTypeName("HRESULT (float, float, float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, float, float, int> bezierCurveTo;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> clip;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> closePath;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> fill;

        [NativeTypeName("HRESULT (float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, int> lineTo;

        [NativeTypeName("HRESULT (float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, int> moveTo;

        [NativeTypeName("HRESULT (float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, int> quadraticCurveTo;

        [NativeTypeName("HRESULT (float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, int> rect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> stroke;

        [NativeTypeName("HRESULT (float, float, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, short*, int> isPointInPath;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_font;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_font;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textAlign;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textAlign;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_textBaseline;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_textBaseline;

        [NativeTypeName("HRESULT (BSTR, float, float, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, float, float, VARIANT, int> fillText;

        [NativeTypeName("HRESULT (BSTR, ICanvasTextMetrics **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ICanvasTextMetrics**, int> measureText;

        [NativeTypeName("HRESULT (BSTR, float, float, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, float, float, VARIANT, int> strokeText;

        [NativeTypeName("HRESULT (IDispatch *, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, VARIANT, int> drawImage;

        [NativeTypeName("HRESULT (VARIANT, VARIANT, ICanvasImageData **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT, ICanvasImageData**, int> createImageData;

        [NativeTypeName("HRESULT (float, float, float, float, ICanvasImageData **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, ICanvasImageData**, int> getImageData;

        [NativeTypeName("HRESULT (ICanvasImageData *, float, float, VARIANT, VARIANT, VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ICanvasImageData*, float, float, VARIANT, VARIANT, VARIANT, VARIANT, int> putImageData;
    }
}
