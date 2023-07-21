// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IUIAnimationVariableIntegerChangeHandler2.xml' path='doc/member[@name="IUIAnimationVariableIntegerChangeHandler2"]/*' />
[Guid("829B6CF1-4F3A-4412-AE09-B243EB4C6B58")]
[NativeTypeName("struct IUIAnimationVariableIntegerChangeHandler2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationVariableIntegerChangeHandler2 : IUIAnimationVariableIntegerChangeHandler2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationVariableIntegerChangeHandler2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, Guid*, void**, int>)(lpVtbl[0]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, uint>)(lpVtbl[1]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, uint>)(lpVtbl[2]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationVariableIntegerChangeHandler2.xml' path='doc/member[@name="IUIAnimationVariableIntegerChangeHandler2.OnIntegerValueChanged"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnIntegerValueChanged(IUIAnimationStoryboard2* storyboard, IUIAnimationVariable2* variable, [NativeTypeName("INT32 *")] int* newValue, [NativeTypeName("INT32 *")] int* previousValue, uint cDimension)
    {
        return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler2*, IUIAnimationStoryboard2*, IUIAnimationVariable2*, int*, int*, uint, int>)(lpVtbl[3]))((IUIAnimationVariableIntegerChangeHandler2*)Unsafe.AsPointer(ref this), storyboard, variable, newValue, previousValue, cDimension);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnIntegerValueChanged(IUIAnimationStoryboard2* storyboard, IUIAnimationVariable2* variable, [NativeTypeName("INT32 *")] int* newValue, [NativeTypeName("INT32 *")] int* previousValue, uint cDimension);
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

        [NativeTypeName("HRESULT (IUIAnimationStoryboard2 *, IUIAnimationVariable2 *, INT32 *, INT32 *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationStoryboard2*, IUIAnimationVariable2*, int*, int*, uint, int> OnIntegerValueChanged;
    }
}
