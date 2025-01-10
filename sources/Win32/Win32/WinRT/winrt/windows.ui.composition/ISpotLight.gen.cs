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

[Guid("5A9FE273-44A1-4F95-A422-8FA5116BDB44")]
[NativeTypeName("struct ISpotLight : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpotLight : ISpotLight.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpotLight));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpotLight, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpotLight, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpotLight, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISpotLight, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpotLight, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISpotLight, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ConstantAttenuation(float* value)
    {
        return ((delegate* unmanaged<ISpotLight, float*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ConstantAttenuation(float value)
    {
        return ((delegate* unmanaged<ISpotLight, float, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_CoordinateSpace(
        [NativeTypeName("ABI::Windows::UI::Composition::IVisual **")] IVisual* value
    )
    {
        return ((delegate* unmanaged<ISpotLight, IVisual*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CoordinateSpace(
        [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual value
    )
    {
        return ((delegate* unmanaged<ISpotLight, IVisual, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Direction(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
    )
    {
        return ((delegate* unmanaged<ISpotLight, Vector3*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Direction(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
    )
    {
        return ((delegate* unmanaged<ISpotLight, Vector3, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_InnerConeAngle(float* value)
    {
        return ((delegate* unmanaged<ISpotLight, float*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_InnerConeAngle(float value)
    {
        return ((delegate* unmanaged<ISpotLight, float, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_InnerConeAngleInDegrees(float* value)
    {
        return ((delegate* unmanaged<ISpotLight, float*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_InnerConeAngleInDegrees(float value)
    {
        return ((delegate* unmanaged<ISpotLight, float, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_InnerConeColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<ISpotLight, Color*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_InnerConeColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<ISpotLight, Color, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_LinearAttenuation(float* value)
    {
        return ((delegate* unmanaged<ISpotLight, float*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_LinearAttenuation(float value)
    {
        return ((delegate* unmanaged<ISpotLight, float, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Offset(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
    )
    {
        return ((delegate* unmanaged<ISpotLight, Vector3*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT put_Offset(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
    )
    {
        return ((delegate* unmanaged<ISpotLight, Vector3, int>)((*lpVtbl)[21]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_OuterConeAngle(float* value)
    {
        return ((delegate* unmanaged<ISpotLight, float*, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_OuterConeAngle(float value)
    {
        return ((delegate* unmanaged<ISpotLight, float, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_OuterConeAngleInDegrees(float* value)
    {
        return ((delegate* unmanaged<ISpotLight, float*, int>)((*lpVtbl)[24]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT put_OuterConeAngleInDegrees(float value)
    {
        return ((delegate* unmanaged<ISpotLight, float, int>)((*lpVtbl)[25]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_OuterConeColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value)
    {
        return ((delegate* unmanaged<ISpotLight, Color*, int>)((*lpVtbl)[26]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_OuterConeColor([NativeTypeName("ABI::Windows::UI::Color")] Color value)
    {
        return ((delegate* unmanaged<ISpotLight, Color, int>)((*lpVtbl)[27]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_QuadraticAttenuation(float* value)
    {
        return ((delegate* unmanaged<ISpotLight, float*, int>)((*lpVtbl)[28]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT put_QuadraticAttenuation(float value)
    {
        return ((delegate* unmanaged<ISpotLight, float, int>)((*lpVtbl)[29]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ConstantAttenuation(float* value);

        [VtblIndex(7)]
        HRESULT put_ConstantAttenuation(float value);

        [VtblIndex(8)]
        HRESULT get_CoordinateSpace(
            [NativeTypeName("ABI::Windows::UI::Composition::IVisual **")] IVisual* value
        );

        [VtblIndex(9)]
        HRESULT put_CoordinateSpace(
            [NativeTypeName("ABI::Windows::UI::Composition::IVisual *")] IVisual value
        );

        [VtblIndex(10)]
        HRESULT get_Direction(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
        );

        [VtblIndex(11)]
        HRESULT put_Direction(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
        );

        [VtblIndex(12)]
        HRESULT get_InnerConeAngle(float* value);

        [VtblIndex(13)]
        HRESULT put_InnerConeAngle(float value);

        [VtblIndex(14)]
        HRESULT get_InnerConeAngleInDegrees(float* value);

        [VtblIndex(15)]
        HRESULT put_InnerConeAngleInDegrees(float value);

        [VtblIndex(16)]
        HRESULT get_InnerConeColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(17)]
        HRESULT put_InnerConeColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(18)]
        HRESULT get_LinearAttenuation(float* value);

        [VtblIndex(19)]
        HRESULT put_LinearAttenuation(float value);

        [VtblIndex(20)]
        HRESULT get_Offset(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value
        );

        [VtblIndex(21)]
        HRESULT put_Offset(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
        );

        [VtblIndex(22)]
        HRESULT get_OuterConeAngle(float* value);

        [VtblIndex(23)]
        HRESULT put_OuterConeAngle(float value);

        [VtblIndex(24)]
        HRESULT get_OuterConeAngleInDegrees(float* value);

        [VtblIndex(25)]
        HRESULT put_OuterConeAngleInDegrees(float value);

        [VtblIndex(26)]
        HRESULT get_OuterConeColor([NativeTypeName("ABI::Windows::UI::Color *")] Color* value);

        [VtblIndex(27)]
        HRESULT put_OuterConeColor([NativeTypeName("ABI::Windows::UI::Color")] Color value);

        [VtblIndex(28)]
        HRESULT get_QuadraticAttenuation(float* value);

        [VtblIndex(29)]
        HRESULT put_QuadraticAttenuation(float value);
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

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_ConstantAttenuation;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_ConstantAttenuation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IVisual **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVisual*, int> get_CoordinateSpace;

        [NativeTypeName(
            "HRESULT (ABI::Windows::UI::Composition::IVisual *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVisual, int> put_CoordinateSpace;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3*, int> get_Direction;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3, int> put_Direction;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_InnerConeAngle;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_InnerConeAngle;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_InnerConeAngleInDegrees;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_InnerConeAngleInDegrees;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_InnerConeColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color, int> put_InnerConeColor;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_LinearAttenuation;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_LinearAttenuation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3*, int> get_Offset;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector3, int> put_Offset;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_OuterConeAngle;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_OuterConeAngle;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_OuterConeAngleInDegrees;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_OuterConeAngleInDegrees;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color*, int> get_OuterConeColor;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Color, int> put_OuterConeColor;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_QuadraticAttenuation;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_QuadraticAttenuation;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpotLight"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpotLight(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpotLight"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpotLight(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpotLight(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpotLight"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpotLight"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpotLight value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpotLight"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpotLight(Silk.NET.Windows.IUnknown value)
    {
        return new ISpotLight(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpotLight"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpotLight"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpotLight value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
