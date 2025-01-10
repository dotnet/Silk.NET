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

[Guid("87BE986C-10BE-4943-BF48-4B54CE1983A2")]
[NativeTypeName("struct IMFContentDecryptionModule : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IMFContentDecryptionModule
    : IMFContentDecryptionModule.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFContentDecryptionModule));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModule, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFContentDecryptionModule, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFContentDecryptionModule, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetContentEnabler(IMFContentEnabler contentEnabler, IMFAsyncResult result)
    {
        return (
            (delegate* unmanaged<
                IMFContentDecryptionModule,
                IMFContentEnabler,
                IMFAsyncResult,
                int>)((*lpVtbl)[3])
        )(this, contentEnabler, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSuspendNotify(IMFCdmSuspendNotify* notify)
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModule, IMFCdmSuspendNotify*, int>)(
                (*lpVtbl)[4]
            )
        )(this, notify);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPMPHostApp(IMFPMPHostApp pmpHostApp)
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModule, IMFPMPHostApp, int>)((*lpVtbl)[5])
        )(this, pmpHostApp);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateSession(
        MF_MEDIAKEYSESSION_TYPE sessionType,
        IMFContentDecryptionModuleSessionCallbacks callbacks,
        IMFContentDecryptionModuleSession* session
    )
    {
        return (
            (delegate* unmanaged<
                IMFContentDecryptionModule,
                MF_MEDIAKEYSESSION_TYPE,
                IMFContentDecryptionModuleSessionCallbacks,
                IMFContentDecryptionModuleSession*,
                int>)((*lpVtbl)[6])
        )(this, sessionType, callbacks, session);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetServerCertificate(
        [NativeTypeName("const BYTE *")] byte* certificate,
        [NativeTypeName("DWORD")] uint certificateSize
    )
    {
        return ((delegate* unmanaged<IMFContentDecryptionModule, byte*, uint, int>)((*lpVtbl)[7]))(
            this,
            certificate,
            certificateSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateTrustedInput(
        [NativeTypeName("const BYTE *")] byte* contentInitData,
        [NativeTypeName("DWORD")] uint contentInitDataSize,
        IMFTrustedInput* trustedInput
    )
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModule, byte*, uint, IMFTrustedInput*, int>)(
                (*lpVtbl)[8]
            )
        )(this, contentInitData, contentInitDataSize, trustedInput);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetProtectionSystemIds(Guid** systemIds, [NativeTypeName("DWORD *")] uint* count)
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModule, Guid**, uint*, int>)((*lpVtbl)[9])
        )(this, systemIds, count);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetContentEnabler(IMFContentEnabler contentEnabler, IMFAsyncResult result);

        [VtblIndex(4)]
        HRESULT GetSuspendNotify(IMFCdmSuspendNotify* notify);

        [VtblIndex(5)]
        HRESULT SetPMPHostApp(IMFPMPHostApp pmpHostApp);

        [VtblIndex(6)]
        HRESULT CreateSession(
            MF_MEDIAKEYSESSION_TYPE sessionType,
            IMFContentDecryptionModuleSessionCallbacks callbacks,
            IMFContentDecryptionModuleSession* session
        );

        [VtblIndex(7)]
        HRESULT SetServerCertificate(
            [NativeTypeName("const BYTE *")] byte* certificate,
            [NativeTypeName("DWORD")] uint certificateSize
        );

        [VtblIndex(8)]
        HRESULT CreateTrustedInput(
            [NativeTypeName("const BYTE *")] byte* contentInitData,
            [NativeTypeName("DWORD")] uint contentInitDataSize,
            IMFTrustedInput* trustedInput
        );

        [VtblIndex(9)]
        HRESULT GetProtectionSystemIds(Guid** systemIds, [NativeTypeName("DWORD *")] uint* count);
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

        [NativeTypeName("HRESULT (IMFContentEnabler *, IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IMFContentEnabler,
            IMFAsyncResult,
            int> SetContentEnabler;

        [NativeTypeName("HRESULT (IMFCdmSuspendNotify **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFCdmSuspendNotify*, int> GetSuspendNotify;

        [NativeTypeName("HRESULT (IMFPMPHostApp *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFPMPHostApp, int> SetPMPHostApp;

        [NativeTypeName(
            "HRESULT (MF_MEDIAKEYSESSION_TYPE, IMFContentDecryptionModuleSessionCallbacks *, IMFContentDecryptionModuleSession **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MF_MEDIAKEYSESSION_TYPE,
            IMFContentDecryptionModuleSessionCallbacks,
            IMFContentDecryptionModuleSession*,
            int> CreateSession;

        [NativeTypeName("HRESULT (const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> SetServerCertificate;

        [NativeTypeName(
            "HRESULT (const BYTE *, DWORD, IMFTrustedInput **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, byte*, uint, IMFTrustedInput*, int> CreateTrustedInput;

        [NativeTypeName("HRESULT (GUID **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid**, uint*, int> GetProtectionSystemIds;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFContentDecryptionModule"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFContentDecryptionModule(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFContentDecryptionModule"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFContentDecryptionModule(Silk.NET.Windows.IUnknown value)
    {
        return new IMFContentDecryptionModule(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFContentDecryptionModule"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFContentDecryptionModule"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFContentDecryptionModule value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
