// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAudioChannelConfig.xml' path='doc/member[@name="IAudioChannelConfig"]/*'/>
[Guid("BB11C46F-EC28-493C-B88A-5DB88062CE98")]
[NativeTypeName("struct IAudioChannelConfig : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioChannelConfig : IAudioChannelConfig.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioChannelConfig));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioChannelConfig*, Guid*, void**, int> )(lpVtbl[0]))((IAudioChannelConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioChannelConfig*, uint> )(lpVtbl[1]))((IAudioChannelConfig*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioChannelConfig*, uint> )(lpVtbl[2]))((IAudioChannelConfig*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioChannelConfig.xml' path='doc/member[@name="IAudioChannelConfig.SetChannelConfig"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetChannelConfig([NativeTypeName("DWORD")] uint dwConfig, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioChannelConfig*, uint, Guid*, int> )(lpVtbl[3]))((IAudioChannelConfig*)Unsafe.AsPointer(ref this), dwConfig, pguidEventContext);
    }

    /// <include file='IAudioChannelConfig.xml' path='doc/member[@name="IAudioChannelConfig.GetChannelConfig"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetChannelConfig([NativeTypeName("DWORD *")] uint* pdwConfig)
    {
        return ((delegate* unmanaged<IAudioChannelConfig*, uint*, int> )(lpVtbl[4]))((IAudioChannelConfig*)Unsafe.AsPointer(ref this), pdwConfig);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetChannelConfig([NativeTypeName("DWORD")] uint dwConfig, [NativeTypeName("LPCGUID")] Guid* pguidEventContext);
        [VtblIndex(4)]
        HRESULT GetChannelConfig([NativeTypeName("DWORD *")] uint* pdwConfig);
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
        [NativeTypeName("HRESULT (DWORD, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, int> SetChannelConfig;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetChannelConfig;
    }
}