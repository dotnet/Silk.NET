// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8EFE6F27-0CE0-4988-B32D-738EB63DB3B7")]
[NativeTypeName("struct IAppxManifestReader7 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestReader7 : IAppxManifestReader7.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestReader7));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestReader7, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestReader7, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestReader7, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDriverDependencies(
        IAppxManifestDriverDependenciesEnumerator* driverDependencies
    )
    {
        return (
            (delegate* unmanaged<
                IAppxManifestReader7,
                IAppxManifestDriverDependenciesEnumerator*,
                int>)((*lpVtbl)[3])
        )(this, driverDependencies);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetOSPackageDependencies(
        IAppxManifestOSPackageDependenciesEnumerator* osPackageDependencies
    )
    {
        return (
            (delegate* unmanaged<
                IAppxManifestReader7,
                IAppxManifestOSPackageDependenciesEnumerator*,
                int>)((*lpVtbl)[4])
        )(this, osPackageDependencies);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetHostRuntimeDependencies(
        IAppxManifestHostRuntimeDependenciesEnumerator* hostRuntimeDependencies
    )
    {
        return (
            (delegate* unmanaged<
                IAppxManifestReader7,
                IAppxManifestHostRuntimeDependenciesEnumerator*,
                int>)((*lpVtbl)[5])
        )(this, hostRuntimeDependencies);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDriverDependencies(
            IAppxManifestDriverDependenciesEnumerator* driverDependencies
        );

        [VtblIndex(4)]
        HRESULT GetOSPackageDependencies(
            IAppxManifestOSPackageDependenciesEnumerator* osPackageDependencies
        );

        [VtblIndex(5)]
        HRESULT GetHostRuntimeDependencies(
            IAppxManifestHostRuntimeDependenciesEnumerator* hostRuntimeDependencies
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
            "HRESULT (IAppxManifestDriverDependenciesEnumerator **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppxManifestDriverDependenciesEnumerator*,
            int> GetDriverDependencies;

        [NativeTypeName(
            "HRESULT (IAppxManifestOSPackageDependenciesEnumerator **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppxManifestOSPackageDependenciesEnumerator*,
            int> GetOSPackageDependencies;

        [NativeTypeName(
            "HRESULT (IAppxManifestHostRuntimeDependenciesEnumerator **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppxManifestHostRuntimeDependenciesEnumerator*,
            int> GetHostRuntimeDependencies;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxManifestReader7"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxManifestReader7(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxManifestReader7"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxManifestReader7(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxManifestReader7(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxManifestReader7"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxManifestReader7"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxManifestReader7 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
