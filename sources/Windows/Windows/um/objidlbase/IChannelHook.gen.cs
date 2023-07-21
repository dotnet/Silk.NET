// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IChannelHook.xml' path='doc/member[@name="IChannelHook"]/*' />
[Guid("1008C4A0-7613-11CF-9AF1-0020AF6E72F4")]
[NativeTypeName("struct IChannelHook : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IChannelHook : IChannelHook.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IChannelHook));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IChannelHook*, Guid*, void**, int>)(lpVtbl[0]))((IChannelHook*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IChannelHook*, uint>)(lpVtbl[1]))((IChannelHook*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IChannelHook*, uint>)(lpVtbl[2]))((IChannelHook*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IChannelHook.xml' path='doc/member[@name="IChannelHook.ClientGetSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void ClientGetSize([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize)
    {
        ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint*, void>)(lpVtbl[3]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize);
    }

    /// <include file='IChannelHook.xml' path='doc/member[@name="IChannelHook.ClientFillBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void ClientFillBuffer([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize, void* pDataBuffer)
    {
        ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint*, void*, void>)(lpVtbl[4]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize, pDataBuffer);
    }

    /// <include file='IChannelHook.xml' path='doc/member[@name="IChannelHook.ClientNotify"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void ClientNotify([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG")] uint cbDataSize, void* pDataBuffer, [NativeTypeName("DWORD")] uint lDataRep, HRESULT hrFault)
    {
        ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint, void*, uint, HRESULT, void>)(lpVtbl[5]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, cbDataSize, pDataBuffer, lDataRep, hrFault);
    }

    /// <include file='IChannelHook.xml' path='doc/member[@name="IChannelHook.ServerNotify"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void ServerNotify([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG")] uint cbDataSize, void* pDataBuffer, [NativeTypeName("DWORD")] uint lDataRep)
    {
        ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint, void*, uint, void>)(lpVtbl[6]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, cbDataSize, pDataBuffer, lDataRep);
    }

    /// <include file='IChannelHook.xml' path='doc/member[@name="IChannelHook.ServerGetSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void ServerGetSize([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, HRESULT hrFault, [NativeTypeName("ULONG *")] uint* pDataSize)
    {
        ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, HRESULT, uint*, void>)(lpVtbl[7]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, hrFault, pDataSize);
    }

    /// <include file='IChannelHook.xml' path='doc/member[@name="IChannelHook.ServerFillBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void ServerFillBuffer([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize, void* pDataBuffer, HRESULT hrFault)
    {
        ((delegate* unmanaged<IChannelHook*, Guid*, Guid*, uint*, void*, HRESULT, void>)(lpVtbl[8]))((IChannelHook*)Unsafe.AsPointer(ref this), uExtent, riid, pDataSize, pDataBuffer, hrFault);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void ClientGetSize([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize);

        [VtblIndex(4)]
        void ClientFillBuffer([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize, void* pDataBuffer);

        [VtblIndex(5)]
        void ClientNotify([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG")] uint cbDataSize, void* pDataBuffer, [NativeTypeName("DWORD")] uint lDataRep, HRESULT hrFault);

        [VtblIndex(6)]
        void ServerNotify([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG")] uint cbDataSize, void* pDataBuffer, [NativeTypeName("DWORD")] uint lDataRep);

        [VtblIndex(7)]
        void ServerGetSize([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, HRESULT hrFault, [NativeTypeName("ULONG *")] uint* pDataSize);

        [VtblIndex(8)]
        void ServerFillBuffer([NativeTypeName("const GUID &")] Guid* uExtent, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("ULONG *")] uint* pDataSize, void* pDataBuffer, HRESULT hrFault);
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

        [NativeTypeName("void (const GUID &, const IID &, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, uint*, void> ClientGetSize;

        [NativeTypeName("void (const GUID &, const IID &, ULONG *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, uint*, void*, void> ClientFillBuffer;

        [NativeTypeName("void (const GUID &, const IID &, ULONG, void *, DWORD, HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, uint, void*, uint, HRESULT, void> ClientNotify;

        [NativeTypeName("void (const GUID &, const IID &, ULONG, void *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, uint, void*, uint, void> ServerNotify;

        [NativeTypeName("void (const GUID &, const IID &, HRESULT, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, HRESULT, uint*, void> ServerGetSize;

        [NativeTypeName("void (const GUID &, const IID &, ULONG *, void *, HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, uint*, void*, HRESULT, void> ServerFillBuffer;
    }
}
