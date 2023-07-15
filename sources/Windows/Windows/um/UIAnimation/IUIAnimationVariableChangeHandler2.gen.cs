// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IUIAnimationVariableChangeHandler2.xml' path='doc/member[@name="IUIAnimationVariableChangeHandler2"]/*'/>
[Guid("63ACC8D2-6EAE-4BB0-B879-586DD8CFBE42")]
[NativeTypeName("struct IUIAnimationVariableChangeHandler2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationVariableChangeHandler2 : IUIAnimationVariableChangeHandler2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationVariableChangeHandler2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationVariableChangeHandler2*, Guid*, void**, int> )(lpVtbl[0]))((IUIAnimationVariableChangeHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationVariableChangeHandler2*, uint> )(lpVtbl[1]))((IUIAnimationVariableChangeHandler2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationVariableChangeHandler2*, uint> )(lpVtbl[2]))((IUIAnimationVariableChangeHandler2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationVariableChangeHandler2.xml' path='doc/member[@name="IUIAnimationVariableChangeHandler2.OnValueChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnValueChanged(IUIAnimationStoryboard2* storyboard, IUIAnimationVariable2* variable, double* newValue, double* previousValue, uint cDimension)
    {
        return ((delegate* unmanaged<IUIAnimationVariableChangeHandler2*, IUIAnimationStoryboard2*, IUIAnimationVariable2*, double*, double*, uint, int> )(lpVtbl[3]))((IUIAnimationVariableChangeHandler2*)Unsafe.AsPointer(ref this), storyboard, variable, newValue, previousValue, cDimension);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnValueChanged(IUIAnimationStoryboard2* storyboard, IUIAnimationVariable2* variable, double* newValue, double* previousValue, uint cDimension);
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
        [NativeTypeName("HRESULT (IUIAnimationStoryboard2 *, IUIAnimationVariable2 *, DOUBLE *, DOUBLE *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationStoryboard2*, IUIAnimationVariable2*, double*, double*, uint, int> OnValueChanged;
    }
}