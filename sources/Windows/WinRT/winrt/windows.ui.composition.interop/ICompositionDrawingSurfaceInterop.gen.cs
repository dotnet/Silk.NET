// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;
/// <include file='ICompositionDrawingSurfaceInterop.xml' path='doc/member[@name="ICompositionDrawingSurfaceInterop"]/*'/>
[Guid("FD04E6E3-FE0C-4C3C-AB19-A07601A576EE")]
[NativeTypeName("struct ICompositionDrawingSurfaceInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICompositionDrawingSurfaceInterop : ICompositionDrawingSurfaceInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionDrawingSurfaceInterop));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, Guid*, void**, int> )(lpVtbl[0]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, uint> )(lpVtbl[1]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, uint> )(lpVtbl[2]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICompositionDrawingSurfaceInterop.xml' path='doc/member[@name="ICompositionDrawingSurfaceInterop.BeginDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, void** updateObject, POINT* updateOffset)
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, RECT*, Guid*, void**, POINT*, int> )(lpVtbl[3]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this), updateRect, iid, updateObject, updateOffset);
    }

    /// <include file='ICompositionDrawingSurfaceInterop.xml' path='doc/member[@name="ICompositionDrawingSurfaceInterop.EndDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndDraw()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, int> )(lpVtbl[4]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICompositionDrawingSurfaceInterop.xml' path='doc/member[@name="ICompositionDrawingSurfaceInterop.Resize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Resize(SIZE sizePixels)
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, SIZE, int> )(lpVtbl[5]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this), sizePixels);
    }

    /// <include file='ICompositionDrawingSurfaceInterop.xml' path='doc/member[@name="ICompositionDrawingSurfaceInterop.Scroll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY)
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, RECT*, RECT*, int, int, int> )(lpVtbl[6]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this), scrollRect, clipRect, offsetX, offsetY);
    }

    /// <include file='ICompositionDrawingSurfaceInterop.xml' path='doc/member[@name="ICompositionDrawingSurfaceInterop.ResumeDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResumeDraw()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, int> )(lpVtbl[7]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICompositionDrawingSurfaceInterop.xml' path='doc/member[@name="ICompositionDrawingSurfaceInterop.SuspendDraw"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SuspendDraw()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop*, int> )(lpVtbl[8]))((ICompositionDrawingSurfaceInterop*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginDraw([NativeTypeName("const RECT *")] RECT* updateRect, [NativeTypeName("const IID &")] Guid* iid, void** updateObject, POINT* updateOffset);
        [VtblIndex(4)]
        HRESULT EndDraw();
        [VtblIndex(5)]
        HRESULT Resize(SIZE sizePixels);
        [VtblIndex(6)]
        HRESULT Scroll([NativeTypeName("const RECT *")] RECT* scrollRect, [NativeTypeName("const RECT *")] RECT* clipRect, int offsetX, int offsetY);
        [VtblIndex(7)]
        HRESULT ResumeDraw();
        [VtblIndex(8)]
        HRESULT SuspendDraw();
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
    }
}