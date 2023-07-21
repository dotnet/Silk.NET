// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IXMLGenericParse.xml' path='doc/member[@name="IXMLGenericParse"]/*' />
[Guid("E4E23071-4D07-11D2-AE76-0080C73BC199")]
[NativeTypeName("struct IXMLGenericParse : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXMLGenericParse : IXMLGenericParse.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLGenericParse));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLGenericParse*, Guid*, void**, int>)(lpVtbl[0]))((IXMLGenericParse*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXMLGenericParse*, uint>)(lpVtbl[1]))((IXMLGenericParse*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLGenericParse*, uint>)(lpVtbl[2]))((IXMLGenericParse*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXMLGenericParse.xml' path='doc/member[@name="IXMLGenericParse.SetGenericParse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetGenericParse([NativeTypeName("VARIANT_BOOL")] short fDoGeneric)
    {
        return ((delegate* unmanaged<IXMLGenericParse*, short, int>)(lpVtbl[3]))((IXMLGenericParse*)Unsafe.AsPointer(ref this), fDoGeneric);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetGenericParse([NativeTypeName("VARIANT_BOOL")] short fDoGeneric);
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

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> SetGenericParse;
    }
}
