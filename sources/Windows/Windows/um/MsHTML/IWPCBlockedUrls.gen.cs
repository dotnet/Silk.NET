// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IWPCBlockedUrls.xml' path='doc/member[@name="IWPCBlockedUrls"]/*'/>
[Guid("30510413-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IWPCBlockedUrls : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWPCBlockedUrls : IWPCBlockedUrls.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWPCBlockedUrls));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWPCBlockedUrls*, Guid*, void**, int> )(lpVtbl[0]))((IWPCBlockedUrls*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWPCBlockedUrls*, uint> )(lpVtbl[1]))((IWPCBlockedUrls*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWPCBlockedUrls*, uint> )(lpVtbl[2]))((IWPCBlockedUrls*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWPCBlockedUrls.xml' path='doc/member[@name="IWPCBlockedUrls.GetCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount([NativeTypeName("DWORD *")] uint* pdwCount)
    {
        return ((delegate* unmanaged<IWPCBlockedUrls*, uint*, int> )(lpVtbl[3]))((IWPCBlockedUrls*)Unsafe.AsPointer(ref this), pdwCount);
    }

    /// <include file='IWPCBlockedUrls.xml' path='doc/member[@name="IWPCBlockedUrls.GetUrl"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetUrl([NativeTypeName("DWORD")] uint dwIdx, [NativeTypeName("BSTR *")] ushort** pbstrUrl)
    {
        return ((delegate* unmanaged<IWPCBlockedUrls*, uint, ushort**, int> )(lpVtbl[4]))((IWPCBlockedUrls*)Unsafe.AsPointer(ref this), dwIdx, pbstrUrl);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount([NativeTypeName("DWORD *")] uint* pdwCount);
        [VtblIndex(4)]
        HRESULT GetUrl([NativeTypeName("DWORD")] uint dwIdx, [NativeTypeName("BSTR *")] ushort** pbstrUrl);
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
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;
        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetUrl;
    }
}