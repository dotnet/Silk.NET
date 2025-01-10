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

[Guid("7A38B2BD-CEC8-4EEB-830F-D8D07AEDEBC3")]
[NativeTypeName("struct ICompositor6 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositor6 : ICompositor6.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositor6));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositor6, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositor6, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositor6, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositor6, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositor6, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositor6, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateGeometricClip(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometricClip **")]
            ICompositionGeometricClip* result
    )
    {
        return ((delegate* unmanaged<ICompositor6, ICompositionGeometricClip*, int>)((*lpVtbl)[6]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateGeometricClipWithGeometry(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry *")]
            ICompositionGeometry geometry,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometricClip **")]
            ICompositionGeometricClip* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositor6,
                ICompositionGeometry,
                ICompositionGeometricClip*,
                int>)((*lpVtbl)[7])
        )(this, geometry, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateRedirectVisual(
        [NativeTypeName("ABI::Windows::UI::Composition::IRedirectVisual **")]
            IRedirectVisual* result
    )
    {
        return ((delegate* unmanaged<ICompositor6, IRedirectVisual*, int>)((*lpVtbl)[8]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateRedirectVisualWithSourceVisual(
        [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual source,
        [NativeTypeName("ABI::Windows::UI::Composition::IRedirectVisual **")]
            IRedirectVisual* result
    )
    {
        return ((delegate* unmanaged<ICompositor6, IVisual, IRedirectVisual*, int>)((*lpVtbl)[9]))(
            this,
            source,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateBooleanKeyFrameAnimation(
        [NativeTypeName("ABI::Windows::UI::Composition::IBooleanKeyFrameAnimation **")]
            IBooleanKeyFrameAnimation* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor6, IBooleanKeyFrameAnimation*, int>)((*lpVtbl)[10])
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateGeometricClip(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometricClip **")]
                ICompositionGeometricClip* result
        );

        [VtblIndex(7)]
        HRESULT CreateGeometricClipWithGeometry(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry *")]
                ICompositionGeometry geometry,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometricClip **")]
                ICompositionGeometricClip* result
        );

        [VtblIndex(8)]
        HRESULT CreateRedirectVisual(
            [NativeTypeName("ABI::Windows::UI::Composition::IRedirectVisual **")]
                IRedirectVisual* result
        );

        [VtblIndex(9)]
        HRESULT CreateRedirectVisualWithSourceVisual(
            [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual source,
            [NativeTypeName("ABI::Windows::UI::Composition::IRedirectVisual **")]
                IRedirectVisual* result
        );

        [VtblIndex(10)]
        HRESULT CreateBooleanKeyFrameAnimation(
            [NativeTypeName("ABI::Windows::UI::Composition::IBooleanKeyFrameAnimation **")]
                IBooleanKeyFrameAnimation* result
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionGeometricClip **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionGeometricClip*, int> CreateGeometricClip;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionGeometry *, ABI::Windows::UI::Composition::ICompositionGeometricClip **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICompositionGeometry,
            ICompositionGeometricClip*,
            int> CreateGeometricClipWithGeometry;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IRedirectVisual **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRedirectVisual*, int> CreateRedirectVisual;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IVisual *, ABI::Windows::UI::Composition::IRedirectVisual **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVisual,
            IRedirectVisual*,
            int> CreateRedirectVisualWithSourceVisual;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IBooleanKeyFrameAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBooleanKeyFrameAnimation*,
            int> CreateBooleanKeyFrameAnimation;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositor6"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositor6(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositor6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositor6(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositor6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositor6"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositor6"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositor6 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositor6"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositor6(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositor6(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositor6"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositor6"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositor6 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
