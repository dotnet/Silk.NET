// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("62FF9123-A85A-4E9B-A218-435A93E268FD")]
[NativeTypeName("struct IUIAnimationTransition2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationTransition2
    : IUIAnimationTransition2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationTransition2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationTransition2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUIAnimationTransition2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationTransition2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDimension(uint* dimension)
    {
        return ((delegate* unmanaged<IUIAnimationTransition2, uint*, int>)((*lpVtbl)[3]))(
            this,
            dimension
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetInitialValue(double value)
    {
        return ((delegate* unmanaged<IUIAnimationTransition2, double, int>)((*lpVtbl)[4]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetInitialVectorValue(
        [NativeTypeName("const DOUBLE *")] double* value,
        uint cDimension
    )
    {
        return ((delegate* unmanaged<IUIAnimationTransition2, double*, uint, int>)((*lpVtbl)[5]))(
            this,
            value,
            cDimension
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetInitialVelocity(double velocity)
    {
        return ((delegate* unmanaged<IUIAnimationTransition2, double, int>)((*lpVtbl)[6]))(
            this,
            velocity
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetInitialVectorVelocity(
        [NativeTypeName("const DOUBLE *")] double* velocity,
        uint cDimension
    )
    {
        return ((delegate* unmanaged<IUIAnimationTransition2, double*, uint, int>)((*lpVtbl)[7]))(
            this,
            velocity,
            cDimension
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsDurationKnown()
    {
        return ((delegate* unmanaged<IUIAnimationTransition2, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDuration([NativeTypeName("UI_ANIMATION_SECONDS *")] double* duration)
    {
        return ((delegate* unmanaged<IUIAnimationTransition2, double*, int>)((*lpVtbl)[9]))(
            this,
            duration
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDimension(uint* dimension);

        [VtblIndex(4)]
        HRESULT SetInitialValue(double value);

        [VtblIndex(5)]
        HRESULT SetInitialVectorValue(
            [NativeTypeName("const DOUBLE *")] double* value,
            uint cDimension
        );

        [VtblIndex(6)]
        HRESULT SetInitialVelocity(double velocity);

        [VtblIndex(7)]
        HRESULT SetInitialVectorVelocity(
            [NativeTypeName("const DOUBLE *")] double* velocity,
            uint cDimension
        );

        [VtblIndex(8)]
        HRESULT IsDurationKnown();

        [VtblIndex(9)]
        HRESULT GetDuration([NativeTypeName("UI_ANIMATION_SECONDS *")] double* duration);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetDimension;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetInitialValue;

        [NativeTypeName("HRESULT (const DOUBLE *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, uint, int> SetInitialVectorValue;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetInitialVelocity;

        [NativeTypeName("HRESULT (const DOUBLE *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, uint, int> SetInitialVectorVelocity;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDurationKnown;

        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetDuration;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUIAnimationTransition2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUIAnimationTransition2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUIAnimationTransition2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUIAnimationTransition2(Silk.NET.Windows.IUnknown value)
    {
        return new IUIAnimationTransition2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUIAnimationTransition2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUIAnimationTransition2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUIAnimationTransition2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
