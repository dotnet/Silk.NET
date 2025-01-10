// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.cryptography.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("320B7E22-3CB0-4CDF-8663-1D28910065EB")]
[NativeTypeName("struct ICryptographicBufferStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICryptographicBufferStatics
    : ICryptographicBufferStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICryptographicBufferStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICryptographicBufferStatics, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICryptographicBufferStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICryptographicBufferStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ICryptographicBufferStatics, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICryptographicBufferStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICryptographicBufferStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Compare(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer object1,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer object2,
        [NativeTypeName("boolean *")] byte* isEqual
    )
    {
        return (
            (delegate* unmanaged<ICryptographicBufferStatics, IBuffer, IBuffer, byte*, int>)(
                (*lpVtbl)[6]
            )
        )(this, object1, object2, isEqual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GenerateRandom(
        [NativeTypeName("UINT32")] uint length,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
    )
    {
        return (
            (delegate* unmanaged<ICryptographicBufferStatics, uint, IBuffer*, int>)((*lpVtbl)[7])
        )(this, length, buffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GenerateRandomNumber([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<ICryptographicBufferStatics, uint*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateFromByteArray(
        [NativeTypeName("UINT32")] uint valueLength,
        byte* value,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
    )
    {
        return (
            (delegate* unmanaged<ICryptographicBufferStatics, uint, byte*, IBuffer*, int>)(
                (*lpVtbl)[9]
            )
        )(this, valueLength, value, buffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CopyToByteArray(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
        [NativeTypeName("UINT32 *")] uint* valueLength,
        byte** value
    )
    {
        return (
            (delegate* unmanaged<ICryptographicBufferStatics, IBuffer, uint*, byte**, int>)(
                (*lpVtbl)[10]
            )
        )(this, buffer, valueLength, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DecodeFromHexString(
        HSTRING value,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
    )
    {
        return (
            (delegate* unmanaged<ICryptographicBufferStatics, HSTRING, IBuffer*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value, buffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT EncodeToHexString(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
        HSTRING* value
    )
    {
        return (
            (delegate* unmanaged<ICryptographicBufferStatics, IBuffer, HSTRING*, int>)(
                (*lpVtbl)[12]
            )
        )(this, buffer, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DecodeFromBase64String(
        HSTRING value,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
    )
    {
        return (
            (delegate* unmanaged<ICryptographicBufferStatics, HSTRING, IBuffer*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value, buffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT EncodeToBase64String(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
        HSTRING* value
    )
    {
        return (
            (delegate* unmanaged<ICryptographicBufferStatics, IBuffer, HSTRING*, int>)(
                (*lpVtbl)[14]
            )
        )(this, buffer, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT ConvertStringToBinary(
        HSTRING value,
        [NativeTypeName("ABI::Windows::Security::Cryptography::BinaryStringEncoding")]
            BinaryStringEncoding encoding,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
    )
    {
        return (
            (delegate* unmanaged<
                ICryptographicBufferStatics,
                HSTRING,
                BinaryStringEncoding,
                IBuffer*,
                int>)((*lpVtbl)[15])
        )(this, value, encoding, buffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT ConvertBinaryToString(
        [NativeTypeName("ABI::Windows::Security::Cryptography::BinaryStringEncoding")]
            BinaryStringEncoding encoding,
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
        HSTRING* value
    )
    {
        return (
            (delegate* unmanaged<
                ICryptographicBufferStatics,
                BinaryStringEncoding,
                IBuffer,
                HSTRING*,
                int>)((*lpVtbl)[16])
        )(this, encoding, buffer, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Compare(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer object1,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer object2,
            [NativeTypeName("boolean *")] byte* isEqual
        );

        [VtblIndex(7)]
        HRESULT GenerateRandom(
            [NativeTypeName("UINT32")] uint length,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
        );

        [VtblIndex(8)]
        HRESULT GenerateRandomNumber([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT CreateFromByteArray(
            [NativeTypeName("UINT32")] uint valueLength,
            byte* value,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
        );

        [VtblIndex(10)]
        HRESULT CopyToByteArray(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
            [NativeTypeName("UINT32 *")] uint* valueLength,
            byte** value
        );

        [VtblIndex(11)]
        HRESULT DecodeFromHexString(
            HSTRING value,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
        );

        [VtblIndex(12)]
        HRESULT EncodeToHexString(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
            HSTRING* value
        );

        [VtblIndex(13)]
        HRESULT DecodeFromBase64String(
            HSTRING value,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
        );

        [VtblIndex(14)]
        HRESULT EncodeToBase64String(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
            HSTRING* value
        );

        [VtblIndex(15)]
        HRESULT ConvertStringToBinary(
            HSTRING value,
            [NativeTypeName("ABI::Windows::Security::Cryptography::BinaryStringEncoding")]
                BinaryStringEncoding encoding,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* buffer
        );

        [VtblIndex(16)]
        HRESULT ConvertBinaryToString(
            [NativeTypeName("ABI::Windows::Security::Cryptography::BinaryStringEncoding")]
                BinaryStringEncoding encoding,
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer *")] IBuffer buffer,
            HSTRING* value
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
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, ABI::Windows::Storage::Streams::IBuffer *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, IBuffer, byte*, int> Compare;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, IBuffer*, int> GenerateRandom;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GenerateRandomNumber;

        [NativeTypeName(
            "HRESULT (UINT32, BYTE *, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, byte*, IBuffer*, int> CreateFromByteArray;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, UINT32 *, BYTE **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, uint*, byte**, int> CopyToByteArray;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IBuffer*, int> DecodeFromHexString;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, HSTRING*, int> EncodeToHexString;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IBuffer*, int> DecodeFromBase64String;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer *, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer, HSTRING*, int> EncodeToBase64String;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Security::Cryptography::BinaryStringEncoding, ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            BinaryStringEncoding,
            IBuffer*,
            int> ConvertStringToBinary;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::BinaryStringEncoding, ABI::Windows::Storage::Streams::IBuffer *, HSTRING *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BinaryStringEncoding,
            IBuffer,
            HSTRING*,
            int> ConvertBinaryToString;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICryptographicBufferStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICryptographicBufferStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICryptographicBufferStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICryptographicBufferStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new ICryptographicBufferStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICryptographicBufferStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICryptographicBufferStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICryptographicBufferStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICryptographicBufferStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICryptographicBufferStatics(Silk.NET.Windows.IUnknown value)
    {
        return new ICryptographicBufferStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICryptographicBufferStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICryptographicBufferStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICryptographicBufferStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
