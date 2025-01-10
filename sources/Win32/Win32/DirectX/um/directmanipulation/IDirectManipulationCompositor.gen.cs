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

[Guid("537A0825-0387-4EFA-B62F-71EB1F085A7E")]
[NativeTypeName("struct IDirectManipulationCompositor : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDirectManipulationCompositor
    : IDirectManipulationCompositor.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationCompositor));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDirectManipulationCompositor, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor, uint>)((*lpVtbl)[2]))(this);
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
                IDirectManipulationCompositor,
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
            (delegate* unmanaged<IDirectManipulationCompositor, IDirectManipulationContent, int>)(
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
                IDirectManipulationCompositor,
                IDirectManipulationUpdateManager,
                int>)((*lpVtbl)[5])
        )(this, updateManager);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Flush()
    {
        return ((delegate* unmanaged<IDirectManipulationCompositor, int>)((*lpVtbl)[6]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddContent(
            IDirectManipulationContent content,
            IUnknown device,
            IUnknown parentVisual,
            IUnknown childVisual
        );

        [VtblIndex(4)]
        HRESULT RemoveContent(IDirectManipulationContent content);

        [VtblIndex(5)]
        HRESULT SetUpdateManager(IDirectManipulationUpdateManager updateManager);

        [VtblIndex(6)]
        HRESULT Flush();
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectManipulationCompositor"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectManipulationCompositor(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectManipulationCompositor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectManipulationCompositor(Silk.NET.Windows.IUnknown value)
    {
        return new IDirectManipulationCompositor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectManipulationCompositor"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectManipulationCompositor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirectManipulationCompositor value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
