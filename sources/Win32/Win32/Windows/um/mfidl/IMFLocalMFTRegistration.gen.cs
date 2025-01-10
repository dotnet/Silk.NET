// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("149C4D73-B4BE-4F8D-8B87-079E926B6ADD")]
[NativeTypeName("struct IMFLocalMFTRegistration : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFLocalMFTRegistration
    : IMFLocalMFTRegistration.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFLocalMFTRegistration));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFLocalMFTRegistration, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFLocalMFTRegistration, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFLocalMFTRegistration, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterMFTs(MFT_REGISTRATION_INFO* pMFTs, [NativeTypeName("DWORD")] uint cMFTs)
    {
        return (
            (delegate* unmanaged<IMFLocalMFTRegistration, MFT_REGISTRATION_INFO*, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, pMFTs, cMFTs);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterMFTs(MFT_REGISTRATION_INFO* pMFTs, [NativeTypeName("DWORD")] uint cMFTs);
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

        [NativeTypeName("HRESULT (MFT_REGISTRATION_INFO *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MFT_REGISTRATION_INFO*, uint, int> RegisterMFTs;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFLocalMFTRegistration"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFLocalMFTRegistration(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFLocalMFTRegistration"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFLocalMFTRegistration(Silk.NET.Windows.IUnknown value)
    {
        return new IMFLocalMFTRegistration(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFLocalMFTRegistration"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFLocalMFTRegistration"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFLocalMFTRegistration value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
