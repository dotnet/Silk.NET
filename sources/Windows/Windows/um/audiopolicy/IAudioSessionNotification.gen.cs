// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAudioSessionNotification.xml' path='doc/member[@name="IAudioSessionNotification"]/*'/>
[Guid("641DD20B-4D41-49CC-ABA3-174B9477BB08")]
[NativeTypeName("struct IAudioSessionNotification : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioSessionNotification : IAudioSessionNotification.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioSessionNotification));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioSessionNotification*, Guid*, void**, int> )(lpVtbl[0]))((IAudioSessionNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioSessionNotification*, uint> )(lpVtbl[1]))((IAudioSessionNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSessionNotification*, uint> )(lpVtbl[2]))((IAudioSessionNotification*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioSessionNotification.xml' path='doc/member[@name="IAudioSessionNotification.OnSessionCreated"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnSessionCreated(IAudioSessionControl* NewSession)
    {
        return ((delegate* unmanaged<IAudioSessionNotification*, IAudioSessionControl*, int> )(lpVtbl[3]))((IAudioSessionNotification*)Unsafe.AsPointer(ref this), NewSession);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnSessionCreated(IAudioSessionControl* NewSession);
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
        [NativeTypeName("HRESULT (IAudioSessionControl *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAudioSessionControl*, int> OnSessionCreated;
    }
}