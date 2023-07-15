// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IIPDVDec.xml' path='doc/member[@name="IIPDVDec"]/*'/>
[Guid("B8E8BD60-0BFE-11D0-AF91-00AA00B67A42")]
[NativeTypeName("struct IIPDVDec : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IIPDVDec : IIPDVDec.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IIPDVDec));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IIPDVDec*, Guid*, void**, int> )(lpVtbl[0]))((IIPDVDec*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IIPDVDec*, uint> )(lpVtbl[1]))((IIPDVDec*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IIPDVDec*, uint> )(lpVtbl[2]))((IIPDVDec*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IIPDVDec.xml' path='doc/member[@name="IIPDVDec.get_IPDisplay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_IPDisplay(int* displayPix)
    {
        return ((delegate* unmanaged<IIPDVDec*, int*, int> )(lpVtbl[3]))((IIPDVDec*)Unsafe.AsPointer(ref this), displayPix);
    }

    /// <include file='IIPDVDec.xml' path='doc/member[@name="IIPDVDec.put_IPDisplay"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT put_IPDisplay(int displayPix)
    {
        return ((delegate* unmanaged<IIPDVDec*, int, int> )(lpVtbl[4]))((IIPDVDec*)Unsafe.AsPointer(ref this), displayPix);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_IPDisplay(int* displayPix);
        [VtblIndex(4)]
        HRESULT put_IPDisplay(int displayPix);
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
        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_IPDisplay;
        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_IPDisplay;
    }
}