// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IHTMLPaintSite.xml' path='doc/member[@name="IHTMLPaintSite"]/*'/>
[Guid("3050F6A7-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLPaintSite : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHTMLPaintSite : IHTMLPaintSite.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLPaintSite));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLPaintSite*, Guid*, void**, int> )(lpVtbl[0]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLPaintSite*, uint> )(lpVtbl[1]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLPaintSite*, uint> )(lpVtbl[2]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLPaintSite.xml' path='doc/member[@name="IHTMLPaintSite.InvalidatePainterInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InvalidatePainterInfo()
    {
        return ((delegate* unmanaged<IHTMLPaintSite*, int> )(lpVtbl[3]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHTMLPaintSite.xml' path='doc/member[@name="IHTMLPaintSite.InvalidateRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InvalidateRect(RECT* prcInvalid)
    {
        return ((delegate* unmanaged<IHTMLPaintSite*, RECT*, int> )(lpVtbl[4]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this), prcInvalid);
    }

    /// <include file='IHTMLPaintSite.xml' path='doc/member[@name="IHTMLPaintSite.InvalidateRegion"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InvalidateRegion(HRGN rgnInvalid)
    {
        return ((delegate* unmanaged<IHTMLPaintSite*, HRGN, int> )(lpVtbl[5]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this), rgnInvalid);
    }

    /// <include file='IHTMLPaintSite.xml' path='doc/member[@name="IHTMLPaintSite.GetDrawInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDrawInfo([NativeTypeName("LONG")] int lFlags, HTML_PAINT_DRAW_INFO* pDrawInfo)
    {
        return ((delegate* unmanaged<IHTMLPaintSite*, int, HTML_PAINT_DRAW_INFO*, int> )(lpVtbl[6]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this), lFlags, pDrawInfo);
    }

    /// <include file='IHTMLPaintSite.xml' path='doc/member[@name="IHTMLPaintSite.TransformGlobalToLocal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TransformGlobalToLocal(POINT ptGlobal, POINT* pptLocal)
    {
        return ((delegate* unmanaged<IHTMLPaintSite*, POINT, POINT*, int> )(lpVtbl[7]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this), ptGlobal, pptLocal);
    }

    /// <include file='IHTMLPaintSite.xml' path='doc/member[@name="IHTMLPaintSite.TransformLocalToGlobal"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TransformLocalToGlobal(POINT ptLocal, POINT* pptGlobal)
    {
        return ((delegate* unmanaged<IHTMLPaintSite*, POINT, POINT*, int> )(lpVtbl[8]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this), ptLocal, pptGlobal);
    }

    /// <include file='IHTMLPaintSite.xml' path='doc/member[@name="IHTMLPaintSite.GetHitTestCookie"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetHitTestCookie([NativeTypeName("LONG *")] int* plCookie)
    {
        return ((delegate* unmanaged<IHTMLPaintSite*, int*, int> )(lpVtbl[9]))((IHTMLPaintSite*)Unsafe.AsPointer(ref this), plCookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InvalidatePainterInfo();
        [VtblIndex(4)]
        HRESULT InvalidateRect(RECT* prcInvalid);
        [VtblIndex(5)]
        HRESULT InvalidateRegion(HRGN rgnInvalid);
        [VtblIndex(6)]
        HRESULT GetDrawInfo([NativeTypeName("LONG")] int lFlags, HTML_PAINT_DRAW_INFO* pDrawInfo);
        [VtblIndex(7)]
        HRESULT TransformGlobalToLocal(POINT ptGlobal, POINT* pptLocal);
        [VtblIndex(8)]
        HRESULT TransformLocalToGlobal(POINT ptLocal, POINT* pptGlobal);
        [VtblIndex(9)]
        HRESULT GetHitTestCookie([NativeTypeName("LONG *")] int* plCookie);
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> InvalidatePainterInfo;
        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> InvalidateRect;
        [NativeTypeName("HRESULT (HRGN) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRGN, int> InvalidateRegion;
        [NativeTypeName("HRESULT (LONG, HTML_PAINT_DRAW_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, HTML_PAINT_DRAW_INFO*, int> GetDrawInfo;
        [NativeTypeName("HRESULT (POINT, POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, POINT*, int> TransformGlobalToLocal;
        [NativeTypeName("HRESULT (POINT, POINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, POINT*, int> TransformLocalToGlobal;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetHitTestCookie;
    }
}