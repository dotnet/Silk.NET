// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3F96EE40-AD81-4096-8470-59A4B770F89A")]
[NativeTypeName("struct IMFContentDecryptionModuleSessionCallbacks : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IMFContentDecryptionModuleSessionCallbacks
    : IMFContentDecryptionModuleSessionCallbacks.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFContentDecryptionModuleSessionCallbacks));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT KeyMessage(
        MF_MEDIAKEYSESSION_MESSAGETYPE messageType,
        [NativeTypeName("const BYTE *")] byte* message,
        [NativeTypeName("DWORD")] uint messageSize,
        [NativeTypeName("LPCWSTR")] ushort* destinationURL
    )
    {
        return (
            (delegate* unmanaged<
                IMFContentDecryptionModuleSessionCallbacks,
                MF_MEDIAKEYSESSION_MESSAGETYPE,
                byte*,
                uint,
                ushort*,
                int>)((*lpVtbl)[3])
        )(this, messageType, message, messageSize, destinationURL);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT KeyStatusChanged()
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModuleSessionCallbacks, int>)((*lpVtbl)[4])
        )(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT KeyMessage(
            MF_MEDIAKEYSESSION_MESSAGETYPE messageType,
            [NativeTypeName("const BYTE *")] byte* message,
            [NativeTypeName("DWORD")] uint messageSize,
            [NativeTypeName("LPCWSTR")] ushort* destinationURL
        );

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

        [NativeTypeName(
            "HRESULT (MF_MEDIAKEYSESSION_MESSAGETYPE, const BYTE *, DWORD, LPCWSTR) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MF_MEDIAKEYSESSION_MESSAGETYPE,
            byte*,
            uint,
            ushort*,
            int> KeyMessage;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> KeyStatusChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFContentDecryptionModuleSessionCallbacks"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFContentDecryptionModuleSessionCallbacks(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFContentDecryptionModuleSessionCallbacks"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFContentDecryptionModuleSessionCallbacks(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IMFContentDecryptionModuleSessionCallbacks(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFContentDecryptionModuleSessionCallbacks"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFContentDecryptionModuleSessionCallbacks"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IMFContentDecryptionModuleSessionCallbacks value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
