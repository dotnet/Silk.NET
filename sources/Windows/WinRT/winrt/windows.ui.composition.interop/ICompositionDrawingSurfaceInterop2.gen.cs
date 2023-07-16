// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='ICompositionDrawingSurfaceInterop2.xml' path='doc/member[@name="ICompositionDrawingSurfaceInterop2"]/*'/>
[Guid("41E64AAE-98C0-4239-8E95-A330DD6AA18B")]
[NativeTypeName("struct ICompositionDrawingSurfaceInterop2 : ABI::Windows::UI::Composition::ICompositionDrawingSurfaceInterop")]
[NativeInheritance("ICompositionDrawingSurfaceInterop")]
public unsafe partial struct ICompositionDrawingSurfaceInterop2 : ICompositionDrawingSurfaceInterop2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionDrawingSurfaceInterop2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, Guid*, void**, int> )(lpVtbl[0]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, uint> )(lpVtbl[1]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, uint> )(lpVtbl[2]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ICompositionDrawingSurfaceInterop.BeginDraw"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, void** updateObject, POINT* updateOffset)
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, RECT*, Guid*, void**, POINT*, int> )(lpVtbl[3]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
    }

    /// <inheritdoc cref = "ICompositionDrawingSurfaceInterop.EndDraw"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndDraw()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, int> )(lpVtbl[4]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ICompositionDrawingSurfaceInterop.Resize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Resize(SIZE sizePixels)
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, SIZE, int> )(lpVtbl[5]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), sizePixels);
    }

    /// <inheritdoc cref = "ICompositionDrawingSurfaceInterop.Scroll"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY)
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, RECT*, RECT*, int, int, int> )(lpVtbl[6]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
    }

    /// <inheritdoc cref = "ICompositionDrawingSurfaceInterop.ResumeDraw"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResumeDraw()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, int> )(lpVtbl[7]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ICompositionDrawingSurfaceInterop.SuspendDraw"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SuspendDraw()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, int> )(lpVtbl[8]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICompositionDrawingSurfaceInterop2.xml' path='doc/member[@name="ICompositionDrawingSurfaceInterop2.CopySurface"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CopySurface(IUnknown* destinationResource, int destinationOffsetX, int destinationOffsetY, [NativeTypeName("const RECT *")] RECT* sourceRectangle)
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2*, IUnknown*, int, int, RECT*, int> )(lpVtbl[9]))((ICompositionDrawingSurfaceInterop2*)Unsafe.AsPointer(ref this), destinationResource, destinationOffsetX, destinationOffsetY, sourceRectangle);
    }

    public interface Interface : ICompositionDrawingSurfaceInterop.Interface
    {
        [VtblIndex(9)]
        HRESULT CopySurface(IUnknown* destinationResource, int destinationOffsetX, int destinationOffsetY, [NativeTypeName("const RECT *")] RECT* sourceRectangle);
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
        [NativeTypeName("HRESULT (SIZE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE, int> Resize;
        [NativeTypeName("HRESULT (const RECT *, const RECT *, int, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, int, int, int> Scroll;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResumeDraw;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SuspendDraw;
        [NativeTypeName("HRESULT (IUnknown *, int, int, const RECT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int, int, RECT*, int> CopySurface;
    }
}