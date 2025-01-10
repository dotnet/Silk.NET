// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("69D14C80-C18E-11D0-A9CE-006097942311")]
[NativeTypeName("struct IDataFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDataFilter : IDataFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDataFilter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDataFilter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDataFilter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDataFilter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DoEncode(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LONG")] int lInBufferSize,
        byte* pbInBuffer,
        [NativeTypeName("LONG")] int lOutBufferSize,
        byte* pbOutBuffer,
        [NativeTypeName("LONG")] int lInBytesAvailable,
        [NativeTypeName("LONG *")] int* plInBytesRead,
        [NativeTypeName("LONG *")] int* plOutBytesWritten,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return (
            (delegate* unmanaged<
                IDataFilter,
                uint,
                int,
                byte*,
                int,
                byte*,
                int,
                int*,
                int*,
                uint,
                int>)((*lpVtbl)[3])
        )(
            this,
            dwFlags,
            lInBufferSize,
            pbInBuffer,
            lOutBufferSize,
            pbOutBuffer,
            lInBytesAvailable,
            plInBytesRead,
            plOutBytesWritten,
            dwReserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DoDecode(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("LONG")] int lInBufferSize,
        byte* pbInBuffer,
        [NativeTypeName("LONG")] int lOutBufferSize,
        byte* pbOutBuffer,
        [NativeTypeName("LONG")] int lInBytesAvailable,
        [NativeTypeName("LONG *")] int* plInBytesRead,
        [NativeTypeName("LONG *")] int* plOutBytesWritten,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return (
            (delegate* unmanaged<
                IDataFilter,
                uint,
                int,
                byte*,
                int,
                byte*,
                int,
                int*,
                int*,
                uint,
                int>)((*lpVtbl)[4])
        )(
            this,
            dwFlags,
            lInBufferSize,
            pbInBuffer,
            lOutBufferSize,
            pbOutBuffer,
            lInBytesAvailable,
            plInBytesRead,
            plOutBytesWritten,
            dwReserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetEncodingLevel([NativeTypeName("DWORD")] uint dwEncLevel)
    {
        return ((delegate* unmanaged<IDataFilter, uint, int>)((*lpVtbl)[5]))(this, dwEncLevel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DoEncode(
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("LONG")] int lInBufferSize,
            byte* pbInBuffer,
            [NativeTypeName("LONG")] int lOutBufferSize,
            byte* pbOutBuffer,
            [NativeTypeName("LONG")] int lInBytesAvailable,
            [NativeTypeName("LONG *")] int* plInBytesRead,
            [NativeTypeName("LONG *")] int* plOutBytesWritten,
            [NativeTypeName("DWORD")] uint dwReserved
        );

        [VtblIndex(4)]
        HRESULT DoDecode(
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("LONG")] int lInBufferSize,
            byte* pbInBuffer,
            [NativeTypeName("LONG")] int lOutBufferSize,
            byte* pbOutBuffer,
            [NativeTypeName("LONG")] int lInBytesAvailable,
            [NativeTypeName("LONG *")] int* plInBytesRead,
            [NativeTypeName("LONG *")] int* plOutBytesWritten,
            [NativeTypeName("DWORD")] uint dwReserved
        );

        [VtblIndex(5)]
        HRESULT SetEncodingLevel([NativeTypeName("DWORD")] uint dwEncLevel);
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
            "HRESULT (DWORD, LONG, BYTE *, LONG, BYTE *, LONG, LONG *, LONG *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            int,
            byte*,
            int,
            byte*,
            int,
            int*,
            int*,
            uint,
            int> DoEncode;

        [NativeTypeName(
            "HRESULT (DWORD, LONG, BYTE *, LONG, BYTE *, LONG, LONG *, LONG *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            int,
            byte*,
            int,
            byte*,
            int,
            int*,
            int*,
            uint,
            int> DoDecode;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetEncodingLevel;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDataFilter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDataFilter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDataFilter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDataFilter(Silk.NET.Windows.IUnknown value)
    {
        return new IDataFilter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDataFilter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDataFilter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDataFilter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
