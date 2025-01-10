// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DDA0B713-F3FF-49D3-898A-2786780C5D98")]
[NativeTypeName("struct IAppxManifestPackageDependency2 : IAppxManifestPackageDependency")]
[NativeInheritance("IAppxManifestPackageDependency")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxManifestPackageDependency2
    : IAppxManifestPackageDependency2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestPackageDependency2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppxManifestPackageDependency2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependency2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependency2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
    {
        return (
            (delegate* unmanaged<IAppxManifestPackageDependency2, ushort**, int>)((*lpVtbl)[3])
        )(this, name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPublisher([NativeTypeName("LPWSTR *")] ushort** publisher)
    {
        return (
            (delegate* unmanaged<IAppxManifestPackageDependency2, ushort**, int>)((*lpVtbl)[4])
        )(this, publisher);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMinVersion([NativeTypeName("UINT64 *")] ulong* minVersion)
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependency2, ulong*, int>)((*lpVtbl)[5]))(
            this,
            minVersion
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMaxMajorVersionTested(
        [NativeTypeName("UINT16 *")] ushort* maxMajorVersionTested
    )
    {
        return ((delegate* unmanaged<IAppxManifestPackageDependency2, ushort*, int>)((*lpVtbl)[6]))(
            this,
            maxMajorVersionTested
        );
    }

    public interface Interface : IAppxManifestPackageDependency.Interface
    {
        [VtblIndex(6)]
        HRESULT GetMaxMajorVersionTested(
            [NativeTypeName("UINT16 *")] ushort* maxMajorVersionTested
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetPublisher;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetMinVersion;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetMaxMajorVersionTested;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxManifestPackageDependency2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxManifestPackageDependency2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IAppxManifestPackageDependency"/> to <see cref = "IAppxManifestPackageDependency2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IAppxManifestPackageDependency"/> instance to be converted </param>
    public static explicit operator IAppxManifestPackageDependency2(
        Silk.NET.Windows.IAppxManifestPackageDependency value
    )
    {
        return new IAppxManifestPackageDependency2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxManifestPackageDependency2"/> to <see cref = "Silk.NET.Windows.IAppxManifestPackageDependency"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxManifestPackageDependency2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IAppxManifestPackageDependency(
        IAppxManifestPackageDependency2 value
    )
    {
        return new Silk.NET.Windows.IAppxManifestPackageDependency(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxManifestPackageDependency2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxManifestPackageDependency2(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxManifestPackageDependency2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxManifestPackageDependency2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxManifestPackageDependency2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxManifestPackageDependency2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
