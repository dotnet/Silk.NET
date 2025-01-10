// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3455D234-8414-410D-95C7-7B35255B8391")]
[NativeTypeName("struct IAppxManifestHostRuntimeDependency : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestHostRuntimeDependency
    : IAppxManifestHostRuntimeDependency.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestHostRuntimeDependency));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppxManifestHostRuntimeDependency, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestHostRuntimeDependency, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestHostRuntimeDependency, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
    {
        return (
            (delegate* unmanaged<IAppxManifestHostRuntimeDependency, ushort**, int>)((*lpVtbl)[3])
        )(this, name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher)
    {
        return (
            (delegate* unmanaged<IAppxManifestHostRuntimeDependency, ushort**, int>)((*lpVtbl)[4])
        )(this, publisher);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMinVersion([NativeTypeName("UINT64 *")] ulong* minVersion)
    {
        return (
            (delegate* unmanaged<IAppxManifestHostRuntimeDependency, ulong*, int>)((*lpVtbl)[5])
        )(this, minVersion);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name);

        [VtblIndex(4)]
        HRESULT GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher);

        [VtblIndex(5)]
        HRESULT GetMinVersion([NativeTypeName("UINT64 *")] ulong* minVersion);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetPublisher;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetMinVersion;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxManifestHostRuntimeDependency"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxManifestHostRuntimeDependency(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxManifestHostRuntimeDependency"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxManifestHostRuntimeDependency(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAppxManifestHostRuntimeDependency(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxManifestHostRuntimeDependency"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxManifestHostRuntimeDependency"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAppxManifestHostRuntimeDependency value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
