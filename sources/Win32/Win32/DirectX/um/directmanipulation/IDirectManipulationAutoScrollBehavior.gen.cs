// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("6D5954D4-2003-4356-9B31-D051C9FF0AF7")]
[NativeTypeName("struct IDirectManipulationAutoScrollBehavior : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDirectManipulationAutoScrollBehavior
    : IDirectManipulationAutoScrollBehavior.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationAutoScrollBehavior));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDirectManipulationAutoScrollBehavior, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationAutoScrollBehavior, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationAutoScrollBehavior, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetConfiguration(
        DIRECTMANIPULATION_MOTION_TYPES motionTypes,
        DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION scrollMotion
    )
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationAutoScrollBehavior,
                DIRECTMANIPULATION_MOTION_TYPES,
                DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION,
                int>)((*lpVtbl)[3])
        )(this, motionTypes, scrollMotion);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetConfiguration(
            DIRECTMANIPULATION_MOTION_TYPES motionTypes,
            DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION scrollMotion
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
            "HRESULT (DIRECTMANIPULATION_MOTION_TYPES, DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DIRECTMANIPULATION_MOTION_TYPES,
            DIRECTMANIPULATION_AUTOSCROLL_CONFIGURATION,
            int> SetConfiguration;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectManipulationAutoScrollBehavior"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectManipulationAutoScrollBehavior(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectManipulationAutoScrollBehavior"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectManipulationAutoScrollBehavior(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDirectManipulationAutoScrollBehavior(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectManipulationAutoScrollBehavior"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectManipulationAutoScrollBehavior"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDirectManipulationAutoScrollBehavior value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
