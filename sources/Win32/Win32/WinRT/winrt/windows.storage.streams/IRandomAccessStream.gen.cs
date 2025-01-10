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

[Guid("905A0FE1-BC53-11DF-8C49-001E4FC686DA")]
[NativeTypeName("struct IRandomAccessStream : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRandomAccessStream : IRandomAccessStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRandomAccessStream));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRandomAccessStream, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRandomAccessStream, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRandomAccessStream, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IRandomAccessStream, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IRandomAccessStream, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IRandomAccessStream, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Size([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IRandomAccessStream, ulong*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Size([NativeTypeName("UINT64")] ulong value)
    {
        return ((delegate* unmanaged<IRandomAccessStream, ulong, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetInputStreamAt(
        [NativeTypeName("UINT64")] ulong position,
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream* stream
    )
    {
        return (
            (delegate* unmanaged<IRandomAccessStream, ulong, IInputStream*, int>)((*lpVtbl)[8])
        )(this, position, stream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetOutputStreamAt(
        [NativeTypeName("UINT64")] ulong position,
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream* stream
    )
    {
        return (
            (delegate* unmanaged<IRandomAccessStream, ulong, IOutputStream*, int>)((*lpVtbl)[9])
        )(this, position, stream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Position([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IRandomAccessStream, ulong*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Seek([NativeTypeName("UINT64")] ulong position)
    {
        return ((delegate* unmanaged<IRandomAccessStream, ulong, int>)((*lpVtbl)[11]))(
            this,
            position
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CloneStream(
        [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")]
            IRandomAccessStream* stream
    )
    {
        return (
            (delegate* unmanaged<IRandomAccessStream, IRandomAccessStream*, int>)((*lpVtbl)[12])
        )(this, stream);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_CanRead([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IRandomAccessStream, byte*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_CanWrite([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IRandomAccessStream, byte*, int>)((*lpVtbl)[14]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Size([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(7)]
        HRESULT put_Size([NativeTypeName("UINT64")] ulong value);

        [VtblIndex(8)]
        HRESULT GetInputStreamAt(
            [NativeTypeName("UINT64")] ulong position,
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream* stream
        );

        [VtblIndex(9)]
        HRESULT GetOutputStreamAt(
            [NativeTypeName("UINT64")] ulong position,
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")]
                IOutputStream* stream
        );

        [VtblIndex(10)]
        HRESULT get_Position([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(11)]
        HRESULT Seek([NativeTypeName("UINT64")] ulong position);

        [VtblIndex(12)]
        HRESULT CloneStream(
            [NativeTypeName("ABI::Windows::Storage::Streams::IRandomAccessStream **")]
                IRandomAccessStream* stream
        );

        [VtblIndex(13)]
        HRESULT get_CanRead([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT get_CanWrite([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_Size;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> put_Size;

        [NativeTypeName(
            "HRESULT (UINT64, ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ulong, IInputStream*, int> GetInputStreamAt;

        [NativeTypeName(
            "HRESULT (UINT64, ABI::Windows::Storage::Streams::IOutputStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ulong, IOutputStream*, int> GetOutputStreamAt;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_Position;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> Seek;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IRandomAccessStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRandomAccessStream*, int> CloneStream;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CanRead;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_CanWrite;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRandomAccessStream"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRandomAccessStream(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRandomAccessStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRandomAccessStream(Silk.NET.WinRT.IInspectable value)
    {
        return new IRandomAccessStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRandomAccessStream"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRandomAccessStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IRandomAccessStream value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRandomAccessStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRandomAccessStream(Silk.NET.Windows.IUnknown value)
    {
        return new IRandomAccessStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRandomAccessStream"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRandomAccessStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRandomAccessStream value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
