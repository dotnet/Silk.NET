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

[Guid("814B5AF5-C2C8-4270-A9B7-A198CE8D02FA")]
[NativeTypeName("struct IDirectManipulationDragDropBehavior : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDirectManipulationDragDropBehavior
    : IDirectManipulationDragDropBehavior.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationDragDropBehavior));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDirectManipulationDragDropBehavior, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationDragDropBehavior, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationDragDropBehavior, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetConfiguration(DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION configuration)
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationDragDropBehavior,
                DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION,
                int>)((*lpVtbl)[3])
        )(this, configuration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStatus(DIRECTMANIPULATION_DRAG_DROP_STATUS* status)
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationDragDropBehavior,
                DIRECTMANIPULATION_DRAG_DROP_STATUS*,
                int>)((*lpVtbl)[4])
        )(this, status);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetConfiguration(DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION configuration);

        [VtblIndex(4)]
        HRESULT GetStatus(DIRECTMANIPULATION_DRAG_DROP_STATUS* status);
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
            "HRESULT (DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DIRECTMANIPULATION_DRAG_DROP_CONFIGURATION,
            int> SetConfiguration;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_DRAG_DROP_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_DRAG_DROP_STATUS*, int> GetStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectManipulationDragDropBehavior"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectManipulationDragDropBehavior(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectManipulationDragDropBehavior"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectManipulationDragDropBehavior(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDirectManipulationDragDropBehavior(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectManipulationDragDropBehavior"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectManipulationDragDropBehavior"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDirectManipulationDragDropBehavior value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
