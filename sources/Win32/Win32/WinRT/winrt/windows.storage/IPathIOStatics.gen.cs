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

[Guid("0F2F3758-8EC7-4381-922B-8F6C07D288F3")]
[NativeTypeName("struct IPathIOStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPathIOStatics : IPathIOStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPathIOStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPathIOStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPathIOStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPathIOStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPathIOStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPathIOStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPathIOStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReadTextAsync(
        HSTRING absolutePath,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** textOperation
    )
    {
        return (
            (delegate* unmanaged<IPathIOStatics, HSTRING, IAsyncOperation<HSTRING>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, absolutePath, textOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReadTextWithEncodingAsync(
        HSTRING absolutePath,
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
            UnicodeEncoding encoding,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
            IAsyncOperation<HSTRING>** textOperation
    )
    {
        return (
            (delegate* unmanaged<
                IPathIOStatics,
                HSTRING,
                UnicodeEncoding,
                IAsyncOperation<HSTRING>**,
                int>)((*lpVtbl)[7])
        )(this, absolutePath, encoding, textOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT WriteTextAsync(
        HSTRING absolutePath,
        HSTRING contents,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* textOperation
    )
    {
        return (
            (delegate* unmanaged<IPathIOStatics, HSTRING, HSTRING, IAsyncAction*, int>)(
                (*lpVtbl)[8]
            )
        )(this, absolutePath, contents, textOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT WriteTextWithEncodingAsync(
        HSTRING absolutePath,
        HSTRING contents,
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
            UnicodeEncoding encoding,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* textOperation
    )
    {
        return (
            (delegate* unmanaged<
                IPathIOStatics,
                HSTRING,
                HSTRING,
                UnicodeEncoding,
                IAsyncAction*,
                int>)((*lpVtbl)[9])
        )(this, absolutePath, contents, encoding, textOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AppendTextAsync(
        HSTRING absolutePath,
        HSTRING contents,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* textOperation
    )
    {
        return (
            (delegate* unmanaged<IPathIOStatics, HSTRING, HSTRING, IAsyncAction*, int>)(
                (*lpVtbl)[10]
            )
        )(this, absolutePath, contents, textOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT AppendTextWithEncodingAsync(
        HSTRING absolutePath,
        HSTRING contents,
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
            UnicodeEncoding encoding,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* textOperation
    )
    {
        return (
            (delegate* unmanaged<
                IPathIOStatics,
                HSTRING,
                HSTRING,
                UnicodeEncoding,
                IAsyncAction*,
                int>)((*lpVtbl)[11])
        )(this, absolutePath, contents, encoding, textOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ReadLinesAsync(
        HSTRING absolutePath,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")]
            IAsyncOperation<IntPtr>** linesOperation
    )
    {
        return (
            (delegate* unmanaged<IPathIOStatics, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[12]
            )
        )(this, absolutePath, linesOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ReadLinesWithEncodingAsync(
        HSTRING absolutePath,
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
            UnicodeEncoding encoding,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **")]
            IAsyncOperation<IntPtr>** linesOperation
    )
    {
        return (
            (delegate* unmanaged<
                IPathIOStatics,
                HSTRING,
                UnicodeEncoding,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[13])
        )(this, absolutePath, encoding, linesOperation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT WriteLinesAsync(
        HSTRING absolutePath,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* lines,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IPathIOStatics, HSTRING, IIterable<HSTRING>*, IAsyncAction*, int>)(
                (*lpVtbl)[14]
            )
        )(this, absolutePath, lines, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT WriteLinesWithEncodingAsync(
        HSTRING absolutePath,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* lines,
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
            UnicodeEncoding encoding,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IPathIOStatics,
                HSTRING,
                IIterable<HSTRING>*,
                UnicodeEncoding,
                IAsyncAction*,
                int>)((*lpVtbl)[15])
        )(this, absolutePath, lines, encoding, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT AppendLinesAsync(
        HSTRING absolutePath,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* lines,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IPathIOStatics, HSTRING, IIterable<HSTRING>*, IAsyncAction*, int>)(
                (*lpVtbl)[16]
            )
        )(this, absolutePath, lines, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AppendLinesWithEncodingAsync(
        HSTRING absolutePath,
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* lines,
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
            UnicodeEncoding encoding,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IPathIOStatics,
                HSTRING,
                IIterable<HSTRING>*,
                UnicodeEncoding,
                IAsyncAction*,
                int>)((*lpVtbl)[17])
        )(this, absolutePath, lines, encoding, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ReadBufferAsync(
        HSTRING absolutePath,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IPathIOStatics, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[18]
            )
        )(this, absolutePath, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT WriteBufferAsync(
        HSTRING absolutePath,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IPathIOStatics, HSTRING, IBuffer, IAsyncAction*, int>)(
                (*lpVtbl)[19]
            )
        )(this, absolutePath, buffer, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT WriteBytesAsync(
        HSTRING absolutePath,
        [NativeTypeName("UINT32")] uint bufferLength,
        byte* buffer,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IPathIOStatics, HSTRING, uint, byte*, IAsyncAction*, int>)(
                (*lpVtbl)[20]
            )
        )(this, absolutePath, bufferLength, buffer, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ReadTextAsync(
            HSTRING absolutePath,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** textOperation
        );

        [VtblIndex(7)]
        HRESULT ReadTextWithEncodingAsync(
            HSTRING absolutePath,
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding encoding,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **")]
                IAsyncOperation<HSTRING>** textOperation
        );

        [VtblIndex(8)]
        HRESULT WriteTextAsync(
            HSTRING absolutePath,
            HSTRING contents,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")]
                IAsyncAction* textOperation
        );

        [VtblIndex(9)]
        HRESULT WriteTextWithEncodingAsync(
            HSTRING absolutePath,
            HSTRING contents,
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding encoding,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")]
                IAsyncAction* textOperation
        );

        [VtblIndex(10)]
        HRESULT AppendTextAsync(
            HSTRING absolutePath,
            HSTRING contents,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")]
                IAsyncAction* textOperation
        );

        [VtblIndex(11)]
        HRESULT AppendTextWithEncodingAsync(
            HSTRING absolutePath,
            HSTRING contents,
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding encoding,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")]
                IAsyncAction* textOperation
        );

        [VtblIndex(12)]
        HRESULT ReadLinesAsync(
            HSTRING absolutePath,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **"
            )]
                IAsyncOperation<IntPtr>** linesOperation
        );

        [VtblIndex(13)]
        HRESULT ReadLinesWithEncodingAsync(
            HSTRING absolutePath,
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding encoding,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **"
            )]
                IAsyncOperation<IntPtr>** linesOperation
        );

        [VtblIndex(14)]
        HRESULT WriteLinesAsync(
            HSTRING absolutePath,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* lines,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(15)]
        HRESULT WriteLinesWithEncodingAsync(
            HSTRING absolutePath,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* lines,
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding encoding,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(16)]
        HRESULT AppendLinesAsync(
            HSTRING absolutePath,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* lines,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(17)]
        HRESULT AppendLinesWithEncodingAsync(
            HSTRING absolutePath,
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* lines,
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding encoding,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(18)]
        HRESULT ReadBufferAsync(
            HSTRING absolutePath,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(19)]
        HRESULT WriteBufferAsync(
            HSTRING absolutePath,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(20)]
        HRESULT WriteBytesAsync(
            HSTRING absolutePath,
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<HSTRING>**, int> ReadTextAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::__FIAsyncOperation_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            UnicodeEncoding,
            IAsyncOperation<HSTRING>**,
            int> ReadTextWithEncodingAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, IAsyncAction*, int> WriteTextAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            UnicodeEncoding,
            IAsyncAction*,
            int> WriteTextWithEncodingAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, IAsyncAction*, int> AppendTextAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            UnicodeEncoding,
            IAsyncAction*,
            int> AppendTextWithEncodingAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> ReadLinesAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            UnicodeEncoding,
            IAsyncOperation<IntPtr>**,
            int> ReadLinesWithEncodingAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IIterable<HSTRING>*,
            IAsyncAction*,
            int> WriteLinesAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IIterable<HSTRING>*,
            UnicodeEncoding,
            IAsyncAction*,
            int> WriteLinesWithEncodingAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IIterable<HSTRING>*,
            IAsyncAction*,
            int> AppendLinesAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Storage::Streams::UnicodeEncoding, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IIterable<HSTRING>*,
            UnicodeEncoding,
            IAsyncAction*,
            int> AppendLinesWithEncodingAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> ReadBufferAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IBuffer, IAsyncAction*, int> WriteBufferAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, UINT32, BYTE *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            uint,
            byte*,
            IAsyncAction*,
            int> WriteBytesAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPathIOStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPathIOStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPathIOStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPathIOStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IPathIOStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPathIOStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPathIOStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPathIOStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPathIOStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPathIOStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IPathIOStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPathIOStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPathIOStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPathIOStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
