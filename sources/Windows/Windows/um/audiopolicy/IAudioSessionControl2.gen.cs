// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAudioSessionControl2.xml' path='doc/member[@name="IAudioSessionControl2"]/*'/>
[Guid("BFB7FF88-7239-4FC9-8FA2-07C950BE9C6D")]
[NativeTypeName("struct IAudioSessionControl2 : IAudioSessionControl")]
[NativeInheritance("IAudioSessionControl")]
public unsafe partial struct IAudioSessionControl2 : IAudioSessionControl2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioSessionControl2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, Guid*, void**, int> )(lpVtbl[0]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, uint> )(lpVtbl[1]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, uint> )(lpVtbl[2]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IAudioSessionControl.GetState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetState(AudioSessionState* pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, AudioSessionState*, int> )(lpVtbl[3]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref = "IAudioSessionControl.GetDisplayName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDisplayName([NativeTypeName("LPWSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, ushort**, int> )(lpVtbl[4]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref = "IAudioSessionControl.SetDisplayName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetDisplayName([NativeTypeName("LPCWSTR")] ushort* Value, [NativeTypeName("LPCGUID")] Guid* EventContext)
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, ushort*, Guid*, int> )(lpVtbl[5]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), Value, EventContext);
    }

    /// <inheritdoc cref = "IAudioSessionControl.GetIconPath"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetIconPath([NativeTypeName("LPWSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, ushort**, int> )(lpVtbl[6]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref = "IAudioSessionControl.SetIconPath"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetIconPath([NativeTypeName("LPCWSTR")] ushort* Value, [NativeTypeName("LPCGUID")] Guid* EventContext)
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, ushort*, Guid*, int> )(lpVtbl[7]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), Value, EventContext);
    }

    /// <inheritdoc cref = "IAudioSessionControl.GetGroupingParam"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetGroupingParam(Guid* pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, Guid*, int> )(lpVtbl[8]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <inheritdoc cref = "IAudioSessionControl.SetGroupingParam"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetGroupingParam([NativeTypeName("LPCGUID")] Guid* Override, [NativeTypeName("LPCGUID")] Guid* EventContext)
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, Guid*, Guid*, int> )(lpVtbl[9]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), Override, EventContext);
    }

    /// <inheritdoc cref = "IAudioSessionControl.RegisterAudioSessionNotification"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RegisterAudioSessionNotification(IAudioSessionEvents* NewNotifications)
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, IAudioSessionEvents*, int> )(lpVtbl[10]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), NewNotifications);
    }

    /// <inheritdoc cref = "IAudioSessionControl.UnregisterAudioSessionNotification"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnregisterAudioSessionNotification(IAudioSessionEvents* NewNotifications)
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, IAudioSessionEvents*, int> )(lpVtbl[11]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), NewNotifications);
    }

    /// <include file='IAudioSessionControl2.xml' path='doc/member[@name="IAudioSessionControl2.GetSessionIdentifier"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetSessionIdentifier([NativeTypeName("LPWSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, ushort**, int> )(lpVtbl[12]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IAudioSessionControl2.xml' path='doc/member[@name="IAudioSessionControl2.GetSessionInstanceIdentifier"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetSessionInstanceIdentifier([NativeTypeName("LPWSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, ushort**, int> )(lpVtbl[13]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IAudioSessionControl2.xml' path='doc/member[@name="IAudioSessionControl2.GetProcessId"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetProcessId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, uint*, int> )(lpVtbl[14]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IAudioSessionControl2.xml' path='doc/member[@name="IAudioSessionControl2.IsSystemSoundsSession"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsSystemSoundsSession()
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, int> )(lpVtbl[15]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioSessionControl2.xml' path='doc/member[@name="IAudioSessionControl2.SetDuckingPreference"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetDuckingPreference(BOOL optOut)
    {
        return ((delegate* unmanaged<IAudioSessionControl2*, BOOL, int> )(lpVtbl[16]))((IAudioSessionControl2*)Unsafe.AsPointer(ref this), optOut);
    }

    public interface Interface : IAudioSessionControl.Interface
    {
        [VtblIndex(12)]
        HRESULT GetSessionIdentifier([NativeTypeName("LPWSTR *")] ushort** pRetVal);
        [VtblIndex(13)]
        HRESULT GetSessionInstanceIdentifier([NativeTypeName("LPWSTR *")] ushort** pRetVal);
        [VtblIndex(14)]
        HRESULT GetProcessId([NativeTypeName("DWORD *")] uint* pRetVal);
        [VtblIndex(15)]
        HRESULT IsSystemSoundsSession();
        [VtblIndex(16)]
        HRESULT SetDuckingPreference(BOOL optOut);
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
        [NativeTypeName("HRESULT (AudioSessionState *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AudioSessionState*, int> GetState;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;
        [NativeTypeName("HRESULT (LPCWSTR, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, int> SetDisplayName;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetIconPath;
        [NativeTypeName("HRESULT (LPCWSTR, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, Guid*, int> SetIconPath;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGroupingParam;
        [NativeTypeName("HRESULT (LPCGUID, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, int> SetGroupingParam;
        [NativeTypeName("HRESULT (IAudioSessionEvents *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAudioSessionEvents*, int> RegisterAudioSessionNotification;
        [NativeTypeName("HRESULT (IAudioSessionEvents *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAudioSessionEvents*, int> UnregisterAudioSessionNotification;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSessionIdentifier;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSessionInstanceIdentifier;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetProcessId;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsSystemSoundsSession;
        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetDuckingPreference;
    }
}