// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFLocalMFTRegistration.xml' path='doc/member[@name="IMFLocalMFTRegistration"]/*' />
[Guid("149C4D73-B4BE-4F8D-8B87-079E926B6ADD")]
[NativeTypeName("struct IMFLocalMFTRegistration : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFLocalMFTRegistration : IMFLocalMFTRegistration.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFLocalMFTRegistration));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFLocalMFTRegistration*, Guid*, void**, int>)(lpVtbl[0]))((IMFLocalMFTRegistration*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFLocalMFTRegistration*, uint>)(lpVtbl[1]))((IMFLocalMFTRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFLocalMFTRegistration*, uint>)(lpVtbl[2]))((IMFLocalMFTRegistration*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFLocalMFTRegistration.xml' path='doc/member[@name="IMFLocalMFTRegistration.RegisterMFTs"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterMFTs(MFT_REGISTRATION_INFO* pMFTs, [NativeTypeName("DWORD")] uint cMFTs)
    {
        return ((delegate* unmanaged<IMFLocalMFTRegistration*, MFT_REGISTRATION_INFO*, uint, int>)(lpVtbl[3]))((IMFLocalMFTRegistration*)Unsafe.AsPointer(ref this), pMFTs, cMFTs);
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
}
