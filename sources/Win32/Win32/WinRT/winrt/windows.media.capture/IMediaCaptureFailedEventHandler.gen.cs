// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2014EFFB-5CD8-4F08-A314-0D360DA59F14")]
[NativeTypeName("struct IMediaCaptureFailedEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMediaCaptureFailedEventHandler
    : IMediaCaptureFailedEventHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaCaptureFailedEventHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMediaCaptureFailedEventHandler, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaCaptureFailedEventHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaCaptureFailedEventHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke(
        [NativeTypeName("ABI::Windows::Media::Capture::IMediaCapture *")] IMediaCapture sender,
        [NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureFailedEventArgs *")]
            IMediaCaptureFailedEventArgs errorEventArgs
    )
    {
        return (
            (delegate* unmanaged<
                IMediaCaptureFailedEventHandler,
                IMediaCapture,
                IMediaCaptureFailedEventArgs,
                int>)((*lpVtbl)[3])
        )(this, sender, errorEventArgs);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke(
            [NativeTypeName("ABI::Windows::Media::Capture::IMediaCapture *")] IMediaCapture sender,
            [NativeTypeName("ABI::Windows::Media::Capture::IMediaCaptureFailedEventArgs *")]
                IMediaCaptureFailedEventArgs errorEventArgs
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
            "HRESULT (ABI::Windows::Media::Capture::IMediaCapture *, ABI::Windows::Media::Capture::IMediaCaptureFailedEventArgs *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaCapture, IMediaCaptureFailedEventArgs, int> Invoke;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaCaptureFailedEventHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaCaptureFailedEventHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaCaptureFailedEventHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaCaptureFailedEventHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaCaptureFailedEventHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaCaptureFailedEventHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaCaptureFailedEventHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaCaptureFailedEventHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
