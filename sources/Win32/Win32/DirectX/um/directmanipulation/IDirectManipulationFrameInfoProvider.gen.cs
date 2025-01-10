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

[Guid("FB759DBA-6F4C-4C01-874E-19C8A05907F9")]
[NativeTypeName("struct IDirectManipulationFrameInfoProvider : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDirectManipulationFrameInfoProvider
    : IDirectManipulationFrameInfoProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationFrameInfoProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDirectManipulationFrameInfoProvider, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationFrameInfoProvider, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationFrameInfoProvider, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetNextFrameInfo(
        [NativeTypeName("ULONGLONG *")] ulong* time,
        [NativeTypeName("ULONGLONG *")] ulong* processTime,
        [NativeTypeName("ULONGLONG *")] ulong* compositionTime
    )
    {
        return (
            (delegate* unmanaged<
                IDirectManipulationFrameInfoProvider,
                ulong*,
                ulong*,
                ulong*,
                int>)((*lpVtbl)[3])
        )(this, time, processTime, compositionTime);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetNextFrameInfo(
            [NativeTypeName("ULONGLONG *")] ulong* time,
            [NativeTypeName("ULONGLONG *")] ulong* processTime,
            [NativeTypeName("ULONGLONG *")] ulong* compositionTime
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

        [NativeTypeName("HRESULT (ULONGLONG *, ULONGLONG *, ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, ulong*, ulong*, int> GetNextFrameInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectManipulationFrameInfoProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectManipulationFrameInfoProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectManipulationFrameInfoProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectManipulationFrameInfoProvider(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDirectManipulationFrameInfoProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectManipulationFrameInfoProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectManipulationFrameInfoProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDirectManipulationFrameInfoProvider value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
