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

[Guid("AD016D79-1E4C-4C0D-9C29-83338C87C162")]
[NativeTypeName("struct ICompositionSurfaceBrush : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionSurfaceBrush
    : ICompositionSurfaceBrush.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionSurfaceBrush));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionSurfaceBrush, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositionSurfaceBrush, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionSurfaceBrush, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositionSurfaceBrush, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionSurfaceBrush, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionSurfaceBrush, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_BitmapInterpolationMode(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionBitmapInterpolationMode *")]
            CompositionBitmapInterpolationMode* value
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionSurfaceBrush,
                CompositionBitmapInterpolationMode*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_BitmapInterpolationMode(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionBitmapInterpolationMode")]
            CompositionBitmapInterpolationMode value
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionSurfaceBrush,
                CompositionBitmapInterpolationMode,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_HorizontalAlignmentRatio(float* value)
    {
        return ((delegate* unmanaged<ICompositionSurfaceBrush, float*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_HorizontalAlignmentRatio(float value)
    {
        return ((delegate* unmanaged<ICompositionSurfaceBrush, float, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Stretch(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch *")]
            CompositionStretch* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSurfaceBrush, CompositionStretch*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Stretch(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch")]
            CompositionStretch value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSurfaceBrush, CompositionStretch, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Surface(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface **")]
            ICompositionSurface* value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSurfaceBrush, ICompositionSurface*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Surface(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface *")]
            ICompositionSurface value
    )
    {
        return (
            (delegate* unmanaged<ICompositionSurfaceBrush, ICompositionSurface, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_VerticalAlignmentRatio(float* value)
    {
        return ((delegate* unmanaged<ICompositionSurfaceBrush, float*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_VerticalAlignmentRatio(float value)
    {
        return ((delegate* unmanaged<ICompositionSurfaceBrush, float, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_BitmapInterpolationMode(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionBitmapInterpolationMode *")]
                CompositionBitmapInterpolationMode* value
        );

        [VtblIndex(7)]
        HRESULT put_BitmapInterpolationMode(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionBitmapInterpolationMode")]
                CompositionBitmapInterpolationMode value
        );

        [VtblIndex(8)]
        HRESULT get_HorizontalAlignmentRatio(float* value);

        [VtblIndex(9)]
        HRESULT put_HorizontalAlignmentRatio(float value);

        [VtblIndex(10)]
        HRESULT get_Stretch(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch *")]
                CompositionStretch* value
        );

        [VtblIndex(11)]
        HRESULT put_Stretch(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionStretch")]
                CompositionStretch value
        );

        [VtblIndex(12)]
        HRESULT get_Surface(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface **")]
                ICompositionSurface* value
        );

        [VtblIndex(13)]
        HRESULT put_Surface(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface *")]
                ICompositionSurface value
        );

        [VtblIndex(14)]
        HRESULT get_VerticalAlignmentRatio(float* value);

        [VtblIndex(15)]
        HRESULT put_VerticalAlignmentRatio(float value);
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionBitmapInterpolationMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CompositionBitmapInterpolationMode*,
            int> get_BitmapInterpolationMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionBitmapInterpolationMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CompositionBitmapInterpolationMode,
            int> put_BitmapInterpolationMode;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_HorizontalAlignmentRatio;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_HorizontalAlignmentRatio;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionStretch *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionStretch*, int> get_Stretch;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionStretch) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionStretch, int> put_Stretch;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionSurface **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionSurface*, int> get_Surface;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionSurface *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionSurface, int> put_Surface;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_VerticalAlignmentRatio;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_VerticalAlignmentRatio;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionSurfaceBrush"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionSurfaceBrush(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionSurfaceBrush"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionSurfaceBrush(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionSurfaceBrush(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionSurfaceBrush"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionSurfaceBrush"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionSurfaceBrush value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionSurfaceBrush"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionSurfaceBrush(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionSurfaceBrush(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionSurfaceBrush"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionSurfaceBrush"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionSurfaceBrush value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
