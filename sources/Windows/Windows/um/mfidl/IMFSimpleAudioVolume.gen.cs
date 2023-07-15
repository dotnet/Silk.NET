// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFSimpleAudioVolume.xml' path='doc/member[@name="IMFSimpleAudioVolume"]/*'/>
[Guid("089EDF13-CF71-4338-8D13-9E569DBDC319")]
[NativeTypeName("struct IMFSimpleAudioVolume : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSimpleAudioVolume : IMFSimpleAudioVolume.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSimpleAudioVolume));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSimpleAudioVolume*, Guid*, void**, int> )(lpVtbl[0]))((IMFSimpleAudioVolume*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSimpleAudioVolume*, uint> )(lpVtbl[1]))((IMFSimpleAudioVolume*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSimpleAudioVolume*, uint> )(lpVtbl[2]))((IMFSimpleAudioVolume*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSimpleAudioVolume.xml' path='doc/member[@name="IMFSimpleAudioVolume.SetMasterVolume"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMasterVolume(float fLevel)
    {
        return ((delegate* unmanaged<IMFSimpleAudioVolume*, float, int> )(lpVtbl[3]))((IMFSimpleAudioVolume*)Unsafe.AsPointer(ref this), fLevel);
    }

    /// <include file='IMFSimpleAudioVolume.xml' path='doc/member[@name="IMFSimpleAudioVolume.GetMasterVolume"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMasterVolume(float* pfLevel)
    {
        return ((delegate* unmanaged<IMFSimpleAudioVolume*, float*, int> )(lpVtbl[4]))((IMFSimpleAudioVolume*)Unsafe.AsPointer(ref this), pfLevel);
    }

    /// <include file='IMFSimpleAudioVolume.xml' path='doc/member[@name="IMFSimpleAudioVolume.SetMute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetMute([NativeTypeName("const BOOL")] BOOL bMute)
    {
        return ((delegate* unmanaged<IMFSimpleAudioVolume*, BOOL, int> )(lpVtbl[5]))((IMFSimpleAudioVolume*)Unsafe.AsPointer(ref this), bMute);
    }

    /// <include file='IMFSimpleAudioVolume.xml' path='doc/member[@name="IMFSimpleAudioVolume.GetMute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMute(BOOL* pbMute)
    {
        return ((delegate* unmanaged<IMFSimpleAudioVolume*, BOOL*, int> )(lpVtbl[6]))((IMFSimpleAudioVolume*)Unsafe.AsPointer(ref this), pbMute);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetMasterVolume(float fLevel);
        [VtblIndex(4)]
        HRESULT GetMasterVolume(float* pfLevel);
        [VtblIndex(5)]
        HRESULT SetMute([NativeTypeName("const BOOL")] BOOL bMute);
        [VtblIndex(6)]
        HRESULT GetMute(BOOL* pbMute);
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
        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetMasterVolume;
        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> GetMasterVolume;
        [NativeTypeName("HRESULT (const BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetMute;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetMute;
    }
}