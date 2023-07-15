// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IProvideClassInfo2.xml' path='doc/member[@name="IProvideClassInfo2"]/*'/>
[Guid("A6BC3AC0-DBAA-11CE-9DE3-00AA004BB851")]
[NativeTypeName("struct IProvideClassInfo2 : IProvideClassInfo")]
[NativeInheritance("IProvideClassInfo")]
public unsafe partial struct IProvideClassInfo2 : IProvideClassInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProvideClassInfo2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProvideClassInfo2*, Guid*, void**, int> )(lpVtbl[0]))((IProvideClassInfo2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProvideClassInfo2*, uint> )(lpVtbl[1]))((IProvideClassInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProvideClassInfo2*, uint> )(lpVtbl[2]))((IProvideClassInfo2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IProvideClassInfo.GetClassInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassInfo(ITypeInfo** ppTI)
    {
        return ((delegate* unmanaged<IProvideClassInfo2*, ITypeInfo**, int> )(lpVtbl[3]))((IProvideClassInfo2*)Unsafe.AsPointer(ref this), ppTI);
    }

    /// <include file='IProvideClassInfo2.xml' path='doc/member[@name="IProvideClassInfo2.GetGUID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGUID([NativeTypeName("DWORD")] uint dwGuidKind, Guid* pGUID)
    {
        return ((delegate* unmanaged<IProvideClassInfo2*, uint, Guid*, int> )(lpVtbl[4]))((IProvideClassInfo2*)Unsafe.AsPointer(ref this), dwGuidKind, pGUID);
    }

    public interface Interface : IProvideClassInfo.Interface
    {
        [VtblIndex(4)]
        HRESULT GetGUID([NativeTypeName("DWORD")] uint dwGuidKind, Guid* pGUID);
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
        [NativeTypeName("HRESULT (ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITypeInfo**, int> GetClassInfo;
        [NativeTypeName("HRESULT (DWORD, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, int> GetGUID;
    }
}