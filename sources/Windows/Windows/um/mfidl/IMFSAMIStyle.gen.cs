// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFSAMIStyle.xml' path='doc/member[@name="IMFSAMIStyle"]/*'/>
[Guid("A7E025DD-5303-4A62-89D6-E747E1EFAC73")]
[NativeTypeName("struct IMFSAMIStyle : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSAMIStyle : IMFSAMIStyle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFSAMIStyle));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSAMIStyle*, Guid*, void**, int> )(lpVtbl[0]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSAMIStyle*, uint> )(lpVtbl[1]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSAMIStyle*, uint> )(lpVtbl[2]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFSAMIStyle.xml' path='doc/member[@name="IMFSAMIStyle.GetStyleCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetStyleCount([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IMFSAMIStyle*, uint*, int> )(lpVtbl[3]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), pdwCount);
    }

    /// <include file='IMFSAMIStyle.xml' path='doc/member[@name="IMFSAMIStyle.GetStyles"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStyles(PROPVARIANT* pPropVarStyleArray)
    {
        return ((delegate* unmanaged<IMFSAMIStyle*, PROPVARIANT*, int> )(lpVtbl[4]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), pPropVarStyleArray);
    }

    /// <include file='IMFSAMIStyle.xml' path='doc/member[@name="IMFSAMIStyle.SetSelectedStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetSelectedStyle([NativeTypeName("LPCWSTR")] ushort* pwszStyle)
    {
        return ((delegate* unmanaged<IMFSAMIStyle*, ushort*, int> )(lpVtbl[5]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), pwszStyle);
    }

    /// <include file='IMFSAMIStyle.xml' path='doc/member[@name="IMFSAMIStyle.GetSelectedStyle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSelectedStyle([NativeTypeName("LPWSTR *")] ushort** ppwszStyle)
    {
        return ((delegate* unmanaged<IMFSAMIStyle*, ushort**, int> )(lpVtbl[6]))((IMFSAMIStyle*)Unsafe.AsPointer(ref this), ppwszStyle);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetStyleCount([NativeTypeName("DWORD *")] uint* pdwCount);
        [VtblIndex(4)]
        HRESULT GetStyles(PROPVARIANT* pPropVarStyleArray);
        [VtblIndex(5)]
        HRESULT SetSelectedStyle([NativeTypeName("LPCWSTR")] ushort* pwszStyle);
        [VtblIndex(6)]
        HRESULT GetSelectedStyle([NativeTypeName("LPWSTR *")] ushort** ppwszStyle);
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
        public delegate* unmanaged<TSelf*, uint*, int> GetStyleCount;
        [NativeTypeName("HRESULT (PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, int> GetStyles;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetSelectedStyle;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetSelectedStyle;
    }
}