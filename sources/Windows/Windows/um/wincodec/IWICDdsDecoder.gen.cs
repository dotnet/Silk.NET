// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWICDdsDecoder.xml' path='doc/member[@name="IWICDdsDecoder"]/*'/>
[Guid("409CD537-8532-40CB-9774-E2FEB2DF4E9C")]
[NativeTypeName("struct IWICDdsDecoder : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IWICDdsDecoder : IWICDdsDecoder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICDdsDecoder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICDdsDecoder*, Guid*, void**, int> )(lpVtbl[0]))((IWICDdsDecoder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICDdsDecoder*, uint> )(lpVtbl[1]))((IWICDdsDecoder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICDdsDecoder*, uint> )(lpVtbl[2]))((IWICDdsDecoder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICDdsDecoder.xml' path='doc/member[@name="IWICDdsDecoder.GetParameters"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetParameters(WICDdsParameters* pParameters)
    {
        return ((delegate* unmanaged<IWICDdsDecoder*, WICDdsParameters*, int> )(lpVtbl[3]))((IWICDdsDecoder*)Unsafe.AsPointer(ref this), pParameters);
    }

    /// <include file='IWICDdsDecoder.xml' path='doc/member[@name="IWICDdsDecoder.GetFrame"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFrame(uint arrayIndex, uint mipLevel, uint sliceIndex, IWICBitmapFrameDecode** ppIBitmapFrame)
    {
        return ((delegate* unmanaged<IWICDdsDecoder*, uint, uint, uint, IWICBitmapFrameDecode**, int> )(lpVtbl[4]))((IWICDdsDecoder*)Unsafe.AsPointer(ref this), arrayIndex, mipLevel, sliceIndex, ppIBitmapFrame);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetParameters(WICDdsParameters* pParameters);
        [VtblIndex(4)]
        HRESULT GetFrame(uint arrayIndex, uint mipLevel, uint sliceIndex, IWICBitmapFrameDecode** ppIBitmapFrame);
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
        [NativeTypeName("HRESULT (WICDdsParameters *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WICDdsParameters*, int> GetParameters;
        [NativeTypeName("HRESULT (UINT, UINT, UINT, IWICBitmapFrameDecode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, IWICBitmapFrameDecode**, int> GetFrame;
    }
}