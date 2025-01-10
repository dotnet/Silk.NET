// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("50E01980-5166-4093-80F8-ADA00089E9CF")]
[NativeTypeName("struct IAudioFileOutputNode : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioFileOutputNode : IAudioFileOutputNode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioFileOutputNode));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioFileOutputNode, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAudioFileOutputNode, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioFileOutputNode, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAudioFileOutputNode, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAudioFileOutputNode, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAudioFileOutputNode, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_File(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile* value
    )
    {
        return ((delegate* unmanaged<IAudioFileOutputNode, IStorageFile*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_FileEncodingProfile(
        [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
            IMediaEncodingProfile* value
    )
    {
        return (
            (delegate* unmanaged<IAudioFileOutputNode, IMediaEncodingProfile*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FinalizeAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CTranscodeFailureReason_t **"
        )]
            IAsyncOperation<TranscodeFailureReason>** result
    )
    {
        return (
            (delegate* unmanaged<
                IAudioFileOutputNode,
                IAsyncOperation<TranscodeFailureReason>**,
                int>)((*lpVtbl)[8])
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_File(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile **")] IStorageFile* value
        );

        [VtblIndex(7)]
        HRESULT get_FileEncodingProfile(
            [NativeTypeName("ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **")]
                IMediaEncodingProfile* value
        );

        [VtblIndex(8)]
        HRESULT FinalizeAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CTranscodeFailureReason_t **"
            )]
                IAsyncOperation<TranscodeFailureReason>** result
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
            "HRESULT (ABI::Windows::Storage::IStorageFile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFile*, int> get_File;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Media::MediaProperties::IMediaEncodingProfile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaEncodingProfile*, int> get_FileEncodingProfile;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CTranscoding__CTranscodeFailureReason_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<TranscodeFailureReason>**,
            int> FinalizeAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAudioFileOutputNode"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAudioFileOutputNode(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAudioFileOutputNode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAudioFileOutputNode(Silk.NET.WinRT.IInspectable value)
    {
        return new IAudioFileOutputNode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioFileOutputNode"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioFileOutputNode"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAudioFileOutputNode value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAudioFileOutputNode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAudioFileOutputNode(Silk.NET.Windows.IUnknown value)
    {
        return new IAudioFileOutputNode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAudioFileOutputNode"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAudioFileOutputNode"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAudioFileOutputNode value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
