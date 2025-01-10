// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C43825AB-69B7-400A-9709-CC37F5A72D24")]
[NativeTypeName("struct IAppxManifestReader3 : IAppxManifestReader2")]
[NativeInheritance("IAppxManifestReader2")]
public unsafe partial struct IAppxManifestReader3 : IAppxManifestReader3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxManifestReader3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxManifestReader3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppxManifestReader3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxManifestReader3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPackageId(IAppxManifestPackageId* packageId)
    {
        return (
            (delegate* unmanaged<IAppxManifestReader3, IAppxManifestPackageId*, int>)((*lpVtbl)[3])
        )(this, packageId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProperties(IAppxManifestProperties* packageProperties)
    {
        return (
            (delegate* unmanaged<IAppxManifestReader3, IAppxManifestProperties*, int>)((*lpVtbl)[4])
        )(this, packageProperties);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPackageDependencies(IAppxManifestPackageDependenciesEnumerator* dependencies)
    {
        return (
            (delegate* unmanaged<
                IAppxManifestReader3,
                IAppxManifestPackageDependenciesEnumerator*,
                int>)((*lpVtbl)[5])
        )(this, dependencies);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCapabilities(APPX_CAPABILITIES* capabilities)
    {
        return ((delegate* unmanaged<IAppxManifestReader3, APPX_CAPABILITIES*, int>)((*lpVtbl)[6]))(
            this,
            capabilities
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetResources(IAppxManifestResourcesEnumerator* resources)
    {
        return (
            (delegate* unmanaged<IAppxManifestReader3, IAppxManifestResourcesEnumerator*, int>)(
                (*lpVtbl)[7]
            )
        )(this, resources);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDeviceCapabilities(
        IAppxManifestDeviceCapabilitiesEnumerator* deviceCapabilities
    )
    {
        return (
            (delegate* unmanaged<
                IAppxManifestReader3,
                IAppxManifestDeviceCapabilitiesEnumerator*,
                int>)((*lpVtbl)[8])
        )(this, deviceCapabilities);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetPrerequisite(
        [NativeTypeName("LPCWSTR")] ushort* name,
        [NativeTypeName("UINT64 *")] ulong* value
    )
    {
        return ((delegate* unmanaged<IAppxManifestReader3, ushort*, ulong*, int>)((*lpVtbl)[9]))(
            this,
            name,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetApplications(IAppxManifestApplicationsEnumerator* applications)
    {
        return (
            (delegate* unmanaged<IAppxManifestReader3, IAppxManifestApplicationsEnumerator*, int>)(
                (*lpVtbl)[10]
            )
        )(this, applications);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStream(IStream* manifestStream)
    {
        return ((delegate* unmanaged<IAppxManifestReader3, IStream*, int>)((*lpVtbl)[11]))(
            this,
            manifestStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetQualifiedResources(IAppxManifestQualifiedResourcesEnumerator* resources)
    {
        return (
            (delegate* unmanaged<
                IAppxManifestReader3,
                IAppxManifestQualifiedResourcesEnumerator*,
                int>)((*lpVtbl)[12])
        )(this, resources);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCapabilitiesByCapabilityClass(
        APPX_CAPABILITY_CLASS_TYPE capabilityClass,
        IAppxManifestCapabilitiesEnumerator* capabilities
    )
    {
        return (
            (delegate* unmanaged<
                IAppxManifestReader3,
                APPX_CAPABILITY_CLASS_TYPE,
                IAppxManifestCapabilitiesEnumerator*,
                int>)((*lpVtbl)[13])
        )(this, capabilityClass, capabilities);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetTargetDeviceFamilies(
        IAppxManifestTargetDeviceFamiliesEnumerator* targetDeviceFamilies
    )
    {
        return (
            (delegate* unmanaged<
                IAppxManifestReader3,
                IAppxManifestTargetDeviceFamiliesEnumerator*,
                int>)((*lpVtbl)[14])
        )(this, targetDeviceFamilies);
    }

    public interface Interface : IAppxManifestReader2.Interface
    {
        [VtblIndex(13)]
        HRESULT GetCapabilitiesByCapabilityClass(
            APPX_CAPABILITY_CLASS_TYPE capabilityClass,
            IAppxManifestCapabilitiesEnumerator* capabilities
        );

        [VtblIndex(14)]
        HRESULT GetTargetDeviceFamilies(
            IAppxManifestTargetDeviceFamiliesEnumerator* targetDeviceFamilies
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

        [NativeTypeName("HRESULT (IAppxManifestPackageId **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestPackageId*, int> GetPackageId;

        [NativeTypeName("HRESULT (IAppxManifestProperties **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestProperties*, int> GetProperties;

        [NativeTypeName(
            "HRESULT (IAppxManifestPackageDependenciesEnumerator **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppxManifestPackageDependenciesEnumerator*,
            int> GetPackageDependencies;

        [NativeTypeName("HRESULT (APPX_CAPABILITIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPX_CAPABILITIES*, int> GetCapabilities;

        [NativeTypeName("HRESULT (IAppxManifestResourcesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestResourcesEnumerator*, int> GetResources;

        [NativeTypeName(
            "HRESULT (IAppxManifestDeviceCapabilitiesEnumerator **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppxManifestDeviceCapabilitiesEnumerator*,
            int> GetDeviceCapabilities;

        [NativeTypeName("HRESULT (LPCWSTR, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ulong*, int> GetPrerequisite;

        [NativeTypeName(
            "HRESULT (IAppxManifestApplicationsEnumerator **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppxManifestApplicationsEnumerator*,
            int> GetApplications;

        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> GetStream;

        [NativeTypeName(
            "HRESULT (IAppxManifestQualifiedResourcesEnumerator **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppxManifestQualifiedResourcesEnumerator*,
            int> GetQualifiedResources;

        [NativeTypeName(
            "HRESULT (APPX_CAPABILITY_CLASS_TYPE, IAppxManifestCapabilitiesEnumerator **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            APPX_CAPABILITY_CLASS_TYPE,
            IAppxManifestCapabilitiesEnumerator*,
            int> GetCapabilitiesByCapabilityClass;

        [NativeTypeName(
            "HRESULT (IAppxManifestTargetDeviceFamiliesEnumerator **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppxManifestTargetDeviceFamiliesEnumerator*,
            int> GetTargetDeviceFamilies;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxManifestReader3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxManifestReader3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IAppxManifestReader2"/> to <see cref = "IAppxManifestReader3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IAppxManifestReader2"/> instance to be converted </param>
    public static explicit operator IAppxManifestReader3(
        Silk.NET.Windows.IAppxManifestReader2 value
    )
    {
        return new IAppxManifestReader3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxManifestReader3"/> to <see cref = "Silk.NET.Windows.IAppxManifestReader2"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxManifestReader3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IAppxManifestReader2(
        IAppxManifestReader3 value
    )
    {
        return new Silk.NET.Windows.IAppxManifestReader2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IAppxManifestReader"/> to <see cref = "IAppxManifestReader3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IAppxManifestReader"/> instance to be converted </param>
    public static explicit operator IAppxManifestReader3(Silk.NET.Windows.IAppxManifestReader value)
    {
        return new IAppxManifestReader3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxManifestReader3"/> to <see cref = "Silk.NET.Windows.IAppxManifestReader"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxManifestReader3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IAppxManifestReader(IAppxManifestReader3 value)
    {
        return new Silk.NET.Windows.IAppxManifestReader(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxManifestReader3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxManifestReader3(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxManifestReader3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxManifestReader3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxManifestReader3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxManifestReader3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
