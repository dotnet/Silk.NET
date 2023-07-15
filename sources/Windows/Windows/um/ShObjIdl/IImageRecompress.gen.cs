// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IImageRecompress.xml' path='doc/member[@name="IImageRecompress"]/*'/>
[Guid("505F1513-6B3E-4892-A272-59F8889A4D3E")]
[NativeTypeName("struct IImageRecompress : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IImageRecompress : IImageRecompress.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IImageRecompress));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IImageRecompress*, Guid*, void**, int> )(lpVtbl[0]))((IImageRecompress*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IImageRecompress*, uint> )(lpVtbl[1]))((IImageRecompress*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IImageRecompress*, uint> )(lpVtbl[2]))((IImageRecompress*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IImageRecompress.xml' path='doc/member[@name="IImageRecompress.RecompressImage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RecompressImage(IShellItem* psi, int cx, int cy, int iQuality, IStorage* pstg, IStream** ppstrmOut)
    {
        return ((delegate* unmanaged<IImageRecompress*, IShellItem*, int, int, int, IStorage*, IStream**, int> )(lpVtbl[3]))((IImageRecompress*)Unsafe.AsPointer(ref this), psi, cx, cy, iQuality, pstg, ppstrmOut);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RecompressImage(IShellItem* psi, int cx, int cy, int iQuality, IStorage* pstg, IStream** ppstrmOut);
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
        [NativeTypeName("HRESULT (IShellItem *, int, int, int, IStorage *, IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int, int, int, IStorage*, IStream**, int> RecompressImage;
    }
}