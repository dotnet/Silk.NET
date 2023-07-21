// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;

/// <include file='IVisualInteractionSourceInterop.xml' path='doc/member[@name="IVisualInteractionSourceInterop"]/*' />
[Guid("11F62CD1-2F9D-42D3-B05F-D6790D9E9F8E")]
[NativeTypeName("struct IVisualInteractionSourceInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVisualInteractionSourceInterop : IVisualInteractionSourceInterop.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVisualInteractionSourceInterop));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVisualInteractionSourceInterop*, Guid*, void**, int>)(lpVtbl[0]))((IVisualInteractionSourceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVisualInteractionSourceInterop*, uint>)(lpVtbl[1]))((IVisualInteractionSourceInterop*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVisualInteractionSourceInterop*, uint>)(lpVtbl[2]))((IVisualInteractionSourceInterop*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IVisualInteractionSourceInterop.xml' path='doc/member[@name="IVisualInteractionSourceInterop.TryRedirectForManipulation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT TryRedirectForManipulation([NativeTypeName("const POINTER_INFO &")] POINTER_INFO* pointerInfo)
    {
        return ((delegate* unmanaged<IVisualInteractionSourceInterop*, POINTER_INFO*, int>)(lpVtbl[3]))((IVisualInteractionSourceInterop*)Unsafe.AsPointer(ref this), pointerInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT TryRedirectForManipulation([NativeTypeName("const POINTER_INFO &")] POINTER_INFO* pointerInfo);
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

        [NativeTypeName("HRESULT (const POINTER_INFO &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINTER_INFO*, int> TryRedirectForManipulation;
    }
}
