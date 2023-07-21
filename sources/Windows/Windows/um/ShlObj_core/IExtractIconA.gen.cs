// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IExtractIconA.xml' path='doc/member[@name="IExtractIconA"]/*' />
[Guid("000214EB-0000-0000-C000-000000000046")]
[NativeTypeName("struct IExtractIconA : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExtractIconA : IExtractIconA.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExtractIconA));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExtractIconA*, Guid*, void**, int>)(lpVtbl[0]))((IExtractIconA*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IExtractIconA*, uint>)(lpVtbl[1]))((IExtractIconA*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExtractIconA*, uint>)(lpVtbl[2]))((IExtractIconA*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IExtractIconA.xml' path='doc/member[@name="IExtractIconA.GetIconLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIconLocation(uint uFlags, [NativeTypeName("PSTR")] sbyte* pszIconFile, uint cchMax, int* piIndex, uint* pwFlags)
    {
        return ((delegate* unmanaged<IExtractIconA*, uint, sbyte*, uint, int*, uint*, int>)(lpVtbl[3]))((IExtractIconA*)Unsafe.AsPointer(ref this), uFlags, pszIconFile, cchMax, piIndex, pwFlags);
    }

    /// <include file='IExtractIconA.xml' path='doc/member[@name="IExtractIconA.Extract"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Extract([NativeTypeName("PCSTR")] sbyte* pszFile, uint nIconIndex, HICON* phiconLarge, HICON* phiconSmall, uint nIconSize)
    {
        return ((delegate* unmanaged<IExtractIconA*, sbyte*, uint, HICON*, HICON*, uint, int>)(lpVtbl[4]))((IExtractIconA*)Unsafe.AsPointer(ref this), pszFile, nIconIndex, phiconLarge, phiconSmall, nIconSize);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetIconLocation(uint uFlags, [NativeTypeName("PSTR")] sbyte* pszIconFile, uint cchMax, int* piIndex, uint* pwFlags);

        [VtblIndex(4)]
        HRESULT Extract([NativeTypeName("PCSTR")] sbyte* pszFile, uint nIconIndex, HICON* phiconLarge, HICON* phiconSmall, uint nIconSize);
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

        [NativeTypeName("HRESULT (UINT, PSTR, UINT, int *, UINT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, sbyte*, uint, int*, uint*, int> GetIconLocation;

        [NativeTypeName("HRESULT (PCSTR, UINT, HICON *, HICON *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, uint, HICON*, HICON*, uint, int> Extract;
    }
}
