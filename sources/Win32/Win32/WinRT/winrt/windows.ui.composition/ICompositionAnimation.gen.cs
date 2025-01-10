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

[Guid("464C4C2C-1CAA-4061-9B40-E13FDE1503CA")]
[NativeTypeName("struct ICompositionAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionAnimation : ICompositionAnimation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionAnimation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositionAnimation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositionAnimation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionAnimation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICompositionAnimation, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICompositionAnimation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICompositionAnimation, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ClearAllParameters()
    {
        return ((delegate* unmanaged<ICompositionAnimation, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ClearParameter(HSTRING key)
    {
        return ((delegate* unmanaged<ICompositionAnimation, HSTRING, int>)((*lpVtbl)[7]))(
            this,
            key
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetColorParameter(
        HSTRING key,
        [NativeTypeName("ABI::Windows::UI::Color")] Color value
    )
    {
        return ((delegate* unmanaged<ICompositionAnimation, HSTRING, Color, int>)((*lpVtbl)[8]))(
            this,
            key,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetMatrix3x2Parameter(
        HSTRING key,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2")] Matrix3x2 value
    )
    {
        return (
            (delegate* unmanaged<ICompositionAnimation, HSTRING, Matrix3x2, int>)((*lpVtbl)[9])
        )(this, key, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetMatrix4x4Parameter(
        HSTRING key,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4")] Matrix4x4 value
    )
    {
        return (
            (delegate* unmanaged<ICompositionAnimation, HSTRING, Matrix4x4, int>)((*lpVtbl)[10])
        )(this, key, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetQuaternionParameter(
        HSTRING key,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value
    )
    {
        return (
            (delegate* unmanaged<ICompositionAnimation, HSTRING, Quaternion, int>)((*lpVtbl)[11])
        )(this, key, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetReferenceParameter(
        HSTRING key,
        [NativeTypeName("ABI::Windows::UI::Composition::ICompositionObject *")]
            ICompositionObject compositionObject
    )
    {
        return (
            (delegate* unmanaged<ICompositionAnimation, HSTRING, ICompositionObject, int>)(
                (*lpVtbl)[12]
            )
        )(this, key, compositionObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetScalarParameter(HSTRING key, float value)
    {
        return ((delegate* unmanaged<ICompositionAnimation, HSTRING, float, int>)((*lpVtbl)[13]))(
            this,
            key,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetVector2Parameter(
        HSTRING key,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
    )
    {
        return ((delegate* unmanaged<ICompositionAnimation, HSTRING, Vector2, int>)((*lpVtbl)[14]))(
            this,
            key,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetVector3Parameter(
        HSTRING key,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
    )
    {
        return ((delegate* unmanaged<ICompositionAnimation, HSTRING, Vector3, int>)((*lpVtbl)[15]))(
            this,
            key,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetVector4Parameter(
        HSTRING key,
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector4")] Vector4 value
    )
    {
        return ((delegate* unmanaged<ICompositionAnimation, HSTRING, Vector4, int>)((*lpVtbl)[16]))(
            this,
            key,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ClearAllParameters();

        [VtblIndex(7)]
        HRESULT ClearParameter(HSTRING key);

        [VtblIndex(8)]
        HRESULT SetColorParameter(
            HSTRING key,
            [NativeTypeName("ABI::Windows::UI::Color")] Color value
        );

        [VtblIndex(9)]
        HRESULT SetMatrix3x2Parameter(
            HSTRING key,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix3x2")] Matrix3x2 value
        );

        [VtblIndex(10)]
        HRESULT SetMatrix4x4Parameter(
            HSTRING key,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Matrix4x4")] Matrix4x4 value
        );

        [VtblIndex(11)]
        HRESULT SetQuaternionParameter(
            HSTRING key,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Quaternion")] Quaternion value
        );

        [VtblIndex(12)]
        HRESULT SetReferenceParameter(
            HSTRING key,
            [NativeTypeName("ABI::Windows::UI::Composition::ICompositionObject *")]
                ICompositionObject compositionObject
        );

        [VtblIndex(13)]
        HRESULT SetScalarParameter(HSTRING key, float value);

        [VtblIndex(14)]
        HRESULT SetVector2Parameter(
            HSTRING key,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2")] Vector2 value
        );

        [VtblIndex(15)]
        HRESULT SetVector3Parameter(
            HSTRING key,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector3")] Vector3 value
        );

        [VtblIndex(16)]
        HRESULT SetVector4Parameter(
            HSTRING key,
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector4")] Vector4 value
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearAllParameters;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> ClearParameter;

        [NativeTypeName("HRESULT (HSTRING, ABI::Windows::UI::Color) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, Color, int> SetColorParameter;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Matrix3x2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, Matrix3x2, int> SetMatrix3x2Parameter;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Matrix4x4) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, Matrix4x4, int> SetMatrix4x4Parameter;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Quaternion) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, Quaternion, int> SetQuaternionParameter;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::UI::Composition::ICompositionObject *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, ICompositionObject, int> SetReferenceParameter;

        [NativeTypeName("HRESULT (HSTRING, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, float, int> SetScalarParameter;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector2) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, Vector2, int> SetVector2Parameter;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector3) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, Vector3, int> SetVector3Parameter;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Numerics::Vector4) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, Vector4, int> SetVector4Parameter;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionAnimation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionAnimation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICompositionAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICompositionAnimation(Silk.NET.WinRT.IInspectable value)
    {
        return new ICompositionAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionAnimation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICompositionAnimation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionAnimation(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositionAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionAnimation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositionAnimation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
