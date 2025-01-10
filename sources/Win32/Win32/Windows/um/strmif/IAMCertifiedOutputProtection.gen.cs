// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6FEDED3E-0FF1-4901-A2F1-43F7012C8515")]
[NativeTypeName("struct IAMCertifiedOutputProtection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMCertifiedOutputProtection
    : IAMCertifiedOutputProtection.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMCertifiedOutputProtection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAMCertifiedOutputProtection, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMCertifiedOutputProtection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMCertifiedOutputProtection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT KeyExchange(
        Guid* pRandom,
        byte** VarLenCertGH,
        [NativeTypeName("DWORD *")] uint* pdwLengthCertGH
    )
    {
        return (
            (delegate* unmanaged<IAMCertifiedOutputProtection, Guid*, byte**, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pRandom, VarLenCertGH, pdwLengthCertGH);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SessionSequenceStart(AMCOPPSignature* pSig)
    {
        return (
            (delegate* unmanaged<IAMCertifiedOutputProtection, AMCOPPSignature*, int>)((*lpVtbl)[4])
        )(this, pSig);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ProtectionCommand([NativeTypeName("const AMCOPPCommand *")] AMCOPPCommand* cmd)
    {
        return (
            (delegate* unmanaged<IAMCertifiedOutputProtection, AMCOPPCommand*, int>)((*lpVtbl)[5])
        )(this, cmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ProtectionStatus(
        [NativeTypeName("const AMCOPPStatusInput *")] AMCOPPStatusInput* pStatusInput,
        AMCOPPStatusOutput* pStatusOutput
    )
    {
        return (
            (delegate* unmanaged<
                IAMCertifiedOutputProtection,
                AMCOPPStatusInput*,
                AMCOPPStatusOutput*,
                int>)((*lpVtbl)[6])
        )(this, pStatusInput, pStatusOutput);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT KeyExchange(
            Guid* pRandom,
            byte** VarLenCertGH,
            [NativeTypeName("DWORD *")] uint* pdwLengthCertGH
        );

        [VtblIndex(4)]
        HRESULT SessionSequenceStart(AMCOPPSignature* pSig);

        [VtblIndex(5)]
        HRESULT ProtectionCommand([NativeTypeName("const AMCOPPCommand *")] AMCOPPCommand* cmd);

        [VtblIndex(6)]
        HRESULT ProtectionStatus(
            [NativeTypeName("const AMCOPPStatusInput *")] AMCOPPStatusInput* pStatusInput,
            AMCOPPStatusOutput* pStatusOutput
        );
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

        [NativeTypeName(
            "HRESULT (const AMCOPPStatusInput *, AMCOPPStatusOutput *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            AMCOPPStatusInput*,
            AMCOPPStatusOutput*,
            int> ProtectionStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMCertifiedOutputProtection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMCertifiedOutputProtection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMCertifiedOutputProtection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMCertifiedOutputProtection(Silk.NET.Windows.IUnknown value)
    {
        return new IAMCertifiedOutputProtection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMCertifiedOutputProtection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMCertifiedOutputProtection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMCertifiedOutputProtection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
