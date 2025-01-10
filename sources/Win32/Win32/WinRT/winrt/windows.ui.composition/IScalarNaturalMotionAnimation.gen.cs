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

[Guid("94A94581-BF92-495B-B5BD-D2C659430737")]
[NativeTypeName("struct IScalarNaturalMotionAnimation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IScalarNaturalMotionAnimation
    : IScalarNaturalMotionAnimation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IScalarNaturalMotionAnimation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IScalarNaturalMotionAnimation, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IScalarNaturalMotionAnimation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IScalarNaturalMotionAnimation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IScalarNaturalMotionAnimation, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IScalarNaturalMotionAnimation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IScalarNaturalMotionAnimation, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_FinalValue(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")]
            IReference<float>** value
    )
    {
        return (
            (delegate* unmanaged<IScalarNaturalMotionAnimation, IReference<float>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_FinalValue(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t *")]
            IReference<float>* value
    )
    {
        return (
            (delegate* unmanaged<IScalarNaturalMotionAnimation, IReference<float>*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InitialValue(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")]
            IReference<float>** value
    )
    {
        return (
            (delegate* unmanaged<IScalarNaturalMotionAnimation, IReference<float>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_InitialValue(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t *")]
            IReference<float>* value
    )
    {
        return (
            (delegate* unmanaged<IScalarNaturalMotionAnimation, IReference<float>*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_InitialVelocity(float* value)
    {
        return ((delegate* unmanaged<IScalarNaturalMotionAnimation, float*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_InitialVelocity(float value)
    {
        return ((delegate* unmanaged<IScalarNaturalMotionAnimation, float, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_FinalValue(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")]
                IReference<float>** value
        );

        [VtblIndex(7)]
        HRESULT put_FinalValue(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t *")]
                IReference<float>* value
        );

        [VtblIndex(8)]
        HRESULT get_InitialValue(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t **")]
                IReference<float>** value
        );

        [VtblIndex(9)]
        HRESULT put_InitialValue(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_float_t *")]
                IReference<float>* value
        );

        [VtblIndex(10)]
        HRESULT get_InitialVelocity(float* value);

        [VtblIndex(11)]
        HRESULT put_InitialVelocity(float value);
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
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<float>**, int> get_FinalValue;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<float>*, int> put_FinalValue;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<float>**, int> get_InitialValue;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_float_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<float>*, int> put_InitialValue;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> get_InitialVelocity;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> put_InitialVelocity;
    }

    /// <summary>Initializes a new instance of the <see cref = "IScalarNaturalMotionAnimation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IScalarNaturalMotionAnimation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IScalarNaturalMotionAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IScalarNaturalMotionAnimation(Silk.NET.WinRT.IInspectable value)
    {
        return new IScalarNaturalMotionAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IScalarNaturalMotionAnimation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IScalarNaturalMotionAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IScalarNaturalMotionAnimation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IScalarNaturalMotionAnimation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IScalarNaturalMotionAnimation(Silk.NET.Windows.IUnknown value)
    {
        return new IScalarNaturalMotionAnimation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IScalarNaturalMotionAnimation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IScalarNaturalMotionAnimation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IScalarNaturalMotionAnimation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
