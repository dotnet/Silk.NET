// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("45892507-AD66-4DE2-83A2-ACBB13CD8D43")]
[NativeTypeName("struct IMFMediaKeys2 : IMFMediaKeys")]
[NativeInheritance("IMFMediaKeys")]
public unsafe partial struct IMFMediaKeys2 : IMFMediaKeys2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaKeys2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaKeys2, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaKeys2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaKeys2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateSession(
        [NativeTypeName("BSTR")] ushort* mimeType,
        [NativeTypeName("const BYTE *")] byte* initData,
        [NativeTypeName("DWORD")] uint cb,
        [NativeTypeName("const BYTE *")] byte* customData,
        [NativeTypeName("DWORD")] uint cbCustomData,
        IMFMediaKeySessionNotify notify,
        IMFMediaKeySession* ppSession
    )
    {
        return (
            (delegate* unmanaged<
                IMFMediaKeys2,
                ushort*,
                byte*,
                uint,
                byte*,
                uint,
                IMFMediaKeySessionNotify,
                IMFMediaKeySession*,
                int>)((*lpVtbl)[3])
        )(this, mimeType, initData, cb, customData, cbCustomData, notify, ppSession);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_KeySystem([NativeTypeName("BSTR *")] ushort** keySystem)
    {
        return ((delegate* unmanaged<IMFMediaKeys2, ushort**, int>)((*lpVtbl)[4]))(this, keySystem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFMediaKeys2, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSuspendNotify(IMFCdmSuspendNotify* notify)
    {
        return ((delegate* unmanaged<IMFMediaKeys2, IMFCdmSuspendNotify*, int>)((*lpVtbl)[6]))(
            this,
            notify
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateSession2(
        MF_MEDIAKEYSESSION_TYPE eSessionType,
        IMFMediaKeySessionNotify2 pMFMediaKeySessionNotify2,
        IMFMediaKeySession2* ppSession
    )
    {
        return (
            (delegate* unmanaged<
                IMFMediaKeys2,
                MF_MEDIAKEYSESSION_TYPE,
                IMFMediaKeySessionNotify2,
                IMFMediaKeySession2*,
                int>)((*lpVtbl)[7])
        )(this, eSessionType, pMFMediaKeySessionNotify2, ppSession);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetServerCertificate(
        [NativeTypeName("const BYTE *")] byte* pbServerCertificate,
        [NativeTypeName("DWORD")] uint cb
    )
    {
        return ((delegate* unmanaged<IMFMediaKeys2, byte*, uint, int>)((*lpVtbl)[8]))(
            this,
            pbServerCertificate,
            cb
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDOMException(HRESULT systemCode, HRESULT* code)
    {
        return ((delegate* unmanaged<IMFMediaKeys2, HRESULT, HRESULT*, int>)((*lpVtbl)[9]))(
            this,
            systemCode,
            code
        );
    }

    public interface Interface : IMFMediaKeys.Interface
    {
        [VtblIndex(7)]
        HRESULT CreateSession2(
            MF_MEDIAKEYSESSION_TYPE eSessionType,
            IMFMediaKeySessionNotify2 pMFMediaKeySessionNotify2,
            IMFMediaKeySession2* ppSession
        );

        [VtblIndex(8)]
        HRESULT SetServerCertificate(
            [NativeTypeName("const BYTE *")] byte* pbServerCertificate,
            [NativeTypeName("DWORD")] uint cb
        );

        [VtblIndex(9)]
        HRESULT GetDOMException(HRESULT systemCode, HRESULT* code);
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
            "HRESULT (BSTR, const BYTE *, DWORD, const BYTE *, DWORD, IMFMediaKeySessionNotify *, IMFMediaKeySession **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            byte*,
            uint,
            byte*,
            uint,
            IMFMediaKeySessionNotify,
            IMFMediaKeySession*,
            int> CreateSession;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_KeySystem;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;

        [NativeTypeName("HRESULT (IMFCdmSuspendNotify **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFCdmSuspendNotify*, int> GetSuspendNotify;

        [NativeTypeName(
            "HRESULT (MF_MEDIAKEYSESSION_TYPE, IMFMediaKeySessionNotify2 *, IMFMediaKeySession2 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            MF_MEDIAKEYSESSION_TYPE,
            IMFMediaKeySessionNotify2,
            IMFMediaKeySession2*,
            int> CreateSession2;

        [NativeTypeName("HRESULT (const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> SetServerCertificate;

        [NativeTypeName("HRESULT (HRESULT, HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, HRESULT*, int> GetDOMException;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaKeys2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaKeys2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFMediaKeys"/> to <see cref = "IMFMediaKeys2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFMediaKeys"/> instance to be converted </param>
    public static explicit operator IMFMediaKeys2(Silk.NET.Windows.IMFMediaKeys value)
    {
        return new IMFMediaKeys2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaKeys2"/> to <see cref = "Silk.NET.Windows.IMFMediaKeys"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaKeys2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFMediaKeys(IMFMediaKeys2 value)
    {
        return new Silk.NET.Windows.IMFMediaKeys(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaKeys2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaKeys2(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaKeys2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaKeys2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaKeys2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaKeys2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
