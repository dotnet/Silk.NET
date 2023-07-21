// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RestrictedErrorInfo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;

/// <include file='ILanguageExceptionTransform.xml' path='doc/member[@name="ILanguageExceptionTransform"]/*' />
[Guid("FEB5A271-A6CD-45CE-880A-696706BADC65")]
[NativeTypeName("struct ILanguageExceptionTransform : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.15063.0")]
public unsafe partial struct ILanguageExceptionTransform : ILanguageExceptionTransform.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILanguageExceptionTransform));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILanguageExceptionTransform*, Guid*, void**, int>)(lpVtbl[0]))((ILanguageExceptionTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ILanguageExceptionTransform*, uint>)(lpVtbl[1]))((ILanguageExceptionTransform*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILanguageExceptionTransform*, uint>)(lpVtbl[2]))((ILanguageExceptionTransform*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ILanguageExceptionTransform.xml' path='doc/member[@name="ILanguageExceptionTransform.GetTransformedRestrictedErrorInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTransformedRestrictedErrorInfo(IRestrictedErrorInfo** restrictedErrorInfo)
    {
        return ((delegate* unmanaged<ILanguageExceptionTransform*, IRestrictedErrorInfo**, int>)(lpVtbl[3]))((ILanguageExceptionTransform*)Unsafe.AsPointer(ref this), restrictedErrorInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetTransformedRestrictedErrorInfo(IRestrictedErrorInfo** restrictedErrorInfo);
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

        [NativeTypeName("HRESULT (IRestrictedErrorInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IRestrictedErrorInfo**, int> GetTransformedRestrictedErrorInfo;
    }
}
