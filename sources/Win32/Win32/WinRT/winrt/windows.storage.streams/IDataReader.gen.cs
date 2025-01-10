// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.streams.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E2B50029-B4C1-4314-A4B8-FB813A2F275E")]
[NativeTypeName("struct IDataReader : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataReader : IDataReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataReader));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDataReader, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDataReader, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataReader, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDataReader, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDataReader, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDataReader, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UnconsumedBufferLength([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IDataReader, uint*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_UnicodeEncoding(
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding *")] UnicodeEncoding* value
    )
    {
        return ((delegate* unmanaged<IDataReader, UnicodeEncoding*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_UnicodeEncoding(
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")] UnicodeEncoding value
    )
    {
        return ((delegate* unmanaged<IDataReader, UnicodeEncoding, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ByteOrder(
        [NativeTypeName("ABI::Windows::Storage::Streams::ByteOrder *")] ByteOrder* value
    )
    {
        return ((delegate* unmanaged<IDataReader, ByteOrder*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ByteOrder(
        [NativeTypeName("ABI::Windows::Storage::Streams::ByteOrder")] ByteOrder value
    )
    {
        return ((delegate* unmanaged<IDataReader, ByteOrder, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_InputStreamOptions(
        [NativeTypeName("ABI::Windows::Storage::Streams::InputStreamOptions *")]
            InputStreamOptions* value
    )
    {
        return ((delegate* unmanaged<IDataReader, InputStreamOptions*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_InputStreamOptions(
        [NativeTypeName("ABI::Windows::Storage::Streams::InputStreamOptions")]
            InputStreamOptions value
    )
    {
        return ((delegate* unmanaged<IDataReader, InputStreamOptions, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ReadByte(byte* value)
    {
        return ((delegate* unmanaged<IDataReader, byte*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ReadBytes([NativeTypeName("UINT32")] uint valueLength, byte* value)
    {
        return ((delegate* unmanaged<IDataReader, uint, byte*, int>)((*lpVtbl)[14]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ReadBuffer(
        [NativeTypeName("UINT32")] uint length,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
    )
    {
        return ((delegate* unmanaged<IDataReader, uint, IBuffer*, int>)((*lpVtbl)[15]))(
            this,
            length,
            buffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ReadBoolean([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IDataReader, byte*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT ReadGuid(Guid* value)
    {
        return ((delegate* unmanaged<IDataReader, Guid*, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ReadInt16([NativeTypeName("INT16 *")] short* value)
    {
        return ((delegate* unmanaged<IDataReader, short*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT ReadInt32([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IDataReader, int*, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT ReadInt64([NativeTypeName("INT64 *")] long* value)
    {
        return ((delegate* unmanaged<IDataReader, long*, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT ReadUInt16([NativeTypeName("UINT16 *")] ushort* value)
    {
        return ((delegate* unmanaged<IDataReader, ushort*, int>)((*lpVtbl)[21]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ReadUInt32([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IDataReader, uint*, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT ReadUInt64([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IDataReader, ulong*, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT ReadSingle(float* value)
    {
        return ((delegate* unmanaged<IDataReader, float*, int>)((*lpVtbl)[24]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT ReadDouble(double* value)
    {
        return ((delegate* unmanaged<IDataReader, double*, int>)((*lpVtbl)[25]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT ReadString([NativeTypeName("UINT32")] uint codeUnitCount, HSTRING* value)
    {
        return ((delegate* unmanaged<IDataReader, uint, HSTRING*, int>)((*lpVtbl)[26]))(
            this,
            codeUnitCount,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT ReadDateTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<IDataReader, WinRTDateTime*, int>)((*lpVtbl)[27]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT ReadTimeSpan(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IDataReader, TimeSpan*, int>)((*lpVtbl)[28]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT LoadAsync(
        [NativeTypeName("UINT32")] uint count,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
            IAsyncOperation<uint>** operation
    )
    {
        return (
            (delegate* unmanaged<IDataReader, uint, IAsyncOperation<uint>**, int>)((*lpVtbl)[29])
        )(this, count, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT DetachBuffer(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
    )
    {
        return ((delegate* unmanaged<IDataReader, IBuffer*, int>)((*lpVtbl)[30]))(this, buffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT DetachStream(
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream* stream
    )
    {
        return ((delegate* unmanaged<IDataReader, IInputStream*, int>)((*lpVtbl)[31]))(
            this,
            stream
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UnconsumedBufferLength([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT get_UnicodeEncoding(
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding *")]
                UnicodeEncoding* value
        );

        [VtblIndex(8)]
        HRESULT put_UnicodeEncoding(
            [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding")]
                UnicodeEncoding value
        );

        [VtblIndex(9)]
        HRESULT get_ByteOrder(
            [NativeTypeName("ABI::Windows::Storage::Streams::ByteOrder *")] ByteOrder* value
        );

        [VtblIndex(10)]
        HRESULT put_ByteOrder(
            [NativeTypeName("ABI::Windows::Storage::Streams::ByteOrder")] ByteOrder value
        );

        [VtblIndex(11)]
        HRESULT get_InputStreamOptions(
            [NativeTypeName("ABI::Windows::Storage::Streams::InputStreamOptions *")]
                InputStreamOptions* value
        );

        [VtblIndex(12)]
        HRESULT put_InputStreamOptions(
            [NativeTypeName("ABI::Windows::Storage::Streams::InputStreamOptions")]
                InputStreamOptions value
        );

        [VtblIndex(13)]
        HRESULT ReadByte(byte* value);

        [VtblIndex(14)]
        HRESULT ReadBytes([NativeTypeName("UINT32")] uint valueLength, byte* value);

        [VtblIndex(15)]
        HRESULT ReadBuffer(
            [NativeTypeName("UINT32")] uint length,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
        );

        [VtblIndex(16)]
        HRESULT ReadBoolean([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT ReadGuid(Guid* value);

        [VtblIndex(18)]
        HRESULT ReadInt16([NativeTypeName("INT16 *")] short* value);

        [VtblIndex(19)]
        HRESULT ReadInt32([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(20)]
        HRESULT ReadInt64([NativeTypeName("INT64 *")] long* value);

        [VtblIndex(21)]
        HRESULT ReadUInt16([NativeTypeName("UINT16 *")] ushort* value);

        [VtblIndex(22)]
        HRESULT ReadUInt32([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(23)]
        HRESULT ReadUInt64([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(24)]
        HRESULT ReadSingle(float* value);

        [VtblIndex(25)]
        HRESULT ReadDouble(double* value);

        [VtblIndex(26)]
        HRESULT ReadString([NativeTypeName("UINT32")] uint codeUnitCount, HSTRING* value);

        [VtblIndex(27)]
        HRESULT ReadDateTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(28)]
        HRESULT ReadTimeSpan(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(29)]
        HRESULT LoadAsync(
            [NativeTypeName("UINT32")] uint count,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
                IAsyncOperation<uint>** operation
        );

        [VtblIndex(30)]
        HRESULT DetachBuffer(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
        );

        [VtblIndex(31)]
        HRESULT DetachStream(
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream* stream
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_UnconsumedBufferLength;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::UnicodeEncoding *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, UnicodeEncoding*, int> get_UnicodeEncoding;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::UnicodeEncoding) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, UnicodeEncoding, int> put_UnicodeEncoding;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::ByteOrder *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ByteOrder*, int> get_ByteOrder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::ByteOrder) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ByteOrder, int> put_ByteOrder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::InputStreamOptions *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, InputStreamOptions*, int> get_InputStreamOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::InputStreamOptions) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, InputStreamOptions, int> put_InputStreamOptions;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> ReadByte;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> ReadBytes;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IBuffer*, int> ReadBuffer;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> ReadBoolean;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> ReadGuid;

        [NativeTypeName("HRESULT (INT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> ReadInt16;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> ReadInt32;

        [NativeTypeName("HRESULT (INT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> ReadInt64;

        [NativeTypeName("HRESULT (UINT16 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> ReadUInt16;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> ReadUInt32;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> ReadUInt64;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, int> ReadSingle;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> ReadDouble;

        [NativeTypeName("HRESULT (UINT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HSTRING*, int> ReadString;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> ReadDateTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> ReadTimeSpan;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IAsyncOperation<uint>**, int> LoadAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> DetachBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IInputStream*, int> DetachStream;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataReader"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataReader(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDataReader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDataReader(Silk.NET.WinRT.IInspectable value)
    {
        return new IDataReader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataReader"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDataReader"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDataReader value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataReader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataReader(Silk.NET.Windows.IUnknown value)
    {
        return new IDataReader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataReader"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataReader"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataReader value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
