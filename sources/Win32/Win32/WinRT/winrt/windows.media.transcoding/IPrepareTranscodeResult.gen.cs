// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.transcoding.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("05F25DCE-994F-4A34-9D68-97CCCE1730D6")]
[NativeTypeName("struct IPrepareTranscodeResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrepareTranscodeResult
    : IPrepareTranscodeResult.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrepareTranscodeResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrepareTranscodeResult, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPrepareTranscodeResult, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrepareTranscodeResult, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPrepareTranscodeResult, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPrepareTranscodeResult, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPrepareTranscodeResult, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_CanTranscode([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPrepareTranscodeResult, byte*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_FailureReason(
        [NativeTypeName("ABI::Windows::Media::Transcoding::TranscodeFailureReason *")]
            TranscodeFailureReason* value
    )
    {
        return (
            (delegate* unmanaged<IPrepareTranscodeResult, TranscodeFailureReason*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TranscodeAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncActionWithProgress_1_double_t **")]
            IAsyncActionWithProgress<double>** operation
    )
    {
        return (
            (delegate* unmanaged<IPrepareTranscodeResult, IAsyncActionWithProgress<double>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_CanTranscode([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_FailureReason(
            [NativeTypeName("ABI::Windows::Media::Transcoding::TranscodeFailureReason *")]
                TranscodeFailureReason* value
        );

        [VtblIndex(8)]
        HRESULT TranscodeAsync(
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncActionWithProgress_1_double_t **")]
                IAsyncActionWithProgress<double>** operation
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CanTranscode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::Transcoding::TranscodeFailureReason *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, TranscodeFailureReason*, int> get_FailureReason;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncActionWithProgress_1_double_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncActionWithProgress<double>**, int> TranscodeAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrepareTranscodeResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrepareTranscodeResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrepareTranscodeResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrepareTranscodeResult(Silk.NET.WinRT.IInspectable value)
    {
        return new IPrepareTranscodeResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrepareTranscodeResult"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrepareTranscodeResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPrepareTranscodeResult value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrepareTranscodeResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrepareTranscodeResult(Silk.NET.Windows.IUnknown value)
    {
        return new IPrepareTranscodeResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrepareTranscodeResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrepareTranscodeResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPrepareTranscodeResult value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
