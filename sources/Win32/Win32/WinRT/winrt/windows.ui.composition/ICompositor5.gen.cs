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

[Guid("48EA31AD-7FCD-4076-A79C-90CC4B852C9B")]
[NativeTypeName("struct ICompositor5 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositor5 : ICompositor5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositor5));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositor5, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositor5, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositor5, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositor5, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositor5, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositor5, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Comment(HSTRING* value)
    {
        return ((delegate* unmanaged<ICompositor5, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Comment(HSTRING value)
    {
        return ((delegate* unmanaged<ICompositor5, HSTRING, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_GlobalPlaybackRate(float* value)
    {
        return ((delegate* unmanaged<ICompositor5, float*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_GlobalPlaybackRate(float value)
    {
        return ((delegate* unmanaged<ICompositor5, float, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateBounceScalarAnimation(
        [NativeTypeName("ABI::Windows::UI::Composition::IBounceScalarNaturalMotionAnimation **")]
            IBounceScalarNaturalMotionAnimation* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor5, IBounceScalarNaturalMotionAnimation*, int>)(
                (*lpVtbl)[10]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateBounceVector2Animation(
        [NativeTypeName("ABI::Windows::UI::Composition::IBounceVector2NaturalMotionAnimation **")]
            IBounceVector2NaturalMotionAnimation* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor5, IBounceVector2NaturalMotionAnimation*, int>)(
                (*lpVtbl)[11]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateBounceVector3Animation(
        [NativeTypeName("ABI::Windows::UI::Composition::IBounceVector3NaturalMotionAnimation **")]
            IBounceVector3NaturalMotionAnimation* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor5, IBounceVector3NaturalMotionAnimation*, int>)(
                (*lpVtbl)[12]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateContainerShape(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionContainerShape **")]
            ICompositionContainerShape* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor5, ICompositionContainerShape*, int>)((*lpVtbl)[13])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreateEllipseGeometry(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEllipseGeometry **")]
            ICompositionEllipseGeometry* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor5, ICompositionEllipseGeometry*, int>)((*lpVtbl)[14])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateLineGeometry(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionLineGeometry **")]
            ICompositionLineGeometry* result
    )
    {
        return ((delegate* unmanaged<ICompositor5, ICompositionLineGeometry*, int>)((*lpVtbl)[15]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreatePathGeometry(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPathGeometry **")]
            ICompositionPathGeometry* result
    )
    {
        return ((delegate* unmanaged<ICompositor5, ICompositionPathGeometry*, int>)((*lpVtbl)[16]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT CreatePathGeometryWithPath(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPath *")] ICompositionPath path,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPathGeometry **")]
            ICompositionPathGeometry* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor5, ICompositionPath, ICompositionPathGeometry*, int>)(
                (*lpVtbl)[17]
            )
        )(this, path, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreatePathKeyFrameAnimation(
        [NativeTypeName("ABI::Windows::UI::Composition::IPathKeyFrameAnimation **")]
            IPathKeyFrameAnimation* result
    )
    {
        return ((delegate* unmanaged<ICompositor5, IPathKeyFrameAnimation*, int>)((*lpVtbl)[18]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT CreateRectangleGeometry(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionRectangleGeometry **")]
            ICompositionRectangleGeometry* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor5, ICompositionRectangleGeometry*, int>)((*lpVtbl)[19])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT CreateRoundedRectangleGeometry(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionRoundedRectangleGeometry **")]
            ICompositionRoundedRectangleGeometry* result
    )
    {
        return (
            (delegate* unmanaged<ICompositor5, ICompositionRoundedRectangleGeometry*, int>)(
                (*lpVtbl)[20]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CreateShapeVisual(
        [NativeTypeName("ABI::Windows::UI::Composition::IShapeVisual **")] IShapeVisual* result
    )
    {
        return ((delegate* unmanaged<ICompositor5, IShapeVisual*, int>)((*lpVtbl)[21]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT CreateSpriteShape(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSpriteShape **")]
            ICompositionSpriteShape* result
    )
    {
        return ((delegate* unmanaged<ICompositor5, ICompositionSpriteShape*, int>)((*lpVtbl)[22]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT CreateSpriteShapeWithGeometry(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry *")]
            ICompositionGeometry geometry,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSpriteShape **")]
            ICompositionSpriteShape* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositor5,
                ICompositionGeometry,
                ICompositionSpriteShape*,
                int>)((*lpVtbl)[23])
        )(this, geometry, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT CreateViewBox(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionViewBox **")]
            ICompositionViewBox* result
    )
    {
        return ((delegate* unmanaged<ICompositor5, ICompositionViewBox*, int>)((*lpVtbl)[24]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT RequestCommitAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<ICompositor5, IAsyncAction*, int>)((*lpVtbl)[25]))(
            this,
            operation
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Comment(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Comment(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_GlobalPlaybackRate(float* value);

        [VtblIndex(9)]
        HRESULT put_GlobalPlaybackRate(float value);

        [VtblIndex(10)]
        HRESULT CreateBounceScalarAnimation(
            [NativeTypeName(
                "ABI::Windows::UI::Composition::IBounceScalarNaturalMotionAnimation **"
            )]
                IBounceScalarNaturalMotionAnimation* result
        );

        [VtblIndex(11)]
        HRESULT CreateBounceVector2Animation(
            [NativeTypeName(
                "ABI::Windows::UI::Composition::IBounceVector2NaturalMotionAnimation **"
            )]
                IBounceVector2NaturalMotionAnimation* result
        );

        [VtblIndex(12)]
        HRESULT CreateBounceVector3Animation(
            [NativeTypeName(
                "ABI::Windows::UI::Composition::IBounceVector3NaturalMotionAnimation **"
            )]
                IBounceVector3NaturalMotionAnimation* result
        );

        [VtblIndex(13)]
        HRESULT CreateContainerShape(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionContainerShape **")]
                ICompositionContainerShape* result
        );

        [VtblIndex(14)]
        HRESULT CreateEllipseGeometry(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionEllipseGeometry **")]
                ICompositionEllipseGeometry* result
        );

        [VtblIndex(15)]
        HRESULT CreateLineGeometry(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionLineGeometry **")]
                ICompositionLineGeometry* result
        );

        [VtblIndex(16)]
        HRESULT CreatePathGeometry(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPathGeometry **")]
                ICompositionPathGeometry* result
        );

        [VtblIndex(17)]
        HRESULT CreatePathGeometryWithPath(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPath *")]
                ICompositionPath path,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionPathGeometry **")]
                ICompositionPathGeometry* result
        );

        [VtblIndex(18)]
        HRESULT CreatePathKeyFrameAnimation(
            [NativeTypeName("ABI::Windows::UI::Composition::IPathKeyFrameAnimation **")]
                IPathKeyFrameAnimation* result
        );

        [VtblIndex(19)]
        HRESULT CreateRectangleGeometry(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionRectangleGeometry **")]
                ICompositionRectangleGeometry* result
        );

        [VtblIndex(20)]
        HRESULT CreateRoundedRectangleGeometry(
            [NativeTypeName(
                "ABI::Windows::UI::Composition::ICompositionRoundedRectangleGeometry **"
            )]
                ICompositionRoundedRectangleGeometry* result
        );

        [VtblIndex(21)]
        HRESULT CreateShapeVisual(
            [NativeTypeName("ABI::Windows::UI::Composition::IShapeVisual **")] IShapeVisual* result
        );

        [VtblIndex(22)]
        HRESULT CreateSpriteShape(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSpriteShape **")]
                ICompositionSpriteShape* result
        );

        [VtblIndex(23)]
        HRESULT CreateSpriteShapeWithGeometry(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionGeometry *")]
                ICompositionGeometry geometry,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionSpriteShape **")]
                ICompositionSpriteShape* result
        );

        [VtblIndex(24)]
        HRESULT CreateViewBox(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionViewBox **")]
                ICompositionViewBox* result
        );

        [VtblIndex(25)]
        HRESULT RequestCommitAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Comment;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Comment;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_GlobalPlaybackRate;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_GlobalPlaybackRate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IBounceScalarNaturalMotionAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBounceScalarNaturalMotionAnimation*,
            int> CreateBounceScalarAnimation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IBounceVector2NaturalMotionAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBounceVector2NaturalMotionAnimation*,
            int> CreateBounceVector2Animation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IBounceVector3NaturalMotionAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IBounceVector3NaturalMotionAnimation*,
            int> CreateBounceVector3Animation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionContainerShape **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionContainerShape*, int> CreateContainerShape;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionEllipseGeometry **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionEllipseGeometry*, int> CreateEllipseGeometry;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionLineGeometry **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionLineGeometry*, int> CreateLineGeometry;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionPathGeometry **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionPathGeometry*, int> CreatePathGeometry;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionPath *, ABI::Windows::UI::Composition::ICompositionPathGeometry **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICompositionPath,
            ICompositionPathGeometry*,
            int> CreatePathGeometryWithPath;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IPathKeyFrameAnimation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IPathKeyFrameAnimation*,
            int> CreatePathKeyFrameAnimation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionRectangleGeometry **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICompositionRectangleGeometry*,
            int> CreateRectangleGeometry;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionRoundedRectangleGeometry **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICompositionRoundedRectangleGeometry*,
            int> CreateRoundedRectangleGeometry;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IShapeVisual **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShapeVisual*, int> CreateShapeVisual;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionSpriteShape **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionSpriteShape*, int> CreateSpriteShape;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionGeometry *, ABI::Windows::UI::Composition::ICompositionSpriteShape **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ICompositionGeometry,
            ICompositionSpriteShape*,
            int> CreateSpriteShapeWithGeometry;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionViewBox **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionViewBox*, int> CreateViewBox;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> RequestCommitAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositor5"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositor5(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositor5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositor5(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositor5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositor5"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositor5"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositor5 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositor5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositor5(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositor5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositor5"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositor5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositor5 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
