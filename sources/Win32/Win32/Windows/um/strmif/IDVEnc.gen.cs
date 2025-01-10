// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D18E17A0-AACB-11D0-AFB0-00AA00B67A42")]
[NativeTypeName("struct IDVEnc : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDVEnc : IDVEnc.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDVEnc));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDVEnc, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDVEnc, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDVEnc, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_IFormatResolution(
        int* VideoFormat,
        int* DVFormat,
        int* Resolution,
        byte fDVInfo,
        DVINFO* sDVInfo
    )
    {
        return ((delegate* unmanaged<IDVEnc, int*, int*, int*, byte, DVINFO*, int>)((*lpVtbl)[3]))(
            this,
            VideoFormat,
            DVFormat,
            Resolution,
            fDVInfo,
            sDVInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_IFormatResolution(
        int VideoFormat,
        int DVFormat,
        int Resolution,
        byte fDVInfo,
        DVINFO* sDVInfo
    )
    {
        return ((delegate* unmanaged<IDVEnc, int, int, int, byte, DVINFO*, int>)((*lpVtbl)[4]))(
            this,
            VideoFormat,
            DVFormat,
            Resolution,
            fDVInfo,
            sDVInfo
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_IFormatResolution(
            int* VideoFormat,
            int* DVFormat,
            int* Resolution,
            byte fDVInfo,
            DVINFO* sDVInfo
        );

        [VtblIndex(4)]
        HRESULT put_IFormatResolution(
            int VideoFormat,
            int DVFormat,
            int Resolution,
            byte fDVInfo,
            DVINFO* sDVInfo
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

        [NativeTypeName("HRESULT (int *, int *, int *, BYTE, DVINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            int*,
            int*,
            int*,
            byte,
            DVINFO*,
            int> get_IFormatResolution;

        [NativeTypeName("HRESULT (int, int, int, BYTE, DVINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int, int, byte, DVINFO*, int> put_IFormatResolution;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDVEnc"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDVEnc(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDVEnc"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDVEnc(Silk.NET.Windows.IUnknown value)
    {
        return new IDVEnc(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDVEnc"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDVEnc"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDVEnc value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
