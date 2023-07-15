// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAudioSessionManager.xml' path='doc/member[@name="IAudioSessionManager"]/*'/>
[Guid("BFA971F1-4D5E-40BB-935E-967039BFBEE4")]
[NativeTypeName("struct IAudioSessionManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioSessionManager : IAudioSessionManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioSessionManager));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioSessionManager*, Guid*, void**, int> )(lpVtbl[0]))((IAudioSessionManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioSessionManager*, uint> )(lpVtbl[1]))((IAudioSessionManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSessionManager*, uint> )(lpVtbl[2]))((IAudioSessionManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioSessionManager.xml' path='doc/member[@name="IAudioSessionManager.GetAudioSessionControl"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAudioSessionControl([NativeTypeName("LPCGUID")] Guid* AudioSessionGuid, [NativeTypeName("DWORD")] uint StreamFlags, IAudioSessionControl** SessionControl)
    {
        return ((delegate* unmanaged<IAudioSessionManager*, Guid*, uint, IAudioSessionControl**, int> )(lpVtbl[3]))((IAudioSessionManager*)Unsafe.AsPointer(ref this), AudioSessionGuid, StreamFlags, SessionControl);
    }

    /// <include file='IAudioSessionManager.xml' path='doc/member[@name="IAudioSessionManager.GetSimpleAudioVolume"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSimpleAudioVolume([NativeTypeName("LPCGUID")] Guid* AudioSessionGuid, [NativeTypeName("DWORD")] uint StreamFlags, ISimpleAudioVolume** AudioVolume)
    {
        return ((delegate* unmanaged<IAudioSessionManager*, Guid*, uint, ISimpleAudioVolume**, int> )(lpVtbl[4]))((IAudioSessionManager*)Unsafe.AsPointer(ref this), AudioSessionGuid, StreamFlags, AudioVolume);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAudioSessionControl([NativeTypeName("LPCGUID")] Guid* AudioSessionGuid, [NativeTypeName("DWORD")] uint StreamFlags, IAudioSessionControl** SessionControl);
        [VtblIndex(4)]
        HRESULT GetSimpleAudioVolume([NativeTypeName("LPCGUID")] Guid* AudioSessionGuid, [NativeTypeName("DWORD")] uint StreamFlags, ISimpleAudioVolume** AudioVolume);
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
        [NativeTypeName("HRESULT (LPCGUID, DWORD, IAudioSessionControl **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, IAudioSessionControl**, int> GetAudioSessionControl;
        [NativeTypeName("HRESULT (LPCGUID, DWORD, ISimpleAudioVolume **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, ISimpleAudioVolume**, int> GetSimpleAudioVolume;
    }
}