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

[Guid("277672AC-4F63-42C1-8ABC-BEAE3600EB59")]
[NativeTypeName("struct IAppxBlockMapFile : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxBlockMapFile : IAppxBlockMapFile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBlockMapFile));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBlockMapFile, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppxBlockMapFile, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBlockMapFile, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBlocks(IAppxBlockMapBlocksEnumerator* blocks)
    {
        return (
            (delegate* unmanaged<IAppxBlockMapFile, IAppxBlockMapBlocksEnumerator*, int>)(
                (*lpVtbl)[3]
            )
        )(this, blocks);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLocalFileHeaderSize([NativeTypeName("UINT32 *")] uint* lfhSize)
    {
        return ((delegate* unmanaged<IAppxBlockMapFile, uint*, int>)((*lpVtbl)[4]))(this, lfhSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IAppxBlockMapFile, ushort**, int>)((*lpVtbl)[5]))(this, name);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetUncompressedSize([NativeTypeName("UINT64 *")] ulong* size)
    {
        return ((delegate* unmanaged<IAppxBlockMapFile, ulong*, int>)((*lpVtbl)[6]))(this, size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ValidateFileHash(IStream fileStream, BOOL* isValid)
    {
        return ((delegate* unmanaged<IAppxBlockMapFile, IStream, BOOL*, int>)((*lpVtbl)[7]))(
            this,
            fileStream,
            isValid
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetBlocks(IAppxBlockMapBlocksEnumerator* blocks);

        [VtblIndex(4)]
        HRESULT GetLocalFileHeaderSize([NativeTypeName("UINT32 *")] uint* lfhSize);

        [VtblIndex(5)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** name);

        [VtblIndex(6)]
        HRESULT GetUncompressedSize([NativeTypeName("UINT64 *")] ulong* size);

        [VtblIndex(7)]
        HRESULT ValidateFileHash(IStream fileStream, BOOL* isValid);
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

        [NativeTypeName("HRESULT (IAppxBlockMapBlocksEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxBlockMapBlocksEnumerator*, int> GetBlocks;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetLocalFileHeaderSize;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetUncompressedSize;

        [NativeTypeName("HRESULT (IStream *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, BOOL*, int> ValidateFileHash;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxBlockMapFile"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxBlockMapFile(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxBlockMapFile"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxBlockMapFile(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxBlockMapFile(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxBlockMapFile"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxBlockMapFile"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxBlockMapFile value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
