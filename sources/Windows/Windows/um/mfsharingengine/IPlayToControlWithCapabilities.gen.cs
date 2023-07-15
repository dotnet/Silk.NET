// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IPlayToControlWithCapabilities.xml' path='doc/member[@name="IPlayToControlWithCapabilities"]/*'/>
[Guid("AA9DD80F-C50A-4220-91C1-332287F82A34")]
[NativeTypeName("struct IPlayToControlWithCapabilities : IPlayToControl")]
[NativeInheritance("IPlayToControl")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IPlayToControlWithCapabilities : IPlayToControlWithCapabilities.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPlayToControlWithCapabilities));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities*, Guid*, void**, int> )(lpVtbl[0]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities*, uint> )(lpVtbl[1]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities*, uint> )(lpVtbl[2]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPlayToControl.Connect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Connect(IMFSharingEngineClassFactory* pFactory)
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities*, IMFSharingEngineClassFactory*, int> )(lpVtbl[3]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this), pFactory);
    }

    /// <inheritdoc cref = "IPlayToControl.Disconnect"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Disconnect()
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities*, int> )(lpVtbl[4]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPlayToControlWithCapabilities.xml' path='doc/member[@name="IPlayToControlWithCapabilities.GetCapabilities"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCapabilities(PLAYTO_SOURCE_CREATEFLAGS* pCapabilities)
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities*, PLAYTO_SOURCE_CREATEFLAGS*, int> )(lpVtbl[5]))((IPlayToControlWithCapabilities*)Unsafe.AsPointer(ref this), pCapabilities);
    }

    public interface Interface : IPlayToControl.Interface
    {
        [VtblIndex(5)]
        HRESULT GetCapabilities(PLAYTO_SOURCE_CREATEFLAGS* pCapabilities);
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
        [NativeTypeName("HRESULT (IMFSharingEngineClassFactory *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSharingEngineClassFactory*, int> Connect;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Disconnect;
        [NativeTypeName("HRESULT (PLAYTO_SOURCE_CREATEFLAGS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PLAYTO_SOURCE_CREATEFLAGS*, int> GetCapabilities;
    }
}