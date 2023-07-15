// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IWbemStatusCodeText.xml' path='doc/member[@name="IWbemStatusCodeText"]/*'/>
[Guid("EB87E1BC-3233-11D2-AEC9-00C04FB68820")]
[NativeTypeName("struct IWbemStatusCodeText : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemStatusCodeText : IWbemStatusCodeText.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemStatusCodeText));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemStatusCodeText*, Guid*, void**, int> )(lpVtbl[0]))((IWbemStatusCodeText*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWbemStatusCodeText*, uint> )(lpVtbl[1]))((IWbemStatusCodeText*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemStatusCodeText*, uint> )(lpVtbl[2]))((IWbemStatusCodeText*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWbemStatusCodeText.xml' path='doc/member[@name="IWbemStatusCodeText.GetErrorCodeText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetErrorCodeText(HRESULT hRes, [NativeTypeName("LCID")] uint LocaleId, [NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** MessageText)
    {
        return ((delegate* unmanaged<IWbemStatusCodeText*, HRESULT, uint, int, ushort**, int> )(lpVtbl[3]))((IWbemStatusCodeText*)Unsafe.AsPointer(ref this), hRes, LocaleId, lFlags, MessageText);
    }

    /// <include file='IWbemStatusCodeText.xml' path='doc/member[@name="IWbemStatusCodeText.GetFacilityCodeText"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFacilityCodeText(HRESULT hRes, [NativeTypeName("LCID")] uint LocaleId, [NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** MessageText)
    {
        return ((delegate* unmanaged<IWbemStatusCodeText*, HRESULT, uint, int, ushort**, int> )(lpVtbl[4]))((IWbemStatusCodeText*)Unsafe.AsPointer(ref this), hRes, LocaleId, lFlags, MessageText);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetErrorCodeText(HRESULT hRes, [NativeTypeName("LCID")] uint LocaleId, [NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** MessageText);
        [VtblIndex(4)]
        HRESULT GetFacilityCodeText(HRESULT hRes, [NativeTypeName("LCID")] uint LocaleId, [NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** MessageText);
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
        [NativeTypeName("HRESULT (HRESULT, LCID, long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, uint, int, ushort**, int> GetErrorCodeText;
        [NativeTypeName("HRESULT (HRESULT, LCID, long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, uint, int, ushort**, int> GetFacilityCodeText;
    }
}