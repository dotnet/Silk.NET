// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("887411EB-7F54-4732-A5F0-5E43E3B8C2F5")]
[NativeTypeName("struct IFileIOStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFileIOStatics : IFileIOStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileIOStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileIOStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFileIOStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileIOStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IFileIOStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFileIOStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IFileIOStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReadTextAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** textOperation
    )
    {
        return (
            (delegate* unmanaged<IFileIOStatics, IStorageFile, IAsyncOperation<HSTRING>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, file, textOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReadTextWithEncodingAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
            UnicodeEncoding encoding,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** textOperation
    )
    {
        return (
            (delegate* unmanaged<
                IFileIOStatics,
                IStorageFile,
                UnicodeEncoding,
                IAsyncOperation<HSTRING>**,
                int>)((*lpVtbl)[7])
        )(this, file, encoding, textOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WriteTextAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        HSTRING contents,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* textOperation
    )
    {
        return (
            (delegate* unmanaged<IFileIOStatics, IStorageFile, HSTRING, IAsyncAction*, int>)(
                (*lpVtbl)[8]
            )
        )(this, file, contents, textOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT WriteTextWithEncodingAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        HSTRING contents,
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
            UnicodeEncoding encoding,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* textOperation
    )
    {
        return (
            (delegate* unmanaged<
                IFileIOStatics,
                IStorageFile,
                HSTRING,
                UnicodeEncoding,
                IAsyncAction*,
                int>)((*lpVtbl)[9])
        )(this, file, contents, encoding, textOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AppendTextAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        HSTRING contents,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* textOperation
    )
    {
        return (
            (delegate* unmanaged<IFileIOStatics, IStorageFile, HSTRING, IAsyncAction*, int>)(
                (*lpVtbl)[10]
            )
        )(this, file, contents, textOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AppendTextWithEncodingAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        HSTRING contents,
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
            UnicodeEncoding encoding,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* textOperation
    )
    {
        return (
            (delegate* unmanaged<
                IFileIOStatics,
                IStorageFile,
                HSTRING,
                UnicodeEncoding,
                IAsyncAction*,
                int>)((*lpVtbl)[11])
        )(this, file, contents, encoding, textOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ReadLinesAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")]
            IAsyncOperation<IntPtr>** linesOperation
    )
    {
        return (
            (delegate* unmanaged<IFileIOStatics, IStorageFile, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[12]
            )
        )(this, file, linesOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ReadLinesWithEncodingAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
            UnicodeEncoding encoding,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")]
            IAsyncOperation<IntPtr>** linesOperation
    )
    {
        return (
            (delegate* unmanaged<
                IFileIOStatics,
                IStorageFile,
                UnicodeEncoding,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[13])
        )(this, file, encoding, linesOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT WriteLinesAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* lines,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IFileIOStatics,
                IStorageFile,
                IIterable<HSTRING>*,
                IAsyncAction*,
                int>)((*lpVtbl)[14])
        )(this, file, lines, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT WriteLinesWithEncodingAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* lines,
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
            UnicodeEncoding encoding,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IFileIOStatics,
                IStorageFile,
                IIterable<HSTRING>*,
                UnicodeEncoding,
                IAsyncAction*,
                int>)((*lpVtbl)[15])
        )(this, file, lines, encoding, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AppendLinesAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* lines,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IFileIOStatics,
                IStorageFile,
                IIterable<HSTRING>*,
                IAsyncAction*,
                int>)((*lpVtbl)[16])
        )(this, file, lines, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AppendLinesWithEncodingAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* lines,
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
            UnicodeEncoding encoding,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IFileIOStatics,
                IStorageFile,
                IIterable<HSTRING>*,
                UnicodeEncoding,
                IAsyncAction*,
                int>)((*lpVtbl)[17])
        )(this, file, lines, encoding, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ReadBufferAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IFileIOStatics, IStorageFile, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[18]
            )
        )(this, file, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT WriteBufferAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IFileIOStatics, IStorageFile, IBuffer, IAsyncAction*, int>)(
                (*lpVtbl)[19]
            )
        )(this, file, buffer, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT WriteBytesAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName("UINT32")] uint bufferLength,
        byte* buffer,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IFileIOStatics, IStorageFile, uint, byte*, IAsyncAction*, int>)(
                (*lpVtbl)[20]
            )
        )(this, file, bufferLength, buffer, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ReadTextAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** textOperation
        );

        [VtblIndex(7)]
        HRESULT ReadTextWithEncodingAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding encoding,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** textOperation
        );

        [VtblIndex(8)]
        HRESULT WriteTextAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            HSTRING contents,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")]
                IAsyncAction* textOperation
        );

        [VtblIndex(9)]
        HRESULT WriteTextWithEncodingAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            HSTRING contents,
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding encoding,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")]
                IAsyncAction* textOperation
        );

        [VtblIndex(10)]
        HRESULT AppendTextAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            HSTRING contents,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")]
                IAsyncAction* textOperation
        );

        [VtblIndex(11)]
        HRESULT AppendTextWithEncodingAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            HSTRING contents,
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding encoding,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")]
                IAsyncAction* textOperation
        );

        [VtblIndex(12)]
        HRESULT ReadLinesAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **"
            )]
                IAsyncOperation<IntPtr>** linesOperation
        );

        [VtblIndex(13)]
        HRESULT ReadLinesWithEncodingAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding encoding,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **"
            )]
                IAsyncOperation<IntPtr>** linesOperation
        );

        [VtblIndex(14)]
        HRESULT WriteLinesAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* lines,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(15)]
        HRESULT WriteLinesWithEncodingAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* lines,
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding encoding,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(16)]
        HRESULT AppendLinesAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* lines,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(17)]
        HRESULT AppendLinesWithEncodingAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* lines,
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding encoding,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(18)]
        HRESULT ReadBufferAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(19)]
        HRESULT WriteBufferAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(20)]
        HRESULT WriteBytesAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName("UINT32")] uint bufferLength,
            byte* buffer,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
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
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IAsyncOperation<HSTRING>**,
            int> ReadTextAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            UnicodeEncoding,
            IAsyncOperation<HSTRING>**,
            int> ReadTextWithEncodingAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            HSTRING,
            IAsyncAction*,
            int> WriteTextAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            HSTRING,
            UnicodeEncoding,
            IAsyncAction*,
            int> WriteTextWithEncodingAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            HSTRING,
            IAsyncAction*,
            int> AppendTextAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            HSTRING,
            UnicodeEncoding,
            IAsyncAction*,
            int> AppendTextWithEncodingAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IAsyncOperation<IntPtr>**,
            int> ReadLinesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            UnicodeEncoding,
            IAsyncOperation<IntPtr>**,
            int> ReadLinesWithEncodingAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IIterable<HSTRING>*,
            IAsyncAction*,
            int> WriteLinesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IIterable<HSTRING>*,
            UnicodeEncoding,
            IAsyncAction*,
            int> WriteLinesWithEncodingAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IIterable<HSTRING>*,
            IAsyncAction*,
            int> AppendLinesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IIterable<HSTRING>*,
            UnicodeEncoding,
            IAsyncAction*,
            int> AppendLinesWithEncodingAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IAsyncOperation<IntPtr>**,
            int> ReadBufferAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IBuffer,
            IAsyncAction*,
            int> WriteBufferAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, UINT32, BYTE *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            uint,
            byte*,
            IAsyncAction*,
            int> WriteBytesAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileIOStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileIOStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFileIOStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFileIOStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IFileIOStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileIOStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFileIOStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFileIOStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileIOStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileIOStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IFileIOStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileIOStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileIOStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileIOStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
