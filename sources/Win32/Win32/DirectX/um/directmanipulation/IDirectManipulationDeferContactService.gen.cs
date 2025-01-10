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

[Guid("652D5C71-FE60-4A98-BE70-E5F21291E7F1")]
[NativeTypeName("struct IDirectManipulationDeferContactService : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IDirectManipulationDeferContactService
    : IDirectManipulationDeferContactService.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationDeferContactService));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDirectManipulationDeferContactService, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationDeferContactService, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationDeferContactService, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DeferContact(
        [NativeTypeName("UINT32")] uint pointerId,
        [NativeTypeName("UINT32")] uint timeout
    )
    {
        return (
            (delegate* unmanaged<IDirectManipulationDeferContactService, uint, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, pointerId, timeout);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CancelContact([NativeTypeName("UINT32")] uint pointerId)
    {
        return (
            (delegate* unmanaged<IDirectManipulationDeferContactService, uint, int>)((*lpVtbl)[4])
        )(this, pointerId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CancelDeferral([NativeTypeName("UINT32")] uint pointerId)
    {
        return (
            (delegate* unmanaged<IDirectManipulationDeferContactService, uint, int>)((*lpVtbl)[5])
        )(this, pointerId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DeferContact(
            [NativeTypeName("UINT32")] uint pointerId,
            [NativeTypeName("UINT32")] uint timeout
        );

        [VtblIndex(4)]
        HRESULT CancelContact([NativeTypeName("UINT32")] uint pointerId);

        [VtblIndex(5)]
        HRESULT CancelDeferral([NativeTypeName("UINT32")] uint pointerId);
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

        [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> DeferContact;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> CancelContact;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> CancelDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectManipulationDeferContactService"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectManipulationDeferContactService(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectManipulationDeferContactService"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectManipulationDeferContactService(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDirectManipulationDeferContactService(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectManipulationDeferContactService"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectManipulationDeferContactService"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDirectManipulationDeferContactService value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
