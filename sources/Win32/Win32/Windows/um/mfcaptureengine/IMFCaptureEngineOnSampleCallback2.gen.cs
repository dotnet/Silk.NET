// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfcaptureengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E37CEED7-340F-4514-9F4D-9C2AE026100B")]
[NativeTypeName("struct IMFCaptureEngineOnSampleCallback2 : IMFCaptureEngineOnSampleCallback")]
[NativeInheritance("IMFCaptureEngineOnSampleCallback")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IMFCaptureEngineOnSampleCallback2
    : IMFCaptureEngineOnSampleCallback2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCaptureEngineOnSampleCallback2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFCaptureEngineOnSampleCallback2, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCaptureEngineOnSampleCallback2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnSample(IMFSample pSample)
    {
        return (
            (delegate* unmanaged<IMFCaptureEngineOnSampleCallback2, IMFSample, int>)((*lpVtbl)[3])
        )(this, pSample);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnSynchronizedEvent(IMFMediaEvent pEvent)
    {
        return (
            (delegate* unmanaged<IMFCaptureEngineOnSampleCallback2, IMFMediaEvent, int>)(
                (*lpVtbl)[4]
            )
        )(this, pEvent);
    }

    public interface Interface : IMFCaptureEngineOnSampleCallback.Interface
    {
        [VtblIndex(4)]
        HRESULT OnSynchronizedEvent(IMFMediaEvent pEvent);
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

        [NativeTypeName("HRESULT (IMFSample *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSample, int> OnSample;

        [NativeTypeName("HRESULT (IMFMediaEvent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFMediaEvent, int> OnSynchronizedEvent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFCaptureEngineOnSampleCallback2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFCaptureEngineOnSampleCallback2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMFCaptureEngineOnSampleCallback"/> to <see cref = "IMFCaptureEngineOnSampleCallback2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMFCaptureEngineOnSampleCallback"/> instance to be converted </param>
    public static explicit operator IMFCaptureEngineOnSampleCallback2(
        Silk.NET.Windows.IMFCaptureEngineOnSampleCallback value
    )
    {
        return new IMFCaptureEngineOnSampleCallback2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFCaptureEngineOnSampleCallback2"/> to <see cref = "Silk.NET.Windows.IMFCaptureEngineOnSampleCallback"/>.</summary>
    /// <param name = "value">The <see cref = "IMFCaptureEngineOnSampleCallback2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMFCaptureEngineOnSampleCallback(
        IMFCaptureEngineOnSampleCallback2 value
    )
    {
        return new Silk.NET.Windows.IMFCaptureEngineOnSampleCallback(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFCaptureEngineOnSampleCallback2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFCaptureEngineOnSampleCallback2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IMFCaptureEngineOnSampleCallback2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFCaptureEngineOnSampleCallback2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFCaptureEngineOnSampleCallback2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IMFCaptureEngineOnSampleCallback2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
