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

[Guid("A7929A74-E6B2-4BD6-8B95-4040119CA34D")]
[NativeTypeName("struct IDCompositionEffectGroup : IDCompositionEffect")]
[NativeInheritance("IDCompositionEffect")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionEffectGroup
    : IDCompositionEffectGroup.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionEffectGroup));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionEffectGroup, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDCompositionEffectGroup, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionEffectGroup, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetOpacity(IDCompositionAnimation animation)
    {
        return (
            (delegate* unmanaged<IDCompositionEffectGroup, IDCompositionAnimation, int>)(
                (*lpVtbl)[3]
            )
        )(this, animation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOpacity(float opacity)
    {
        return ((delegate* unmanaged<IDCompositionEffectGroup, float, int>)((*lpVtbl)[4]))(
            this,
            opacity
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetTransform3D(IDCompositionTransform3D transform3D)
    {
        return (
            (delegate* unmanaged<IDCompositionEffectGroup, IDCompositionTransform3D, int>)(
                (*lpVtbl)[5]
            )
        )(this, transform3D);
    }

    public interface Interface : IDCompositionEffect.Interface
    {
        [VtblIndex(3)]
        HRESULT SetOpacity(IDCompositionAnimation animation);

        [VtblIndex(4)]
        HRESULT SetOpacity(float opacity);

        [VtblIndex(5)]
        HRESULT SetTransform3D(IDCompositionTransform3D transform3D);
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
        public delegate* unmanaged<TSelf*, IDCompositionAnimation, int> SetOpacity;

        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetOpacity1;

        [NativeTypeName(
            "HRESULT (IDCompositionTransform3D *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDCompositionTransform3D, int> SetTransform3D;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionEffectGroup"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionEffectGroup(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> to <see cref = "IDCompositionEffectGroup"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDCompositionEffect"/> instance to be converted </param>
    public static explicit operator IDCompositionEffectGroup(
        Silk.NET.DirectX.IDCompositionEffect value
    )
    {
        return new IDCompositionEffectGroup(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionEffectGroup"/> to <see cref = "Silk.NET.DirectX.IDCompositionEffect"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionEffectGroup"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDCompositionEffect(
        IDCompositionEffectGroup value
    )
    {
        return new Silk.NET.DirectX.IDCompositionEffect(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionEffectGroup"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionEffectGroup(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionEffectGroup(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionEffectGroup"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionEffectGroup"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionEffectGroup value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
