// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IUIAnimationTransition.xml' path='doc/member[@name="IUIAnimationTransition"]/*'/>
[Guid("DC6CE252-F731-41CF-B610-614B6CA049AD")]
[NativeTypeName("struct IUIAnimationTransition : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationTransition : IUIAnimationTransition.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationTransition));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationTransition*, Guid*, void**, int> )(lpVtbl[0]))((IUIAnimationTransition*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationTransition*, uint> )(lpVtbl[1]))((IUIAnimationTransition*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationTransition*, uint> )(lpVtbl[2]))((IUIAnimationTransition*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTransition.xml' path='doc/member[@name="IUIAnimationTransition.SetInitialValue"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInitialValue(double value)
    {
        return ((delegate* unmanaged<IUIAnimationTransition*, double, int> )(lpVtbl[3]))((IUIAnimationTransition*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IUIAnimationTransition.xml' path='doc/member[@name="IUIAnimationTransition.SetInitialVelocity"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetInitialVelocity(double velocity)
    {
        return ((delegate* unmanaged<IUIAnimationTransition*, double, int> )(lpVtbl[4]))((IUIAnimationTransition*)Unsafe.AsPointer(ref this), velocity);
    }

    /// <include file='IUIAnimationTransition.xml' path='doc/member[@name="IUIAnimationTransition.IsDurationKnown"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsDurationKnown()
    {
        return ((delegate* unmanaged<IUIAnimationTransition*, int> )(lpVtbl[5]))((IUIAnimationTransition*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTransition.xml' path='doc/member[@name="IUIAnimationTransition.GetDuration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDuration([NativeTypeName("UI_ANIMATION_SECONDS *")] double* duration)
    {
        return ((delegate* unmanaged<IUIAnimationTransition*, double*, int> )(lpVtbl[6]))((IUIAnimationTransition*)Unsafe.AsPointer(ref this), duration);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetInitialValue(double value);
        [VtblIndex(4)]
        HRESULT SetInitialVelocity(double velocity);
        [VtblIndex(5)]
        HRESULT IsDurationKnown();
        [VtblIndex(6)]
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
        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetInitialValue;
        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> SetInitialVelocity;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDurationKnown;
        [NativeTypeName("HRESULT (UI_ANIMATION_SECONDS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetDuration;
    }
}