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

[Guid("80B0902F-7BF0-4117-B8C6-4279EF81EE77")]
[NativeTypeName("struct IAppxEncryptedBundleWriter : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.14393.0")]
public unsafe partial struct IAppxEncryptedBundleWriter
    : IAppxEncryptedBundleWriter.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxEncryptedBundleWriter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppxEncryptedBundleWriter, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxEncryptedBundleWriter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxEncryptedBundleWriter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddPayloadPackageEncrypted(
        [NativeTypeName("LPCWSTR")] ushort* fileName,
        IStream packageStream
    )
    {
        return (
            (delegate* unmanaged<IAppxEncryptedBundleWriter, ushort*, IStream, int>)((*lpVtbl)[3])
        )(this, fileName, packageStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<IAppxEncryptedBundleWriter, int>)((*lpVtbl)[4]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddPayloadPackageEncrypted(
            [NativeTypeName("LPCWSTR")] ushort* fileName,
            IStream packageStream
        );

        [VtblIndex(4)]
        HRESULT Close();
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

        [NativeTypeName("HRESULT (LPCWSTR, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IStream, int> AddPayloadPackageEncrypted;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxEncryptedBundleWriter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxEncryptedBundleWriter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxEncryptedBundleWriter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxEncryptedBundleWriter(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxEncryptedBundleWriter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxEncryptedBundleWriter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxEncryptedBundleWriter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxEncryptedBundleWriter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
