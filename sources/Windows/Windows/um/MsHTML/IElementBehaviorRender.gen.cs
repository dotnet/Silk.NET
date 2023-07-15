// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IElementBehaviorRender.xml' path='doc/member[@name="IElementBehaviorRender"]/*'/>
[Guid("3050F4AA-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementBehaviorRender : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementBehaviorRender : IElementBehaviorRender.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementBehaviorRender));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementBehaviorRender*, Guid*, void**, int> )(lpVtbl[0]))((IElementBehaviorRender*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IElementBehaviorRender*, uint> )(lpVtbl[1]))((IElementBehaviorRender*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementBehaviorRender*, uint> )(lpVtbl[2]))((IElementBehaviorRender*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IElementBehaviorRender.xml' path='doc/member[@name="IElementBehaviorRender.Draw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Draw(HDC hdc, [NativeTypeName("LONG")] int lLayer, RECT* pRect, IUnknown* pReserved)
    {
        return ((delegate* unmanaged<IElementBehaviorRender*, HDC, int, RECT*, IUnknown*, int> )(lpVtbl[3]))((IElementBehaviorRender*)Unsafe.AsPointer(ref this), hdc, lLayer, pRect, pReserved);
    }

    /// <include file='IElementBehaviorRender.xml' path='doc/member[@name="IElementBehaviorRender.GetRenderInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRenderInfo([NativeTypeName("LONG *")] int* plRenderInfo)
    {
        return ((delegate* unmanaged<IElementBehaviorRender*, int*, int> )(lpVtbl[4]))((IElementBehaviorRender*)Unsafe.AsPointer(ref this), plRenderInfo);
    }

    /// <include file='IElementBehaviorRender.xml' path='doc/member[@name="IElementBehaviorRender.HitTestPoint"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT HitTestPoint(POINT* pPoint, IUnknown* pReserved, BOOL* pbHit)
    {
        return ((delegate* unmanaged<IElementBehaviorRender*, POINT*, IUnknown*, BOOL*, int> )(lpVtbl[5]))((IElementBehaviorRender*)Unsafe.AsPointer(ref this), pPoint, pReserved, pbHit);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Draw(HDC hdc, [NativeTypeName("LONG")] int lLayer, RECT* pRect, IUnknown* pReserved);
        [VtblIndex(4)]
        HRESULT GetRenderInfo([NativeTypeName("LONG *")] int* plRenderInfo);
        [VtblIndex(5)]
        HRESULT HitTestPoint(POINT* pPoint, IUnknown* pReserved, BOOL* pbHit);
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
        [NativeTypeName("HRESULT (HDC, LONG, RECT *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, int, RECT*, IUnknown*, int> Draw;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetRenderInfo;
        [NativeTypeName("HRESULT (POINT *, IUnknown *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, IUnknown*, BOOL*, int> HitTestPoint;
    }
}