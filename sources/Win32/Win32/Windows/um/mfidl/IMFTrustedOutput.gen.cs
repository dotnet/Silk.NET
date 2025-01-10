// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D19F8E95-B126-4446-890C-5DCB7AD71453")]
[NativeTypeName("struct IMFTrustedOutput : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTrustedOutput : IMFTrustedOutput.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTrustedOutput));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTrustedOutput, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFTrustedOutput, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTrustedOutput, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetOutputTrustAuthorityCount(
        [NativeTypeName("DWORD *")] uint* pcOutputTrustAuthorities
    )
    {
        return ((delegate* unmanaged<IMFTrustedOutput, uint*, int>)((*lpVtbl)[3]))(
            this,
            pcOutputTrustAuthorities
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetOutputTrustAuthorityByIndex(
        [NativeTypeName("DWORD")] uint dwIndex,
        IMFOutputTrustAuthority* ppauthority
    )
    {
        return (
            (delegate* unmanaged<IMFTrustedOutput, uint, IMFOutputTrustAuthority*, int>)(
                (*lpVtbl)[4]
            )
        )(this, dwIndex, ppauthority);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsFinal(BOOL* pfIsFinal)
    {
        return ((delegate* unmanaged<IMFTrustedOutput, BOOL*, int>)((*lpVtbl)[5]))(this, pfIsFinal);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetOutputTrustAuthorityCount(
            [NativeTypeName("DWORD *")] uint* pcOutputTrustAuthorities
        );

        [VtblIndex(4)]
        HRESULT GetOutputTrustAuthorityByIndex(
            [NativeTypeName("DWORD")] uint dwIndex,
            IMFOutputTrustAuthority* ppauthority
        );

        [VtblIndex(5)]
        HRESULT IsFinal(BOOL* pfIsFinal);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetOutputTrustAuthorityCount;

        [NativeTypeName("HRESULT (DWORD, IMFOutputTrustAuthority **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IMFOutputTrustAuthority*,
            int> GetOutputTrustAuthorityByIndex;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsFinal;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFTrustedOutput"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFTrustedOutput(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFTrustedOutput"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFTrustedOutput(Silk.NET.Windows.IUnknown value)
    {
        return new IMFTrustedOutput(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFTrustedOutput"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFTrustedOutput"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFTrustedOutput value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
