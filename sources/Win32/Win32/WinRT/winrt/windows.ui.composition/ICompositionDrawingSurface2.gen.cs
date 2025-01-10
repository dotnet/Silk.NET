// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("FAD0E88B-E354-44E8-8E3D-C4880D5A213F")]
[NativeTypeName("struct ICompositionDrawingSurface2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionDrawingSurface2
    : ICompositionDrawingSurface2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionDrawingSurface2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICompositionDrawingSurface2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurface2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionDrawingSurface2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICompositionDrawingSurface2, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionDrawingSurface2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionDrawingSurface2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SizeInt32(
        [NativeTypeName("ABI::Windows::Graphics::SizeInt32 *")] SizeInt32* value
    )
    {
        return ((delegate* unmanaged<ICompositionDrawingSurface2, SizeInt32*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Resize(
        [NativeTypeName("ABI::Windows::Graphics::SizeInt32")] SizeInt32 sizePixels
    )
    {
        return ((delegate* unmanaged<ICompositionDrawingSurface2, SizeInt32, int>)((*lpVtbl)[7]))(
            this,
            sizePixels
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Scroll([NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset)
    {
        return ((delegate* unmanaged<ICompositionDrawingSurface2, PointInt32, int>)((*lpVtbl)[8]))(
            this,
            offset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ScrollRect(
        [NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset,
        [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 scrollRect
    )
    {
        return (
            (delegate* unmanaged<ICompositionDrawingSurface2, PointInt32, RectInt32, int>)(
                (*lpVtbl)[9]
            )
        )(this, offset, scrollRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ScrollWithClip(
        [NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset,
        [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 clipRect
    )
    {
        return (
            (delegate* unmanaged<ICompositionDrawingSurface2, PointInt32, RectInt32, int>)(
                (*lpVtbl)[10]
            )
        )(this, offset, clipRect);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ScrollRectWithClip(
        [NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset,
        [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 clipRect,
        [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 scrollRect
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionDrawingSurface2,
                PointInt32,
                RectInt32,
                RectInt32,
                int>)((*lpVtbl)[11])
        )(this, offset, clipRect, scrollRect);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SizeInt32(
            [NativeTypeName("ABI::Windows::Graphics::SizeInt32 *")] SizeInt32* value
        );

        [VtblIndex(7)]
        HRESULT Resize([NativeTypeName("ABI::Windows::Graphics::SizeInt32")] SizeInt32 sizePixels);

        [VtblIndex(8)]
        HRESULT Scroll([NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset);

        [VtblIndex(9)]
        HRESULT ScrollRect(
            [NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset,
            [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 scrollRect
        );

        [VtblIndex(10)]
        HRESULT ScrollWithClip(
            [NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset,
            [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 clipRect
        );

        [VtblIndex(11)]
        HRESULT ScrollRectWithClip(
            [NativeTypeName("ABI::Windows::Graphics::PointInt32")] PointInt32 offset,
            [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 clipRect,
            [NativeTypeName("ABI::Windows::Graphics::RectInt32")] RectInt32 scrollRect
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::SizeInt32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SizeInt32*, int> get_SizeInt32;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::SizeInt32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SizeInt32, int> Resize;

        [NativeTypeName("HRESULT (ABI::Windows::Graphics::PointInt32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PointInt32, int> Scroll;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::PointInt32, ABI::Windows::Graphics::RectInt32) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PointInt32, RectInt32, int> ScrollRect;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::PointInt32, ABI::Windows::Graphics::RectInt32) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PointInt32, RectInt32, int> ScrollWithClip;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::PointInt32, ABI::Windows::Graphics::RectInt32, ABI::Windows::Graphics::RectInt32) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PointInt32,
            RectInt32,
            RectInt32,
            int> ScrollRectWithClip;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionDrawingSurface2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionDrawingSurface2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionDrawingSurface2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionDrawingSurface2(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionDrawingSurface2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionDrawingSurface2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionDrawingSurface2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionDrawingSurface2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionDrawingSurface2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionDrawingSurface2(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionDrawingSurface2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionDrawingSurface2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionDrawingSurface2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionDrawingSurface2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
