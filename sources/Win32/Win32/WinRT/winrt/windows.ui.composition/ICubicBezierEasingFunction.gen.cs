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

[Guid("32350666-C1E8-44F9-96B8-C98ACF0AE698")]
[NativeTypeName("struct ICubicBezierEasingFunction : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICubicBezierEasingFunction
    : ICubicBezierEasingFunction.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICubicBezierEasingFunction));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICubicBezierEasingFunction, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICubicBezierEasingFunction, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICubicBezierEasingFunction, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICubicBezierEasingFunction, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICubicBezierEasingFunction, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICubicBezierEasingFunction, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ControlPoint1(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<ICubicBezierEasingFunction, Vector2*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ControlPoint2(
        [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
    )
    {
        return ((delegate* unmanaged<ICubicBezierEasingFunction, Vector2*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ControlPoint1(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
        );

        [VtblIndex(7)]
        HRESULT get_ControlPoint2(
            [NativeTypeName("ABI::Windows::Foundation::Numerics::Vector2 *")] Vector2* value
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
        public delegate* unmanaged<TSelf*, Vector2*, int> get_ControlPoint1;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Numerics::Vector2 *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Vector2*, int> get_ControlPoint2;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICubicBezierEasingFunction"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICubicBezierEasingFunction(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICubicBezierEasingFunction"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICubicBezierEasingFunction(Silk.NET.WinRT.IInspectable value)
    {
        return new ICubicBezierEasingFunction(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICubicBezierEasingFunction"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICubicBezierEasingFunction"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICubicBezierEasingFunction value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICubicBezierEasingFunction"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICubicBezierEasingFunction(Silk.NET.Windows.IUnknown value)
    {
        return new ICubicBezierEasingFunction(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICubicBezierEasingFunction"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICubicBezierEasingFunction"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICubicBezierEasingFunction value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
