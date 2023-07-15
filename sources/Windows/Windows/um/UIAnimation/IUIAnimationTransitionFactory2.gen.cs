// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IUIAnimationTransitionFactory2.xml' path='doc/member[@name="IUIAnimationTransitionFactory2"]/*'/>
[Guid("937D4916-C1A6-42D5-88D8-30344D6EFE31")]
[NativeTypeName("struct IUIAnimationTransitionFactory2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationTransitionFactory2 : IUIAnimationTransitionFactory2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationTransitionFactory2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionFactory2*, Guid*, void**, int> )(lpVtbl[0]))((IUIAnimationTransitionFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationTransitionFactory2*, uint> )(lpVtbl[1]))((IUIAnimationTransitionFactory2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationTransitionFactory2*, uint> )(lpVtbl[2]))((IUIAnimationTransitionFactory2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationTransitionFactory2.xml' path='doc/member[@name="IUIAnimationTransitionFactory2.CreateTransition"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateTransition(IUIAnimationInterpolator2* interpolator, IUIAnimationTransition2** transition)
    {
        return ((delegate* unmanaged<IUIAnimationTransitionFactory2*, IUIAnimationInterpolator2*, IUIAnimationTransition2**, int> )(lpVtbl[3]))((IUIAnimationTransitionFactory2*)Unsafe.AsPointer(ref this), interpolator, transition);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateTransition(IUIAnimationInterpolator2* interpolator, IUIAnimationTransition2** transition);
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
        [NativeTypeName("HRESULT (IUIAnimationInterpolator2 *, IUIAnimationTransition2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationInterpolator2*, IUIAnimationTransition2**, int> CreateTransition;
    }
}