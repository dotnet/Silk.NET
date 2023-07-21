// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfIntegratableCandidateListUIElement.xml' path='doc/member[@name="ITfIntegratableCandidateListUIElement"]/*' />
[Guid("C7A6F54F-B180-416F-B2BF-7BF2E4683D7B")]
[NativeTypeName("struct ITfIntegratableCandidateListUIElement : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ITfIntegratableCandidateListUIElement : ITfIntegratableCandidateListUIElement.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfIntegratableCandidateListUIElement));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, Guid*, void**, int>)(lpVtbl[0]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, uint>)(lpVtbl[1]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, uint>)(lpVtbl[2]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfIntegratableCandidateListUIElement.xml' path='doc/member[@name="ITfIntegratableCandidateListUIElement.SetIntegrationStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetIntegrationStyle(Guid guidIntegrationStyle)
    {
        return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, Guid, int>)(lpVtbl[3]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this), guidIntegrationStyle);
    }

    /// <include file='ITfIntegratableCandidateListUIElement.xml' path='doc/member[@name="ITfIntegratableCandidateListUIElement.GetSelectionStyle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSelectionStyle(TfIntegratableCandidateListSelectionStyle* ptfSelectionStyle)
    {
        return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, TfIntegratableCandidateListSelectionStyle*, int>)(lpVtbl[4]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this), ptfSelectionStyle);
    }

    /// <include file='ITfIntegratableCandidateListUIElement.xml' path='doc/member[@name="ITfIntegratableCandidateListUIElement.OnKeyDown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnKeyDown(WPARAM wParam, LPARAM lParam, BOOL* pfEaten)
    {
        return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, WPARAM, LPARAM, BOOL*, int>)(lpVtbl[5]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this), wParam, lParam, pfEaten);
    }

    /// <include file='ITfIntegratableCandidateListUIElement.xml' path='doc/member[@name="ITfIntegratableCandidateListUIElement.ShowCandidateNumbers"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ShowCandidateNumbers(BOOL* pfShow)
    {
        return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, BOOL*, int>)(lpVtbl[6]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this), pfShow);
    }

    /// <include file='ITfIntegratableCandidateListUIElement.xml' path='doc/member[@name="ITfIntegratableCandidateListUIElement.FinalizeExactCompositionString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT FinalizeExactCompositionString()
    {
        return ((delegate* unmanaged<ITfIntegratableCandidateListUIElement*, int>)(lpVtbl[7]))((ITfIntegratableCandidateListUIElement*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetIntegrationStyle(Guid guidIntegrationStyle);

        [VtblIndex(4)]
        HRESULT GetSelectionStyle(TfIntegratableCandidateListSelectionStyle* ptfSelectionStyle);

        [VtblIndex(5)]
        HRESULT OnKeyDown(WPARAM wParam, LPARAM lParam, BOOL* pfEaten);

        [VtblIndex(6)]
        HRESULT ShowCandidateNumbers(BOOL* pfShow);

        [VtblIndex(7)]
        HRESULT FinalizeExactCompositionString();
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

        [NativeTypeName("HRESULT (GUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> SetIntegrationStyle;

        [NativeTypeName("HRESULT (TfIntegratableCandidateListSelectionStyle *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TfIntegratableCandidateListSelectionStyle*, int> GetSelectionStyle;

        [NativeTypeName("HRESULT (WPARAM, LPARAM, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WPARAM, LPARAM, BOOL*, int> OnKeyDown;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> ShowCandidateNumbers;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> FinalizeExactCompositionString;
    }
}
