// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D0AE555D-3B12-4D97-B060-0990BC5AEB67")]
[NativeTypeName("struct IMFSecureChannel : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSecureChannel : IMFSecureChannel.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSecureChannel));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSecureChannel, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSecureChannel, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSecureChannel, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCertificate(byte** ppCert, [NativeTypeName("DWORD *")] uint* pcbCert)
    {
        return ((delegate* unmanaged<IMFSecureChannel, byte**, uint*, int>)((*lpVtbl)[3]))(
            this,
            ppCert,
            pcbCert
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetupSession(
        byte* pbEncryptedSessionKey,
        [NativeTypeName("DWORD")] uint cbSessionKey
    )
    {
        return ((delegate* unmanaged<IMFSecureChannel, byte*, uint, int>)((*lpVtbl)[4]))(
            this,
            pbEncryptedSessionKey,
            cbSessionKey
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCertificate(byte** ppCert, [NativeTypeName("DWORD *")] uint* pcbCert);

        [VtblIndex(4)]
        HRESULT SetupSession(
            byte* pbEncryptedSessionKey,
            [NativeTypeName("DWORD")] uint cbSessionKey
        );
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

        [NativeTypeName("HRESULT (BYTE **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, int> GetCertificate;

        [NativeTypeName("HRESULT (BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> SetupSession;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSecureChannel"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSecureChannel(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSecureChannel"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSecureChannel(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSecureChannel(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSecureChannel"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSecureChannel"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSecureChannel value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
