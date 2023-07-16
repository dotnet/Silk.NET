// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPlayToControl.xml' path='doc/member[@name="IPlayToControl"]/*'/>
[Guid("607574EB-F4B6-45C1-B08C-CB715122901D")]
[NativeTypeName("struct IPlayToControl : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IPlayToControl : IPlayToControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPlayToControl));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPlayToControl*, Guid*, void**, int> )(lpVtbl[0]))((IPlayToControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPlayToControl*, uint> )(lpVtbl[1]))((IPlayToControl*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPlayToControl*, uint> )(lpVtbl[2]))((IPlayToControl*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IPlayToControl.xml' path='doc/member[@name="IPlayToControl.Connect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Connect(IMFSharingEngineClassFactory* pFactory)
    {
        return ((delegate* unmanaged<IPlayToControl*, IMFSharingEngineClassFactory*, int> )(lpVtbl[3]))((IPlayToControl*)Unsafe.AsPointer(ref this), pFactory);
    }

    /// <include file='IPlayToControl.xml' path='doc/member[@name="IPlayToControl.Disconnect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Disconnect()
    {
        return ((delegate* unmanaged<IPlayToControl*, int> )(lpVtbl[4]))((IPlayToControl*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Connect(IMFSharingEngineClassFactory* pFactory);
        [VtblIndex(4)]
        HRESULT Disconnect();
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
    }
}