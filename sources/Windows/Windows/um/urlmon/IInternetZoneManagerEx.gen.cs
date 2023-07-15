// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IInternetZoneManagerEx.xml' path='doc/member[@name="IInternetZoneManagerEx"]/*'/>
[Guid("A4C23339-8E06-431E-9BF4-7E711C085648")]
[NativeTypeName("struct IInternetZoneManagerEx : IInternetZoneManager")]
[NativeInheritance("IInternetZoneManager")]
public unsafe partial struct IInternetZoneManagerEx : IInternetZoneManagerEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetZoneManagerEx));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, Guid*, void**, int> )(lpVtbl[0]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint> )(lpVtbl[1]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint> )(lpVtbl[2]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInternetZoneManager.GetZoneAttributes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, ZONEATTRIBUTES* pZoneAttributes)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint, ZONEATTRIBUTES*, int> )(lpVtbl[3]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
    }

    /// <inheritdoc cref = "IInternetZoneManager.SetZoneAttributes"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetZoneAttributes([NativeTypeName("DWORD")] uint dwZone, ZONEATTRIBUTES* pZoneAttributes)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint, ZONEATTRIBUTES*, int> )(lpVtbl[4]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, pZoneAttributes);
    }

    /// <inheritdoc cref = "IInternetZoneManager.GetZoneCustomPolicy"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, byte** ppPolicy, [NativeTypeName("DWORD *")] uint* pcbPolicy, URLZONEREG urlZoneReg)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint, Guid*, byte**, uint*, URLZONEREG, int> )(lpVtbl[5]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, guidKey, ppPolicy, pcbPolicy, urlZoneReg);
    }

    /// <inheritdoc cref = "IInternetZoneManager.SetZoneCustomPolicy"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetZoneCustomPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("const GUID &")] Guid* guidKey, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint, Guid*, byte*, uint, URLZONEREG, int> )(lpVtbl[6]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, guidKey, pPolicy, cbPolicy, urlZoneReg);
    }

    /// <inheritdoc cref = "IInternetZoneManager.GetZoneActionPolicy"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint, uint, byte*, uint, URLZONEREG, int> )(lpVtbl[7]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
    }

    /// <inheritdoc cref = "IInternetZoneManager.SetZoneActionPolicy"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetZoneActionPolicy([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint, uint, byte*, uint, URLZONEREG, int> )(lpVtbl[8]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg);
    }

    /// <inheritdoc cref = "IInternetZoneManager.PromptAction"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT PromptAction([NativeTypeName("DWORD")] uint dwAction, HWND hwndParent, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPCWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint dwPromptFlags)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint, HWND, ushort*, ushort*, uint, int> )(lpVtbl[9]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwAction, hwndParent, pwszUrl, pwszText, dwPromptFlags);
    }

    /// <inheritdoc cref = "IInternetZoneManager.LogAction"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LogAction([NativeTypeName("DWORD")] uint dwAction, [NativeTypeName("LPCWSTR")] ushort* pwszUrl, [NativeTypeName("LPCWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint dwLogFlags)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint, ushort*, ushort*, uint, int> )(lpVtbl[10]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwAction, pwszUrl, pwszText, dwLogFlags);
    }

    /// <inheritdoc cref = "IInternetZoneManager.CreateZoneEnumerator"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateZoneEnumerator([NativeTypeName("DWORD *")] uint* pdwEnum, [NativeTypeName("DWORD *")] uint* pdwCount, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint*, uint*, uint, int> )(lpVtbl[11]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), pdwEnum, pdwCount, dwFlags);
    }

    /// <inheritdoc cref = "IInternetZoneManager.GetZoneAt"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetZoneAt([NativeTypeName("DWORD")] uint dwEnum, [NativeTypeName("DWORD")] uint dwIndex, [NativeTypeName("DWORD *")] uint* pdwZone)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint, uint, uint*, int> )(lpVtbl[12]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwEnum, dwIndex, pdwZone);
    }

    /// <inheritdoc cref = "IInternetZoneManager.DestroyZoneEnumerator"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DestroyZoneEnumerator([NativeTypeName("DWORD")] uint dwEnum)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint, int> )(lpVtbl[13]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwEnum);
    }

    /// <inheritdoc cref = "IInternetZoneManager.CopyTemplatePoliciesToZone"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CopyTemplatePoliciesToZone([NativeTypeName("DWORD")] uint dwTemplate, [NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint, uint, uint, int> )(lpVtbl[14]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwTemplate, dwZone, dwReserved);
    }

    /// <include file='IInternetZoneManagerEx.xml' path='doc/member[@name="IInternetZoneManagerEx.GetZoneActionPolicyEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint, uint, byte*, uint, URLZONEREG, uint, int> )(lpVtbl[15]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg, dwFlags);
    }

    /// <include file='IInternetZoneManagerEx.xml' path='doc/member[@name="IInternetZoneManagerEx.SetZoneActionPolicyEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IInternetZoneManagerEx*, uint, uint, byte*, uint, URLZONEREG, uint, int> )(lpVtbl[16]))((IInternetZoneManagerEx*)Unsafe.AsPointer(ref this), dwZone, dwAction, pPolicy, cbPolicy, urlZoneReg, dwFlags);
    }

    public interface Interface : IInternetZoneManager.Interface
    {
        [VtblIndex(15)]
        HRESULT GetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags);
        [VtblIndex(16)]
        HRESULT SetZoneActionPolicyEx([NativeTypeName("DWORD")] uint dwZone, [NativeTypeName("DWORD")] uint dwAction, byte* pPolicy, [NativeTypeName("DWORD")] uint cbPolicy, URLZONEREG urlZoneReg, [NativeTypeName("DWORD")] uint dwFlags);
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
        [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ZONEATTRIBUTES*, int> GetZoneAttributes;
        [NativeTypeName("HRESULT (DWORD, ZONEATTRIBUTES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ZONEATTRIBUTES*, int> SetZoneAttributes;
        [NativeTypeName("HRESULT (DWORD, const GUID &, BYTE **, DWORD *, URLZONEREG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, byte**, uint*, URLZONEREG, int> GetZoneCustomPolicy;
        [NativeTypeName("HRESULT (DWORD, const GUID &, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, byte*, uint, URLZONEREG, int> SetZoneCustomPolicy;
        [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, uint, URLZONEREG, int> GetZoneActionPolicy;
        [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, uint, URLZONEREG, int> SetZoneActionPolicy;
        [NativeTypeName("HRESULT (DWORD, HWND, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HWND, ushort*, ushort*, uint, int> PromptAction;
        [NativeTypeName("HRESULT (DWORD, LPCWSTR, LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, ushort*, uint, int> LogAction;
        [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, uint, int> CreateZoneEnumerator;
        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint*, int> GetZoneAt;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> DestroyZoneEnumerator;
        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, int> CopyTemplatePoliciesToZone;
        [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, uint, URLZONEREG, uint, int> GetZoneActionPolicyEx;
        [NativeTypeName("HRESULT (DWORD, DWORD, BYTE *, DWORD, URLZONEREG, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, byte*, uint, URLZONEREG, uint, int> SetZoneActionPolicyEx;
    }
}