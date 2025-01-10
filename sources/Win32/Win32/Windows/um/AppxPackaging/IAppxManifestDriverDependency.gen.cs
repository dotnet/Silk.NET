// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1210CB94-5A92-4602-BE24-79F318AF4AF9")]
[NativeTypeName("struct IAppxManifestDriverDependency : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxManifestDriverDependency
    : IAppxManifestDriverDependency.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestDriverDependency));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppxManifestDriverDependency, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestDriverDependency, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestDriverDependency, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDriverConstraints(IAppxManifestDriverConstraintsEnumerator* driverConstraints)
    {
        return (
            (delegate* unmanaged<
                IAppxManifestDriverDependency,
                IAppxManifestDriverConstraintsEnumerator*,
                int>)((*lpVtbl)[3])
        )(this, driverConstraints);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDriverConstraints(IAppxManifestDriverConstraintsEnumerator* driverConstraints);
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
            "HRESULT (IAppxManifestDriverConstraintsEnumerator **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppxManifestDriverConstraintsEnumerator*,
            int> GetDriverConstraints;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxManifestDriverDependency"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxManifestDriverDependency(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxManifestDriverDependency"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxManifestDriverDependency(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxManifestDriverDependency(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxManifestDriverDependency"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxManifestDriverDependency"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxManifestDriverDependency value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
