// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("11F62CD1-2F9D-42D3-B05F-D6790D9E9F8E")]
[NativeTypeName("struct IVisualInteractionSourceInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IVisualInteractionSourceInterop
    : IVisualInteractionSourceInterop.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVisualInteractionSourceInterop));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IVisualInteractionSourceInterop, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IVisualInteractionSourceInterop, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVisualInteractionSourceInterop, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT TryRedirectForManipulation(
        [NativeTypeName("const POINTER_INFO &")] POINTER_INFO* pointerInfo
    )
    {
        return (
            (delegate* unmanaged<IVisualInteractionSourceInterop, POINTER_INFO*, int>)((*lpVtbl)[3])
        )(this, pointerInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT TryRedirectForManipulation(
            [NativeTypeName("const POINTER_INFO &")] POINTER_INFO* pointerInfo
        );
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
            "HRESULT (const POINTER_INFO &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, POINTER_INFO*, int> TryRedirectForManipulation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVisualInteractionSourceInterop"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVisualInteractionSourceInterop(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVisualInteractionSourceInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVisualInteractionSourceInterop(Silk.NET.Windows.IUnknown value)
    {
        return new IVisualInteractionSourceInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVisualInteractionSourceInterop"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVisualInteractionSourceInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVisualInteractionSourceInterop value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
