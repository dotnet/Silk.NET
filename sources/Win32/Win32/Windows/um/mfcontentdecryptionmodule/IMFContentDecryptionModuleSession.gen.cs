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

[Guid("4E233EFD-1DD2-49E8-B577-D63EEE4C0D33")]
[NativeTypeName("struct IMFContentDecryptionModuleSession : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct IMFContentDecryptionModuleSession
    : IMFContentDecryptionModuleSession.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFContentDecryptionModuleSession));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModuleSession, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleSession, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleSession, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSessionId([NativeTypeName("LPWSTR *")] ushort** sessionId)
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModuleSession, ushort**, int>)((*lpVtbl)[3])
        )(this, sessionId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetExpiration(double* expiration)
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModuleSession, double*, int>)((*lpVtbl)[4])
        )(this, expiration);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetKeyStatuses(MFMediaKeyStatus** keyStatuses, uint* numKeyStatuses)
    {
        return (
            (delegate* unmanaged<
                IMFContentDecryptionModuleSession,
                MFMediaKeyStatus**,
                uint*,
                int>)((*lpVtbl)[5])
        )(this, keyStatuses, numKeyStatuses);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Load([NativeTypeName("LPCWSTR")] ushort* sessionId, BOOL* loaded)
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModuleSession, ushort*, BOOL*, int>)(
                (*lpVtbl)[6]
            )
        )(this, sessionId, loaded);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GenerateRequest(
        [NativeTypeName("LPCWSTR")] ushort* initDataType,
        [NativeTypeName("const BYTE *")] byte* initData,
        [NativeTypeName("DWORD")] uint initDataSize
    )
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModuleSession, ushort*, byte*, uint, int>)(
                (*lpVtbl)[7]
            )
        )(this, initDataType, initData, initDataSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Update(
        [NativeTypeName("const BYTE *")] byte* response,
        [NativeTypeName("DWORD")] uint responseSize
    )
    {
        return (
            (delegate* unmanaged<IMFContentDecryptionModuleSession, byte*, uint, int>)((*lpVtbl)[8])
        )(this, response, responseSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleSession, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Remove()
    {
        return ((delegate* unmanaged<IMFContentDecryptionModuleSession, int>)((*lpVtbl)[10]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSessionId([NativeTypeName("LPWSTR *")] ushort** sessionId);

        [VtblIndex(4)]
        HRESULT GetExpiration(double* expiration);

        [VtblIndex(5)]
        HRESULT GetKeyStatuses(MFMediaKeyStatus** keyStatuses, uint* numKeyStatuses);

        [VtblIndex(6)]
        HRESULT Load([NativeTypeName("LPCWSTR")] ushort* sessionId, BOOL* loaded);

        [VtblIndex(7)]
        HRESULT GenerateRequest(
            [NativeTypeName("LPCWSTR")] ushort* initDataType,
            [NativeTypeName("const BYTE *")] byte* initData,
            [NativeTypeName("DWORD")] uint initDataSize
        );

        [VtblIndex(8)]
        HRESULT Update(
            [NativeTypeName("const BYTE *")] byte* response,
            [NativeTypeName("DWORD")] uint responseSize
        );

        [VtblIndex(9)]
        HRESULT Close();

        [VtblIndex(10)]
        HRESULT Remove();
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSessionId;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> GetExpiration;

        [NativeTypeName("HRESULT (MFMediaKeyStatus **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFMediaKeyStatus**, uint*, int> GetKeyStatuses;

        [NativeTypeName("HRESULT (LPCWSTR, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL*, int> Load;

        [NativeTypeName("HRESULT (LPCWSTR, const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, byte*, uint, int> GenerateRequest;

        [NativeTypeName("HRESULT (const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> Update;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Remove;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFContentDecryptionModuleSession"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFContentDecryptionModuleSession(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFContentDecryptionModuleSession"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFContentDecryptionModuleSession(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IMFContentDecryptionModuleSession(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFContentDecryptionModuleSession"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFContentDecryptionModuleSession"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IMFContentDecryptionModuleSession value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
