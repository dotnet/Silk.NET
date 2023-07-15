// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAudioClient.xml' path='doc/member[@name="IAudioClient"]/*'/>
[Guid("1CB9AD4C-DBFA-4C32-B178-C2F568A703B2")]
[NativeTypeName("struct IAudioClient : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioClient : IAudioClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioClient));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioClient*, Guid*, void**, int> )(lpVtbl[0]))((IAudioClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioClient*, uint> )(lpVtbl[1]))((IAudioClient*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioClient*, uint> )(lpVtbl[2]))((IAudioClient*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioClient.xml' path='doc/member[@name="IAudioClient.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(AUDCLNT_SHAREMODE ShareMode, [NativeTypeName("DWORD")] uint StreamFlags, [NativeTypeName("REFERENCE_TIME")] long hnsBufferDuration, [NativeTypeName("REFERENCE_TIME")] long hnsPeriodicity, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid)
    {
        return ((delegate* unmanaged<IAudioClient*, AUDCLNT_SHAREMODE, uint, long, long, WAVEFORMATEX*, Guid*, int> )(lpVtbl[3]))((IAudioClient*)Unsafe.AsPointer(ref this), ShareMode, StreamFlags, hnsBufferDuration, hnsPeriodicity, pFormat, AudioSessionGuid);
    }

    /// <include file='IAudioClient.xml' path='doc/member[@name="IAudioClient.GetBufferSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBufferSize([NativeTypeName("UINT32 *")] uint* pNumBufferFrames)
    {
        return ((delegate* unmanaged<IAudioClient*, uint*, int> )(lpVtbl[4]))((IAudioClient*)Unsafe.AsPointer(ref this), pNumBufferFrames);
    }

    /// <include file='IAudioClient.xml' path='doc/member[@name="IAudioClient.GetStreamLatency"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStreamLatency([NativeTypeName("REFERENCE_TIME *")] long* phnsLatency)
    {
        return ((delegate* unmanaged<IAudioClient*, long*, int> )(lpVtbl[5]))((IAudioClient*)Unsafe.AsPointer(ref this), phnsLatency);
    }

    /// <include file='IAudioClient.xml' path='doc/member[@name="IAudioClient.GetCurrentPadding"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetCurrentPadding([NativeTypeName("UINT32 *")] uint* pNumPaddingFrames)
    {
        return ((delegate* unmanaged<IAudioClient*, uint*, int> )(lpVtbl[6]))((IAudioClient*)Unsafe.AsPointer(ref this), pNumPaddingFrames);
    }

    /// <include file='IAudioClient.xml' path='doc/member[@name="IAudioClient.IsFormatSupported"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsFormatSupported(AUDCLNT_SHAREMODE ShareMode, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, WAVEFORMATEX** ppClosestMatch)
    {
        return ((delegate* unmanaged<IAudioClient*, AUDCLNT_SHAREMODE, WAVEFORMATEX*, WAVEFORMATEX**, int> )(lpVtbl[7]))((IAudioClient*)Unsafe.AsPointer(ref this), ShareMode, pFormat, ppClosestMatch);
    }

    /// <include file='IAudioClient.xml' path='doc/member[@name="IAudioClient.GetMixFormat"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetMixFormat(WAVEFORMATEX** ppDeviceFormat)
    {
        return ((delegate* unmanaged<IAudioClient*, WAVEFORMATEX**, int> )(lpVtbl[8]))((IAudioClient*)Unsafe.AsPointer(ref this), ppDeviceFormat);
    }

    /// <include file='IAudioClient.xml' path='doc/member[@name="IAudioClient.GetDevicePeriod"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDevicePeriod([NativeTypeName("REFERENCE_TIME *")] long* phnsDefaultDevicePeriod, [NativeTypeName("REFERENCE_TIME *")] long* phnsMinimumDevicePeriod)
    {
        return ((delegate* unmanaged<IAudioClient*, long*, long*, int> )(lpVtbl[9]))((IAudioClient*)Unsafe.AsPointer(ref this), phnsDefaultDevicePeriod, phnsMinimumDevicePeriod);
    }

    /// <include file='IAudioClient.xml' path='doc/member[@name="IAudioClient.Start"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IAudioClient*, int> )(lpVtbl[10]))((IAudioClient*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioClient.xml' path='doc/member[@name="IAudioClient.Stop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IAudioClient*, int> )(lpVtbl[11]))((IAudioClient*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioClient.xml' path='doc/member[@name="IAudioClient.Reset"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IAudioClient*, int> )(lpVtbl[12]))((IAudioClient*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioClient.xml' path='doc/member[@name="IAudioClient.SetEventHandle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetEventHandle(HANDLE eventHandle)
    {
        return ((delegate* unmanaged<IAudioClient*, HANDLE, int> )(lpVtbl[13]))((IAudioClient*)Unsafe.AsPointer(ref this), eventHandle);
    }

    /// <include file='IAudioClient.xml' path='doc/member[@name="IAudioClient.GetService"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetService([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IAudioClient*, Guid*, void**, int> )(lpVtbl[14]))((IAudioClient*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(AUDCLNT_SHAREMODE ShareMode, [NativeTypeName("DWORD")] uint StreamFlags, [NativeTypeName("REFERENCE_TIME")] long hnsBufferDuration, [NativeTypeName("REFERENCE_TIME")] long hnsPeriodicity, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, [NativeTypeName("LPCGUID")] Guid* AudioSessionGuid);
        [VtblIndex(4)]
        HRESULT GetBufferSize([NativeTypeName("UINT32 *")] uint* pNumBufferFrames);
        [VtblIndex(5)]
        HRESULT GetStreamLatency([NativeTypeName("REFERENCE_TIME *")] long* phnsLatency);
        [VtblIndex(6)]
        HRESULT GetCurrentPadding([NativeTypeName("UINT32 *")] uint* pNumPaddingFrames);
        [VtblIndex(7)]
        HRESULT IsFormatSupported(AUDCLNT_SHAREMODE ShareMode, [NativeTypeName("const WAVEFORMATEX *")] WAVEFORMATEX* pFormat, WAVEFORMATEX** ppClosestMatch);
        [VtblIndex(8)]
        HRESULT GetMixFormat(WAVEFORMATEX** ppDeviceFormat);
        [VtblIndex(9)]
        HRESULT GetDevicePeriod([NativeTypeName("REFERENCE_TIME *")] long* phnsDefaultDevicePeriod, [NativeTypeName("REFERENCE_TIME *")] long* phnsMinimumDevicePeriod);
        [VtblIndex(10)]
        HRESULT Start();
        [VtblIndex(11)]
        HRESULT Stop();
        [VtblIndex(12)]
        HRESULT Reset();
        [VtblIndex(13)]
        HRESULT SetEventHandle(HANDLE eventHandle);
        [VtblIndex(14)]
        HRESULT GetService([NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
        [NativeTypeName("HRESULT (AUDCLNT_SHAREMODE, DWORD, REFERENCE_TIME, REFERENCE_TIME, const WAVEFORMATEX *, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AUDCLNT_SHAREMODE, uint, long, long, WAVEFORMATEX*, Guid*, int> Initialize;
        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetBufferSize;
        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> GetStreamLatency;
        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentPadding;
        [NativeTypeName("HRESULT (AUDCLNT_SHAREMODE, const WAVEFORMATEX *, WAVEFORMATEX **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AUDCLNT_SHAREMODE, WAVEFORMATEX*, WAVEFORMATEX**, int> IsFormatSupported;
        [NativeTypeName("HRESULT (WAVEFORMATEX **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WAVEFORMATEX**, int> GetMixFormat;
        [NativeTypeName("HRESULT (REFERENCE_TIME *, REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, long*, int> GetDevicePeriod;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT (HANDLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> SetEventHandle;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetService;
    }
}