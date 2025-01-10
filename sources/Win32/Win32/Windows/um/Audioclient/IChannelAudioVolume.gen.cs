// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1C158861-B533-4B30-B1CF-E853E51C59B8")]
[NativeTypeName("struct IChannelAudioVolume : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IChannelAudioVolume : IChannelAudioVolume.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IChannelAudioVolume));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IChannelAudioVolume, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IChannelAudioVolume, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IChannelAudioVolume, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetChannelCount([NativeTypeName("UINT32 *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IChannelAudioVolume, uint*, int>)((*lpVtbl)[3]))(
            this,
            pdwCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetChannelVolume(
        [NativeTypeName("UINT32")] uint dwIndex,
        [NativeTypeName("const float")] float fLevel,
        [NativeTypeName("LPCGUID")] Guid* EventContext
    )
    {
        return ((delegate* unmanaged<IChannelAudioVolume, uint, float, Guid*, int>)((*lpVtbl)[4]))(
            this,
            dwIndex,
            fLevel,
            EventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, float* pfLevel)
    {
        return ((delegate* unmanaged<IChannelAudioVolume, uint, float*, int>)((*lpVtbl)[5]))(
            this,
            dwIndex,
            pfLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAllVolumes(
        [NativeTypeName("UINT32")] uint dwCount,
        [NativeTypeName("const float *")] float* pfVolumes,
        [NativeTypeName("LPCGUID")] Guid* EventContext
    )
    {
        return ((delegate* unmanaged<IChannelAudioVolume, uint, float*, Guid*, int>)((*lpVtbl)[6]))(
            this,
            dwCount,
            pfVolumes,
            EventContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAllVolumes([NativeTypeName("UINT32")] uint dwCount, float* pfVolumes)
    {
        return ((delegate* unmanaged<IChannelAudioVolume, uint, float*, int>)((*lpVtbl)[7]))(
            this,
            dwCount,
            pfVolumes
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetChannelCount([NativeTypeName("UINT32 *")] uint* pdwCount);

        [VtblIndex(4)]
        HRESULT SetChannelVolume(
            [NativeTypeName("UINT32")] uint dwIndex,
            [NativeTypeName("const float")] float fLevel,
            [NativeTypeName("LPCGUID")] Guid* EventContext
        );

        [VtblIndex(5)]
        HRESULT GetChannelVolume([NativeTypeName("UINT32")] uint dwIndex, float* pfLevel);

        [VtblIndex(6)]
        HRESULT SetAllVolumes(
            [NativeTypeName("UINT32")] uint dwCount,
            [NativeTypeName("const float *")] float* pfVolumes,
            [NativeTypeName("LPCGUID")] Guid* EventContext
        );

        [VtblIndex(7)]
        HRESULT GetAllVolumes([NativeTypeName("UINT32")] uint dwCount, float* pfVolumes);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetChannelCount;

        [NativeTypeName("HRESULT (UINT32, const float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, Guid*, int> SetChannelVolume;

        [NativeTypeName("HRESULT (UINT32, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, int> GetChannelVolume;

        [NativeTypeName("HRESULT (UINT32, const float *, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, Guid*, int> SetAllVolumes;

        [NativeTypeName("HRESULT (UINT32, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, int> GetAllVolumes;
    }

    /// <summary>Initializes a new instance of the <see cref = "IChannelAudioVolume"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IChannelAudioVolume(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IChannelAudioVolume"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IChannelAudioVolume(Silk.NET.Windows.IUnknown value)
    {
        return new IChannelAudioVolume(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IChannelAudioVolume"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IChannelAudioVolume"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IChannelAudioVolume value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
