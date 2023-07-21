// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAMCertifiedOutputProtection.xml' path='doc/member[@name="IAMCertifiedOutputProtection"]/*' />
[Guid("6FEDED3E-0FF1-4901-A2F1-43F7012C8515")]
[NativeTypeName("struct IAMCertifiedOutputProtection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMCertifiedOutputProtection : IAMCertifiedOutputProtection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMCertifiedOutputProtection));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMCertifiedOutputProtection*, Guid*, void**, int>)(lpVtbl[0]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMCertifiedOutputProtection*, uint>)(lpVtbl[1]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMCertifiedOutputProtection*, uint>)(lpVtbl[2]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAMCertifiedOutputProtection.xml' path='doc/member[@name="IAMCertifiedOutputProtection.KeyExchange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT KeyExchange(Guid* pRandom, byte** VarLenCertGH, [NativeTypeName("DWORD *")] uint* pdwLengthCertGH)
    {
        return ((delegate* unmanaged<IAMCertifiedOutputProtection*, Guid*, byte**, uint*, int>)(lpVtbl[3]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), pRandom, VarLenCertGH, pdwLengthCertGH);
    }

    /// <include file='IAMCertifiedOutputProtection.xml' path='doc/member[@name="IAMCertifiedOutputProtection.SessionSequenceStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SessionSequenceStart(AMCOPPSignature* pSig)
    {
        return ((delegate* unmanaged<IAMCertifiedOutputProtection*, AMCOPPSignature*, int>)(lpVtbl[4]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), pSig);
    }

    /// <include file='IAMCertifiedOutputProtection.xml' path='doc/member[@name="IAMCertifiedOutputProtection.ProtectionCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ProtectionCommand([NativeTypeName("const AMCOPPCommand *")] AMCOPPCommand* cmd)
    {
        return ((delegate* unmanaged<IAMCertifiedOutputProtection*, AMCOPPCommand*, int>)(lpVtbl[5]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), cmd);
    }

    /// <include file='IAMCertifiedOutputProtection.xml' path='doc/member[@name="IAMCertifiedOutputProtection.ProtectionStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ProtectionStatus([NativeTypeName("const AMCOPPStatusInput *")] AMCOPPStatusInput* pStatusInput, AMCOPPStatusOutput* pStatusOutput)
    {
        return ((delegate* unmanaged<IAMCertifiedOutputProtection*, AMCOPPStatusInput*, AMCOPPStatusOutput*, int>)(lpVtbl[6]))((IAMCertifiedOutputProtection*)Unsafe.AsPointer(ref this), pStatusInput, pStatusOutput);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT KeyExchange(Guid* pRandom, byte** VarLenCertGH, [NativeTypeName("DWORD *")] uint* pdwLengthCertGH);

        [VtblIndex(4)]
        HRESULT SessionSequenceStart(AMCOPPSignature* pSig);

        [VtblIndex(5)]
        HRESULT ProtectionCommand([NativeTypeName("const AMCOPPCommand *")] AMCOPPCommand* cmd);

        [VtblIndex(6)]
        HRESULT ProtectionStatus([NativeTypeName("const AMCOPPStatusInput *")] AMCOPPStatusInput* pStatusInput, AMCOPPStatusOutput* pStatusOutput);
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

        [NativeTypeName("HRESULT (GUID *, BYTE **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte**, uint*, int> KeyExchange;

        [NativeTypeName("HRESULT (AMCOPPSignature *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AMCOPPSignature*, int> SessionSequenceStart;

        [NativeTypeName("HRESULT (const AMCOPPCommand *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AMCOPPCommand*, int> ProtectionCommand;

        [NativeTypeName("HRESULT (const AMCOPPStatusInput *, AMCOPPStatusOutput *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AMCOPPStatusInput*, AMCOPPStatusOutput*, int> ProtectionStatus;
    }
}
