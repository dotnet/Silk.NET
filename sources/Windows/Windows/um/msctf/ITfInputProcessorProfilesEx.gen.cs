// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='ITfInputProcessorProfilesEx.xml' path='doc/member[@name="ITfInputProcessorProfilesEx"]/*' />
[Guid("892F230F-FE00-4A41-A98E-FCD6DE0D35EF")]
[NativeTypeName("struct ITfInputProcessorProfilesEx : ITfInputProcessorProfiles")]
[NativeInheritance("ITfInputProcessorProfiles")]
public unsafe partial struct ITfInputProcessorProfilesEx : ITfInputProcessorProfilesEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfInputProcessorProfilesEx));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, void**, int>)(lpVtbl[0]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, uint>)(lpVtbl[1]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, uint>)(lpVtbl[2]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.Register" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Register([NativeTypeName("const IID &")] Guid* rclsid)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, int>)(lpVtbl[3]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.Unregister" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unregister([NativeTypeName("const IID &")] Guid* rclsid)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, int>)(lpVtbl[4]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.AddLanguageProfile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("const WCHAR *")] ushort* pchDesc, [NativeTypeName("ULONG")] uint cchDesc, [NativeTypeName("const WCHAR *")] ushort* pchIconFile, [NativeTypeName("ULONG")] uint cchFile, [NativeTypeName("ULONG")] uint uIconIndex)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, ushort*, uint, ushort*, uint, uint, int>)(lpVtbl[5]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, pchDesc, cchDesc, pchIconFile, cchFile, uIconIndex);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.RemoveLanguageProfile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, int>)(lpVtbl[6]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.EnumInputProcessorInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumInputProcessorInfo(IEnumGUID** ppEnum)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, IEnumGUID**, int>)(lpVtbl[7]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), ppEnum);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.GetDefaultLanguageProfile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetDefaultLanguageProfile([NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* catid, [NativeTypeName("CLSID *")] Guid* pclsid, Guid* pguidProfile)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, ushort, Guid*, Guid*, Guid*, int>)(lpVtbl[8]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), langid, catid, pclsid, pguidProfile);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.SetDefaultLanguageProfile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetDefaultLanguageProfile([NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const GUID &")] Guid* guidProfiles)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, ushort, Guid*, Guid*, int>)(lpVtbl[9]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), langid, rclsid, guidProfiles);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.ActivateLanguageProfile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ActivateLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfiles)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, int>)(lpVtbl[10]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfiles);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.GetActiveLanguageProfile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetActiveLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID *")] ushort* plangid, Guid* pguidProfile)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort*, Guid*, int>)(lpVtbl[11]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, plangid, pguidProfile);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.GetLanguageProfileDescription" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetLanguageProfileDescription([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("BSTR *")] ushort** pbstrProfile)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, ushort**, int>)(lpVtbl[12]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, pbstrProfile);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.GetCurrentLanguage" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetCurrentLanguage([NativeTypeName("LANGID *")] ushort* plangid)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, ushort*, int>)(lpVtbl[13]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), plangid);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.ChangeCurrentLanguage" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT ChangeCurrentLanguage([NativeTypeName("LANGID")] ushort langid)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, ushort, int>)(lpVtbl[14]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), langid);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.GetLanguageList" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetLanguageList([NativeTypeName("LANGID **")] ushort** ppLangId, [NativeTypeName("ULONG *")] uint* pulCount)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, ushort**, uint*, int>)(lpVtbl[15]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), ppLangId, pulCount);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.EnumLanguageProfiles" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT EnumLanguageProfiles([NativeTypeName("LANGID")] ushort langid, IEnumTfLanguageProfiles** ppEnum)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, ushort, IEnumTfLanguageProfiles**, int>)(lpVtbl[16]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), langid, ppEnum);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.EnableLanguageProfile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT EnableLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, BOOL fEnable)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, BOOL, int>)(lpVtbl[17]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, fEnable);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.IsEnabledLanguageProfile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT IsEnabledLanguageProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, BOOL* pfEnable)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, BOOL*, int>)(lpVtbl[18]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, pfEnable);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.EnableLanguageProfileByDefault" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT EnableLanguageProfileByDefault([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, BOOL fEnable)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, BOOL, int>)(lpVtbl[19]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, fEnable);
    }

    /// <inheritdoc cref="ITfInputProcessorProfiles.SubstituteKeyboardLayout" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SubstituteKeyboardLayout([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, HKL hKL)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, HKL, int>)(lpVtbl[20]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, hKL);
    }

    /// <include file='ITfInputProcessorProfilesEx.xml' path='doc/member[@name="ITfInputProcessorProfilesEx.SetLanguageProfileDisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetLanguageProfileDisplayName([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("const WCHAR *")] ushort* pchFile, [NativeTypeName("ULONG")] uint cchFile, [NativeTypeName("ULONG")] uint uResId)
    {
        return ((delegate* unmanaged<ITfInputProcessorProfilesEx*, Guid*, ushort, Guid*, ushort*, uint, uint, int>)(lpVtbl[21]))((ITfInputProcessorProfilesEx*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, pchFile, cchFile, uResId);
    }

    public interface Interface : ITfInputProcessorProfiles.Interface
    {
        [VtblIndex(21)]
        HRESULT SetLanguageProfileDisplayName([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("const WCHAR *")] ushort* pchFile, [NativeTypeName("ULONG")] uint cchFile, [NativeTypeName("ULONG")] uint uResId);
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

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> Register;

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> Unregister;

        [NativeTypeName("HRESULT (const IID &, LANGID, const GUID &, const WCHAR *, ULONG, const WCHAR *, ULONG, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort, Guid*, ushort*, uint, ushort*, uint, uint, int> AddLanguageProfile;

        [NativeTypeName("HRESULT (const IID &, LANGID, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort, Guid*, int> RemoveLanguageProfile;

        [NativeTypeName("HRESULT (IEnumGUID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumGUID**, int> EnumInputProcessorInfo;

        [NativeTypeName("HRESULT (LANGID, const GUID &, CLSID *, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, Guid*, Guid*, Guid*, int> GetDefaultLanguageProfile;

        [NativeTypeName("HRESULT (LANGID, const IID &, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, Guid*, Guid*, int> SetDefaultLanguageProfile;

        [NativeTypeName("HRESULT (const IID &, LANGID, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort, Guid*, int> ActivateLanguageProfile;

        [NativeTypeName("HRESULT (const IID &, LANGID *, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, Guid*, int> GetActiveLanguageProfile;

        [NativeTypeName("HRESULT (const IID &, LANGID, const GUID &, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort, Guid*, ushort**, int> GetLanguageProfileDescription;

        [NativeTypeName("HRESULT (LANGID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetCurrentLanguage;

        [NativeTypeName("HRESULT (LANGID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> ChangeCurrentLanguage;

        [NativeTypeName("HRESULT (LANGID **, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, uint*, int> GetLanguageList;

        [NativeTypeName("HRESULT (LANGID, IEnumTfLanguageProfiles **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, IEnumTfLanguageProfiles**, int> EnumLanguageProfiles;

        [NativeTypeName("HRESULT (const IID &, LANGID, const GUID &, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort, Guid*, BOOL, int> EnableLanguageProfile;

        [NativeTypeName("HRESULT (const IID &, LANGID, const GUID &, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort, Guid*, BOOL*, int> IsEnabledLanguageProfile;

        [NativeTypeName("HRESULT (const IID &, LANGID, const GUID &, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort, Guid*, BOOL, int> EnableLanguageProfileByDefault;

        [NativeTypeName("HRESULT (const IID &, LANGID, const GUID &, HKL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort, Guid*, HKL, int> SubstituteKeyboardLayout;

        [NativeTypeName("HRESULT (const IID &, LANGID, const GUID &, const WCHAR *, ULONG, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort, Guid*, ushort*, uint, uint, int> SetLanguageProfileDisplayName;
    }
}
