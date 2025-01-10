// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D1A34EF2-CAD8-4635-A3D2-FCDA8D3F3CAF")]
[NativeTypeName("struct IBitmapData : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.14393.0")]
public unsafe partial struct IBitmapData : IBitmapData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBitmapData));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBitmapData, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBitmapData, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBitmapData, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CopyBytesTo(
        [NativeTypeName("unsigned int")] uint sourceOffsetInBytes,
        [NativeTypeName("unsigned int")] uint maxBytesToCopy,
        byte* pvBytes,
        [NativeTypeName("unsigned int *")] uint* numberOfBytesCopied
    )
    {
        return ((delegate* unmanaged<IBitmapData, uint, uint, byte*, uint*, int>)((*lpVtbl)[3]))(
            this,
            sourceOffsetInBytes,
            maxBytesToCopy,
            pvBytes,
            numberOfBytesCopied
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStride([NativeTypeName("unsigned int *")] uint* pStride)
    {
        return ((delegate* unmanaged<IBitmapData, uint*, int>)((*lpVtbl)[4]))(this, pStride);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetBitmapDescription(BitmapDescription* pBitmapDescription)
    {
        return ((delegate* unmanaged<IBitmapData, BitmapDescription*, int>)((*lpVtbl)[5]))(
            this,
            pBitmapDescription
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSourceBitmapDescription(BitmapDescription* pBitmapDescription)
    {
        return ((delegate* unmanaged<IBitmapData, BitmapDescription*, int>)((*lpVtbl)[6]))(
            this,
            pBitmapDescription
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CopyBytesTo(
            [NativeTypeName("unsigned int")] uint sourceOffsetInBytes,
            [NativeTypeName("unsigned int")] uint maxBytesToCopy,
            byte* pvBytes,
            [NativeTypeName("unsigned int *")] uint* numberOfBytesCopied
        );

        [VtblIndex(4)]
        HRESULT GetStride([NativeTypeName("unsigned int *")] uint* pStride);

        [VtblIndex(5)]
        HRESULT GetBitmapDescription(BitmapDescription* pBitmapDescription);

        [VtblIndex(6)]
        HRESULT GetSourceBitmapDescription(BitmapDescription* pBitmapDescription);
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

        [NativeTypeName(
            "HRESULT (unsigned int, unsigned int, byte *, unsigned int *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, uint*, int> CopyBytesTo;

        [NativeTypeName("HRESULT (unsigned int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetStride;

        [NativeTypeName("HRESULT (BitmapDescription *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BitmapDescription*, int> GetBitmapDescription;

        [NativeTypeName("HRESULT (BitmapDescription *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BitmapDescription*, int> GetSourceBitmapDescription;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBitmapData"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBitmapData(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBitmapData"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBitmapData(Silk.NET.Windows.IUnknown value)
    {
        return new IBitmapData(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBitmapData"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBitmapData"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBitmapData value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
