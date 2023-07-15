// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IElementBehaviorSiteRender.xml' path='doc/member[@name="IElementBehaviorSiteRender"]/*'/>
[Guid("3050F4A7-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementBehaviorSiteRender : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementBehaviorSiteRender : IElementBehaviorSiteRender.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementBehaviorSiteRender));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteRender*, Guid*, void**, int> )(lpVtbl[0]))((IElementBehaviorSiteRender*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementBehaviorSiteRender*, uint> )(lpVtbl[1]))((IElementBehaviorSiteRender*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementBehaviorSiteRender*, uint> )(lpVtbl[2]))((IElementBehaviorSiteRender*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementBehaviorSiteRender.xml' path='doc/member[@name="IElementBehaviorSiteRender.Invalidate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invalidate(RECT* pRect)
    {
        return ((delegate* unmanaged<IElementBehaviorSiteRender*, RECT*, int> )(lpVtbl[3]))((IElementBehaviorSiteRender*)Unsafe.AsPointer(ref this), pRect);
    }

    /// <include file='IElementBehaviorSiteRender.xml' path='doc/member[@name="IElementBehaviorSiteRender.InvalidateRenderInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InvalidateRenderInfo()
    {
        return ((delegate* unmanaged<IElementBehaviorSiteRender*, int> )(lpVtbl[4]))((IElementBehaviorSiteRender*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementBehaviorSiteRender.xml' path='doc/member[@name="IElementBehaviorSiteRender.InvalidateStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InvalidateStyle()
    {
        return ((delegate* unmanaged<IElementBehaviorSiteRender*, int> )(lpVtbl[5]))((IElementBehaviorSiteRender*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invalidate(RECT* pRect);
        [VtblIndex(4)]
        HRESULT InvalidateRenderInfo();
        [VtblIndex(5)]
        HRESULT InvalidateStyle();
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
        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> Invalidate;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> InvalidateRenderInfo;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> InvalidateStyle;
    }
}