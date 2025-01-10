// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("26DC4561-A1EE-4AE7-96DA-118A36C0EC95")]
[NativeTypeName("struct IDirect3DDevice9Video : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirect3DDevice9Video : IDirect3DDevice9Video.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirect3DDevice9Video));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirect3DDevice9Video, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDirect3DDevice9Video, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirect3DDevice9Video, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetContentProtectionCaps(
        [NativeTypeName("const GUID *")] Guid* pCryptoType,
        [NativeTypeName("const GUID *")] Guid* pDecodeProfile,
        D3DCONTENTPROTECTIONCAPS* pCaps
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Video,
                Guid*,
                Guid*,
                D3DCONTENTPROTECTIONCAPS*,
                int>)((*lpVtbl)[3])
        )(this, pCryptoType, pDecodeProfile, pCaps);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateAuthenticatedChannel(
        D3DAUTHENTICATEDCHANNELTYPE ChannelType,
        IDirect3DAuthenticatedChannel9* ppAuthenticatedChannel,
        HANDLE* pChannelHandle
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Video,
                D3DAUTHENTICATEDCHANNELTYPE,
                IDirect3DAuthenticatedChannel9*,
                HANDLE*,
                int>)((*lpVtbl)[4])
        )(this, ChannelType, ppAuthenticatedChannel, pChannelHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateCryptoSession(
        [NativeTypeName("const GUID *")] Guid* pCryptoType,
        [NativeTypeName("const GUID *")] Guid* pDecodeProfile,
        IDirect3DCryptoSession9* ppCryptoSession,
        HANDLE* pCryptoHandle
    )
    {
        return (
            (delegate* unmanaged<
                IDirect3DDevice9Video,
                Guid*,
                Guid*,
                IDirect3DCryptoSession9*,
                HANDLE*,
                int>)((*lpVtbl)[5])
        )(this, pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandle);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetContentProtectionCaps(
            [NativeTypeName("const GUID *")] Guid* pCryptoType,
            [NativeTypeName("const GUID *")] Guid* pDecodeProfile,
            D3DCONTENTPROTECTIONCAPS* pCaps
        );

        [VtblIndex(4)]
        HRESULT CreateAuthenticatedChannel(
            D3DAUTHENTICATEDCHANNELTYPE ChannelType,
            IDirect3DAuthenticatedChannel9* ppAuthenticatedChannel,
            HANDLE* pChannelHandle
        );

        [VtblIndex(5)]
        HRESULT CreateCryptoSession(
            [NativeTypeName("const GUID *")] Guid* pCryptoType,
            [NativeTypeName("const GUID *")] Guid* pDecodeProfile,
            IDirect3DCryptoSession9* ppCryptoSession,
            HANDLE* pCryptoHandle
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

        [NativeTypeName(
            "HRESULT (const GUID *, const GUID *, D3DCONTENTPROTECTIONCAPS *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            Guid*,
            D3DCONTENTPROTECTIONCAPS*,
            int> GetContentProtectionCaps;

        [NativeTypeName(
            "HRESULT (D3DAUTHENTICATEDCHANNELTYPE, IDirect3DAuthenticatedChannel9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D3DAUTHENTICATEDCHANNELTYPE,
            IDirect3DAuthenticatedChannel9*,
            HANDLE*,
            int> CreateAuthenticatedChannel;

        [NativeTypeName(
            "HRESULT (const GUID *, const GUID *, IDirect3DCryptoSession9 **, HANDLE *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            Guid*,
            IDirect3DCryptoSession9*,
            HANDLE*,
            int> CreateCryptoSession;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirect3DDevice9Video"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirect3DDevice9Video(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirect3DDevice9Video"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirect3DDevice9Video(Silk.NET.Windows.IUnknown value)
    {
        return new IDirect3DDevice9Video(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirect3DDevice9Video"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirect3DDevice9Video"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirect3DDevice9Video value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
