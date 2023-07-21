// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IXMLError.xml' path='doc/member[@name="IXMLError"]/*' />
[Guid("948C5AD3-C58D-11D0-9C0B-00C04FC99C8E")]
[NativeTypeName("struct IXMLError : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IXMLError : IXMLError.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLError));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLError*, Guid*, void**, int>)(lpVtbl[0]))((IXMLError*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXMLError*, uint>)(lpVtbl[1]))((IXMLError*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLError*, uint>)(lpVtbl[2]))((IXMLError*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXMLError.xml' path='doc/member[@name="IXMLError.GetErrorInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetErrorInfo(XML_ERROR* pErrorReturn)
    {
        return ((delegate* unmanaged<IXMLError*, XML_ERROR*, int>)(lpVtbl[3]))((IXMLError*)Unsafe.AsPointer(ref this), pErrorReturn);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetErrorInfo(XML_ERROR* pErrorReturn);
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

        [NativeTypeName("HRESULT (XML_ERROR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, XML_ERROR*, int> GetErrorInfo;
    }
}
