// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IExtractImage.xml' path='doc/member[@name="IExtractImage"]/*'/>
[Guid("BB2E617C-0920-11D1-9A0B-00C04FC2D6C1")]
[NativeTypeName("struct IExtractImage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExtractImage : IExtractImage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExtractImage));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExtractImage*, Guid*, void**, int> )(lpVtbl[0]))((IExtractImage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IExtractImage*, uint> )(lpVtbl[1]))((IExtractImage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExtractImage*, uint> )(lpVtbl[2]))((IExtractImage*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IExtractImage.xml' path='doc/member[@name="IExtractImage.GetLocation"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetLocation([NativeTypeName("LPWSTR")] ushort* pszPathBuffer, [NativeTypeName("DWORD")] uint cch, [NativeTypeName("DWORD *")] uint* pdwPriority, [NativeTypeName("const SIZE *")] SIZE* prgSize, [NativeTypeName("DWORD")] uint dwRecClrDepth, [NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IExtractImage*, ushort*, uint, uint*, SIZE*, uint, uint*, int> )(lpVtbl[3]))((IExtractImage*)Unsafe.AsPointer(ref this), pszPathBuffer, cch, pdwPriority, prgSize, dwRecClrDepth, pdwFlags);
    }

    /// <include file='IExtractImage.xml' path='doc/member[@name="IExtractImage.Extract"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Extract(HBITMAP* phBmpThumbnail)
    {
        return ((delegate* unmanaged<IExtractImage*, HBITMAP*, int> )(lpVtbl[4]))((IExtractImage*)Unsafe.AsPointer(ref this), phBmpThumbnail);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetLocation([NativeTypeName("LPWSTR")] ushort* pszPathBuffer, [NativeTypeName("DWORD")] uint cch, [NativeTypeName("DWORD *")] uint* pdwPriority, [NativeTypeName("const SIZE *")] SIZE* prgSize, [NativeTypeName("DWORD")] uint dwRecClrDepth, [NativeTypeName("DWORD *")] uint* pdwFlags);
        [VtblIndex(4)]
        HRESULT Extract(HBITMAP* phBmpThumbnail);
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
        [NativeTypeName("HRESULT (LPWSTR, DWORD, DWORD *, const SIZE *, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint*, SIZE*, uint, uint*, int> GetLocation;
        [NativeTypeName("HRESULT (HBITMAP *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HBITMAP*, int> Extract;
    }
}