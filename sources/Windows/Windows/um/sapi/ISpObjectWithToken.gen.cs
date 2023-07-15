// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpObjectWithToken.xml' path='doc/member[@name="ISpObjectWithToken"]/*'/>
[Guid("5B559F40-E952-11D2-BB91-00C04F8EE6C0")]
[NativeTypeName("struct ISpObjectWithToken : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpObjectWithToken : ISpObjectWithToken.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpObjectWithToken));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpObjectWithToken*, Guid*, void**, int> )(lpVtbl[0]))((ISpObjectWithToken*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpObjectWithToken*, uint> )(lpVtbl[1]))((ISpObjectWithToken*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpObjectWithToken*, uint> )(lpVtbl[2]))((ISpObjectWithToken*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpObjectWithToken.xml' path='doc/member[@name="ISpObjectWithToken.SetObjectToken"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetObjectToken(ISpObjectToken* pToken)
    {
        return ((delegate* unmanaged<ISpObjectWithToken*, ISpObjectToken*, int> )(lpVtbl[3]))((ISpObjectWithToken*)Unsafe.AsPointer(ref this), pToken);
    }

    /// <include file='ISpObjectWithToken.xml' path='doc/member[@name="ISpObjectWithToken.GetObjectToken"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetObjectToken(ISpObjectToken** ppToken)
    {
        return ((delegate* unmanaged<ISpObjectWithToken*, ISpObjectToken**, int> )(lpVtbl[4]))((ISpObjectWithToken*)Unsafe.AsPointer(ref this), ppToken);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetObjectToken(ISpObjectToken* pToken);
        [VtblIndex(4)]
        HRESULT GetObjectToken(ISpObjectToken** ppToken);
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
        [NativeTypeName("HRESULT (ISpObjectToken *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpObjectToken*, int> SetObjectToken;
        [NativeTypeName("HRESULT (ISpObjectToken **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpObjectToken**, int> GetObjectToken;
    }
}