// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IUserAccountChangeCallback.xml' path='doc/member[@name="IUserAccountChangeCallback"]/*'/>
[Guid("A561E69A-B4B8-4113-91A5-64C6BCCA3430")]
[NativeTypeName("struct IUserAccountChangeCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUserAccountChangeCallback : IUserAccountChangeCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserAccountChangeCallback));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUserAccountChangeCallback*, Guid*, void**, int> )(lpVtbl[0]))((IUserAccountChangeCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IUserAccountChangeCallback*, uint> )(lpVtbl[1]))((IUserAccountChangeCallback*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserAccountChangeCallback*, uint> )(lpVtbl[2]))((IUserAccountChangeCallback*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IUserAccountChangeCallback.xml' path='doc/member[@name="IUserAccountChangeCallback.OnPictureChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnPictureChange([NativeTypeName("LPCWSTR")] ushort* pszUserName)
    {
        return ((delegate* unmanaged<IUserAccountChangeCallback*, ushort*, int> )(lpVtbl[3]))((IUserAccountChangeCallback*)Unsafe.AsPointer(ref this), pszUserName);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnPictureChange([NativeTypeName("LPCWSTR")] ushort* pszUserName);
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
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> OnPictureChange;
    }
}