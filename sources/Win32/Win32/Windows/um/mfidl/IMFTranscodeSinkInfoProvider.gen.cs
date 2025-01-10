// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8CFFCD2E-5A03-4A3A-AFF7-EDCD107C620E")]
[NativeTypeName("struct IMFTranscodeSinkInfoProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTranscodeSinkInfoProvider
    : IMFTranscodeSinkInfoProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTranscodeSinkInfoProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFTranscodeSinkInfoProvider, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTranscodeSinkInfoProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTranscodeSinkInfoProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetOutputFile([NativeTypeName("LPCWSTR")] ushort* pwszFileName)
    {
        return ((delegate* unmanaged<IMFTranscodeSinkInfoProvider, ushort*, int>)((*lpVtbl)[3]))(
            this,
            pwszFileName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetOutputByteStream(IMFActivate pByteStreamActivate)
    {
        return (
            (delegate* unmanaged<IMFTranscodeSinkInfoProvider, IMFActivate, int>)((*lpVtbl)[4])
        )(this, pByteStreamActivate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetProfile(IMFTranscodeProfile pProfile)
    {
        return (
            (delegate* unmanaged<IMFTranscodeSinkInfoProvider, IMFTranscodeProfile, int>)(
                (*lpVtbl)[5]
            )
        )(this, pProfile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSinkInfo(MF_TRANSCODE_SINK_INFO* pSinkInfo)
    {
        return (
            (delegate* unmanaged<IMFTranscodeSinkInfoProvider, MF_TRANSCODE_SINK_INFO*, int>)(
                (*lpVtbl)[6]
            )
        )(this, pSinkInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetOutputFile([NativeTypeName("LPCWSTR")] ushort* pwszFileName);

        [VtblIndex(4)]
        HRESULT SetOutputByteStream(IMFActivate pByteStreamActivate);

        [VtblIndex(5)]
        HRESULT SetProfile(IMFTranscodeProfile pProfile);

        [VtblIndex(6)]
        HRESULT GetSinkInfo(MF_TRANSCODE_SINK_INFO* pSinkInfo);
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
        public delegate* unmanaged<TSelf*, ushort*, int> SetOutputFile;

        [NativeTypeName("HRESULT (IMFActivate *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFActivate, int> SetOutputByteStream;

        [NativeTypeName("HRESULT (IMFTranscodeProfile *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFTranscodeProfile, int> SetProfile;

        [NativeTypeName("HRESULT (MF_TRANSCODE_SINK_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_TRANSCODE_SINK_INFO*, int> GetSinkInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFTranscodeSinkInfoProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFTranscodeSinkInfoProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFTranscodeSinkInfoProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFTranscodeSinkInfoProvider(Silk.NET.Windows.IUnknown value)
    {
        return new IMFTranscodeSinkInfoProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFTranscodeSinkInfoProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFTranscodeSinkInfoProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFTranscodeSinkInfoProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
