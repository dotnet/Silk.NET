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

[Guid("1FA11B10-701B-41AE-B5F2-49E36BD595AA")]
[NativeTypeName("struct IDirectManipulationDragDropEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDirectManipulationDragDropEventHandler
    : IDirectManipulationDragDropEventHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationDragDropEventHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDirectManipulationDragDropEventHandler, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationDragDropEventHandler, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationDragDropEventHandler, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnDragDropStatusChange(
        IDirectManipulationViewport2 viewport,
        DIRECTMANIPULATION_DRAG_DROP_STATUS current,
        DIRECTMANIPULATION_DRAG_DROP_STATUS previous
    )
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationDragDropEventHandler,
                IDirectManipulationViewport2,
                DIRECTMANIPULATION_DRAG_DROP_STATUS,
                DIRECTMANIPULATION_DRAG_DROP_STATUS,
                int>)((*lpVtbl)[3])
        )(this, viewport, current, previous);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnDragDropStatusChange(
            IDirectManipulationViewport2 viewport,
            DIRECTMANIPULATION_DRAG_DROP_STATUS current,
            DIRECTMANIPULATION_DRAG_DROP_STATUS previous
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
            "HRESULT (IDirectManipulationViewport2 *, DIRECTMANIPULATION_DRAG_DROP_STATUS, DIRECTMANIPULATION_DRAG_DROP_STATUS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirectManipulationViewport2,
            DIRECTMANIPULATION_DRAG_DROP_STATUS,
            DIRECTMANIPULATION_DRAG_DROP_STATUS,
            int> OnDragDropStatusChange;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectManipulationDragDropEventHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectManipulationDragDropEventHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectManipulationDragDropEventHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectManipulationDragDropEventHandler(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDirectManipulationDragDropEventHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectManipulationDragDropEventHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectManipulationDragDropEventHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDirectManipulationDragDropEventHandler value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
