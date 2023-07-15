// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDCompositionSurface.xml' path='doc/member[@name="IDCompositionSurface"]/*'/>
[Guid("BB8A4953-2C99-4F5A-96F5-4819027FA3AC")]
[NativeTypeName("struct IDCompositionSurface : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionSurface : IDCompositionSurface.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionSurface));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionSurface*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionSurface*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionSurface*, uint> )(lpVtbl[1]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionSurface*, uint> )(lpVtbl[2]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionSurface.xml' path='doc/member[@name="IDCompositionSurface.BeginDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, void** updateObject, POINT* updateOffset)
    {
        return ((delegate* unmanaged<IDCompositionSurface*, RECT*, Guid*, void**, POINT*, int> )(lpVtbl[3]))((IDCompositionSurface*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
    }

    /// <include file='IDCompositionSurface.xml' path='doc/member[@name="IDCompositionSurface.EndDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndDraw()
    {
        return ((delegate* unmanaged<IDCompositionSurface*, int> )(lpVtbl[4]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionSurface.xml' path='doc/member[@name="IDCompositionSurface.SuspendDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SuspendDraw()
    {
        return ((delegate* unmanaged<IDCompositionSurface*, int> )(lpVtbl[5]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionSurface.xml' path='doc/member[@name="IDCompositionSurface.ResumeDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ResumeDraw()
    {
        return ((delegate* unmanaged<IDCompositionSurface*, int> )(lpVtbl[6]))((IDCompositionSurface*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionSurface.xml' path='doc/member[@name="IDCompositionSurface.Scroll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY)
    {
        return ((delegate* unmanaged<IDCompositionSurface*, RECT*, RECT*, int, int, int> )(lpVtbl[7]))((IDCompositionSurface*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, void** updateObject, POINT* updateOffset);
        [VtblIndex(4)]
        HRESULT EndDraw();
        [VtblIndex(5)]
        HRESULT SuspendDraw();
        [VtblIndex(6)]
        HRESULT ResumeDraw();
        [VtblIndex(7)]
        HRESULT Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY);
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
        [NativeTypeName("HRESULT (const RECT *, const IID &, void **, POINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, Guid*, void**, POINT*, int> BeginDraw;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndDraw;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SuspendDraw;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResumeDraw;
        [NativeTypeName("HRESULT (const RECT *, const RECT *, int, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, int, int, int> Scroll;
    }
}