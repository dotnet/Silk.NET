// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAudioVolumeLevel.xml' path='doc/member[@name="IAudioVolumeLevel"]/*'/>
[Guid("7FB7B48F-531D-44A2-BCB3-5AD5A134B3DC")]
[NativeTypeName("struct IAudioVolumeLevel : IPerChannelDbLevel")]
[NativeInheritance("IPerChannelDbLevel")]
public unsafe partial struct IAudioVolumeLevel : IAudioVolumeLevel.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioVolumeLevel));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioVolumeLevel*, Guid*, void**, int> )(lpVtbl[0]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioVolumeLevel*, uint> )(lpVtbl[1]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioVolumeLevel*, uint> )(lpVtbl[2]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPerChannelDbLevel.GetChannelCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetChannelCount(uint* pcChannels)
    {
        return ((delegate* unmanaged<IAudioVolumeLevel*, uint*, int> )(lpVtbl[3]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this), pcChannels);
    }

    /// <inheritdoc cref = "IPerChannelDbLevel.GetLevelRange"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLevelRange(uint nChannel, float* pfMinLevelDB, float* pfMaxLevelDB, float* pfStepping)
    {
        return ((delegate* unmanaged<IAudioVolumeLevel*, uint, float*, float*, float*, int> )(lpVtbl[4]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this), nChannel, pfMinLevelDB, pfMaxLevelDB, pfStepping);
    }

    /// <inheritdoc cref = "IPerChannelDbLevel.GetLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLevel(uint nChannel, float* pfLevelDB)
    {
        return ((delegate* unmanaged<IAudioVolumeLevel*, uint, float*, int> )(lpVtbl[5]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this), nChannel, pfLevelDB);
    }

    /// <inheritdoc cref = "IPerChannelDbLevel.SetLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetLevel(uint nChannel, float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioVolumeLevel*, uint, float, Guid*, int> )(lpVtbl[6]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this), nChannel, fLevelDB, pguidEventContext);
    }

    /// <inheritdoc cref = "IPerChannelDbLevel.SetLevelUniform"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetLevelUniform(float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioVolumeLevel*, float, Guid*, int> )(lpVtbl[7]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this), fLevelDB, pguidEventContext);
    }

    /// <inheritdoc cref = "IPerChannelDbLevel.SetLevelAllChannels"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetLevelAllChannels([NativeTypeName("float[]")] float* aLevelsDB, [NativeTypeName("ULONG")] uint cChannels, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioVolumeLevel*, float*, uint, Guid*, int> )(lpVtbl[8]))((IAudioVolumeLevel*)Unsafe.AsPointer(ref this), aLevelsDB, cChannels, pguidEventContext);
    }

    public interface Interface : IPerChannelDbLevel.Interface
    {
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetChannelCount;
        [NativeTypeName("HRESULT (UINT, float *, float *, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, float*, float*, int> GetLevelRange;
        [NativeTypeName("HRESULT (UINT, float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float*, int> GetLevel;
        [NativeTypeName("HRESULT (UINT, float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, float, Guid*, int> SetLevel;
        [NativeTypeName("HRESULT (float, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, Guid*, int> SetLevelUniform;
        [NativeTypeName("HRESULT (float *, ULONG, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, Guid*, int> SetLevelAllChannels;
    }
}