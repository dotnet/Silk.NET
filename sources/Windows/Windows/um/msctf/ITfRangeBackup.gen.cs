// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfRangeBackup.xml' path='doc/member[@name="ITfRangeBackup"]/*'/>
[Guid("463A506D-6992-49D2-9B88-93D55E70BB16")]
[NativeTypeName("struct ITfRangeBackup : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfRangeBackup : ITfRangeBackup.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfRangeBackup));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfRangeBackup*, Guid*, void**, int> )(lpVtbl[0]))((ITfRangeBackup*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfRangeBackup*, uint> )(lpVtbl[1]))((ITfRangeBackup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfRangeBackup*, uint> )(lpVtbl[2]))((ITfRangeBackup*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfRangeBackup.xml' path='doc/member[@name="ITfRangeBackup.Restore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Restore([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange)
    {
        return ((delegate* unmanaged<ITfRangeBackup*, uint, ITfRange*, int> )(lpVtbl[3]))((ITfRangeBackup*)Unsafe.AsPointer(ref this), ec, pRange);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Restore([NativeTypeName("TfEditCookie")] uint ec, ITfRange* pRange);
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
        [NativeTypeName("HRESULT (TfEditCookie, ITfRange *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfRange*, int> Restore;
    }
}