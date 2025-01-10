// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("641ED83C-AE96-46C5-90DC-32774CC5C6D5")]
[NativeTypeName("struct IDCompositionRotateTransform : IDCompositionTransform")]
[NativeInheritance("IDCompositionTransform")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionRotateTransform
    : IDCompositionRotateTransform.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionRotateTransform));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionRotateTransform, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAngle(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRotateTransform, IDCompositionAnimation, int>)(
                (*lpVtbl)[3]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetAngle(float angle)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform, float, int>)((*lpVtbl)[4]))(
            this,
            angle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetCenterX(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRotateTransform, IDCompositionAnimation, int>)(
                (*lpVtbl)[5]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetCenterX(float centerX)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform, float, int>)((*lpVtbl)[6]))(
            this,
            centerX
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetCenterY(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionRotateTransform, IDCompositionAnimation, int>)(
                (*lpVtbl)[7]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetCenterY(float centerY)
    {
        return ((delegate* unmanaged<IDCompositionRotateTransform, float, int>)((*lpVtbl)[8]))(
            this,
            centerY
        );
    }

    public interface Interface : IDCompositionTransform.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAngle(IDCompositionAnimation animation);

        [VtblIndex(4)]
        HRESULT SetAngle(float angle);

        [VtblIndex(5)]
        HRESULT SetCenterX(IDCompositionAnimation animation);

        [VtblIndex(6)]
        HRESULT SetCenterX(float centerX);

        [VtblIndex(7)]
        HRESULT SetCenterY(IDCompositionAnimation animation);

        [VtblIndex(8)]
        HRESULT SetCenterY(float centerY);
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

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetAngle;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetAngle1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetCenterX;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCenterX1;

        [NativeTypeName(
            "HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetCenterY;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetCenterY1;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionRotateTransform"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionRotateTransform(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionTransform"/> to <see cref = "IDCompositionRotateTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionTransform"/> instance to be converted </param>
    public static explicit operator IDCompositionRotateTransform(
        Silk.NET.DirectX.IDCompositionTransform value
    )
    {
        return new IDCompositionRotateTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionRotateTransform"/> to <see cref = "Silk.NET.DirectX.IDCompositionTransform"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionRotateTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionTransform(
        IDCompositionRotateTransform value
    )
    {
        return new Silk.NET.DirectX.IDCompositionTransform(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionTransform3D"/> to <see cref = "IDCompositionRotateTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionTransform3D"/> instance to be converted </param>
    public static explicit operator IDCompositionRotateTransform(
        Silk.NET.DirectX.IDCompositionTransform3D value
    )
    {
        return new IDCompositionRotateTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionRotateTransform"/> to <see cref = "Silk.NET.DirectX.IDCompositionTransform3D"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionRotateTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionTransform3D(
        IDCompositionRotateTransform value
    )
    {
        return new Silk.NET.DirectX.IDCompositionTransform3D(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> to <see cref = "IDCompositionRotateTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionRotateTransform(
        Silk.NET.DirectX.IDCompositionEffect value
    )
    {
        return new IDCompositionRotateTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionRotateTransform"/> to <see cref = "Silk.NET.DirectX.IDCompositionEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionRotateTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionEffect(
        IDCompositionRotateTransform value
    )
    {
        return new Silk.NET.DirectX.IDCompositionEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionRotateTransform"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionRotateTransform(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionRotateTransform(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionRotateTransform"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionRotateTransform"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionRotateTransform value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
