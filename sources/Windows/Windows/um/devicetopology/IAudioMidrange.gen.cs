// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAudioMidrange.xml' path='doc/member[@name="IAudioMidrange"]/*'/>
[Guid("5E54B6D7-B44B-40D9-9A9E-E691D9CE6EDF")]
[NativeTypeName("struct IAudioMidrange : IPerChannelDbLevel")]
[NativeInheritance("IPerChannelDbLevel")]
public unsafe partial struct IAudioMidrange : IAudioMidrange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioMidrange));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioMidrange*, Guid*, void**, int> )(lpVtbl[0]))((IAudioMidrange*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioMidrange*, uint> )(lpVtbl[1]))((IAudioMidrange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioMidrange*, uint> )(lpVtbl[2]))((IAudioMidrange*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPerChannelDbLevel.GetChannelCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetChannelCount(uint* pcChannels)
    {
        return ((delegate* unmanaged<IAudioMidrange*, uint*, int> )(lpVtbl[3]))((IAudioMidrange*)Unsafe.AsPointer(ref this), pcChannels);
    }

    /// <inheritdoc cref = "IPerChannelDbLevel.GetLevelRange"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLevelRange(uint nChannel, float* pfMinLevelDB, float* pfMaxLevelDB, float* pfStepping)
    {
        return ((delegate* unmanaged<IAudioMidrange*, uint, float*, float*, float*, int> )(lpVtbl[4]))((IAudioMidrange*)Unsafe.AsPointer(ref this), nChannel, pfMinLevelDB, pfMaxLevelDB, pfStepping);
    }

    /// <inheritdoc cref = "IPerChannelDbLevel.GetLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLevel(uint nChannel, float* pfLevelDB)
    {
        return ((delegate* unmanaged<IAudioMidrange*, uint, float*, int> )(lpVtbl[5]))((IAudioMidrange*)Unsafe.AsPointer(ref this), nChannel, pfLevelDB);
    }

    /// <inheritdoc cref = "IPerChannelDbLevel.SetLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetLevel(uint nChannel, float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioMidrange*, uint, float, Guid*, int> )(lpVtbl[6]))((IAudioMidrange*)Unsafe.AsPointer(ref this), nChannel, fLevelDB, pguidEventContext);
    }

    /// <inheritdoc cref = "IPerChannelDbLevel.SetLevelUniform"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetLevelUniform(float fLevelDB, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioMidrange*, float, Guid*, int> )(lpVtbl[7]))((IAudioMidrange*)Unsafe.AsPointer(ref this), fLevelDB, pguidEventContext);
    }

    /// <inheritdoc cref = "IPerChannelDbLevel.SetLevelAllChannels"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetLevelAllChannels([NativeTypeName("float[]")] float* aLevelsDB, [NativeTypeName("ULONG")] uint cChannels, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioMidrange*, float*, uint, Guid*, int> )(lpVtbl[8]))((IAudioMidrange*)Unsafe.AsPointer(ref this), aLevelsDB, cChannels, pguidEventContext);
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