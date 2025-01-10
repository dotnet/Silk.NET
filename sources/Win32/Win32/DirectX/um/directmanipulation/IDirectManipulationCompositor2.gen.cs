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

[Guid("D38C7822-F1CB-43CB-B4B9-AC0C767A412E")]
[NativeTypeName("struct IDirectManipulationCompositor2 : IDirectManipulationCompositor")]
[NativeInheritance("IDirectManipulationCompositor")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IDirectManipulationCompositor2
    : IDirectManipulationCompositor2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationCompositor2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDirectManipulationCompositor2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddContent(
        IDirectManipulationContent content,
        IUnknown device,
        IUnknown parentVisual,
        IUnknown childVisual
    )
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationCompositor2,
                IDirectManipulationContent,
                IUnknown,
                IUnknown,
                IUnknown,
                int>)((*lpVtbl)[3])
        )(this, content, device, parentVisual, childVisual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveContent(IDirectManipulationContent content)
    {
        return (
            (delegate* unmanaged<IDirectManipulationCompositor2, IDirectManipulationContent, int>)(
                (*lpVtbl)[4]
            )
        )(this, content);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetUpdateManager(IDirectManipulationUpdateManager updateManager)
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationCompositor2,
                IDirectManipulationUpdateManager,
                int>)((*lpVtbl)[5])
        )(this, updateManager);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor2, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddContentWithCrossProcessChaining(
        IDirectManipulationPrimaryContent content,
        IUnknown device,
        IUnknown parentVisual,
        IUnknown childVisual
    )
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationCompositor2,
                IDirectManipulationPrimaryContent,
                IUnknown,
                IUnknown,
                IUnknown,
                int>)((*lpVtbl)[7])
        )(this, content, device, parentVisual, childVisual);
    }

    public interface Interface : IDirectManipulationCompositor.Interface
    {
        [VtblIndex(7)]
        HRESULT AddContentWithCrossProcessChaining(
            IDirectManipulationPrimaryContent content,
            IUnknown device,
            IUnknown parentVisual,
            IUnknown childVisual
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
            "HRESULT (IDirectManipulationContent *, IUnknown *, IUnknown *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirectManipulationContent,
            IUnknown,
            IUnknown,
            IUnknown,
            int> AddContent;

        [NativeTypeName("HRESULT (IDirectManipulationContent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectManipulationContent, int> RemoveContent;

        [NativeTypeName("HRESULT (IDirectManipulationUpdateManager *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectManipulationUpdateManager, int> SetUpdateManager;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Flush;

        [NativeTypeName(
            "HRESULT (IDirectManipulationPrimaryContent *, IUnknown *, IUnknown *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IDirectManipulationPrimaryContent,
            IUnknown,
            IUnknown,
            IUnknown,
            int> AddContentWithCrossProcessChaining;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectManipulationCompositor2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectManipulationCompositor2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDirectManipulationCompositor"/> to <see cref = "IDirectManipulationCompositor2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDirectManipulationCompositor"/> instance to be converted </param>
    public static explicit operator IDirectManipulationCompositor2(
        Silk.NET.DirectX.IDirectManipulationCompositor value
    )
    {
        return new IDirectManipulationCompositor2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectManipulationCompositor2"/> to <see cref = "Silk.NET.DirectX.IDirectManipulationCompositor"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectManipulationCompositor2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDirectManipulationCompositor(
        IDirectManipulationCompositor2 value
    )
    {
        return new Silk.NET.DirectX.IDirectManipulationCompositor(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectManipulationCompositor2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectManipulationCompositor2(Silk.NET.Windows.IUnknown value)
    {
        return new IDirectManipulationCompositor2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectManipulationCompositor2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectManipulationCompositor2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirectManipulationCompositor2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
