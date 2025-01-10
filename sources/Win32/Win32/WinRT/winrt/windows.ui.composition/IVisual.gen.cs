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

[Guid("117E202D-A859-4C89-873B-C2AA566788E3")]
[NativeTypeName("struct IVisual : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVisual : IVisual.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVisual));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVisual, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVisual, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVisual, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IVisual, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVisual, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVisual, TrustLevel*, int>)((*lpVtbl)[5]))(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AnchorPoint(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<IVisual, Vector2*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_AnchorPoint(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
    )
    {
        return ((delegate* unmanaged<IVisual, Vector2, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_BackfaceVisibility(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionBackfaceVisibility *")]
            CompositionBackfaceVisibility* value
    )
    {
        return ((delegate* unmanaged<IVisual, CompositionBackfaceVisibility*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_BackfaceVisibility(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionBackfaceVisibility")]
            CompositionBackfaceVisibility value
    )
    {
        return ((delegate* unmanaged<IVisual, CompositionBackfaceVisibility, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BorderMode(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionBorderMode *")]
            CompositionBorderMode* value
    )
    {
        return ((delegate* unmanaged<IVisual, CompositionBorderMode*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_BorderMode(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionBorderMode")]
            CompositionBorderMode value
    )
    {
        return ((delegate* unmanaged<IVisual, CompositionBorderMode, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_CenterPoint(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
    )
    {
        return ((delegate* unmanaged<IVisual, Vector3*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_CenterPoint(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
    )
    {
        return ((delegate* unmanaged<IVisual, Vector3, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Clip(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionClip **")]
            ICompositionClip* value
    )
    {
        return ((delegate* unmanaged<IVisual, ICompositionClip*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Clip(
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionClip *")] ICompositionClip value
    )
    {
        return ((delegate* unmanaged<IVisual, ICompositionClip, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_CompositeMode(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionCompositeMode *")]
            CompositionCompositeMode* value
    )
    {
        return ((delegate* unmanaged<IVisual, CompositionCompositeMode*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_CompositeMode(
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionCompositeMode")]
            CompositionCompositeMode value
    )
    {
        return ((delegate* unmanaged<IVisual, CompositionCompositeMode, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IVisual, byte*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_IsVisible([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IVisual, byte, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Offset(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
    )
    {
        return ((delegate* unmanaged<IVisual, Vector3*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_Offset(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
    )
    {
        return ((delegate* unmanaged<IVisual, Vector3, int>)((*lpVtbl)[21]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Opacity(float* value)
    {
        return ((delegate* unmanaged<IVisual, float*, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_Opacity(float value)
    {
        return ((delegate* unmanaged<IVisual, float, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Orientation(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value
    )
    {
        return ((delegate* unmanaged<IVisual, Quaternion*, int>)((*lpVtbl)[24]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_Orientation(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value
    )
    {
        return ((delegate* unmanaged<IVisual, Quaternion, int>)((*lpVtbl)[25]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Parent(
        [NativeTypeName("ABI::Windows::UI::Composition::IContainerVisual **")]
            IContainerVisual* value
    )
    {
        return ((delegate* unmanaged<IVisual, IContainerVisual*, int>)((*lpVtbl)[26]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_RotationAngle(float* value)
    {
        return ((delegate* unmanaged<IVisual, float*, int>)((*lpVtbl)[27]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT put_RotationAngle(float value)
    {
        return ((delegate* unmanaged<IVisual, float, int>)((*lpVtbl)[28]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_RotationAngleInDegrees(float* value)
    {
        return ((delegate* unmanaged<IVisual, float*, int>)((*lpVtbl)[29]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT put_RotationAngleInDegrees(float value)
    {
        return ((delegate* unmanaged<IVisual, float, int>)((*lpVtbl)[30]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT get_RotationAxis(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
    )
    {
        return ((delegate* unmanaged<IVisual, Vector3*, int>)((*lpVtbl)[31]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT put_RotationAxis(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
    )
    {
        return ((delegate* unmanaged<IVisual, Vector3, int>)((*lpVtbl)[32]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_Scale(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
    )
    {
        return ((delegate* unmanaged<IVisual, Vector3*, int>)((*lpVtbl)[33]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT put_Scale(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
    )
    {
        return ((delegate* unmanaged<IVisual, Vector3, int>)((*lpVtbl)[34]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT get_Size(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<IVisual, Vector2*, int>)((*lpVtbl)[35]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT put_Size(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
    )
    {
        return ((delegate* unmanaged<IVisual, Vector2, int>)((*lpVtbl)[36]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT get_TransformMatrix(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4 *")] Matrix4x4* value
    )
    {
        return ((delegate* unmanaged<IVisual, Matrix4x4*, int>)((*lpVtbl)[37]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT put_TransformMatrix(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4")] Matrix4x4 value
    )
    {
        return ((delegate* unmanaged<IVisual, Matrix4x4, int>)((*lpVtbl)[38]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AnchorPoint(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(7)]
        HRESULT put_AnchorPoint(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
        );

        [VtblIndex(8)]
        HRESULT get_BackfaceVisibility(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionBackfaceVisibility *")]
                CompositionBackfaceVisibility* value
        );

        [VtblIndex(9)]
        HRESULT put_BackfaceVisibility(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionBackfaceVisibility")]
                CompositionBackfaceVisibility value
        );

        [VtblIndex(10)]
        HRESULT get_BorderMode(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionBorderMode *")]
                CompositionBorderMode* value
        );

        [VtblIndex(11)]
        HRESULT put_BorderMode(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionBorderMode")]
                CompositionBorderMode value
        );

        [VtblIndex(12)]
        HRESULT get_CenterPoint(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
        );

        [VtblIndex(13)]
        HRESULT put_CenterPoint(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
        );

        [VtblIndex(14)]
        HRESULT get_Clip(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionClip **")]
                ICompositionClip* value
        );

        [VtblIndex(15)]
        HRESULT put_Clip(
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionClip *")]
                ICompositionClip value
        );

        [VtblIndex(16)]
        HRESULT get_CompositeMode(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionCompositeMode *")]
                CompositionCompositeMode* value
        );

        [VtblIndex(17)]
        HRESULT put_CompositeMode(
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionCompositeMode")]
                CompositionCompositeMode value
        );

        [VtblIndex(18)]
        HRESULT get_IsVisible([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(19)]
        HRESULT put_IsVisible([NativeTypeName("boolean")] byte value);

        [VtblIndex(20)]
        HRESULT get_Offset(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
        );

        [VtblIndex(21)]
        HRESULT put_Offset(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
        );

        [VtblIndex(22)]
        HRESULT get_Opacity(float* value);

        [VtblIndex(23)]
        HRESULT put_Opacity(float value);

        [VtblIndex(24)]
        HRESULT get_Orientation(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value
        );

        [VtblIndex(25)]
        HRESULT put_Orientation(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value
        );

        [VtblIndex(26)]
        HRESULT get_Parent(
            [NativeTypeName("ABI::Windows::UI::Composition::IContainerVisual **")]
                IContainerVisual* value
        );

        [VtblIndex(27)]
        HRESULT get_RotationAngle(float* value);

        [VtblIndex(28)]
        HRESULT put_RotationAngle(float value);

        [VtblIndex(29)]
        HRESULT get_RotationAngleInDegrees(float* value);

        [VtblIndex(30)]
        HRESULT put_RotationAngleInDegrees(float value);

        [VtblIndex(31)]
        HRESULT get_RotationAxis(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
        );

        [VtblIndex(32)]
        HRESULT put_RotationAxis(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
        );

        [VtblIndex(33)]
        HRESULT get_Scale(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
        );

        [VtblIndex(34)]
        HRESULT put_Scale(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
        );

        [VtblIndex(35)]
        HRESULT get_Size(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(36)]
        HRESULT put_Size(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
        );

        [VtblIndex(37)]
        HRESULT get_TransformMatrix(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4 *")] Matrix4x4* value
        );

        [VtblIndex(38)]
        HRESULT put_TransformMatrix(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4")] Matrix4x4 value
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
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_AnchorPoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2, int> put_AnchorPoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionBackfaceVisibility *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CompositionBackfaceVisibility*,
            int> get_BackfaceVisibility;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionBackfaceVisibility) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CompositionBackfaceVisibility,
            int> put_BackfaceVisibility;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionBorderMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionBorderMode*, int> get_BorderMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionBorderMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionBorderMode, int> put_BorderMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3*, int> get_CenterPoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3, int> put_CenterPoint;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionClip **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionClip*, int> get_Clip;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::ICompositionClip *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICompositionClip, int> put_Clip;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionCompositeMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionCompositeMode*, int> get_CompositeMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::CompositionCompositeMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, CompositionCompositeMode, int> put_CompositeMode;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsVisible;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsVisible;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3*, int> get_Offset;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3, int> put_Offset;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_Opacity;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_Opacity;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Quaternion *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Quaternion*, int> get_Orientation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Quaternion) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Quaternion, int> put_Orientation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IContainerVisual **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IContainerVisual*, int> get_Parent;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_RotationAngle;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_RotationAngle;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_RotationAngleInDegrees;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_RotationAngleInDegrees;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3*, int> get_RotationAxis;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3, int> put_RotationAxis;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3*, int> get_Scale;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3, int> put_Scale;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_Size;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2, int> put_Size;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Matrix4x4 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Matrix4x4*, int> get_TransformMatrix;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Matrix4x4) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Matrix4x4, int> put_TransformMatrix;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVisual"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVisual(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVisual"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVisual(Silk.NET.WinRT.IInspectable value)
    {
        return new IVisual(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVisual"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVisual"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IVisual value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVisual"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVisual(Silk.NET.Windows.IUnknown value)
    {
        return new IVisual(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVisual"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVisual"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVisual value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
