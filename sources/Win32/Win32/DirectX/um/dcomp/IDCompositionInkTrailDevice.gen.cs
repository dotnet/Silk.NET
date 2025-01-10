// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("DF0C7CEC-CDEB-4D4A-B91C-721BF22F4E6C")]
[NativeTypeName("struct IDCompositionInkTrailDevice : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDCompositionInkTrailDevice
    : IDCompositionInkTrailDevice.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionInkTrailDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDCompositionInkTrailDevice, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionInkTrailDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionInkTrailDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateDelegatedInkTrail(IDCompositionDelegatedInkTrail* inkTrail)
    {
        return (
            (delegate* unmanaged<
                IDCompositionInkTrailDevice,
                IDCompositionDelegatedInkTrail*,
                int>)((*lpVtbl)[3])
        )(this, inkTrail);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateDelegatedInkTrailForSwapChain(
        IUnknown swapChain,
        IDCompositionDelegatedInkTrail* inkTrail
    )
    {
        return (
            (delegate* unmanaged<
                IDCompositionInkTrailDevice,
                IUnknown,
                IDCompositionDelegatedInkTrail*,
                int>)((*lpVtbl)[4])
        )(this, swapChain, inkTrail);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateDelegatedInkTrail(IDCompositionDelegatedInkTrail* inkTrail);

        [VtblIndex(4)]
        HRESULT CreateDelegatedInkTrailForSwapChain(
            IUnknown swapChain,
            IDCompositionDelegatedInkTrail* inkTrail
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
            "HRESULT (IDCompositionDelegatedInkTrail **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDCompositionDelegatedInkTrail*,
            int> CreateDelegatedInkTrail;

        [NativeTypeName(
            "HRESULT (IUnknown *, IDCompositionDelegatedInkTrail **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            IDCompositionDelegatedInkTrail*,
            int> CreateDelegatedInkTrailForSwapChain;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDCompositionInkTrailDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDCompositionInkTrailDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDCompositionInkTrailDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDCompositionInkTrailDevice(Silk.NET.Windows.IUnknown value)
    {
        return new IDCompositionInkTrailDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDCompositionInkTrailDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDCompositionInkTrailDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDCompositionInkTrailDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
