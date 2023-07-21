// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IWICDdsFrameDecode.xml' path='doc/member[@name="IWICDdsFrameDecode"]/*' />
[Guid("3D4C0C61-18A4-41E4-BD80-481A4FC9F464")]
[NativeTypeName("struct IWICDdsFrameDecode : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IWICDdsFrameDecode : IWICDdsFrameDecode.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDdsFrameDecode));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICDdsFrameDecode*, Guid*, void**, int>)(lpVtbl[0]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICDdsFrameDecode*, uint>)(lpVtbl[1]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICDdsFrameDecode*, uint>)(lpVtbl[2]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICDdsFrameDecode.xml' path='doc/member[@name="IWICDdsFrameDecode.GetSizeInBlocks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSizeInBlocks(uint* pWidthInBlocks, uint* pHeightInBlocks)
    {
        return ((delegate* unmanaged<IWICDdsFrameDecode*, uint*, uint*, int>)(lpVtbl[3]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), pWidthInBlocks, pHeightInBlocks);
    }

    /// <include file='IWICDdsFrameDecode.xml' path='doc/member[@name="IWICDdsFrameDecode.GetFormatInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFormatInfo(WICDdsFormatInfo* pFormatInfo)
    {
        return ((delegate* unmanaged<IWICDdsFrameDecode*, WICDdsFormatInfo*, int>)(lpVtbl[4]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), pFormatInfo);
    }

    /// <include file='IWICDdsFrameDecode.xml' path='doc/member[@name="IWICDdsFrameDecode.CopyBlocks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CopyBlocks([NativeTypeName("const WICRect *")] WICRect* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, byte* pbBuffer)
    {
        return ((delegate* unmanaged<IWICDdsFrameDecode*, WICRect*, uint, uint, byte*, int>)(lpVtbl[5]))((IWICDdsFrameDecode*)Unsafe.AsPointer(ref this), prcBoundsInBlocks, cbStride, cbBufferSize, pbBuffer);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSizeInBlocks(uint* pWidthInBlocks, uint* pHeightInBlocks);

        [VtblIndex(4)]
        HRESULT GetFormatInfo(WICDdsFormatInfo* pFormatInfo);

        [VtblIndex(5)]
        HRESULT CopyBlocks([NativeTypeName("const WICRect *")] WICRect* prcBoundsInBlocks, uint cbStride, uint cbBufferSize, byte* pbBuffer);
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

        [NativeTypeName("HRESULT (UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetSizeInBlocks;

        [NativeTypeName("HRESULT (WICDdsFormatInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICDdsFormatInfo*, int> GetFormatInfo;

        [NativeTypeName("HRESULT (const WICRect *, UINT, UINT, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICRect*, uint, uint, byte*, int> CopyBlocks;
    }
}
