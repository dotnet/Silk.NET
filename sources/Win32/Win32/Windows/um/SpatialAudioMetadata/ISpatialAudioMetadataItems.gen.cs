// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BCD7C78F-3098-4F22-B547-A2F25A381269")]
[NativeTypeName("struct ISpatialAudioMetadataItems : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ISpatialAudioMetadataItems
    : ISpatialAudioMetadataItems.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAudioMetadataItems));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpatialAudioMetadataItems, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItems, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItems, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFrameCount([NativeTypeName("UINT16 *")] ushort* frameCount)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItems, ushort*, int>)((*lpVtbl)[3]))(
            this,
            frameCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetItemCount([NativeTypeName("UINT16 *")] ushort* itemCount)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItems, ushort*, int>)((*lpVtbl)[4]))(
            this,
            itemCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMaxItemCount([NativeTypeName("UINT16 *")] ushort* maxItemCount)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItems, ushort*, int>)((*lpVtbl)[5]))(
            this,
            maxItemCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMaxValueBufferLength([NativeTypeName("UINT32 *")] uint* maxValueBufferLength)
    {
        return ((delegate* unmanaged<ISpatialAudioMetadataItems, uint*, int>)((*lpVtbl)[6]))(
            this,
            maxValueBufferLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetInfo(SpatialAudioMetadataItemsInfo* info)
    {
        return (
            (delegate* unmanaged<ISpatialAudioMetadataItems, SpatialAudioMetadataItemsInfo*, int>)(
                (*lpVtbl)[7]
            )
        )(this, info);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFrameCount([NativeTypeName("UINT16 *")] ushort* frameCount);

        [VtblIndex(4)]
        HRESULT GetItemCount([NativeTypeName("UINT16 *")] ushort* itemCount);

        [VtblIndex(5)]
        HRESULT GetMaxItemCount([NativeTypeName("UINT16 *")] ushort* maxItemCount);

        [VtblIndex(6)]
        HRESULT GetMaxValueBufferLength([NativeTypeName("UINT32 *")] uint* maxValueBufferLength);

        [VtblIndex(7)]
        HRESULT GetInfo(SpatialAudioMetadataItemsInfo* info);
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

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetFrameCount;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetItemCount;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetMaxItemCount;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaxValueBufferLength;

        [NativeTypeName("HRESULT (SpatialAudioMetadataItemsInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SpatialAudioMetadataItemsInfo*, int> GetInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialAudioMetadataItems"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialAudioMetadataItems(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialAudioMetadataItems"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialAudioMetadataItems(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialAudioMetadataItems(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAudioMetadataItems"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAudioMetadataItems"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialAudioMetadataItems value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
