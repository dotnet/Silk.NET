// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IUIAnimationTransition2.xml' path='doc/member[@name="IUIAnimationTransition2"]/*'/>
[Guid("62FF9123-A85A-4E9B-A218-435A93E268FD")]
[NativeTypeName("struct IUIAnimationTransition2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationTransition2 : IUIAnimationTransition2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationTransition2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationTransition2*, Guid*, void**, int> )(lpVtbl[0]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationTransition2*, uint> )(lpVtbl[1]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationTransition2*, uint> )(lpVtbl[2]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTransition2.xml' path='doc/member[@name="IUIAnimationTransition2.GetDimension"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDimension(uint* dimension)
    {
        return ((delegate* unmanaged<IUIAnimationTransition2*, uint*, int> )(lpVtbl[3]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), dimension);
    }

    /// <include file='IUIAnimationTransition2.xml' path='doc/member[@name="IUIAnimationTransition2.SetInitialValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetInitialValue(double value)
    {
        return ((delegate* unmanaged<IUIAnimationTransition2*, double, int> )(lpVtbl[4]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUIAnimationTransition2.xml' path='doc/member[@name="IUIAnimationTransition2.SetInitialVectorValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetInitialVectorValue([NativeTypeName("const DOUBLE *")] double* value, uint cDimension)
    {
        return ((delegate* unmanaged<IUIAnimationTransition2*, double*, uint, int> )(lpVtbl[5]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), value, cDimension);
    }

    /// <include file='IUIAnimationTransition2.xml' path='doc/member[@name="IUIAnimationTransition2.SetInitialVelocity"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetInitialVelocity(double velocity)
    {
        return ((delegate* unmanaged<IUIAnimationTransition2*, double, int> )(lpVtbl[6]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), velocity);
    }

    /// <include file='IUIAnimationTransition2.xml' path='doc/member[@name="IUIAnimationTransition2.SetInitialVectorVelocity"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetInitialVectorVelocity([NativeTypeName("const DOUBLE *")] double* velocity, uint cDimension)
    {
        return ((delegate* unmanaged<IUIAnimationTransition2*, double*, uint, int> )(lpVtbl[7]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), velocity, cDimension);
    }

    /// <include file='IUIAnimationTransition2.xml' path='doc/member[@name="IUIAnimationTransition2.IsDurationKnown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT IsDurationKnown()
    {
        return ((delegate* unmanaged<IUIAnimationTransition2*, int> )(lpVtbl[8]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTransition2.xml' path='doc/member[@name="IUIAnimationTransition2.GetDuration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDuration([NativeTypeName("UI_ANIMATION_SECONDS *")] double* duration)
    {
        return ((delegate* unmanaged<IUIAnimationTransition2*, double*, int> )(lpVtbl[9]))((IUIAnimationTransition2*)Unsafe.AsPointer(ref this), duration);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDimension(uint* dimension);
        [VtblIndex(4)]
        HRESULT SetInitialValue(double value);
        [VtblIndex(5)]
        HRESULT SetInitialVectorValue([NativeTypeName("const DOUBLE *")] double* value, uint cDimension);
        [VtblIndex(6)]
        HRESULT SetInitialVelocity(double velocity);
        [VtblIndex(7)]
        HRESULT SetInitialVectorVelocity([NativeTypeName("const DOUBLE *")] double* velocity, uint cDimension);
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
}