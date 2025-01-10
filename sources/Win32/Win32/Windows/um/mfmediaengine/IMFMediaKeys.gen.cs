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

[Guid("5CB31C05-61FF-418F-AFDA-CAAF41421A38")]
[NativeTypeName("struct IMFMediaKeys : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFMediaKeys : IMFMediaKeys.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaKeys));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaKeys, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaKeys, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaKeys, uint>)((*lpVtbl)[2]))(this);
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
                IMFMediaKeys,
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
        return ((delegate* unmanaged<IMFMediaKeys, ushort**, int>)((*lpVtbl)[4]))(this, keySystem);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFMediaKeys, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSuspendNotify(IMFCdmSuspendNotify* notify)
    {
        return ((delegate* unmanaged<IMFMediaKeys, IMFCdmSuspendNotify*, int>)((*lpVtbl)[6]))(
            this,
            notify
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateSession(
            [NativeTypeName("BSTR")] ushort* mimeType,
            [NativeTypeName("const BYTE *")] byte* initData,
            [NativeTypeName("DWORD")] uint cb,
            [NativeTypeName("const BYTE *")] byte* customData,
            [NativeTypeName("DWORD")] uint cbCustomData,
            IMFMediaKeySessionNotify notify,
            IMFMediaKeySession* ppSession
        );

        [VtblIndex(4)]
        HRESULT get_KeySystem([NativeTypeName("BSTR *")] ushort** keySystem);

        [VtblIndex(5)]
        HRESULT Shutdown();

        [VtblIndex(6)]
        HRESULT GetSuspendNotify(IMFCdmSuspendNotify* notify);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaKeys"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaKeys(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaKeys"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaKeys(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaKeys(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaKeys"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaKeys"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaKeys value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
