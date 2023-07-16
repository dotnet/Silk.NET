// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFContentDecryptionModuleSessionCallbacks.xml' path='doc/member[@name="IMFContentDecryptionModuleSessionCallbacks"]/*'/>
[Guid("3F96EE40-AD81-4096-8470-59A4B770F89A")]
[NativeTypeName("struct IMFContentDecryptionModuleSessionCallbacks : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IMFContentDecryptionModuleSessionCallbacks : IMFContentDecryptionModuleSessionCallbacks.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFContentDecryptionModuleSessionCallbacks));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, Guid*, void**, int> )(lpVtbl[0]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, uint> )(lpVtbl[1]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, uint> )(lpVtbl[2]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFContentDecryptionModuleSessionCallbacks.xml' path='doc/member[@name="IMFContentDecryptionModuleSessionCallbacks.KeyMessage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT KeyMessage(MF_MEDIAKEYSESSION_MESSAGETYPE messageType, [NativeTypeName("const BYTE *")] byte* message, [NativeTypeName("DWORD")] uint messageSize, [NativeTypeName("LPCWSTR")] ushort* destinationURL)
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, MF_MEDIAKEYSESSION_MESSAGETYPE, byte*, uint, ushort*, int> )(lpVtbl[3]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this), messageType, message, messageSize, destinationURL);
    }

    /// <include file='IMFContentDecryptionModuleSessionCallbacks.xml' path='doc/member[@name="IMFContentDecryptionModuleSessionCallbacks.KeyStatusChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT KeyStatusChanged()
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks*, int> )(lpVtbl[4]))((IMFContentDecryptionModuleSessionCallbacks*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT KeyMessage(MF_MEDIAKEYSESSION_MESSAGETYPE messageType, [NativeTypeName("const BYTE *")] byte* message, [NativeTypeName("DWORD")] uint messageSize, [NativeTypeName("LPCWSTR")] ushort* destinationURL);
        [VtblIndex(4)]
        HRESULT KeyStatusChanged();
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
        [NativeTypeName("HRESULT (MF_MEDIAKEYSESSION_MESSAGETYPE, const BYTE *, DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_MEDIAKEYSESSION_MESSAGETYPE, byte*, uint, ushort*, int> KeyMessage;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> KeyStatusChanged;
    }
}