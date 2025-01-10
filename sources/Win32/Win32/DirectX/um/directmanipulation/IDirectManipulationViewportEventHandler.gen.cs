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

[Guid("952121DA-D69F-45F9-B0F9-F23944321A6D")]
[NativeTypeName("struct IDirectManipulationViewportEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDirectManipulationViewportEventHandler
    : IDirectManipulationViewportEventHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationViewportEventHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDirectManipulationViewportEventHandler, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationViewportEventHandler, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationViewportEventHandler, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnViewportStatusChanged(
        IDirectManipulationViewport viewport,
        DIRECTMANIPULATION_STATUS current,
        DIRECTMANIPULATION_STATUS previous
    )
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationViewportEventHandler,
                IDirectManipulationViewport,
                DIRECTMANIPULATION_STATUS,
                DIRECTMANIPULATION_STATUS,
                int>)((*lpVtbl)[3])
        )(this, viewport, current, previous);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnViewportUpdated(IDirectManipulationViewport viewport)
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationViewportEventHandler,
                IDirectManipulationViewport,
                int>)((*lpVtbl)[4])
        )(this, viewport);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnContentUpdated(
        IDirectManipulationViewport viewport,
        IDirectManipulationContent content
    )
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationViewportEventHandler,
                IDirectManipulationViewport,
                IDirectManipulationContent,
                int>)((*lpVtbl)[5])
        )(this, viewport, content);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnViewportStatusChanged(
            IDirectManipulationViewport viewport,
            DIRECTMANIPULATION_STATUS current,
            DIRECTMANIPULATION_STATUS previous
        );

        [VtblIndex(4)]
        HRESULT OnViewportUpdated(IDirectManipulationViewport viewport);

        [VtblIndex(5)]
        HRESULT OnContentUpdated(
            IDirectManipulationViewport viewport,
            IDirectManipulationContent content
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
            "HRESULT (IDirectManipulationViewport *, DIRECTMANIPULATION_STATUS, DIRECTMANIPULATION_STATUS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirectManipulationViewport,
            DIRECTMANIPULATION_STATUS,
            DIRECTMANIPULATION_STATUS,
            int> OnViewportStatusChanged;

        [NativeTypeName("HRESULT (IDirectManipulationViewport *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectManipulationViewport, int> OnViewportUpdated;

        [NativeTypeName(
            "HRESULT (IDirectManipulationViewport *, IDirectManipulationContent *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirectManipulationViewport,
            IDirectManipulationContent,
            int> OnContentUpdated;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectManipulationViewportEventHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectManipulationViewportEventHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectManipulationViewportEventHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectManipulationViewportEventHandler(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDirectManipulationViewportEventHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectManipulationViewportEventHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectManipulationViewportEventHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDirectManipulationViewportEventHandler value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
