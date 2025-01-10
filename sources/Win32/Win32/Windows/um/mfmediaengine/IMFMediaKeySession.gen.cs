// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("24FA67D5-D1D0-4DC5-995C-C0EFDC191FB5")]
[NativeTypeName("struct IMFMediaKeySession : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFMediaKeySession : IMFMediaKeySession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaKeySession));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaKeySession, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaKeySession, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaKeySession, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetError(ushort* code, [NativeTypeName("DWORD *")] uint* systemCode)
    {
        return ((delegate* unmanaged<IMFMediaKeySession, ushort*, uint*, int>)((*lpVtbl)[3]))(
            this,
            code,
            systemCode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_KeySystem([NativeTypeName("BSTR *")] ushort** keySystem)
    {
        return ((delegate* unmanaged<IMFMediaKeySession, ushort**, int>)((*lpVtbl)[4]))(
            this,
            keySystem
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_SessionId([NativeTypeName("BSTR *")] ushort** sessionId)
    {
        return ((delegate* unmanaged<IMFMediaKeySession, ushort**, int>)((*lpVtbl)[5]))(
            this,
            sessionId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Update(
        [NativeTypeName("const BYTE *")] byte* key,
        [NativeTypeName("DWORD")] uint cb
    )
    {
        return ((delegate* unmanaged<IMFMediaKeySession, byte*, uint, int>)((*lpVtbl)[6]))(
            this,
            key,
            cb
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<IMFMediaKeySession, int>)((*lpVtbl)[7]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetError(ushort* code, [NativeTypeName("DWORD *")] uint* systemCode);

        [VtblIndex(4)]
        HRESULT get_KeySystem([NativeTypeName("BSTR *")] ushort** keySystem);

        [VtblIndex(5)]
        HRESULT get_SessionId([NativeTypeName("BSTR *")] ushort** sessionId);

        [VtblIndex(6)]
        HRESULT Update(
            [NativeTypeName("const BYTE *")] byte* key,
            [NativeTypeName("DWORD")] uint cb
        );

        [VtblIndex(7)]
        HRESULT Close();
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

        [NativeTypeName("HRESULT (USHORT *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint*, int> GetError;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_KeySystem;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_SessionId;

        [NativeTypeName("HRESULT (const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> Update;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaKeySession"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaKeySession(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaKeySession"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaKeySession(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaKeySession(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaKeySession"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaKeySession"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaKeySession value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
