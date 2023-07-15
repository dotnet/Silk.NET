// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IURLSearchHook2.xml' path='doc/member[@name="IURLSearchHook2"]/*'/>
[Guid("5EE44DA4-6D32-46E3-86BC-07540DEDD0E0")]
[NativeTypeName("struct IURLSearchHook2 : IURLSearchHook")]
[NativeInheritance("IURLSearchHook")]
public unsafe partial struct IURLSearchHook2 : IURLSearchHook2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IURLSearchHook2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IURLSearchHook2*, Guid*, void**, int> )(lpVtbl[0]))((IURLSearchHook2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IURLSearchHook2*, uint> )(lpVtbl[1]))((IURLSearchHook2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IURLSearchHook2*, uint> )(lpVtbl[2]))((IURLSearchHook2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IURLSearchHook.Translate"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Translate([NativeTypeName("PWSTR")] ushort* pwszSearchURL, [NativeTypeName("DWORD")] uint cchBufferSize)
    {
        return ((delegate* unmanaged<IURLSearchHook2*, ushort*, uint, int> )(lpVtbl[3]))((IURLSearchHook2*)Unsafe.AsPointer(ref this), pwszSearchURL, cchBufferSize);
    }

    /// <include file='IURLSearchHook2.xml' path='doc/member[@name="IURLSearchHook2.TranslateWithSearchContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT TranslateWithSearchContext([NativeTypeName("PWSTR")] ushort* pwszSearchURL, [NativeTypeName("DWORD")] uint cchBufferSize, ISearchContext* pSearchContext)
    {
        return ((delegate* unmanaged<IURLSearchHook2*, ushort*, uint, ISearchContext*, int> )(lpVtbl[4]))((IURLSearchHook2*)Unsafe.AsPointer(ref this), pwszSearchURL, cchBufferSize, pSearchContext);
    }

    public interface Interface : IURLSearchHook.Interface
    {
        [VtblIndex(4)]
        HRESULT TranslateWithSearchContext([NativeTypeName("PWSTR")] ushort* pwszSearchURL, [NativeTypeName("DWORD")] uint cchBufferSize, ISearchContext* pSearchContext);
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
        [NativeTypeName("HRESULT (PWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> Translate;
        [NativeTypeName("HRESULT (PWSTR, DWORD, ISearchContext *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ISearchContext*, int> TranslateWithSearchContext;
    }
}