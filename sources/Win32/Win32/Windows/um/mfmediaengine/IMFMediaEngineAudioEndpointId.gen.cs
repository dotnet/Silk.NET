// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7A3BAC98-0E76-49FB-8C20-8A86FD98EAF2")]
[NativeTypeName("struct IMFMediaEngineAudioEndpointId : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaEngineAudioEndpointId
    : IMFMediaEngineAudioEndpointId.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineAudioEndpointId));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFMediaEngineAudioEndpointId, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineAudioEndpointId, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineAudioEndpointId, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAudioEndpointId([NativeTypeName("LPCWSTR")] ushort* pszEndpointId)
    {
        return ((delegate* unmanaged<IMFMediaEngineAudioEndpointId, ushort*, int>)((*lpVtbl)[3]))(
            this,
            pszEndpointId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAudioEndpointId([NativeTypeName("LPWSTR *")] ushort** ppszEndpointId)
    {
        return ((delegate* unmanaged<IMFMediaEngineAudioEndpointId, ushort**, int>)((*lpVtbl)[4]))(
            this,
            ppszEndpointId
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAudioEndpointId([NativeTypeName("LPCWSTR")] ushort* pszEndpointId);

        [VtblIndex(4)]
        HRESULT GetAudioEndpointId([NativeTypeName("LPWSTR *")] ushort** ppszEndpointId);
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetAudioEndpointId;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetAudioEndpointId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaEngineAudioEndpointId"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaEngineAudioEndpointId(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaEngineAudioEndpointId"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaEngineAudioEndpointId(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaEngineAudioEndpointId(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaEngineAudioEndpointId"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaEngineAudioEndpointId"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaEngineAudioEndpointId value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
