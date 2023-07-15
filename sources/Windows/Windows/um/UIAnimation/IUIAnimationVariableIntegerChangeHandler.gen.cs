// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IUIAnimationVariableIntegerChangeHandler.xml' path='doc/member[@name="IUIAnimationVariableIntegerChangeHandler"]/*'/>
[Guid("BB3E1550-356E-44B0-99DA-85AC6017865E")]
[NativeTypeName("struct IUIAnimationVariableIntegerChangeHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUIAnimationVariableIntegerChangeHandler : IUIAnimationVariableIntegerChangeHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUIAnimationVariableIntegerChangeHandler));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler*, Guid*, void**, int> )(lpVtbl[0]))((IUIAnimationVariableIntegerChangeHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler*, uint> )(lpVtbl[1]))((IUIAnimationVariableIntegerChangeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler*, uint> )(lpVtbl[2]))((IUIAnimationVariableIntegerChangeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUIAnimationVariableIntegerChangeHandler.xml' path='doc/member[@name="IUIAnimationVariableIntegerChangeHandler.OnIntegerValueChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnIntegerValueChanged(IUIAnimationStoryboard* storyboard, IUIAnimationVariable* variable, [NativeTypeName("INT32")] int newValue, [NativeTypeName("INT32")] int previousValue)
    {
        return ((delegate* unmanaged<IUIAnimationVariableIntegerChangeHandler*, IUIAnimationStoryboard*, IUIAnimationVariable*, int, int, int> )(lpVtbl[3]))((IUIAnimationVariableIntegerChangeHandler*)Unsafe.AsPointer(ref this), storyboard, variable, newValue, previousValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnIntegerValueChanged(IUIAnimationStoryboard* storyboard, IUIAnimationVariable* variable, [NativeTypeName("INT32")] int newValue, [NativeTypeName("INT32")] int previousValue);
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
        [NativeTypeName("HRESULT (IUIAnimationStoryboard *, IUIAnimationVariable *, INT32, INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUIAnimationStoryboard*, IUIAnimationVariable*, int, int, int> OnIntegerValueChanged;
    }
}