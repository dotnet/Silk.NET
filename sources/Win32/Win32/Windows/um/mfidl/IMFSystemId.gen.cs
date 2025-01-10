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

[Guid("FFF4AF3A-1FC1-4EF9-A29B-D26C49E2F31A")]
[NativeTypeName("struct IMFSystemId : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFSystemId : IMFSystemId.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSystemId));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSystemId, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFSystemId, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSystemId, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetData([NativeTypeName("UINT32 *")] uint* size, byte** data)
    {
        return ((delegate* unmanaged<IMFSystemId, uint*, byte**, int>)((*lpVtbl)[3]))(
            this,
            size,
            data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Setup(
        [NativeTypeName("UINT32")] uint stage,
        [NativeTypeName("UINT32")] uint cbIn,
        [NativeTypeName("const BYTE *")] byte* pbIn,
        [NativeTypeName("UINT32 *")] uint* pcbOut,
        byte** ppbOut
    )
    {
        return (
            (delegate* unmanaged<IMFSystemId, uint, uint, byte*, uint*, byte**, int>)((*lpVtbl)[4])
        )(this, stage, cbIn, pbIn, pcbOut, ppbOut);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetData([NativeTypeName("UINT32 *")] uint* size, byte** data);

        [VtblIndex(4)]
        HRESULT Setup(
            [NativeTypeName("UINT32")] uint stage,
            [NativeTypeName("UINT32")] uint cbIn,
            [NativeTypeName("const BYTE *")] byte* pbIn,
            [NativeTypeName("UINT32 *")] uint* pcbOut,
            byte** ppbOut
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

        [NativeTypeName("HRESULT (UINT32 *, BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, byte**, int> GetData;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32, const BYTE *, UINT32 *, BYTE **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, uint*, byte**, int> Setup;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFSystemId"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFSystemId(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFSystemId"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFSystemId(Silk.NET.Windows.IUnknown value)
    {
        return new IMFSystemId(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFSystemId"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFSystemId"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFSystemId value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
