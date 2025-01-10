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

[Guid("0F97CF2B-C9E4-4E88-8194-D814CBD585D8")]
[NativeTypeName("struct IAppBroadcastStreamVideoFrame : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppBroadcastStreamVideoFrame
    : IAppBroadcastStreamVideoFrame.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppBroadcastStreamVideoFrame));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppBroadcastStreamVideoFrame, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppBroadcastStreamVideoFrame, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppBroadcastStreamVideoFrame, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IAppBroadcastStreamVideoFrame, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppBroadcastStreamVideoFrame, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IAppBroadcastStreamVideoFrame, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_VideoHeader(
        [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastStreamVideoHeader **")]
            IAppBroadcastStreamVideoHeader* value
    )
    {
        return (
            (delegate* unmanaged<
                IAppBroadcastStreamVideoFrame,
                IAppBroadcastStreamVideoHeader*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_VideoBuffer(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return ((delegate* unmanaged<IAppBroadcastStreamVideoFrame, IBuffer*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_VideoHeader(
            [NativeTypeName("ABI::Windows::Media::Capture::IAppBroadcastStreamVideoHeader **")]
                IAppBroadcastStreamVideoHeader* value
        );

        [VtblIndex(7)]
        HRESULT get_VideoBuffer(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Capture::IAppBroadcastStreamVideoHeader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAppBroadcastStreamVideoHeader*, int> get_VideoHeader;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> get_VideoBuffer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppBroadcastStreamVideoFrame"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppBroadcastStreamVideoFrame(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppBroadcastStreamVideoFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppBroadcastStreamVideoFrame(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppBroadcastStreamVideoFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastStreamVideoFrame"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastStreamVideoFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppBroadcastStreamVideoFrame value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppBroadcastStreamVideoFrame"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppBroadcastStreamVideoFrame(Silk.NET.Windows.IUnknown value)
    {
        return new IAppBroadcastStreamVideoFrame(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppBroadcastStreamVideoFrame"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppBroadcastStreamVideoFrame"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppBroadcastStreamVideoFrame value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
