// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IVisualProperties.xml' path='doc/member[@name="IVisualProperties"]/*'/>
[Guid("E693CF68-D967-4112-8763-99172AEE5E5A")]
[NativeTypeName("struct IVisualProperties : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVisualProperties : IVisualProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVisualProperties));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVisualProperties*, Guid*, void**, int> )(lpVtbl[0]))((IVisualProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVisualProperties*, uint> )(lpVtbl[1]))((IVisualProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVisualProperties*, uint> )(lpVtbl[2]))((IVisualProperties*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVisualProperties.xml' path='doc/member[@name="IVisualProperties.SetWatermark"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetWatermark(HBITMAP hbmp, VPWATERMARKFLAGS vpwf)
    {
        return ((delegate* unmanaged<IVisualProperties*, HBITMAP, VPWATERMARKFLAGS, int> )(lpVtbl[3]))((IVisualProperties*)Unsafe.AsPointer(ref this), hbmp, vpwf);
    }

    /// <include file='IVisualProperties.xml' path='doc/member[@name="IVisualProperties.SetColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetColor(VPCOLORFLAGS vpcf, COLORREF cr)
    {
        return ((delegate* unmanaged<IVisualProperties*, VPCOLORFLAGS, COLORREF, int> )(lpVtbl[4]))((IVisualProperties*)Unsafe.AsPointer(ref this), vpcf, cr);
    }

    /// <include file='IVisualProperties.xml' path='doc/member[@name="IVisualProperties.GetColor"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetColor(VPCOLORFLAGS vpcf, COLORREF* pcr)
    {
        return ((delegate* unmanaged<IVisualProperties*, VPCOLORFLAGS, COLORREF*, int> )(lpVtbl[5]))((IVisualProperties*)Unsafe.AsPointer(ref this), vpcf, pcr);
    }

    /// <include file='IVisualProperties.xml' path='doc/member[@name="IVisualProperties.SetItemHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetItemHeight(int cyItemInPixels)
    {
        return ((delegate* unmanaged<IVisualProperties*, int, int> )(lpVtbl[6]))((IVisualProperties*)Unsafe.AsPointer(ref this), cyItemInPixels);
    }

    /// <include file='IVisualProperties.xml' path='doc/member[@name="IVisualProperties.GetItemHeight"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetItemHeight(int* cyItemInPixels)
    {
        return ((delegate* unmanaged<IVisualProperties*, int*, int> )(lpVtbl[7]))((IVisualProperties*)Unsafe.AsPointer(ref this), cyItemInPixels);
    }

    /// <include file='IVisualProperties.xml' path='doc/member[@name="IVisualProperties.SetFont"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetFont([NativeTypeName("const LOGFONTW *")] LOGFONTW* plf, BOOL bRedraw)
    {
        return ((delegate* unmanaged<IVisualProperties*, LOGFONTW*, BOOL, int> )(lpVtbl[8]))((IVisualProperties*)Unsafe.AsPointer(ref this), plf, bRedraw);
    }

    /// <include file='IVisualProperties.xml' path='doc/member[@name="IVisualProperties.GetFont"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetFont(LOGFONTW* plf)
    {
        return ((delegate* unmanaged<IVisualProperties*, LOGFONTW*, int> )(lpVtbl[9]))((IVisualProperties*)Unsafe.AsPointer(ref this), plf);
    }

    /// <include file='IVisualProperties.xml' path='doc/member[@name="IVisualProperties.SetTheme"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetTheme([NativeTypeName("LPCWSTR")] ushort* pszSubAppName, [NativeTypeName("LPCWSTR")] ushort* pszSubIdList)
    {
        return ((delegate* unmanaged<IVisualProperties*, ushort*, ushort*, int> )(lpVtbl[10]))((IVisualProperties*)Unsafe.AsPointer(ref this), pszSubAppName, pszSubIdList);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetWatermark(HBITMAP hbmp, VPWATERMARKFLAGS vpwf);
        [VtblIndex(4)]
        HRESULT SetColor(VPCOLORFLAGS vpcf, COLORREF cr);
        [VtblIndex(5)]
        HRESULT GetColor(VPCOLORFLAGS vpcf, COLORREF* pcr);
        [VtblIndex(6)]
        HRESULT SetItemHeight(int cyItemInPixels);
        [VtblIndex(7)]
        HRESULT GetItemHeight(int* cyItemInPixels);
        [VtblIndex(8)]
        HRESULT SetFont([NativeTypeName("const LOGFONTW *")] LOGFONTW* plf, BOOL bRedraw);
        [VtblIndex(9)]
        HRESULT GetFont(LOGFONTW* plf);
        [VtblIndex(10)]
        HRESULT SetTheme([NativeTypeName("LPCWSTR")] ushort* pszSubAppName, [NativeTypeName("LPCWSTR")] ushort* pszSubIdList);
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
        [NativeTypeName("HRESULT (HBITMAP, VPWATERMARKFLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HBITMAP, VPWATERMARKFLAGS, int> SetWatermark;
        [NativeTypeName("HRESULT (VPCOLORFLAGS, COLORREF) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VPCOLORFLAGS, COLORREF, int> SetColor;
        [NativeTypeName("HRESULT (VPCOLORFLAGS, COLORREF *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VPCOLORFLAGS, COLORREF*, int> GetColor;
        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetItemHeight;
        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetItemHeight;
        [NativeTypeName("HRESULT (const LOGFONTW *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LOGFONTW*, BOOL, int> SetFont;
        [NativeTypeName("HRESULT (LOGFONTW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LOGFONTW*, int> GetFont;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> SetTheme;
    }
}