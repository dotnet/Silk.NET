// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAudioMute.xml' path='doc/member[@name="IAudioMute"]/*'/>
[Guid("DF45AEEA-B74A-4B6B-AFAD-2366B6AA012E")]
[NativeTypeName("struct IAudioMute : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioMute : IAudioMute.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioMute));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioMute*, Guid*, void**, int> )(lpVtbl[0]))((IAudioMute*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioMute*, uint> )(lpVtbl[1]))((IAudioMute*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioMute*, uint> )(lpVtbl[2]))((IAudioMute*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioMute.xml' path='doc/member[@name="IAudioMute.SetMute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMute(BOOL bMuted, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioMute*, BOOL, Guid*, int> )(lpVtbl[3]))((IAudioMute*)Unsafe.AsPointer(ref this), bMuted, pguidEventContext);
    }

    /// <include file='IAudioMute.xml' path='doc/member[@name="IAudioMute.GetMute"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMute(BOOL* pbMuted)
    {
        return ((delegate* unmanaged<IAudioMute*, BOOL*, int> )(lpVtbl[4]))((IAudioMute*)Unsafe.AsPointer(ref this), pbMuted);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetMute(BOOL bMuted, [NativeTypeName("LPCGUID")] Guid* pguidEventContext);
        [VtblIndex(4)]
        HRESULT GetMute(BOOL* pbMuted);
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
        [NativeTypeName("HRESULT (BOOL, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, Guid*, int> SetMute;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetMute;
    }
}