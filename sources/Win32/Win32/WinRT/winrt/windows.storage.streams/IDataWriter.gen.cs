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

[Guid("64B89265-D341-4922-B38A-DD4AF8808C4E")]
[NativeTypeName("struct IDataWriter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDataWriter : IDataWriter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataWriter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDataWriter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDataWriter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataWriter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDataWriter, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDataWriter, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDataWriter, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_UnstoredBufferLength([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IDataWriter, uint*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_UnicodeEncoding(
        [NativeTypeName("ABI::Windows::Storage::Streams::UnicodeEncoding *")] UnicodeEncoding* value
    )
    {
        return ((delegate* unmanaged<IDataWriter, UnicodeEncoding*, int>)((*lpVtbl)[7]))(
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
        return ((delegate* unmanaged<IDataWriter, UnicodeEncoding, int>)((*lpVtbl)[8]))(
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
        return ((delegate* unmanaged<IDataWriter, ByteOrder*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ByteOrder(
        [NativeTypeName("ABI::Windows::Storage::Streams::ByteOrder")] ByteOrder value
    )
    {
        return ((delegate* unmanaged<IDataWriter, ByteOrder, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT WriteByte(byte value)
    {
        return ((delegate* unmanaged<IDataWriter, byte, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT WriteBytes([NativeTypeName("UINT32")] uint valueLength, byte* value)
    {
        return ((delegate* unmanaged<IDataWriter, uint, byte*, int>)((*lpVtbl)[12]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT WriteBuffer(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer
    )
    {
        return ((delegate* unmanaged<IDataWriter, IBuffer, int>)((*lpVtbl)[13]))(this, buffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT WriteBufferRange(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
        [NativeTypeName("UINT32")] uint start,
        [NativeTypeName("UINT32")] uint count
    )
    {
        return ((delegate* unmanaged<IDataWriter, IBuffer, uint, uint, int>)((*lpVtbl)[14]))(
            this,
            buffer,
            start,
            count
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT WriteBoolean([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IDataWriter, byte, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT WriteGuid(Guid value)
    {
        return ((delegate* unmanaged<IDataWriter, Guid, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT WriteInt16([NativeTypeName("INT16")] short value)
    {
        return ((delegate* unmanaged<IDataWriter, short, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT WriteInt32([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<IDataWriter, int, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT WriteInt64([NativeTypeName("INT64")] long value)
    {
        return ((delegate* unmanaged<IDataWriter, long, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT WriteUInt16([NativeTypeName("UINT16")] ushort value)
    {
        return ((delegate* unmanaged<IDataWriter, ushort, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT WriteUInt32([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IDataWriter, uint, int>)((*lpVtbl)[21]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT WriteUInt64([NativeTypeName("UINT64")] ulong value)
    {
        return ((delegate* unmanaged<IDataWriter, ulong, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT WriteSingle(float value)
    {
        return ((delegate* unmanaged<IDataWriter, float, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT WriteDouble(double value)
    {
        return ((delegate* unmanaged<IDataWriter, double, int>)((*lpVtbl)[24]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT WriteDateTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value
    )
    {
        return ((delegate* unmanaged<IDataWriter, WinRTDateTime, int>)((*lpVtbl)[25]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT WriteTimeSpan(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<IDataWriter, TimeSpan, int>)((*lpVtbl)[26]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT WriteString(HSTRING value, [NativeTypeName("UINT32 *")] uint* codeUnitCount)
    {
        return ((delegate* unmanaged<IDataWriter, HSTRING, uint*, int>)((*lpVtbl)[27]))(
            this,
            value,
            codeUnitCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT MeasureString(HSTRING value, [NativeTypeName("UINT32 *")] uint* codeUnitCount)
    {
        return ((delegate* unmanaged<IDataWriter, HSTRING, uint*, int>)((*lpVtbl)[28]))(
            this,
            value,
            codeUnitCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT StoreAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
            IAsyncOperation<uint>** operation
    )
    {
        return ((delegate* unmanaged<IDataWriter, IAsyncOperation<uint>**, int>)((*lpVtbl)[29]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT FlushAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return ((delegate* unmanaged<IDataWriter, IAsyncOperation<byte>**, int>)((*lpVtbl)[30]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT DetachBuffer(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
    )
    {
        return ((delegate* unmanaged<IDataWriter, IBuffer*, int>)((*lpVtbl)[31]))(this, buffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT DetachStream(
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")]
            IOutputStream* outputStream
    )
    {
        return ((delegate* unmanaged<IDataWriter, IOutputStream*, int>)((*lpVtbl)[32]))(
            this,
            outputStream
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_UnstoredBufferLength([NativeTypeName("UINT32 *")] uint* value);

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
        HRESULT WriteByte(byte value);

        [VtblIndex(12)]
        HRESULT WriteBytes([NativeTypeName("UINT32")] uint valueLength, byte* value);

        [VtblIndex(13)]
        HRESULT WriteBuffer(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer
        );

        [VtblIndex(14)]
        HRESULT WriteBufferRange(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
            [NativeTypeName("UINT32")] uint start,
            [NativeTypeName("UINT32")] uint count
        );

        [VtblIndex(15)]
        HRESULT WriteBoolean([NativeTypeName("boolean")] byte value);

        [VtblIndex(16)]
        HRESULT WriteGuid(Guid value);

        [VtblIndex(17)]
        HRESULT WriteInt16([NativeTypeName("INT16")] short value);

        [VtblIndex(18)]
        HRESULT WriteInt32([NativeTypeName("INT32")] int value);

        [VtblIndex(19)]
        HRESULT WriteInt64([NativeTypeName("INT64")] long value);

        [VtblIndex(20)]
        HRESULT WriteUInt16([NativeTypeName("UINT16")] ushort value);

        [VtblIndex(21)]
        HRESULT WriteUInt32([NativeTypeName("UINT32")] uint value);

        [VtblIndex(22)]
        HRESULT WriteUInt64([NativeTypeName("UINT64")] ulong value);

        [VtblIndex(23)]
        HRESULT WriteSingle(float value);

        [VtblIndex(24)]
        HRESULT WriteDouble(double value);

        [VtblIndex(25)]
        HRESULT WriteDateTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value
        );

        [VtblIndex(26)]
        HRESULT WriteTimeSpan(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
        );

        [VtblIndex(27)]
        HRESULT WriteString(HSTRING value, [NativeTypeName("UINT32 *")] uint* codeUnitCount);

        [VtblIndex(28)]
        HRESULT MeasureString(HSTRING value, [NativeTypeName("UINT32 *")] uint* codeUnitCount);

        [VtblIndex(29)]
        HRESULT StoreAsync(
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **")]
                IAsyncOperation<uint>** operation
        );

        [VtblIndex(30)]
        HRESULT FlushAsync(
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(31)]
        HRESULT DetachBuffer(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
        );

        [VtblIndex(32)]
        HRESULT DetachStream(
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")]
                IOutputStream* outputStream
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
        public delegate* unmanaged<TSelf*, uint*, int> get_UnstoredBufferLength;

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

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> WriteByte;

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> WriteBytes;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, int> WriteBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, UINT32, UINT32) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, uint, uint, int> WriteBufferRange;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> WriteBoolean;

        [NativeTypeName("HRESULT (GUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> WriteGuid;

        [NativeTypeName("HRESULT (INT16) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> WriteInt16;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> WriteInt32;

        [NativeTypeName("HRESULT (INT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> WriteInt64;

        [NativeTypeName("HRESULT (UINT16) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> WriteUInt16;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> WriteUInt32;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> WriteUInt64;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> WriteSingle;

        [NativeTypeName("HRESULT (DOUBLE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> WriteDouble;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime, int> WriteDateTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> WriteTimeSpan;

        [NativeTypeName("HRESULT (HSTRING, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, uint*, int> WriteString;

        [NativeTypeName("HRESULT (HSTRING, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, uint*, int> MeasureString;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_UINT32_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<uint>**, int> StoreAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<byte>**, int> FlushAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> DetachBuffer;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IOutputStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IOutputStream*, int> DetachStream;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataWriter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataWriter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDataWriter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDataWriter(Silk.NET.WinRT.IInspectable value)
    {
        return new IDataWriter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataWriter"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDataWriter"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDataWriter value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataWriter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataWriter(Silk.NET.Windows.IUnknown value)
    {
        return new IDataWriter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataWriter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataWriter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataWriter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
