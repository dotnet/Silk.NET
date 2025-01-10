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

[Guid("C1B11EEE-C4BA-4AB2-A55D-D015FE8FF64F")]
[NativeTypeName("struct IAppxEncryptionFactory2 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxEncryptionFactory2
    : IAppxEncryptionFactory2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxEncryptionFactory2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppxEncryptionFactory2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateEncryptedPackageWriter(
        IStream outputStream,
        IStream manifestStream,
        IStream contentGroupMapStream,
        [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")]
            APPX_ENCRYPTED_PACKAGE_SETTINGS* settings,
        [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
        [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")]
            APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles,
        IAppxEncryptedPackageWriter* packageWriter
    )
    {
        return (
            (delegate* unmanaged<
                IAppxEncryptionFactory2,
                IStream,
                IStream,
                IStream,
                APPX_ENCRYPTED_PACKAGE_SETTINGS*,
                APPX_KEY_INFO*,
                APPX_ENCRYPTED_EXEMPTIONS*,
                IAppxEncryptedPackageWriter*,
                int>)((*lpVtbl)[3])
        )(
            this,
            outputStream,
            manifestStream,
            contentGroupMapStream,
            settings,
            keyInfo,
            exemptedFiles,
            packageWriter
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateEncryptedPackageWriter(
            IStream outputStream,
            IStream manifestStream,
            IStream contentGroupMapStream,
            [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS *")]
                APPX_ENCRYPTED_PACKAGE_SETTINGS* settings,
            [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
            [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")]
                APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles,
            IAppxEncryptedPackageWriter* packageWriter
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
            "HRESULT (IStream *, IStream *, IStream *, const APPX_ENCRYPTED_PACKAGE_SETTINGS *, const APPX_KEY_INFO *, const APPX_ENCRYPTED_EXEMPTIONS *, IAppxEncryptedPackageWriter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            IStream,
            IStream,
            APPX_ENCRYPTED_PACKAGE_SETTINGS*,
            APPX_KEY_INFO*,
            APPX_ENCRYPTED_EXEMPTIONS*,
            IAppxEncryptedPackageWriter*,
            int> CreateEncryptedPackageWriter;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxEncryptionFactory2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxEncryptionFactory2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxEncryptionFactory2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxEncryptionFactory2(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxEncryptionFactory2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxEncryptionFactory2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxEncryptionFactory2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxEncryptionFactory2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
