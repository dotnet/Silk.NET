// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C6E13350-30AC-11D0-A18C-00A0C9118956")]
[NativeTypeName("struct IAMAnalogVideoDecoder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMAnalogVideoDecoder : IAMAnalogVideoDecoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMAnalogVideoDecoder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMAnalogVideoDecoder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMAnalogVideoDecoder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMAnalogVideoDecoder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_AvailableTVFormats([NativeTypeName("long *")] int* lAnalogVideoStandard)
    {
        return ((delegate* unmanaged<IAMAnalogVideoDecoder, int*, int>)((*lpVtbl)[3]))(
            this,
            lAnalogVideoStandard
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_TVFormat([NativeTypeName("long")] int lAnalogVideoStandard)
    {
        return ((delegate* unmanaged<IAMAnalogVideoDecoder, int, int>)((*lpVtbl)[4]))(
            this,
            lAnalogVideoStandard
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_TVFormat([NativeTypeName("long *")] int* plAnalogVideoStandard)
    {
        return ((delegate* unmanaged<IAMAnalogVideoDecoder, int*, int>)((*lpVtbl)[5]))(
            this,
            plAnalogVideoStandard
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_HorizontalLocked([NativeTypeName("long *")] int* plLocked)
    {
        return ((delegate* unmanaged<IAMAnalogVideoDecoder, int*, int>)((*lpVtbl)[6]))(
            this,
            plLocked
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_VCRHorizontalLocking([NativeTypeName("long")] int lVCRHorizontalLocking)
    {
        return ((delegate* unmanaged<IAMAnalogVideoDecoder, int, int>)((*lpVtbl)[7]))(
            this,
            lVCRHorizontalLocking
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_VCRHorizontalLocking([NativeTypeName("long *")] int* plVCRHorizontalLocking)
    {
        return ((delegate* unmanaged<IAMAnalogVideoDecoder, int*, int>)((*lpVtbl)[8]))(
            this,
            plVCRHorizontalLocking
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_NumberOfLines([NativeTypeName("long *")] int* plNumberOfLines)
    {
        return ((delegate* unmanaged<IAMAnalogVideoDecoder, int*, int>)((*lpVtbl)[9]))(
            this,
            plNumberOfLines
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_OutputEnable([NativeTypeName("long")] int lOutputEnable)
    {
        return ((delegate* unmanaged<IAMAnalogVideoDecoder, int, int>)((*lpVtbl)[10]))(
            this,
            lOutputEnable
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_OutputEnable([NativeTypeName("long *")] int* plOutputEnable)
    {
        return ((delegate* unmanaged<IAMAnalogVideoDecoder, int*, int>)((*lpVtbl)[11]))(
            this,
            plOutputEnable
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_AvailableTVFormats([NativeTypeName("long *")] int* lAnalogVideoStandard);

        [VtblIndex(4)]
        HRESULT put_TVFormat([NativeTypeName("long")] int lAnalogVideoStandard);

        [VtblIndex(5)]
        HRESULT get_TVFormat([NativeTypeName("long *")] int* plAnalogVideoStandard);

        [VtblIndex(6)]
        HRESULT get_HorizontalLocked([NativeTypeName("long *")] int* plLocked);

        [VtblIndex(7)]
        HRESULT put_VCRHorizontalLocking([NativeTypeName("long")] int lVCRHorizontalLocking);

        [VtblIndex(8)]
        HRESULT get_VCRHorizontalLocking([NativeTypeName("long *")] int* plVCRHorizontalLocking);

        [VtblIndex(9)]
        HRESULT get_NumberOfLines([NativeTypeName("long *")] int* plNumberOfLines);

        [VtblIndex(10)]
        HRESULT put_OutputEnable([NativeTypeName("long")] int lOutputEnable);

        [VtblIndex(11)]
        HRESULT get_OutputEnable([NativeTypeName("long *")] int* plOutputEnable);
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

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_AvailableTVFormats;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_TVFormat;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_TVFormat;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_HorizontalLocked;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_VCRHorizontalLocking;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_VCRHorizontalLocking;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_NumberOfLines;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_OutputEnable;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_OutputEnable;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMAnalogVideoDecoder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMAnalogVideoDecoder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMAnalogVideoDecoder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMAnalogVideoDecoder(Silk.NET.Windows.IUnknown value)
    {
        return new IAMAnalogVideoDecoder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMAnalogVideoDecoder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMAnalogVideoDecoder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMAnalogVideoDecoder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
