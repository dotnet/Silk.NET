// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F743A1EF-D465-4290-A94B-EF0F1528F8E3")]
[NativeTypeName("struct IVideoEncodingProperties2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoEncodingProperties2
    : IVideoEncodingProperties2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoEncodingProperties2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVideoEncodingProperties2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVideoEncodingProperties2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVideoEncodingProperties2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IVideoEncodingProperties2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVideoEncodingProperties2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVideoEncodingProperties2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetFormatUserData([NativeTypeName("UINT32")] uint valueLength, byte* value)
    {
        return ((delegate* unmanaged<IVideoEncodingProperties2, uint, byte*, int>)((*lpVtbl)[6]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFormatUserData([NativeTypeName("UINT32 *")] uint* valueLength, byte** value)
    {
        return ((delegate* unmanaged<IVideoEncodingProperties2, uint*, byte**, int>)((*lpVtbl)[7]))(
            this,
            valueLength,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ProfileId([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged<IVideoEncodingProperties2, int, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ProfileId([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IVideoEncodingProperties2, int*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SetFormatUserData([NativeTypeName("UINT32")] uint valueLength, byte* value);

        [VtblIndex(7)]
        HRESULT GetFormatUserData([NativeTypeName("UINT32 *")] uint* valueLength, byte** value);

        [VtblIndex(8)]
        HRESULT put_ProfileId([NativeTypeName("INT32")] int value);

        [VtblIndex(9)]
        HRESULT get_ProfileId([NativeTypeName("INT32 *")] int* value);
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

        [NativeTypeName("HRESULT (UINT32, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> SetFormatUserData;

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, byte**, int> GetFormatUserData;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_ProfileId;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_ProfileId;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVideoEncodingProperties2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVideoEncodingProperties2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVideoEncodingProperties2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVideoEncodingProperties2(Silk.NET.WinRT.IInspectable value)
    {
        return new IVideoEncodingProperties2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoEncodingProperties2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoEncodingProperties2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IVideoEncodingProperties2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVideoEncodingProperties2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVideoEncodingProperties2(Silk.NET.Windows.IUnknown value)
    {
        return new IVideoEncodingProperties2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoEncodingProperties2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoEncodingProperties2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVideoEncodingProperties2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
