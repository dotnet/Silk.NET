// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B403CA50-7F8C-4E83-985F-CC45060036D8")]
[NativeTypeName("struct ICompositor : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositor : ICompositor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositor));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositor, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositor, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositor, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositor, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositor, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositor, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateColorKeyFrameAnimation(
        [NativeTypeName("ABI::Windows::UI::Composition::IColorKeyFrameAnimation **")]
            IColorKeyFrameAnimation* result
    )
    {
        return ((delegate* unmanaged<ICompositor, IColorKeyFrameAnimation*, int>)((*lpVtbl)[6]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateColorBrush(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionColorBrush **")]
            ICompositionColorBrush* result
    )
    {
        return ((delegate* unmanaged<ICompositor, ICompositionColorBrush*, int>)((*lpVtbl)[7]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateColorBrushWithColor(
        [NativeTypeName("ABI::Windows::UI::Color")] Color color,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionColorBrush **")]
            ICompositionColorBrush* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor, Color, ICompositionColorBrush*, int>)((*lpVtbl)[8])
        )(this, color, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateContainerVisual(
        [NativeTypeName("ABI::Windows::UI::Composition::IContainerVisual **")]
            IContainerVisual* result
    )
    {
        return ((delegate* unmanaged<ICompositor, IContainerVisual*, int>)((*lpVtbl)[9]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateCubicBezierEasingFunction(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 controlPoint1,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 controlPoint2,
        [NativeTypeName("ABI::Windows::UI::Composition::ICubicBezierEasingFunction **")]
            ICubicBezierEasingFunction* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor, Vector2, Vector2, ICubicBezierEasingFunction*, int>)(
                (*lpVtbl)[10]
            )
        )(this, controlPoint1, controlPoint2, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateEffectFactory(
        [NativeTypeName("ABI::Windows::Graphics::Effects::IGraphicsEffect *")]
            IGraphicsEffect graphicsEffect,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEffectFactory **")]
            ICompositionEffectFactory* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor, IGraphicsEffect, ICompositionEffectFactory*, int>)(
                (*lpVtbl)[11]
            )
        )(this, graphicsEffect, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateEffectFactoryWithProperties(
        [NativeTypeName("ABI::Windows::Graphics::Effects::IGraphicsEffect *")]
            IGraphicsEffect graphicsEffect,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* animatableProperties,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEffectFactory **")]
            ICompositionEffectFactory* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositor,
                IGraphicsEffect,
                IIterable<HSTRING>*,
                ICompositionEffectFactory*,
                int>)((*lpVtbl)[12])
        )(this, graphicsEffect, animatableProperties, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateExpressionAnimation(
        [NativeTypeName("ABI::Windows::UI::Composition::IExpressionAnimation **")]
            IExpressionAnimation* result
    )
    {
        return ((delegate* unmanaged<ICompositor, IExpressionAnimation*, int>)((*lpVtbl)[13]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateExpressionAnimationWithExpression(
        HSTRING expression,
        [NativeTypeName("ABI::Windows::UI::Composition::IExpressionAnimation **")]
            IExpressionAnimation* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor, HSTRING, IExpressionAnimation*, int>)((*lpVtbl)[14])
        )(this, expression, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateInsetClip(
        [NativeTypeName("ABI::Windows::UI::Composition::IInsetClip **")] IInsetClip* result
    )
    {
        return ((delegate* unmanaged<ICompositor, IInsetClip*, int>)((*lpVtbl)[15]))(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateInsetClipWithInsets(
        float leftInset,
        float topInset,
        float rightInset,
        float bottomInset,
        [NativeTypeName("ABI::Windows::UI::Composition::IInsetClip **")] IInsetClip* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor, float, float, float, float, IInsetClip*, int>)(
                (*lpVtbl)[16]
            )
        )(this, leftInset, topInset, rightInset, bottomInset, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreateLinearEasingFunction(
        [NativeTypeName("ABI::Windows::UI::Composition::ILinearEasingFunction **")]
            ILinearEasingFunction* result
    )
    {
        return ((delegate* unmanaged<ICompositor, ILinearEasingFunction*, int>)((*lpVtbl)[17]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreatePropertySet(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPropertySet **")]
            ICompositionPropertySet* result
    )
    {
        return ((delegate* unmanaged<ICompositor, ICompositionPropertySet*, int>)((*lpVtbl)[18]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateQuaternionKeyFrameAnimation(
        [NativeTypeName("ABI::Windows::UI::Composition::IQuaternionKeyFrameAnimation **")]
            IQuaternionKeyFrameAnimation* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor, IQuaternionKeyFrameAnimation*, int>)((*lpVtbl)[19])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateScalarKeyFrameAnimation(
        [NativeTypeName("ABI::Windows::UI::Composition::IScalarKeyFrameAnimation **")]
            IScalarKeyFrameAnimation* result
    )
    {
        return ((delegate* unmanaged<ICompositor, IScalarKeyFrameAnimation*, int>)((*lpVtbl)[20]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateScopedBatch(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionBatchTypes")]
            CompositionBatchTypes batchType,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionScopedBatch **")]
            ICompositionScopedBatch* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositor,
                CompositionBatchTypes,
                ICompositionScopedBatch*,
                int>)((*lpVtbl)[21])
        )(this, batchType, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateSpriteVisual(
        [NativeTypeName("ABI::Windows::UI::Composition::ISpriteVisual **")] ISpriteVisual* result
    )
    {
        return ((delegate* unmanaged<ICompositor, ISpriteVisual*, int>)((*lpVtbl)[22]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateSurfaceBrush(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurfaceBrush **")]
            ICompositionSurfaceBrush* result
    )
    {
        return ((delegate* unmanaged<ICompositor, ICompositionSurfaceBrush*, int>)((*lpVtbl)[23]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateSurfaceBrushWithSurface(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface *")]
            ICompositionSurface surface,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurfaceBrush **")]
            ICompositionSurfaceBrush* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor, ICompositionSurface, ICompositionSurfaceBrush*, int>)(
                (*lpVtbl)[24]
            )
        )(this, surface, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT CreateTargetForCurrentView(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionTarget **")]
            ICompositionTarget* result
    )
    {
        return ((delegate* unmanaged<ICompositor, ICompositionTarget*, int>)((*lpVtbl)[25]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT CreateVector2KeyFrameAnimation(
        [NativeTypeName("ABI::Windows::UI::Composition::IVector2KeyFrameAnimation **")]
            IVector2KeyFrameAnimation* result
    )
    {
        return ((delegate* unmanaged<ICompositor, IVector2KeyFrameAnimation*, int>)((*lpVtbl)[26]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT CreateVector3KeyFrameAnimation(
        [NativeTypeName("ABI::Windows::UI::Composition::IVector3KeyFrameAnimation **")]
            IVector3KeyFrameAnimation* result
    )
    {
        return ((delegate* unmanaged<ICompositor, IVector3KeyFrameAnimation*, int>)((*lpVtbl)[27]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CreateVector4KeyFrameAnimation(
        [NativeTypeName("ABI::Windows::UI::Composition::IVector4KeyFrameAnimation **")]
            IVector4KeyFrameAnimation* result
    )
    {
        return ((delegate* unmanaged<ICompositor, IVector4KeyFrameAnimation*, int>)((*lpVtbl)[28]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetCommitBatch(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionBatchTypes")]
            CompositionBatchTypes batchType,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionCommitBatch **")]
            ICompositionCommitBatch* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositor,
                CompositionBatchTypes,
                ICompositionCommitBatch*,
                int>)((*lpVtbl)[29])
        )(this, batchType, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateColorKeyFrameAnimation(
            [NativeTypeName("ABI::Windows::UI::Composition::IColorKeyFrameAnimation **")]
                IColorKeyFrameAnimation* result
        );

        [VtblIndex(7)]
        HRESULT CreateColorBrush(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionColorBrush **")]
                ICompositionColorBrush* result
        );

        [VtblIndex(8)]
        HRESULT CreateColorBrushWithColor(
            [NativeTypeName("ABI::Windows::UI::Color")] Color color,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionColorBrush **")]
                ICompositionColorBrush* result
        );

        [VtblIndex(9)]
        HRESULT CreateContainerVisual(
            [NativeTypeName("ABI::Windows::UI::Composition::IContainerVisual **")]
                IContainerVisual* result
        );

        [VtblIndex(10)]
        HRESULT CreateCubicBezierEasingFunction(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 controlPoint1,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 controlPoint2,
            [NativeTypeName("ABI::Windows::UI::Composition::ICubicBezierEasingFunction **")]
                ICubicBezierEasingFunction* result
        );

        [VtblIndex(11)]
        HRESULT CreateEffectFactory(
            [NativeTypeName("ABI::Windows::Graphics::Effects::IGraphicsEffect *")]
                IGraphicsEffect graphicsEffect,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEffectFactory **")]
                ICompositionEffectFactory* result
        );

        [VtblIndex(12)]
        HRESULT CreateEffectFactoryWithProperties(
            [NativeTypeName("ABI::Windows::Graphics::Effects::IGraphicsEffect *")]
                IGraphicsEffect graphicsEffect,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* animatableProperties,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEffectFactory **")]
                ICompositionEffectFactory* result
        );

        [VtblIndex(13)]
        HRESULT CreateExpressionAnimation(
            [NativeTypeName("ABI::Windows::UI::Composition::IExpressionAnimation **")]
                IExpressionAnimation* result
        );

        [VtblIndex(14)]
        HRESULT CreateExpressionAnimationWithExpression(
            HSTRING expression,
            [NativeTypeName("ABI::Windows::UI::Composition::IExpressionAnimation **")]
                IExpressionAnimation* result
        );

        [VtblIndex(15)]
        HRESULT CreateInsetClip(
            [NativeTypeName("ABI::Windows::UI::Composition::IInsetClip **")] IInsetClip* result
        );

        [VtblIndex(16)]
        HRESULT CreateInsetClipWithInsets(
            float leftInset,
            float topInset,
            float rightInset,
            float bottomInset,
            [NativeTypeName("ABI::Windows::UI::Composition::IInsetClip **")] IInsetClip* result
        );

        [VtblIndex(17)]
        HRESULT CreateLinearEasingFunction(
            [NativeTypeName("ABI::Windows::UI::Composition::ILinearEasingFunction **")]
                ILinearEasingFunction* result
        );

        [VtblIndex(18)]
        HRESULT CreatePropertySet(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPropertySet **")]
                ICompositionPropertySet* result
        );

        [VtblIndex(19)]
        HRESULT CreateQuaternionKeyFrameAnimation(
            [NativeTypeName("ABI::Windows::UI::Composition::IQuaternionKeyFrameAnimation **")]
                IQuaternionKeyFrameAnimation* result
        );

        [VtblIndex(20)]
        HRESULT CreateScalarKeyFrameAnimation(
            [NativeTypeName("ABI::Windows::UI::Composition::IScalarKeyFrameAnimation **")]
                IScalarKeyFrameAnimation* result
        );

        [VtblIndex(21)]
        HRESULT CreateScopedBatch(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionBatchTypes")]
                CompositionBatchTypes batchType,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionScopedBatch **")]
                ICompositionScopedBatch* result
        );

        [VtblIndex(22)]
        HRESULT CreateSpriteVisual(
            [NativeTypeName("ABI::Windows::UI::Composition::ISpriteVisual **")]
                ISpriteVisual* result
        );

        [VtblIndex(23)]
        HRESULT CreateSurfaceBrush(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurfaceBrush **")]
                ICompositionSurfaceBrush* result
        );

        [VtblIndex(24)]
        HRESULT CreateSurfaceBrushWithSurface(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurface *")]
                ICompositionSurface surface,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSurfaceBrush **")]
                ICompositionSurfaceBrush* result
        );

        [VtblIndex(25)]
        HRESULT CreateTargetForCurrentView(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionTarget **")]
                ICompositionTarget* result
        );

        [VtblIndex(26)]
        HRESULT CreateVector2KeyFrameAnimation(
            [NativeTypeName("ABI::Windows::UI::Composition::IVector2KeyFrameAnimation **")]
                IVector2KeyFrameAnimation* result
        );

        [VtblIndex(27)]
        HRESULT CreateVector3KeyFrameAnimation(
            [NativeTypeName("ABI::Windows::UI::Composition::IVector3KeyFrameAnimation **")]
                IVector3KeyFrameAnimation* result
        );

        [VtblIndex(28)]
        HRESULT CreateVector4KeyFrameAnimation(
            [NativeTypeName("ABI::Windows::UI::Composition::IVector4KeyFrameAnimation **")]
                IVector4KeyFrameAnimation* result
        );

        [VtblIndex(29)]
        HRESULT GetCommitBatch(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionBatchTypes")]
                CompositionBatchTypes batchType,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionCommitBatch **")]
                ICompositionCommitBatch* result
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
            "HRESULT (ABI::Windows::UI::Composition::IColorKeyFrameAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IColorKeyFrameAnimation*,
            int> CreateColorKeyFrameAnimation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionColorBrush **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionColorBrush*, int> CreateColorBrush;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Color, ABI::Windows::UI::Composition::ICompositionColorBrush **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Color,
            ICompositionColorBrush*,
            int> CreateColorBrushWithColor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IContainerVisual **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContainerVisual*, int> CreateContainerVisual;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2, ABI::Windows::Foundation::Numerics::Vector2, ABI::Windows::UI::Composition::ICubicBezierEasingFunction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Vector2,
            Vector2,
            ICubicBezierEasingFunction*,
            int> CreateCubicBezierEasingFunction;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Effects::IGraphicsEffect *, ABI::Windows::UI::Composition::ICompositionEffectFactory **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IGraphicsEffect,
            ICompositionEffectFactory*,
            int> CreateEffectFactory;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Effects::IGraphicsEffect *, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::UI::Composition::ICompositionEffectFactory **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IGraphicsEffect,
            IIterable<HSTRING>*,
            ICompositionEffectFactory*,
            int> CreateEffectFactoryWithProperties;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IExpressionAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IExpressionAnimation*, int> CreateExpressionAnimation;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::UI::Composition::IExpressionAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IExpressionAnimation*,
            int> CreateExpressionAnimationWithExpression;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IInsetClip **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IInsetClip*, int> CreateInsetClip;

        [NativeTypeName(
            "HRESULT (FLOAT, FLOAT, FLOAT, FLOAT, ABI::Windows::UI::Composition::IInsetClip **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float,
            float,
            float,
            float,
            IInsetClip*,
            int> CreateInsetClipWithInsets;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ILinearEasingFunction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ILinearEasingFunction*, int> CreateLinearEasingFunction;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionPropertySet **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionPropertySet*, int> CreatePropertySet;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IQuaternionKeyFrameAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IQuaternionKeyFrameAnimation*,
            int> CreateQuaternionKeyFrameAnimation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IScalarKeyFrameAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IScalarKeyFrameAnimation*,
            int> CreateScalarKeyFrameAnimation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionBatchTypes, ABI::Windows::UI::Composition::ICompositionScopedBatch **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CompositionBatchTypes,
            ICompositionScopedBatch*,
            int> CreateScopedBatch;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ISpriteVisual **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISpriteVisual*, int> CreateSpriteVisual;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionSurfaceBrush **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionSurfaceBrush*, int> CreateSurfaceBrush;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionSurface *, ABI::Windows::UI::Composition::ICompositionSurfaceBrush **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICompositionSurface,
            ICompositionSurfaceBrush*,
            int> CreateSurfaceBrushWithSurface;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionTarget **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionTarget*, int> CreateTargetForCurrentView;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IVector2KeyFrameAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVector2KeyFrameAnimation*,
            int> CreateVector2KeyFrameAnimation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IVector3KeyFrameAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVector3KeyFrameAnimation*,
            int> CreateVector3KeyFrameAnimation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IVector4KeyFrameAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IVector4KeyFrameAnimation*,
            int> CreateVector4KeyFrameAnimation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionBatchTypes, ABI::Windows::UI::Composition::ICompositionCommitBatch **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CompositionBatchTypes,
            ICompositionCommitBatch*,
            int> GetCommitBatch;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositor"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositor(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositor(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositor"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositor"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositor value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositor(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositor"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositor value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
