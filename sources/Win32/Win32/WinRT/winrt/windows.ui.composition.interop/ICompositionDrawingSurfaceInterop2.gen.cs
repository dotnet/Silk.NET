// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("41E64AAE-98C0-4239-8E95-A330DD6AA18B")]
[NativeTypeName(
    "struct ICompositionDrawingSurfaceInterop2 : ABI::Windows::UI::Composition::ICompositionDrawingSurfaceInterop"
)]
[NativeInheritance("ICompositionDrawingSurfaceInterop")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct ICompositionDrawingSurfaceInterop2
    : ICompositionDrawingSurfaceInterop2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionDrawingSurfaceInterop2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICompositionDrawingSurfaceInterop2, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT BeginDraw(
        [NativeTypeName("const RECT *")] RECT* updateRect,
        [NativeTypeName("const IID &")] Guid* iid,
        void** updateObject,
        POINT* updateOffset
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionDrawingSurfaceInterop2,
                RECT*,
                Guid*,
                void**,
                POINT*,
                int>)((*lpVtbl)[3])
        )(this, updateRect, iid, updateObject, updateOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EndDraw()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Resize(SIZE sizePixels)
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2, SIZE, int>)((*lpVtbl)[5]))(
            this,
            sizePixels
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Scroll(
        [NativeTypeName("const RECT *")] RECT* scrollRect,
        [NativeTypeName("const RECT *")] RECT* clipRect,
        int offsetX,
        int offsetY
    )
    {
        return (
            (delegate* unmanaged<ICompositionDrawingSurfaceInterop2, RECT*, RECT*, int, int, int>)(
                (*lpVtbl)[6]
            )
        )(this, scrollRect, clipRect, offsetX, offsetY);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResumeDraw()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SuspendDraw()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop2, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CopySurface(
        IUnknown destinationResource,
        int destinationOffsetX,
        int destinationOffsetY,
        [NativeTypeName("const RECT *")] RECT* sourceRectangle
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionDrawingSurfaceInterop2,
                IUnknown,
                int,
                int,
                RECT*,
                int>)((*lpVtbl)[9])
        )(this, destinationResource, destinationOffsetX, destinationOffsetY, sourceRectangle);
    }

    public interface Interface : ICompositionDrawingSurfaceInterop.Interface
    {
        [VtblIndex(9)]
        HRESULT CopySurface(
            IUnknown destinationResource,
            int destinationOffsetX,
            int destinationOffsetY,
            [NativeTypeName("const RECT *")] RECT* sourceRectangle
        );
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

        [NativeTypeName(
            "HRESULT (const RECT *, const IID &, void **, POINT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RECT*, Guid*, void**, POINT*, int> BeginDraw;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndDraw;

        [NativeTypeName("HRESULT (SIZE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE, int> Resize;

        [NativeTypeName(
            "HRESULT (const RECT *, const RECT *, int, int) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, RECT*, RECT*, int, int, int> Scroll;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ResumeDraw;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SuspendDraw;

        [NativeTypeName(
            "HRESULT (IUnknown *, int, int, const RECT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUnknown, int, int, RECT*, int> CopySurface;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionDrawingSurfaceInterop2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionDrawingSurfaceInterop2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.ICompositionDrawingSurfaceInterop"/> to <see cref = "ICompositionDrawingSurfaceInterop2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.ICompositionDrawingSurfaceInterop"/> instance to be converted </param>
    public static explicit operator ICompositionDrawingSurfaceInterop2(
        Silk.NET.WinRT.ICompositionDrawingSurfaceInterop value
    )
    {
        return new ICompositionDrawingSurfaceInterop2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionDrawingSurfaceInterop2"/> to <see cref = "Silk.NET.WinRT.ICompositionDrawingSurfaceInterop"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionDrawingSurfaceInterop2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.ICompositionDrawingSurfaceInterop(
        ICompositionDrawingSurfaceInterop2 value
    )
    {
        return new Silk.NET.WinRT.ICompositionDrawingSurfaceInterop(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionDrawingSurfaceInterop2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionDrawingSurfaceInterop2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ICompositionDrawingSurfaceInterop2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionDrawingSurfaceInterop2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionDrawingSurfaceInterop2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ICompositionDrawingSurfaceInterop2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
