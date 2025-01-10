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

[Guid("9CD9D523-5009-4C01-9882-DC029FBD47A3")]
[NativeTypeName("struct IAppxBundleWriter4 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxBundleWriter4 : IAppxBundleWriter4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleWriter4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleWriter4, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppxBundleWriter4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleWriter4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddPayloadPackage(
        [NativeTypeName("LPCWSTR")] ushort* fileName,
        IStream packageStream,
        BOOL isDefaultApplicablePackage
    )
    {
        return (
            (delegate* unmanaged<IAppxBundleWriter4, ushort*, IStream, BOOL, int>)((*lpVtbl)[3])
        )(this, fileName, packageStream, isDefaultApplicablePackage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddPackageReference(
        [NativeTypeName("LPCWSTR")] ushort* fileName,
        IStream inputStream,
        BOOL isDefaultApplicablePackage
    )
    {
        return (
            (delegate* unmanaged<IAppxBundleWriter4, ushort*, IStream, BOOL, int>)((*lpVtbl)[4])
        )(this, fileName, inputStream, isDefaultApplicablePackage);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddExternalPackageReference(
        [NativeTypeName("LPCWSTR")] ushort* fileName,
        IStream inputStream,
        BOOL isDefaultApplicablePackage
    )
    {
        return (
            (delegate* unmanaged<IAppxBundleWriter4, ushort*, IStream, BOOL, int>)((*lpVtbl)[5])
        )(this, fileName, inputStream, isDefaultApplicablePackage);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddPayloadPackage(
            [NativeTypeName("LPCWSTR")] ushort* fileName,
            IStream packageStream,
            BOOL isDefaultApplicablePackage
        );

        [VtblIndex(4)]
        HRESULT AddPackageReference(
            [NativeTypeName("LPCWSTR")] ushort* fileName,
            IStream inputStream,
            BOOL isDefaultApplicablePackage
        );

        [VtblIndex(5)]
        HRESULT AddExternalPackageReference(
            [NativeTypeName("LPCWSTR")] ushort* fileName,
            IStream inputStream,
            BOOL isDefaultApplicablePackage
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

        [NativeTypeName("HRESULT (LPCWSTR, IStream *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IStream, BOOL, int> AddPayloadPackage;

        [NativeTypeName("HRESULT (LPCWSTR, IStream *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IStream, BOOL, int> AddPackageReference;

        [NativeTypeName("HRESULT (LPCWSTR, IStream *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IStream, BOOL, int> AddExternalPackageReference;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxBundleWriter4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxBundleWriter4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxBundleWriter4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxBundleWriter4(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxBundleWriter4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxBundleWriter4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxBundleWriter4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxBundleWriter4 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
