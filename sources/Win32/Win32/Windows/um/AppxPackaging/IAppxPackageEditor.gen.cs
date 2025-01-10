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

[Guid("E2ADB6DC-5E71-4416-86B6-86E5F5291A6B")]
[NativeTypeName("struct IAppxPackageEditor : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxPackageEditor : IAppxPackageEditor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxPackageEditor));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxPackageEditor, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppxPackageEditor, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxPackageEditor, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetWorkingDirectory([NativeTypeName("LPCWSTR")] ushort* workingDirectory)
    {
        return ((delegate* unmanaged<IAppxPackageEditor, ushort*, int>)((*lpVtbl)[3]))(
            this,
            workingDirectory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateDeltaPackage(
        IStream updatedPackageStream,
        IStream baselinePackageStream,
        IStream deltaPackageStream
    )
    {
        return (
            (delegate* unmanaged<IAppxPackageEditor, IStream, IStream, IStream, int>)((*lpVtbl)[4])
        )(this, updatedPackageStream, baselinePackageStream, deltaPackageStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateDeltaPackageUsingBaselineBlockMap(
        IStream updatedPackageStream,
        IStream baselineBlockMapStream,
        [NativeTypeName("LPCWSTR")] ushort* baselinePackageFullName,
        IStream deltaPackageStream
    )
    {
        return (
            (delegate* unmanaged<IAppxPackageEditor, IStream, IStream, ushort*, IStream, int>)(
                (*lpVtbl)[5]
            )
        )(
            this,
            updatedPackageStream,
            baselineBlockMapStream,
            baselinePackageFullName,
            deltaPackageStream
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UpdatePackage(
        IStream baselinePackageStream,
        IStream deltaPackageStream,
        APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION updateOption
    )
    {
        return (
            (delegate* unmanaged<
                IAppxPackageEditor,
                IStream,
                IStream,
                APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION,
                int>)((*lpVtbl)[6])
        )(this, baselinePackageStream, deltaPackageStream, updateOption);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UpdateEncryptedPackage(
        IStream baselineEncryptedPackageStream,
        IStream deltaPackageStream,
        APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION updateOption,
        [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *")]
            APPX_ENCRYPTED_PACKAGE_SETTINGS2* settings,
        [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo
    )
    {
        return (
            (delegate* unmanaged<
                IAppxPackageEditor,
                IStream,
                IStream,
                APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION,
                APPX_ENCRYPTED_PACKAGE_SETTINGS2*,
                APPX_KEY_INFO*,
                int>)((*lpVtbl)[7])
        )(
            this,
            baselineEncryptedPackageStream,
            deltaPackageStream,
            updateOption,
            settings,
            keyInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UpdatePackageManifest(
        IStream packageStream,
        IStream updatedManifestStream,
        BOOL isPackageEncrypted,
        APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_MANIFEST_OPTIONS options
    )
    {
        return (
            (delegate* unmanaged<
                IAppxPackageEditor,
                IStream,
                IStream,
                BOOL,
                APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_MANIFEST_OPTIONS,
                int>)((*lpVtbl)[8])
        )(this, packageStream, updatedManifestStream, isPackageEncrypted, options);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetWorkingDirectory([NativeTypeName("LPCWSTR")] ushort* workingDirectory);

        [VtblIndex(4)]
        HRESULT CreateDeltaPackage(
            IStream updatedPackageStream,
            IStream baselinePackageStream,
            IStream deltaPackageStream
        );

        [VtblIndex(5)]
        HRESULT CreateDeltaPackageUsingBaselineBlockMap(
            IStream updatedPackageStream,
            IStream baselineBlockMapStream,
            [NativeTypeName("LPCWSTR")] ushort* baselinePackageFullName,
            IStream deltaPackageStream
        );

        [VtblIndex(6)]
        HRESULT UpdatePackage(
            IStream baselinePackageStream,
            IStream deltaPackageStream,
            APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION updateOption
        );

        [VtblIndex(7)]
        HRESULT UpdateEncryptedPackage(
            IStream baselineEncryptedPackageStream,
            IStream deltaPackageStream,
            APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION updateOption,
            [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *")]
                APPX_ENCRYPTED_PACKAGE_SETTINGS2* settings,
            [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo
        );

        [VtblIndex(8)]
        HRESULT UpdatePackageManifest(
            IStream packageStream,
            IStream updatedManifestStream,
            BOOL isPackageEncrypted,
            APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_MANIFEST_OPTIONS options
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetWorkingDirectory;

        [NativeTypeName("HRESULT (IStream *, IStream *, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, IStream, IStream, int> CreateDeltaPackage;

        [NativeTypeName(
            "HRESULT (IStream *, IStream *, LPCWSTR, IStream *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            IStream,
            ushort*,
            IStream,
            int> CreateDeltaPackageUsingBaselineBlockMap;

        [NativeTypeName(
            "HRESULT (IStream *, IStream *, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            IStream,
            APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION,
            int> UpdatePackage;

        [NativeTypeName(
            "HRESULT (IStream *, IStream *, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION, const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *, const APPX_KEY_INFO *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            IStream,
            APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION,
            APPX_ENCRYPTED_PACKAGE_SETTINGS2*,
            APPX_KEY_INFO*,
            int> UpdateEncryptedPackage;

        [NativeTypeName(
            "HRESULT (IStream *, IStream *, BOOL, APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_MANIFEST_OPTIONS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            IStream,
            BOOL,
            APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_MANIFEST_OPTIONS,
            int> UpdatePackageManifest;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxPackageEditor"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxPackageEditor(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxPackageEditor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxPackageEditor(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxPackageEditor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxPackageEditor"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxPackageEditor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxPackageEditor value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
