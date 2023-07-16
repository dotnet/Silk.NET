// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IUniformResourceLocatorW.xml' path='doc/member[@name="IUniformResourceLocatorW"]/*'/>
[Guid("CABB0DA0-DA57-11CF-9974-0020AFD79762")]
[NativeTypeName("struct IUniformResourceLocatorW : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUniformResourceLocatorW : IUniformResourceLocatorW.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUniformResourceLocatorW));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUniformResourceLocatorW*, Guid*, void**, int> )(lpVtbl[0]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUniformResourceLocatorW*, uint> )(lpVtbl[1]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUniformResourceLocatorW*, uint> )(lpVtbl[2]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUniformResourceLocatorW.xml' path='doc/member[@name="IUniformResourceLocatorW.SetURL"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetURL([NativeTypeName("LPCWSTR")] ushort* pcszURL, [NativeTypeName("DWORD")] uint dwInFlags)
    {
        return ((delegate* unmanaged<IUniformResourceLocatorW*, ushort*, uint, int> )(lpVtbl[3]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this), pcszURL, dwInFlags);
    }

    /// <include file='IUniformResourceLocatorW.xml' path='doc/member[@name="IUniformResourceLocatorW.GetURL"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetURL([NativeTypeName("LPWSTR *")] ushort** ppszURL)
    {
        return ((delegate* unmanaged<IUniformResourceLocatorW*, ushort**, int> )(lpVtbl[4]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this), ppszURL);
    }

    /// <include file='IUniformResourceLocatorW.xml' path='doc/member[@name="IUniformResourceLocatorW.InvokeCommand"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InvokeCommand([NativeTypeName("PURLINVOKECOMMANDINFOW")] URLINVOKECOMMANDINFOW* purlici)
    {
        return ((delegate* unmanaged<IUniformResourceLocatorW*, URLINVOKECOMMANDINFOW*, int> )(lpVtbl[5]))((IUniformResourceLocatorW*)Unsafe.AsPointer(ref this), purlici);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetURL([NativeTypeName("LPCWSTR")] ushort* pcszURL, [NativeTypeName("DWORD")] uint dwInFlags);
        [VtblIndex(4)]
        HRESULT GetURL([NativeTypeName("LPWSTR *")] ushort** ppszURL);
        [VtblIndex(5)]
        HRESULT InvokeCommand([NativeTypeName("PURLINVOKECOMMANDINFOW")] URLINVOKECOMMANDINFOW* purlici);
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
        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> SetURL;
        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetURL;
        [NativeTypeName("HRESULT (PURLINVOKECOMMANDINFOW) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, URLINVOKECOMMANDINFOW*, int> InvokeCommand;
    }
}