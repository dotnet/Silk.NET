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

[Guid("9099E33B-246F-41E4-881A-008EB613F858")]
[NativeTypeName("struct IAppxPackageWriter : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxPackageWriter : IAppxPackageWriter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxPackageWriter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxPackageWriter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppxPackageWriter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxPackageWriter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddPayloadFile(
        [NativeTypeName("LPCWSTR")] ushort* fileName,
        [NativeTypeName("LPCWSTR")] ushort* contentType,
        APPX_COMPRESSION_OPTION compressionOption,
        IStream inputStream
    )
    {
        return (
            (delegate* unmanaged<
                IAppxPackageWriter,
                ushort*,
                ushort*,
                APPX_COMPRESSION_OPTION,
                IStream,
                int>)((*lpVtbl)[3])
        )(this, fileName, contentType, compressionOption, inputStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Close(IStream manifest)
    {
        return ((delegate* unmanaged<IAppxPackageWriter, IStream, int>)((*lpVtbl)[4]))(
            this,
            manifest
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddPayloadFile(
            [NativeTypeName("LPCWSTR")] ushort* fileName,
            [NativeTypeName("LPCWSTR")] ushort* contentType,
            APPX_COMPRESSION_OPTION compressionOption,
            IStream inputStream
        );

        [VtblIndex(4)]
        HRESULT Close(IStream manifest);
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
            "HRESULT (LPCWSTR, LPCWSTR, APPX_COMPRESSION_OPTION, IStream *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            APPX_COMPRESSION_OPTION,
            IStream,
            int> AddPayloadFile;

        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, int> Close;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxPackageWriter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxPackageWriter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxPackageWriter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxPackageWriter(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxPackageWriter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxPackageWriter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxPackageWriter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxPackageWriter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
