// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISyncMgrScheduleWizardUIOperation.xml' path='doc/member[@name="ISyncMgrScheduleWizardUIOperation"]/*'/>
[Guid("459A6C84-21D2-4DDC-8A53-F023A46066F2")]
[NativeTypeName("struct ISyncMgrScheduleWizardUIOperation : ISyncMgrUIOperation")]
[NativeInheritance("ISyncMgrUIOperation")]
public unsafe partial struct ISyncMgrScheduleWizardUIOperation : ISyncMgrScheduleWizardUIOperation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrScheduleWizardUIOperation));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrScheduleWizardUIOperation*, Guid*, void**, int> )(lpVtbl[0]))((ISyncMgrScheduleWizardUIOperation*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrScheduleWizardUIOperation*, uint> )(lpVtbl[1]))((ISyncMgrScheduleWizardUIOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrScheduleWizardUIOperation*, uint> )(lpVtbl[2]))((ISyncMgrScheduleWizardUIOperation*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISyncMgrUIOperation.Run"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Run(HWND hwndOwner)
    {
        return ((delegate* unmanaged<ISyncMgrScheduleWizardUIOperation*, HWND, int> )(lpVtbl[3]))((ISyncMgrScheduleWizardUIOperation*)Unsafe.AsPointer(ref this), hwndOwner);
    }

    /// <include file='ISyncMgrScheduleWizardUIOperation.xml' path='doc/member[@name="ISyncMgrScheduleWizardUIOperation.InitWizard"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InitWizard([NativeTypeName("LPCWSTR")] ushort* pszHandlerID)
    {
        return ((delegate* unmanaged<ISyncMgrScheduleWizardUIOperation*, ushort*, int> )(lpVtbl[4]))((ISyncMgrScheduleWizardUIOperation*)Unsafe.AsPointer(ref this), pszHandlerID);
    }

    public interface Interface : ISyncMgrUIOperation.Interface
    {
        [VtblIndex(4)]
        HRESULT InitWizard([NativeTypeName("LPCWSTR")] ushort* pszHandlerID);
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
        [NativeTypeName("HRESULT (HWND) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, int> Run;
        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> InitWizard;
    }
}