// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='INewWindowManager.xml' path='doc/member[@name="INewWindowManager"]/*' />
[Guid("D2BC4C84-3F72-4A52-A604-7BCBF3982CBB")]
[NativeTypeName("struct INewWindowManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INewWindowManager : INewWindowManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INewWindowManager));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INewWindowManager*, Guid*, void**, int>)(lpVtbl[0]))((INewWindowManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INewWindowManager*, uint>)(lpVtbl[1]))((INewWindowManager*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INewWindowManager*, uint>)(lpVtbl[2]))((INewWindowManager*)Unsafe.AsPointer(ref this));
    }

    /// <include file='INewWindowManager.xml' path='doc/member[@name="INewWindowManager.EvaluateNewWindow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EvaluateNewWindow([NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("LPCWSTR")] ushort* pszUrlContext, [NativeTypeName("LPCWSTR")] ushort* pszFeatures, BOOL fReplace, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwUserActionTime)
    {
        return ((delegate* unmanaged<INewWindowManager*, ushort*, ushort*, ushort*, ushort*, BOOL, uint, uint, int>)(lpVtbl[3]))((INewWindowManager*)Unsafe.AsPointer(ref this), pszUrl, pszName, pszUrlContext, pszFeatures, fReplace, dwFlags, dwUserActionTime);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EvaluateNewWindow([NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("LPCWSTR")] ushort* pszUrlContext, [NativeTypeName("LPCWSTR")] ushort* pszFeatures, BOOL fReplace, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwUserActionTime);
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

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, LPCWSTR, BOOL, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, ushort*, BOOL, uint, uint, int> EvaluateNewWindow;
    }
}
