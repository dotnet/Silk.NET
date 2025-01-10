// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6B14A441-FBA7-4BD2-AF0A-839DE7C295DA")]
[NativeTypeName("struct IHttpContent : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHttpContent : IHttpContent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpContent));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHttpContent, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHttpContent, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHttpContent, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHttpContent, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHttpContent, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHttpContent, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Headers(
        [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentHeaderCollection **")]
            IHttpContentHeaderCollection* value
    )
    {
        return (
            (delegate* unmanaged<IHttpContent, IHttpContentHeaderCollection*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT BufferAllAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **"
        )]
            IAsyncOperationWithProgress<ulong, ulong>** operation
    )
    {
        return (
            (delegate* unmanaged<IHttpContent, IAsyncOperationWithProgress<ulong, ulong>**, int>)(
                (*lpVtbl)[7]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReadAsBufferAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_UINT64_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, ulong>** operation
    )
    {
        return (
            (delegate* unmanaged<IHttpContent, IAsyncOperationWithProgress<IntPtr, ulong>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ReadAsInputStreamAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIInputStream_UINT64_t **"
        )]
            IAsyncOperationWithProgress<IntPtr, ulong>** operation
    )
    {
        return (
            (delegate* unmanaged<IHttpContent, IAsyncOperationWithProgress<IntPtr, ulong>**, int>)(
                (*lpVtbl)[9]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ReadAsStringAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_HSTRING_UINT64_t **"
        )]
            IAsyncOperationWithProgress<HSTRING, ulong>** operation
    )
    {
        return (
            (delegate* unmanaged<IHttpContent, IAsyncOperationWithProgress<HSTRING, ulong>**, int>)(
                (*lpVtbl)[10]
            )
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TryComputeLength(
        [NativeTypeName("UINT64 *")] ulong* length,
        [NativeTypeName("boolean *")] byte* succeeded
    )
    {
        return ((delegate* unmanaged<IHttpContent, ulong*, byte*, int>)((*lpVtbl)[11]))(
            this,
            length,
            succeeded
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteToStreamAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
            IOutputStream outputStream,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **"
        )]
            IAsyncOperationWithProgress<ulong, ulong>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IHttpContent,
                IOutputStream,
                IAsyncOperationWithProgress<ulong, ulong>**,
                int>)((*lpVtbl)[12])
        )(this, outputStream, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Headers(
            [NativeTypeName("ABI::Windows::Web::Http::Headers::IHttpContentHeaderCollection **")]
                IHttpContentHeaderCollection* value
        );

        [VtblIndex(7)]
        HRESULT BufferAllAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **"
            )]
                IAsyncOperationWithProgress<ulong, ulong>** operation
        );

        [VtblIndex(8)]
        HRESULT ReadAsBufferAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_UINT64_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, ulong>** operation
        );

        [VtblIndex(9)]
        HRESULT ReadAsInputStreamAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIInputStream_UINT64_t **"
            )]
                IAsyncOperationWithProgress<IntPtr, ulong>** operation
        );

        [VtblIndex(10)]
        HRESULT ReadAsStringAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_HSTRING_UINT64_t **"
            )]
                IAsyncOperationWithProgress<HSTRING, ulong>** operation
        );

        [VtblIndex(11)]
        HRESULT TryComputeLength(
            [NativeTypeName("UINT64 *")] ulong* length,
            [NativeTypeName("boolean *")] byte* succeeded
        );

        [VtblIndex(12)]
        HRESULT WriteToStreamAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
                IOutputStream outputStream,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **"
            )]
                IAsyncOperationWithProgress<ulong, ulong>** operation
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
            "HRESULT (ABI::Windows::Web::Http::Headers::IHttpContentHeaderCollection **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHttpContentHeaderCollection*, int> get_Headers;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperationWithProgress<ulong, ulong>**,
            int> BufferAllAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIBuffer_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperationWithProgress<IntPtr, ulong>**,
            int> ReadAsBufferAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_Windows__CStorage__CStreams__CIInputStream_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperationWithProgress<IntPtr, ulong>**,
            int> ReadAsInputStreamAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_HSTRING_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperationWithProgress<HSTRING, ulong>**,
            int> ReadAsStringAsync;

        [NativeTypeName("HRESULT (UINT64 *, boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, byte*, int> TryComputeLength;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Foundation::__FIAsyncOperationWithProgress_2_UINT64_UINT64_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IOutputStream,
            IAsyncOperationWithProgress<ulong, ulong>**,
            int> WriteToStreamAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHttpContent"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHttpContent(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHttpContent"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHttpContent(Silk.NET.WinRT.IInspectable value)
    {
        return new IHttpContent(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpContent"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpContent"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHttpContent value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHttpContent"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHttpContent(Silk.NET.Windows.IUnknown value)
    {
        return new IHttpContent(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHttpContent"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHttpContent"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHttpContent value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
