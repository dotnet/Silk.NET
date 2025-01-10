// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F676C15D-596A-4CE2-8234-33996F445DB1")]
[NativeTypeName("struct IThumbnailCache : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IThumbnailCache : IThumbnailCache.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IThumbnailCache));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IThumbnailCache, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IThumbnailCache, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IThumbnailCache, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetThumbnail(
        IShellItem pShellItem,
        uint cxyRequestedThumbSize,
        WTS_FLAGS flags,
        ISharedBitmap* ppvThumb,
        WTS_CACHEFLAGS* pOutFlags,
        WTS_THUMBNAILID* pThumbnailID
    )
    {
        return (
            (delegate* unmanaged<
                IThumbnailCache,
                IShellItem,
                uint,
                WTS_FLAGS,
                ISharedBitmap*,
                WTS_CACHEFLAGS*,
                WTS_THUMBNAILID*,
                int>)((*lpVtbl)[3])
        )(this, pShellItem, cxyRequestedThumbSize, flags, ppvThumb, pOutFlags, pThumbnailID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetThumbnailByID(
        WTS_THUMBNAILID thumbnailID,
        uint cxyRequestedThumbSize,
        ISharedBitmap* ppvThumb,
        WTS_CACHEFLAGS* pOutFlags
    )
    {
        return (
            (delegate* unmanaged<
                IThumbnailCache,
                WTS_THUMBNAILID,
                uint,
                ISharedBitmap*,
                WTS_CACHEFLAGS*,
                int>)((*lpVtbl)[4])
        )(this, thumbnailID, cxyRequestedThumbSize, ppvThumb, pOutFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetThumbnail(
            IShellItem pShellItem,
            uint cxyRequestedThumbSize,
            WTS_FLAGS flags,
            ISharedBitmap* ppvThumb,
            WTS_CACHEFLAGS* pOutFlags,
            WTS_THUMBNAILID* pThumbnailID
        );

        [VtblIndex(4)]
        HRESULT GetThumbnailByID(
            WTS_THUMBNAILID thumbnailID,
            uint cxyRequestedThumbSize,
            ISharedBitmap* ppvThumb,
            WTS_CACHEFLAGS* pOutFlags
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
            "HRESULT (IShellItem *, UINT, WTS_FLAGS, ISharedBitmap **, WTS_CACHEFLAGS *, WTS_THUMBNAILID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            uint,
            WTS_FLAGS,
            ISharedBitmap*,
            WTS_CACHEFLAGS*,
            WTS_THUMBNAILID*,
            int> GetThumbnail;

        [NativeTypeName(
            "HRESULT (WTS_THUMBNAILID, UINT, ISharedBitmap **, WTS_CACHEFLAGS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            WTS_THUMBNAILID,
            uint,
            ISharedBitmap*,
            WTS_CACHEFLAGS*,
            int> GetThumbnailByID;
    }

    /// <summary>Initializes a new instance of the <see cref = "IThumbnailCache"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IThumbnailCache(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IThumbnailCache"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IThumbnailCache(Silk.NET.Windows.IUnknown value)
    {
        return new IThumbnailCache(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IThumbnailCache"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IThumbnailCache"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IThumbnailCache value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
