// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfspatialaudio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D396EC8C-605E-4249-978D-72AD1C312872")]
[NativeTypeName("struct IMFSpatialAudioObjectBuffer : IMFMediaBuffer")]
[NativeInheritance("IMFMediaBuffer")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct IMFSpatialAudioObjectBuffer
    : IMFSpatialAudioObjectBuffer.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSpatialAudioObjectBuffer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFSpatialAudioObjectBuffer, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Lock(
        byte** ppbBuffer,
        [NativeTypeName("DWORD *")] uint* pcbMaxLength,
        [NativeTypeName("DWORD *")] uint* pcbCurrentLength
    )
    {
        return (
            (delegate* unmanaged<IMFSpatialAudioObjectBuffer, byte**, uint*, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, ppbBuffer, pcbMaxLength, pcbCurrentLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unlock()
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentLength([NativeTypeName("DWORD *")] uint* pcbCurrentLength)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer, uint*, int>)((*lpVtbl)[5]))(
            this,
            pcbCurrentLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetCurrentLength([NativeTypeName("DWORD")] uint cbCurrentLength)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer, uint, int>)((*lpVtbl)[6]))(
            this,
            cbCurrentLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMaxLength([NativeTypeName("DWORD *")] uint* pcbMaxLength)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer, uint*, int>)((*lpVtbl)[7]))(
            this,
            pcbMaxLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetID([NativeTypeName("UINT32")] uint u32ID)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer, uint, int>)((*lpVtbl)[8]))(
            this,
            u32ID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetID([NativeTypeName("UINT32 *")] uint* pu32ID)
    {
        return ((delegate* unmanaged<IMFSpatialAudioObjectBuffer, uint*, int>)((*lpVtbl)[9]))(
            this,
            pu32ID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetType(AudioObjectType type)
    {
        return (
            (delegate* unmanaged<IMFSpatialAudioObjectBuffer, AudioObjectType, int>)((*lpVtbl)[10])
        )(this, type);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetType(AudioObjectType* pType)
    {
        return (
            (delegate* unmanaged<IMFSpatialAudioObjectBuffer, AudioObjectType*, int>)((*lpVtbl)[11])
        )(this, pType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMetadataItems(ISpatialAudioMetadataItems* ppMetadataItems)
    {
        return (
            (delegate* unmanaged<IMFSpatialAudioObjectBuffer, ISpatialAudioMetadataItems*, int>)(
                (*lpVtbl)[12]
            )
        )(this, ppMetadataItems);
    }

    public interface Interface : IMFMediaBuffer.Interface
    {
        [VtblIndex(8)]
        HRESULT SetID([NativeTypeName("UINT32")] uint u32ID);

        [VtblIndex(9)]
        HRESULT GetID([NativeTypeName("UINT32 *")] uint* pu32ID);

        [VtblIndex(10)]
        HRESULT SetType(AudioObjectType type);

        [VtblIndex(11)]
        HRESULT GetType(AudioObjectType* pType);

        [VtblIndex(12)]
        HRESULT GetMetadataItems(ISpatialAudioMetadataItems* ppMetadataItems);
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

        [NativeTypeName("HRESULT (BYTE **, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, uint*, int> Lock;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unlock;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentLength;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetCurrentLength;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaxLength;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetID;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetID;

        [NativeTypeName("HRESULT (AudioObjectType) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioObjectType, int> SetType;

        [NativeTypeName("HRESULT (AudioObjectType *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, AudioObjectType*, int> GetType;

        [NativeTypeName("HRESULT (ISpatialAudioMetadataItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpatialAudioMetadataItems*, int> GetMetadataItems;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSpatialAudioObjectBuffer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSpatialAudioObjectBuffer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFMediaBuffer"/> to <see cref = "IMFSpatialAudioObjectBuffer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFMediaBuffer"/> instance to be converted </param>
    public static explicit operator IMFSpatialAudioObjectBuffer(
        Silk.NET.Windows.IMFMediaBuffer value
    )
    {
        return new IMFSpatialAudioObjectBuffer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSpatialAudioObjectBuffer"/> to <see cref = "Silk.NET.Windows.IMFMediaBuffer"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSpatialAudioObjectBuffer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFMediaBuffer(
        IMFSpatialAudioObjectBuffer value
    )
    {
        return new Silk.NET.Windows.IMFMediaBuffer(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSpatialAudioObjectBuffer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSpatialAudioObjectBuffer(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSpatialAudioObjectBuffer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSpatialAudioObjectBuffer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSpatialAudioObjectBuffer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSpatialAudioObjectBuffer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
