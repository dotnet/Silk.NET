// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E6257174-A060-4C9A-A088-3B1B471CAD28")]
[NativeTypeName("struct IMFContentProtectionDevice : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFContentProtectionDevice
    : IMFContentProtectionDevice.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFContentProtectionDevice));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFContentProtectionDevice, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFContentProtectionDevice, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFContentProtectionDevice, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InvokeFunction(
        [NativeTypeName("DWORD")] uint FunctionId,
        [NativeTypeName("DWORD")] uint InputBufferByteCount,
        [NativeTypeName("const BYTE *")] byte* InputBuffer,
        [NativeTypeName("DWORD *")] uint* OutputBufferByteCount,
        byte* OutputBuffer
    )
    {
        return (
            (delegate* unmanaged<IMFContentProtectionDevice, uint, uint, byte*, uint*, byte*, int>)(
                (*lpVtbl)[3]
            )
        )(this, FunctionId, InputBufferByteCount, InputBuffer, OutputBufferByteCount, OutputBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateDataByteCount(
        [NativeTypeName("DWORD *")] uint* PrivateInputByteCount,
        [NativeTypeName("DWORD *")] uint* PrivateOutputByteCount
    )
    {
        return ((delegate* unmanaged<IMFContentProtectionDevice, uint*, uint*, int>)((*lpVtbl)[4]))(
            this,
            PrivateInputByteCount,
            PrivateOutputByteCount
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InvokeFunction(
            [NativeTypeName("DWORD")] uint FunctionId,
            [NativeTypeName("DWORD")] uint InputBufferByteCount,
            [NativeTypeName("const BYTE *")] byte* InputBuffer,
            [NativeTypeName("DWORD *")] uint* OutputBufferByteCount,
            byte* OutputBuffer
        );

        [VtblIndex(4)]
        HRESULT GetPrivateDataByteCount(
            [NativeTypeName("DWORD *")] uint* PrivateInputByteCount,
            [NativeTypeName("DWORD *")] uint* PrivateOutputByteCount
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

        [NativeTypeName(
            "HRESULT (DWORD, DWORD, const BYTE *, DWORD *, BYTE *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, uint*, byte*, int> InvokeFunction;

        [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetPrivateDataByteCount;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFContentProtectionDevice"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFContentProtectionDevice(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFContentProtectionDevice"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFContentProtectionDevice(Silk.NET.Windows.IUnknown value)
    {
        return new IMFContentProtectionDevice(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFContentProtectionDevice"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFContentProtectionDevice"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFContentProtectionDevice value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
