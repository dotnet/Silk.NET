// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement"]/*' />
[Guid("305104E7-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct ISVGSVGElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISVGSVGElement : ISVGSVGElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISVGSVGElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, Guid*, void**, int>)(lpVtbl[0]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISVGSVGElement*, uint>)(lpVtbl[1]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISVGSVGElement*, uint>)(lpVtbl[2]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, uint*, int>)(lpVtbl[3]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.putref_x"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT putref_x(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength*, int>)(lpVtbl[7]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_x"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_x(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength**, int>)(lpVtbl[8]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.putref_y"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT putref_y(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength*, int>)(lpVtbl[9]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_y"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_y(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength**, int>)(lpVtbl[10]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.putref_width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT putref_width(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength*, int>)(lpVtbl[11]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_width"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_width(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength**, int>)(lpVtbl[12]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.putref_height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT putref_height(ISVGAnimatedLength* v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength*, int>)(lpVtbl[13]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_height"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_height(ISVGAnimatedLength** p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGAnimatedLength**, int>)(lpVtbl[14]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.put_contentScriptType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_contentScriptType([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ushort*, int>)(lpVtbl[15]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_contentScriptType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_contentScriptType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ushort**, int>)(lpVtbl[16]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.put_contentStyleType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_contentStyleType([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ushort*, int>)(lpVtbl[17]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_contentStyleType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_contentStyleType([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ushort**, int>)(lpVtbl[18]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.putref_viewport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT putref_viewport(ISVGRect* v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect*, int>)(lpVtbl[19]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_viewport"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_viewport(ISVGRect** p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect**, int>)(lpVtbl[20]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.put_pixelUnitToMillimeterX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_pixelUnitToMillimeterX(float v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[21]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_pixelUnitToMillimeterX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_pixelUnitToMillimeterX(float* p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[22]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.put_pixelUnitToMillimeterY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_pixelUnitToMillimeterY(float v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[23]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_pixelUnitToMillimeterY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_pixelUnitToMillimeterY(float* p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[24]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.put_screenPixelToMillimeterX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_screenPixelToMillimeterX(float v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[25]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_screenPixelToMillimeterX"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_screenPixelToMillimeterX(float* p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[26]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.put_screenPixelToMillimeterY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_screenPixelToMillimeterY(float v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[27]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_screenPixelToMillimeterY"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_screenPixelToMillimeterY(float* p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[28]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.put_useCurrentView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_useCurrentView([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, short, int>)(lpVtbl[29]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_useCurrentView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_useCurrentView([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, short*, int>)(lpVtbl[30]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.putref_currentView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT putref_currentView(ISVGViewSpec* v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGViewSpec*, int>)(lpVtbl[31]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_currentView"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_currentView(ISVGViewSpec** p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGViewSpec**, int>)(lpVtbl[32]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.put_currentScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_currentScale(float v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[33]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_currentScale"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_currentScale(float* p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[34]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.putref_currentTranslate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT putref_currentTranslate(ISVGPoint* v)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGPoint*, int>)(lpVtbl[35]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.get_currentTranslate"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT get_currentTranslate(ISVGPoint** p)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGPoint**, int>)(lpVtbl[36]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.suspendRedraw"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT suspendRedraw([NativeTypeName("ULONG")] uint maxWaitMilliseconds, [NativeTypeName("ULONG *")] uint* pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, uint, uint*, int>)(lpVtbl[37]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), maxWaitMilliseconds, pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.unsuspendRedraw"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT unsuspendRedraw([NativeTypeName("ULONG")] uint suspendHandeID)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, uint, int>)(lpVtbl[38]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), suspendHandeID);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.unsuspendRedrawAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT unsuspendRedrawAll()
    {
        return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[39]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.forceRedraw"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT forceRedraw()
    {
        return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[40]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.pauseAnimations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT pauseAnimations()
    {
        return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[41]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.unpauseAnimations"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT unpauseAnimations()
    {
        return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[42]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.animationsPaused"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT animationsPaused([NativeTypeName("VARIANT_BOOL *")] short* pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, short*, int>)(lpVtbl[43]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.getCurrentTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT getCurrentTime(float* pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, float*, int>)(lpVtbl[44]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.setCurrentTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT setCurrentTime(float seconds)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, float, int>)(lpVtbl[45]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), seconds);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.getIntersectionList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT getIntersectionList(ISVGRect* rect, ISVGElement* referenceElement, VARIANT* pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect*, ISVGElement*, VARIANT*, int>)(lpVtbl[46]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), rect, referenceElement, pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.getEnclosureList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT getEnclosureList(ISVGRect* rect, ISVGElement* referenceElement, VARIANT* pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect*, ISVGElement*, VARIANT*, int>)(lpVtbl[47]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), rect, referenceElement, pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.checkIntersection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT checkIntersection(ISVGElement* element, ISVGRect* rect, [NativeTypeName("VARIANT_BOOL *")] short* pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGElement*, ISVGRect*, short*, int>)(lpVtbl[48]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), element, rect, pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.checkEnclosure"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT checkEnclosure(ISVGElement* element, ISVGRect* rect, [NativeTypeName("VARIANT_BOOL *")] short* pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGElement*, ISVGRect*, short*, int>)(lpVtbl[49]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), element, rect, pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.deselectAll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT deselectAll()
    {
        return ((delegate* unmanaged<ISVGSVGElement*, int>)(lpVtbl[50]))((ISVGSVGElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.createSVGNumber"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT createSVGNumber(ISVGNumber** pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGNumber**, int>)(lpVtbl[51]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.createSVGLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT createSVGLength(ISVGLength** pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGLength**, int>)(lpVtbl[52]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.createSVGAngle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT createSVGAngle(ISVGAngle** pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGAngle**, int>)(lpVtbl[53]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.createSVGPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT createSVGPoint(ISVGPoint** pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGPoint**, int>)(lpVtbl[54]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.createSVGMatrix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT createSVGMatrix(ISVGMatrix** pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGMatrix**, int>)(lpVtbl[55]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.createSVGRect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT createSVGRect(ISVGRect** pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGRect**, int>)(lpVtbl[56]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.createSVGTransform"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT createSVGTransform(ISVGTransform** pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGTransform**, int>)(lpVtbl[57]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.createSVGTransformFromMatrix"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT createSVGTransformFromMatrix(ISVGMatrix* matrix, ISVGTransform** pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ISVGMatrix*, ISVGTransform**, int>)(lpVtbl[58]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), matrix, pResult);
    }

    /// <include file='ISVGSVGElement.xml' path='doc/member[@name="ISVGSVGElement.getElementById"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT getElementById([NativeTypeName("BSTR")] ushort* elementId, IHTMLElement** pResult)
    {
        return ((delegate* unmanaged<ISVGSVGElement*, ushort*, IHTMLElement**, int>)(lpVtbl[59]))((ISVGSVGElement*)Unsafe.AsPointer(ref this), elementId, pResult);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT putref_x(ISVGAnimatedLength* v);

        [VtblIndex(8)]
        HRESULT get_x(ISVGAnimatedLength** p);

        [VtblIndex(9)]
        HRESULT putref_y(ISVGAnimatedLength* v);

        [VtblIndex(10)]
        HRESULT get_y(ISVGAnimatedLength** p);

        [VtblIndex(11)]
        HRESULT putref_width(ISVGAnimatedLength* v);

        [VtblIndex(12)]
        HRESULT get_width(ISVGAnimatedLength** p);

        [VtblIndex(13)]
        HRESULT putref_height(ISVGAnimatedLength* v);

        [VtblIndex(14)]
        HRESULT get_height(ISVGAnimatedLength** p);

        [VtblIndex(15)]
        HRESULT put_contentScriptType([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(16)]
        HRESULT get_contentScriptType([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(17)]
        HRESULT put_contentStyleType([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(18)]
        HRESULT get_contentStyleType([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(19)]
        HRESULT putref_viewport(ISVGRect* v);

        [VtblIndex(20)]
        HRESULT get_viewport(ISVGRect** p);

        [VtblIndex(21)]
        HRESULT put_pixelUnitToMillimeterX(float v);

        [VtblIndex(22)]
        HRESULT get_pixelUnitToMillimeterX(float* p);

        [VtblIndex(23)]
        HRESULT put_pixelUnitToMillimeterY(float v);

        [VtblIndex(24)]
        HRESULT get_pixelUnitToMillimeterY(float* p);

        [VtblIndex(25)]
        HRESULT put_screenPixelToMillimeterX(float v);

        [VtblIndex(26)]
        HRESULT get_screenPixelToMillimeterX(float* p);

        [VtblIndex(27)]
        HRESULT put_screenPixelToMillimeterY(float v);

        [VtblIndex(28)]
        HRESULT get_screenPixelToMillimeterY(float* p);

        [VtblIndex(29)]
        HRESULT put_useCurrentView([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(30)]
        HRESULT get_useCurrentView([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(31)]
        HRESULT putref_currentView(ISVGViewSpec* v);

        [VtblIndex(32)]
        HRESULT get_currentView(ISVGViewSpec** p);

        [VtblIndex(33)]
        HRESULT put_currentScale(float v);

        [VtblIndex(34)]
        HRESULT get_currentScale(float* p);

        [VtblIndex(35)]
        HRESULT putref_currentTranslate(ISVGPoint* v);

        [VtblIndex(36)]
        HRESULT get_currentTranslate(ISVGPoint** p);

        [VtblIndex(37)]
        HRESULT suspendRedraw([NativeTypeName("ULONG")] uint maxWaitMilliseconds, [NativeTypeName("ULONG *")] uint* pResult);

        [VtblIndex(38)]
        HRESULT unsuspendRedraw([NativeTypeName("ULONG")] uint suspendHandeID);

        [VtblIndex(39)]
        HRESULT unsuspendRedrawAll();

        [VtblIndex(40)]
        HRESULT forceRedraw();

        [VtblIndex(41)]
        HRESULT pauseAnimations();

        [VtblIndex(42)]
        HRESULT unpauseAnimations();

        [VtblIndex(43)]
        HRESULT animationsPaused([NativeTypeName("VARIANT_BOOL *")] short* pResult);

        [VtblIndex(44)]
        HRESULT getCurrentTime(float* pResult);

        [VtblIndex(45)]
        HRESULT setCurrentTime(float seconds);

        [VtblIndex(46)]
        HRESULT getIntersectionList(ISVGRect* rect, ISVGElement* referenceElement, VARIANT* pResult);

        [VtblIndex(47)]
        HRESULT getEnclosureList(ISVGRect* rect, ISVGElement* referenceElement, VARIANT* pResult);

        [VtblIndex(48)]
        HRESULT checkIntersection(ISVGElement* element, ISVGRect* rect, [NativeTypeName("VARIANT_BOOL *")] short* pResult);

        [VtblIndex(49)]
        HRESULT checkEnclosure(ISVGElement* element, ISVGRect* rect, [NativeTypeName("VARIANT_BOOL *")] short* pResult);

        [VtblIndex(50)]
        HRESULT deselectAll();

        [VtblIndex(51)]
        HRESULT createSVGNumber(ISVGNumber** pResult);

        [VtblIndex(52)]
        HRESULT createSVGLength(ISVGLength** pResult);

        [VtblIndex(53)]
        HRESULT createSVGAngle(ISVGAngle** pResult);

        [VtblIndex(54)]
        HRESULT createSVGPoint(ISVGPoint** pResult);

        [VtblIndex(55)]
        HRESULT createSVGMatrix(ISVGMatrix** pResult);

        [VtblIndex(56)]
        HRESULT createSVGRect(ISVGRect** pResult);

        [VtblIndex(57)]
        HRESULT createSVGTransform(ISVGTransform** pResult);

        [VtblIndex(58)]
        HRESULT createSVGTransformFromMatrix(ISVGMatrix* matrix, ISVGTransform** pResult);

        [VtblIndex(59)]
        HRESULT getElementById([NativeTypeName("BSTR")] ushort* elementId, IHTMLElement** pResult);
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

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_x;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_x;

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_y;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_y;

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_width;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_width;

        [NativeTypeName("HRESULT (ISVGAnimatedLength *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength*, int> putref_height;

        [NativeTypeName("HRESULT (ISVGAnimatedLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAnimatedLength**, int> get_height;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_contentScriptType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_contentScriptType;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_contentStyleType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_contentStyleType;

        [NativeTypeName("HRESULT (ISVGRect *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGRect*, int> putref_viewport;

        [NativeTypeName("HRESULT (ISVGRect **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGRect**, int> get_viewport;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_pixelUnitToMillimeterX;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_pixelUnitToMillimeterX;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_pixelUnitToMillimeterY;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_pixelUnitToMillimeterY;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_screenPixelToMillimeterX;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_screenPixelToMillimeterX;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_screenPixelToMillimeterY;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_screenPixelToMillimeterY;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_useCurrentView;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_useCurrentView;

        [NativeTypeName("HRESULT (ISVGViewSpec *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGViewSpec*, int> putref_currentView;

        [NativeTypeName("HRESULT (ISVGViewSpec **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGViewSpec**, int> get_currentView;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_currentScale;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_currentScale;

        [NativeTypeName("HRESULT (ISVGPoint *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGPoint*, int> putref_currentTranslate;

        [NativeTypeName("HRESULT (ISVGPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGPoint**, int> get_currentTranslate;

        [NativeTypeName("HRESULT (ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> suspendRedraw;

        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> unsuspendRedraw;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> unsuspendRedrawAll;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> forceRedraw;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> pauseAnimations;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> unpauseAnimations;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> animationsPaused;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> getCurrentTime;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> setCurrentTime;

        [NativeTypeName("HRESULT (ISVGRect *, ISVGElement *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGRect*, ISVGElement*, VARIANT*, int> getIntersectionList;

        [NativeTypeName("HRESULT (ISVGRect *, ISVGElement *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGRect*, ISVGElement*, VARIANT*, int> getEnclosureList;

        [NativeTypeName("HRESULT (ISVGElement *, ISVGRect *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElement*, ISVGRect*, short*, int> checkIntersection;

        [NativeTypeName("HRESULT (ISVGElement *, ISVGRect *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGElement*, ISVGRect*, short*, int> checkEnclosure;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> deselectAll;

        [NativeTypeName("HRESULT (ISVGNumber **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGNumber**, int> createSVGNumber;

        [NativeTypeName("HRESULT (ISVGLength **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGLength**, int> createSVGLength;

        [NativeTypeName("HRESULT (ISVGAngle **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGAngle**, int> createSVGAngle;

        [NativeTypeName("HRESULT (ISVGPoint **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGPoint**, int> createSVGPoint;

        [NativeTypeName("HRESULT (ISVGMatrix **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGMatrix**, int> createSVGMatrix;

        [NativeTypeName("HRESULT (ISVGRect **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGRect**, int> createSVGRect;

        [NativeTypeName("HRESULT (ISVGTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGTransform**, int> createSVGTransform;

        [NativeTypeName("HRESULT (ISVGMatrix *, ISVGTransform **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISVGMatrix*, ISVGTransform**, int> createSVGTransformFromMatrix;

        [NativeTypeName("HRESULT (BSTR, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLElement**, int> getElementById;
    }
}
