// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IUniformResourceLocatorA.xml' path='doc/member[@name="IUniformResourceLocatorA"]/*' />
[Guid("FBF23B80-E3F0-101B-8488-00AA003E56F8")]
[NativeTypeName("struct IUniformResourceLocatorA : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUniformResourceLocatorA : IUniformResourceLocatorA.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUniformResourceLocatorA));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUniformResourceLocatorA*, Guid*, void**, int>)(lpVtbl[0]))((IUniformResourceLocatorA*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUniformResourceLocatorA*, uint>)(lpVtbl[1]))((IUniformResourceLocatorA*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUniformResourceLocatorA*, uint>)(lpVtbl[2]))((IUniformResourceLocatorA*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUniformResourceLocatorA.xml' path='doc/member[@name="IUniformResourceLocatorA.SetURL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetURL([NativeTypeName("LPCSTR")] sbyte* pcszURL, [NativeTypeName("DWORD")] uint dwInFlags)
    {
        return ((delegate* unmanaged<IUniformResourceLocatorA*, sbyte*, uint, int>)(lpVtbl[3]))((IUniformResourceLocatorA*)Unsafe.AsPointer(ref this), pcszURL, dwInFlags);
    }

    /// <include file='IUniformResourceLocatorA.xml' path='doc/member[@name="IUniformResourceLocatorA.GetURL"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetURL([NativeTypeName("LPSTR *")] sbyte** ppszURL)
    {
        return ((delegate* unmanaged<IUniformResourceLocatorA*, sbyte**, int>)(lpVtbl[4]))((IUniformResourceLocatorA*)Unsafe.AsPointer(ref this), ppszURL);
    }

    /// <include file='IUniformResourceLocatorA.xml' path='doc/member[@name="IUniformResourceLocatorA.InvokeCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InvokeCommand([NativeTypeName("PURLINVOKECOMMANDINFOA")] URLINVOKECOMMANDINFOA* purlici)
    {
        return ((delegate* unmanaged<IUniformResourceLocatorA*, URLINVOKECOMMANDINFOA*, int>)(lpVtbl[5]))((IUniformResourceLocatorA*)Unsafe.AsPointer(ref this), purlici);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetURL([NativeTypeName("LPCSTR")] sbyte* pcszURL, [NativeTypeName("DWORD")] uint dwInFlags);

        [VtblIndex(4)]
        HRESULT GetURL([NativeTypeName("LPSTR *")] sbyte** ppszURL);

        [VtblIndex(5)]
        HRESULT InvokeCommand([NativeTypeName("PURLINVOKECOMMANDINFOA")] URLINVOKECOMMANDINFOA* purlici);
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

        [NativeTypeName("HRESULT (LPCSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, uint, int> SetURL;

        [NativeTypeName("HRESULT (LPSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte**, int> GetURL;

        [NativeTypeName("HRESULT (PURLINVOKECOMMANDINFOA) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, URLINVOKECOMMANDINFOA*, int> InvokeCommand;
    }
}
