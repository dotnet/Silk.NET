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

[Guid("91DF827B-94FD-468F-827B-57F41B2F6F2E")]
[NativeTypeName("struct IAppxFile : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxFile : IAppxFile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxFile));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxFile, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppxFile, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxFile, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCompressionOption(APPX_COMPRESSION_OPTION* compressionOption)
    {
        return ((delegate* unmanaged<IAppxFile, APPX_COMPRESSION_OPTION*, int>)((*lpVtbl)[3]))(
            this,
            compressionOption
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetContentType([NativeTypeName("LPWSTR *")] ushort** contentType)
    {
        return ((delegate* unmanaged<IAppxFile, ushort**, int>)((*lpVtbl)[4]))(this, contentType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** fileName)
    {
        return ((delegate* unmanaged<IAppxFile, ushort**, int>)((*lpVtbl)[5]))(this, fileName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSize([NativeTypeName("UINT64 *")] ulong* size)
    {
        return ((delegate* unmanaged<IAppxFile, ulong*, int>)((*lpVtbl)[6]))(this, size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetStream(IStream* stream)
    {
        return ((delegate* unmanaged<IAppxFile, IStream*, int>)((*lpVtbl)[7]))(this, stream);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCompressionOption(APPX_COMPRESSION_OPTION* compressionOption);

        [VtblIndex(4)]
        HRESULT GetContentType([NativeTypeName("LPWSTR *")] ushort** contentType);

        [VtblIndex(5)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** fileName);

        [VtblIndex(6)]
        HRESULT GetSize([NativeTypeName("UINT64 *")] ulong* size);

        [VtblIndex(7)]
        HRESULT GetStream(IStream* stream);
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

        [NativeTypeName("HRESULT (APPX_COMPRESSION_OPTION *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPX_COMPRESSION_OPTION*, int> GetCompressionOption;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetContentType;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetSize;

        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> GetStream;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxFile"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxFile(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxFile"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxFile(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxFile(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxFile"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxFile"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxFile value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
