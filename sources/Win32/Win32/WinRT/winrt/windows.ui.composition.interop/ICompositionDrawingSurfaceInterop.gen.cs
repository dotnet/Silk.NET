// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FD04E6E3-FE0C-4C3C-AB19-A07601A576EE")]
[NativeTypeName("struct ICompositionDrawingSurfaceInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICompositionDrawingSurfaceInterop
    : ICompositionDrawingSurfaceInterop.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionDrawingSurfaceInterop));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICompositionDrawingSurfaceInterop, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop, uint>)((*lpVtbl)[2]))(this);
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
                ICompositionDrawingSurfaceInterop,
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
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Resize(SIZE sizePixels)
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop, SIZE, int>)((*lpVtbl)[5]))(
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
            (delegate* unmanaged<ICompositionDrawingSurfaceInterop, RECT*, RECT*, int, int, int>)(
                (*lpVtbl)[6]
            )
        )(this, scrollRect, clipRect, offsetX, offsetY);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ResumeDraw()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SuspendDraw()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurfaceInterop, int>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT BeginDraw(
            [NativeTypeName("const RECT *")] RECT* updateRect,
            [NativeTypeName("const IID &")] Guid* iid,
            void** updateObject,
            POINT* updateOffset
        );

        [VtblIndex(4)]
        HRESULT EndDraw();

        [VtblIndex(5)]
        HRESULT Resize(SIZE sizePixels);

        [VtblIndex(6)]
        HRESULT Scroll(
            [NativeTypeName("const RECT *")] RECT* scrollRect,
            [NativeTypeName("const RECT *")] RECT* clipRect,
            int offsetX,
            int offsetY
        );

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
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionDrawingSurfaceInterop"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionDrawingSurfaceInterop(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionDrawingSurfaceInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionDrawingSurfaceInterop(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ICompositionDrawingSurfaceInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionDrawingSurfaceInterop"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionDrawingSurfaceInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ICompositionDrawingSurfaceInterop value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
