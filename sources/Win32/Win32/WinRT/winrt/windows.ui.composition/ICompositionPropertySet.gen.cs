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

[Guid("C9D6D202-5F67-4453-9117-9EADD430D3C2")]
[NativeTypeName("struct ICompositionPropertySet : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionPropertySet
    : ICompositionPropertySet.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionPropertySet));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionPropertySet, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositionPropertySet, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionPropertySet, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositionPropertySet, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionPropertySet, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionPropertySet, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InsertColor(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::UI::Color")] Color value
    )
    {
        return ((delegate* unmanaged<ICompositionPropertySet, HSTRING, Color, int>)((*lpVtbl)[6]))(
            this,
            propertyName,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT InsertMatrix3x2(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2")] Matrix3x2 value
    )
    {
        return (
            (delegate* unmanaged<ICompositionPropertySet, HSTRING, Matrix3x2, int>)((*lpVtbl)[7])
        )(this, propertyName, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InsertMatrix4x4(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4")] Matrix4x4 value
    )
    {
        return (
            (delegate* unmanaged<ICompositionPropertySet, HSTRING, Matrix4x4, int>)((*lpVtbl)[8])
        )(this, propertyName, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT InsertQuaternion(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value
    )
    {
        return (
            (delegate* unmanaged<ICompositionPropertySet, HSTRING, Quaternion, int>)((*lpVtbl)[9])
        )(this, propertyName, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT InsertScalar(HSTRING propertyName, float value)
    {
        return ((delegate* unmanaged<ICompositionPropertySet, HSTRING, float, int>)((*lpVtbl)[10]))(
            this,
            propertyName,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT InsertVector2(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
    )
    {
        return (
            (delegate* unmanaged<ICompositionPropertySet, HSTRING, Vector2, int>)((*lpVtbl)[11])
        )(this, propertyName, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT InsertVector3(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
    )
    {
        return (
            (delegate* unmanaged<ICompositionPropertySet, HSTRING, Vector3, int>)((*lpVtbl)[12])
        )(this, propertyName, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT InsertVector4(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector4")] Vector4 value
    )
    {
        return (
            (delegate* unmanaged<ICompositionPropertySet, HSTRING, Vector4, int>)((*lpVtbl)[13])
        )(this, propertyName, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT TryGetColor(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::UI::Color *")] Color* value,
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
            CompositionGetValueStatus* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionPropertySet,
                HSTRING,
                Color*,
                CompositionGetValueStatus*,
                int>)((*lpVtbl)[14])
        )(this, propertyName, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT TryGetMatrix3x2(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2 *")] Matrix3x2* value,
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
            CompositionGetValueStatus* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionPropertySet,
                HSTRING,
                Matrix3x2*,
                CompositionGetValueStatus*,
                int>)((*lpVtbl)[15])
        )(this, propertyName, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT TryGetMatrix4x4(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4 *")] Matrix4x4* value,
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
            CompositionGetValueStatus* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionPropertySet,
                HSTRING,
                Matrix4x4*,
                CompositionGetValueStatus*,
                int>)((*lpVtbl)[16])
        )(this, propertyName, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT TryGetQuaternion(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value,
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
            CompositionGetValueStatus* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionPropertySet,
                HSTRING,
                Quaternion*,
                CompositionGetValueStatus*,
                int>)((*lpVtbl)[17])
        )(this, propertyName, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT TryGetScalar(
        HSTRING propertyName,
        float* value,
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
            CompositionGetValueStatus* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionPropertySet,
                HSTRING,
                float*,
                CompositionGetValueStatus*,
                int>)((*lpVtbl)[18])
        )(this, propertyName, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT TryGetVector2(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value,
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
            CompositionGetValueStatus* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionPropertySet,
                HSTRING,
                Vector2*,
                CompositionGetValueStatus*,
                int>)((*lpVtbl)[19])
        )(this, propertyName, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT TryGetVector3(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value,
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
            CompositionGetValueStatus* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionPropertySet,
                HSTRING,
                Vector3*,
                CompositionGetValueStatus*,
                int>)((*lpVtbl)[20])
        )(this, propertyName, value, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT TryGetVector4(
        HSTRING propertyName,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector4 *")] Vector4* value,
        [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
            CompositionGetValueStatus* result
    )
    {
        return (
            (delegate* unmanaged<
                ICompositionPropertySet,
                HSTRING,
                Vector4*,
                CompositionGetValueStatus*,
                int>)((*lpVtbl)[21])
        )(this, propertyName, value, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT InsertColor(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::UI::Color")] Color value
        );

        [VtblIndex(7)]
        HRESULT InsertMatrix3x2(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2")] Matrix3x2 value
        );

        [VtblIndex(8)]
        HRESULT InsertMatrix4x4(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4")] Matrix4x4 value
        );

        [VtblIndex(9)]
        HRESULT InsertQuaternion(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value
        );

        [VtblIndex(10)]
        HRESULT InsertScalar(HSTRING propertyName, float value);

        [VtblIndex(11)]
        HRESULT InsertVector2(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
        );

        [VtblIndex(12)]
        HRESULT InsertVector3(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
        );

        [VtblIndex(13)]
        HRESULT InsertVector4(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector4")] Vector4 value
        );

        [VtblIndex(14)]
        HRESULT TryGetColor(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::UI::Color *")] Color* value,
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
                CompositionGetValueStatus* result
        );

        [VtblIndex(15)]
        HRESULT TryGetMatrix3x2(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2 *")] Matrix3x2* value,
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
                CompositionGetValueStatus* result
        );

        [VtblIndex(16)]
        HRESULT TryGetMatrix4x4(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4 *")] Matrix4x4* value,
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
                CompositionGetValueStatus* result
        );

        [VtblIndex(17)]
        HRESULT TryGetQuaternion(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion *")] Quaternion* value,
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
                CompositionGetValueStatus* result
        );

        [VtblIndex(18)]
        HRESULT TryGetScalar(
            HSTRING propertyName,
            float* value,
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
                CompositionGetValueStatus* result
        );

        [VtblIndex(19)]
        HRESULT TryGetVector2(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value,
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
                CompositionGetValueStatus* result
        );

        [VtblIndex(20)]
        HRESULT TryGetVector3(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3 *")] Vector3* value,
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
                CompositionGetValueStatus* result
        );

        [VtblIndex(21)]
        HRESULT TryGetVector4(
            HSTRING propertyName,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector4 *")] Vector4* value,
            [NativeTypeName("ABI::Windows::UI::Composition::CompositionGetValueStatus *")]
                CompositionGetValueStatus* result
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

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, Color, int> InsertColor;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Matrix3x2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, Matrix3x2, int> InsertMatrix3x2;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Matrix4x4) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, Matrix4x4, int> InsertMatrix4x4;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Quaternion) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, Quaternion, int> InsertQuaternion;

        [NativeTypeName("HRESULT (HSTRING, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, float, int> InsertScalar;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, Vector2, int> InsertVector2;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, Vector3, int> InsertVector3;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector4) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, Vector4, int> InsertVector4;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::UI::Color *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            Color*,
            CompositionGetValueStatus*,
            int> TryGetColor;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Matrix3x2 *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            Matrix3x2*,
            CompositionGetValueStatus*,
            int> TryGetMatrix3x2;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Matrix4x4 *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            Matrix4x4*,
            CompositionGetValueStatus*,
            int> TryGetMatrix4x4;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Quaternion *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            Quaternion*,
            CompositionGetValueStatus*,
            int> TryGetQuaternion;

        [NativeTypeName(
            "HRESULT (HSTRING, FLOAT *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            float*,
            CompositionGetValueStatus*,
            int> TryGetScalar;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector2 *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            Vector2*,
            CompositionGetValueStatus*,
            int> TryGetVector2;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector3 *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            Vector3*,
            CompositionGetValueStatus*,
            int> TryGetVector3;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector4 *, ABI::Windows::UI::Composition::CompositionGetValueStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            Vector4*,
            CompositionGetValueStatus*,
            int> TryGetVector4;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionPropertySet"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionPropertySet(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionPropertySet"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionPropertySet(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionPropertySet(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionPropertySet"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionPropertySet"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionPropertySet value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionPropertySet"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionPropertySet(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionPropertySet(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionPropertySet"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionPropertySet"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionPropertySet value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
