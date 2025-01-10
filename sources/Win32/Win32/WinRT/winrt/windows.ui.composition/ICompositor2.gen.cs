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

[Guid("735081DC-5E24-45DA-A38F-E32CC349A9A0")]
[NativeTypeName("struct ICompositor2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositor2 : ICompositor2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositor2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositor2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositor2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositor2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositor2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositor2, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositor2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateAmbientLight(
        [NativeTypeName("ABI::Windows::UI::Composition::IAmbientLight **")] IAmbientLight* result
    )
    {
        return ((delegate* unmanaged<ICompositor2, IAmbientLight*, int>)((*lpVtbl)[6]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateAnimationGroup(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationGroup **")]
            ICompositionAnimationGroup* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor2, ICompositionAnimationGroup*, int>)((*lpVtbl)[7])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateBackdropBrush(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBackdropBrush **")]
            ICompositionBackdropBrush* result
    )
    {
        return ((delegate* unmanaged<ICompositor2, ICompositionBackdropBrush*, int>)((*lpVtbl)[8]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateDistantLight(
        [NativeTypeName("ABI::Windows::UI::Composition::IDistantLight **")] IDistantLight* result
    )
    {
        return ((delegate* unmanaged<ICompositor2, IDistantLight*, int>)((*lpVtbl)[9]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateDropShadow(
        [NativeTypeName("ABI::Windows::UI::Composition::IDropShadow **")] IDropShadow* result
    )
    {
        return ((delegate* unmanaged<ICompositor2, IDropShadow*, int>)((*lpVtbl)[10]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateImplicitAnimationCollection(
        [NativeTypeName("ABI::Windows::UI::Composition::IImplicitAnimationCollection **")]
            IImplicitAnimationCollection* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor2, IImplicitAnimationCollection*, int>)((*lpVtbl)[11])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateLayerVisual(
        [NativeTypeName("ABI::Windows::UI::Composition::ILayerVisual **")] ILayerVisual* result
    )
    {
        return ((delegate* unmanaged<ICompositor2, ILayerVisual*, int>)((*lpVtbl)[12]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateMaskBrush(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionMaskBrush **")]
            ICompositionMaskBrush* result
    )
    {
        return ((delegate* unmanaged<ICompositor2, ICompositionMaskBrush*, int>)((*lpVtbl)[13]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateNineGridBrush(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionNineGridBrush **")]
            ICompositionNineGridBrush* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor2, ICompositionNineGridBrush*, int>)((*lpVtbl)[14])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreatePointLight(
        [NativeTypeName("ABI::Windows::UI::Composition::IPointLight **")] IPointLight* result
    )
    {
        return ((delegate* unmanaged<ICompositor2, IPointLight*, int>)((*lpVtbl)[15]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateSpotLight(
        [NativeTypeName("ABI::Windows::UI::Composition::ISpotLight **")] ISpotLight* result
    )
    {
        return ((delegate* unmanaged<ICompositor2, ISpotLight*, int>)((*lpVtbl)[16]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateStepEasingFunction(
        [NativeTypeName("ABI::Windows::UI::Composition::IStepEasingFunction **")]
            IStepEasingFunction* result
    )
    {
        return ((delegate* unmanaged<ICompositor2, IStepEasingFunction*, int>)((*lpVtbl)[17]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateStepEasingFunctionWithStepCount(
        [NativeTypeName("INT32")] int stepCount,
        [NativeTypeName("ABI::Windows::UI::Composition::IStepEasingFunction **")]
            IStepEasingFunction* result
    )
    {
        return ((delegate* unmanaged<ICompositor2, int, IStepEasingFunction*, int>)((*lpVtbl)[18]))(
            this,
            stepCount,
            result
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateAmbientLight(
            [NativeTypeName("ABI::Windows::UI::Composition::IAmbientLight **")]
                IAmbientLight* result
        );

        [VtblIndex(7)]
        HRESULT CreateAnimationGroup(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionAnimationGroup **")]
                ICompositionAnimationGroup* result
        );

        [VtblIndex(8)]
        HRESULT CreateBackdropBrush(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionBackdropBrush **")]
                ICompositionBackdropBrush* result
        );

        [VtblIndex(9)]
        HRESULT CreateDistantLight(
            [NativeTypeName("ABI::Windows::UI::Composition::IDistantLight **")]
                IDistantLight* result
        );

        [VtblIndex(10)]
        HRESULT CreateDropShadow(
            [NativeTypeName("ABI::Windows::UI::Composition::IDropShadow **")] IDropShadow* result
        );

        [VtblIndex(11)]
        HRESULT CreateImplicitAnimationCollection(
            [NativeTypeName("ABI::Windows::UI::Composition::IImplicitAnimationCollection **")]
                IImplicitAnimationCollection* result
        );

        [VtblIndex(12)]
        HRESULT CreateLayerVisual(
            [NativeTypeName("ABI::Windows::UI::Composition::ILayerVisual **")] ILayerVisual* result
        );

        [VtblIndex(13)]
        HRESULT CreateMaskBrush(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionMaskBrush **")]
                ICompositionMaskBrush* result
        );

        [VtblIndex(14)]
        HRESULT CreateNineGridBrush(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionNineGridBrush **")]
                ICompositionNineGridBrush* result
        );

        [VtblIndex(15)]
        HRESULT CreatePointLight(
            [NativeTypeName("ABI::Windows::UI::Composition::IPointLight **")] IPointLight* result
        );

        [VtblIndex(16)]
        HRESULT CreateSpotLight(
            [NativeTypeName("ABI::Windows::UI::Composition::ISpotLight **")] ISpotLight* result
        );

        [VtblIndex(17)]
        HRESULT CreateStepEasingFunction(
            [NativeTypeName("ABI::Windows::UI::Composition::IStepEasingFunction **")]
                IStepEasingFunction* result
        );

        [VtblIndex(18)]
        HRESULT CreateStepEasingFunctionWithStepCount(
            [NativeTypeName("INT32")] int stepCount,
            [NativeTypeName("ABI::Windows::UI::Composition::IStepEasingFunction **")]
                IStepEasingFunction* result
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
            "HRESULT (ABI::Windows::UI::Composition::IAmbientLight **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAmbientLight*, int> CreateAmbientLight;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionAnimationGroup **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionAnimationGroup*, int> CreateAnimationGroup;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionBackdropBrush **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionBackdropBrush*, int> CreateBackdropBrush;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IDistantLight **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDistantLight*, int> CreateDistantLight;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IDropShadow **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDropShadow*, int> CreateDropShadow;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IImplicitAnimationCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IImplicitAnimationCollection*,
            int> CreateImplicitAnimationCollection;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ILayerVisual **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ILayerVisual*, int> CreateLayerVisual;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionMaskBrush **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionMaskBrush*, int> CreateMaskBrush;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionNineGridBrush **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionNineGridBrush*, int> CreateNineGridBrush;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IPointLight **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPointLight*, int> CreatePointLight;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ISpotLight **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISpotLight*, int> CreateSpotLight;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IStepEasingFunction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStepEasingFunction*, int> CreateStepEasingFunction;

        [NativeTypeName(
            "HRESULT (INT32, ABI::Windows::UI::Composition::IStepEasingFunction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            IStepEasingFunction*,
            int> CreateStepEasingFunctionWithStepCount;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositor2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositor2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositor2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositor2(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositor2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositor2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositor2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositor2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositor2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositor2(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositor2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositor2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositor2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositor2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
