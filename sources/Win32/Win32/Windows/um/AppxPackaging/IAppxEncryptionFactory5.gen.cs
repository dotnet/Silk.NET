// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("68D6E77A-F446-480F-B0F0-D91A24C60746")]
[NativeTypeName("struct IAppxEncryptionFactory5 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxEncryptionFactory5
    : IAppxEncryptionFactory5.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxEncryptionFactory5));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory5, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppxEncryptionFactory5, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory5, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateEncryptedPackageReader2(
        IStream inputStream,
        [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
        [NativeTypeName("LPCWSTR")] ushort* expectedDigest,
        IAppxPackageReader* packageReader
    )
    {
        return (
            (delegate* unmanaged<
                IAppxEncryptionFactory5,
                IStream,
                APPX_KEY_INFO*,
                ushort*,
                IAppxPackageReader*,
                int>)((*lpVtbl)[3])
        )(this, inputStream, keyInfo, expectedDigest, packageReader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateEncryptedBundleReader2(
        IStream inputStream,
        [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
        [NativeTypeName("LPCWSTR")] ushort* expectedDigest,
        IAppxBundleReader* bundleReader
    )
    {
        return (
            (delegate* unmanaged<
                IAppxEncryptionFactory5,
                IStream,
                APPX_KEY_INFO*,
                ushort*,
                IAppxBundleReader*,
                int>)((*lpVtbl)[4])
        )(this, inputStream, keyInfo, expectedDigest, bundleReader);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateEncryptedPackageReader2(
            IStream inputStream,
            [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
            [NativeTypeName("LPCWSTR")] ushort* expectedDigest,
            IAppxPackageReader* packageReader
        );

        [VtblIndex(4)]
        HRESULT CreateEncryptedBundleReader2(
            IStream inputStream,
            [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo,
            [NativeTypeName("LPCWSTR")] ushort* expectedDigest,
            IAppxBundleReader* bundleReader
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
            "HRESULT (IStream *, const APPX_KEY_INFO *, LPCWSTR, IAppxPackageReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            APPX_KEY_INFO*,
            ushort*,
            IAppxPackageReader*,
            int> CreateEncryptedPackageReader2;

        [NativeTypeName(
            "HRESULT (IStream *, const APPX_KEY_INFO *, LPCWSTR, IAppxBundleReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            APPX_KEY_INFO*,
            ushort*,
            IAppxBundleReader*,
            int> CreateEncryptedBundleReader2;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxEncryptionFactory5"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxEncryptionFactory5(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxEncryptionFactory5"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxEncryptionFactory5(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxEncryptionFactory5(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxEncryptionFactory5"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxEncryptionFactory5"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxEncryptionFactory5 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
