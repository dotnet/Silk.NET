// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("19F68549-CA8A-4706-A4EF-481DBC95E12C")]
[NativeTypeName("struct IMFCapturePhotoConfirmation : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFCapturePhotoConfirmation
    : IMFCapturePhotoConfirmation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFCapturePhotoConfirmation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFCapturePhotoConfirmation, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFCapturePhotoConfirmation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFCapturePhotoConfirmation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPhotoConfirmationCallback(IMFAsyncCallback pNotificationCallback)
    {
        return (
            (delegate* unmanaged<IMFCapturePhotoConfirmation, IMFAsyncCallback, int>)((*lpVtbl)[3])
        )(this, pNotificationCallback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetPixelFormat(Guid subtype)
    {
        return ((delegate* unmanaged<IMFCapturePhotoConfirmation, Guid, int>)((*lpVtbl)[4]))(
            this,
            subtype
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPixelFormat(Guid* subtype)
    {
        return ((delegate* unmanaged<IMFCapturePhotoConfirmation, Guid*, int>)((*lpVtbl)[5]))(
            this,
            subtype
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetPhotoConfirmationCallback(IMFAsyncCallback pNotificationCallback);

        [VtblIndex(4)]
        HRESULT SetPixelFormat(Guid subtype);

        [VtblIndex(5)]
        HRESULT GetPixelFormat(Guid* subtype);
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

        [NativeTypeName("HRESULT (IMFAsyncCallback *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncCallback, int> SetPhotoConfirmationCallback;

        [NativeTypeName("HRESULT (GUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> SetPixelFormat;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetPixelFormat;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFCapturePhotoConfirmation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFCapturePhotoConfirmation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFCapturePhotoConfirmation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFCapturePhotoConfirmation(Silk.NET.Windows.IUnknown value)
    {
        return new IMFCapturePhotoConfirmation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFCapturePhotoConfirmation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFCapturePhotoConfirmation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFCapturePhotoConfirmation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
