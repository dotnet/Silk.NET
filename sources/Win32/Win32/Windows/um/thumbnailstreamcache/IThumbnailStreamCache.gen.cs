// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/thumbnailstreamcache.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("90E11430-9569-41D8-AE75-6D4D2AE7CCA0")]
[NativeTypeName("struct IThumbnailStreamCache : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IThumbnailStreamCache : IThumbnailStreamCache.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IThumbnailStreamCache));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IThumbnailStreamCache, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IThumbnailStreamCache, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IThumbnailStreamCache, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetThumbnailStream(
        [NativeTypeName("LPCWSTR")] ushort* path,
        [NativeTypeName("ULONGLONG")] ulong cacheId,
        ThumbnailStreamCacheOptions options,
        uint requestedThumbnailSize,
        SIZE* thumbnailSize,
        IStream* thumbnailStream
    )
    {
        return (
            (delegate* unmanaged<
                IThumbnailStreamCache,
                ushort*,
                ulong,
                ThumbnailStreamCacheOptions,
                uint,
                SIZE*,
                IStream*,
                int>)((*lpVtbl)[3])
        )(this, path, cacheId, options, requestedThumbnailSize, thumbnailSize, thumbnailStream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetThumbnailStream(
        [NativeTypeName("LPCWSTR")] ushort* path,
        [NativeTypeName("ULONGLONG")] ulong cacheId,
        SIZE thumbnailSize,
        IStream thumbnailStream
    )
    {
        return (
            (delegate* unmanaged<IThumbnailStreamCache, ushort*, ulong, SIZE, IStream, int>)(
                (*lpVtbl)[4]
            )
        )(this, path, cacheId, thumbnailSize, thumbnailStream);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetThumbnailStream(
            [NativeTypeName("LPCWSTR")] ushort* path,
            [NativeTypeName("ULONGLONG")] ulong cacheId,
            ThumbnailStreamCacheOptions options,
            uint requestedThumbnailSize,
            SIZE* thumbnailSize,
            IStream* thumbnailStream
        );

        [VtblIndex(4)]
        HRESULT SetThumbnailStream(
            [NativeTypeName("LPCWSTR")] ushort* path,
            [NativeTypeName("ULONGLONG")] ulong cacheId,
            SIZE thumbnailSize,
            IStream thumbnailStream
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
            "HRESULT (LPCWSTR, ULONGLONG, ThumbnailStreamCacheOptions, UINT, SIZE *, IStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ulong,
            ThumbnailStreamCacheOptions,
            uint,
            SIZE*,
            IStream*,
            int> GetThumbnailStream;

        [NativeTypeName("HRESULT (LPCWSTR, ULONGLONG, SIZE, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ulong, SIZE, IStream, int> SetThumbnailStream;
    }

    /// <summary>Initializes a new instance of the <see cref = "IThumbnailStreamCache"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IThumbnailStreamCache(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IThumbnailStreamCache"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IThumbnailStreamCache(Silk.NET.Windows.IUnknown value)
    {
        return new IThumbnailStreamCache(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IThumbnailStreamCache"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IThumbnailStreamCache"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IThumbnailStreamCache value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
