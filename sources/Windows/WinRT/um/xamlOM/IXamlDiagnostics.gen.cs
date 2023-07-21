// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;

/// <include file='IXamlDiagnostics.xml' path='doc/member[@name="IXamlDiagnostics"]/*' />
[Guid("18C9E2B6-3F43-4116-9F2B-FF935D7770D2")]
[NativeTypeName("struct IXamlDiagnostics : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IXamlDiagnostics : IXamlDiagnostics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXamlDiagnostics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXamlDiagnostics*, Guid*, void**, int>)(lpVtbl[0]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXamlDiagnostics*, uint>)(lpVtbl[1]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXamlDiagnostics*, uint>)(lpVtbl[2]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXamlDiagnostics.xml' path='doc/member[@name="IXamlDiagnostics.GetDispatcher"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDispatcher(IInspectable** ppDispatcher)
    {
        return ((delegate* unmanaged<IXamlDiagnostics*, IInspectable**, int>)(lpVtbl[3]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), ppDispatcher);
    }

    /// <include file='IXamlDiagnostics.xml' path='doc/member[@name="IXamlDiagnostics.GetUiLayer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetUiLayer(IInspectable** ppLayer)
    {
        return ((delegate* unmanaged<IXamlDiagnostics*, IInspectable**, int>)(lpVtbl[4]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), ppLayer);
    }

    /// <include file='IXamlDiagnostics.xml' path='doc/member[@name="IXamlDiagnostics.GetApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetApplication(IInspectable** ppApplication)
    {
        return ((delegate* unmanaged<IXamlDiagnostics*, IInspectable**, int>)(lpVtbl[5]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), ppApplication);
    }

    /// <include file='IXamlDiagnostics.xml' path='doc/member[@name="IXamlDiagnostics.GetIInspectableFromHandle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetIInspectableFromHandle(InstanceHandle instanceHandle, IInspectable** ppInstance)
    {
        return ((delegate* unmanaged<IXamlDiagnostics*, InstanceHandle, IInspectable**, int>)(lpVtbl[6]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), instanceHandle, ppInstance);
    }

    /// <include file='IXamlDiagnostics.xml' path='doc/member[@name="IXamlDiagnostics.GetHandleFromIInspectable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetHandleFromIInspectable(IInspectable* pInstance, InstanceHandle* pHandle)
    {
        return ((delegate* unmanaged<IXamlDiagnostics*, IInspectable*, InstanceHandle*, int>)(lpVtbl[7]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), pInstance, pHandle);
    }

    /// <include file='IXamlDiagnostics.xml' path='doc/member[@name="IXamlDiagnostics.HitTest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT HitTest(RECT rect, [NativeTypeName("unsigned int *")] uint* pCount, InstanceHandle** ppInstanceHandles)
    {
        return ((delegate* unmanaged<IXamlDiagnostics*, RECT, uint*, InstanceHandle**, int>)(lpVtbl[8]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), rect, pCount, ppInstanceHandles);
    }

    /// <include file='IXamlDiagnostics.xml' path='doc/member[@name="IXamlDiagnostics.RegisterInstance"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RegisterInstance(IInspectable* pInstance, InstanceHandle* pInstanceHandle)
    {
        return ((delegate* unmanaged<IXamlDiagnostics*, IInspectable*, InstanceHandle*, int>)(lpVtbl[9]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), pInstance, pInstanceHandle);
    }

    /// <include file='IXamlDiagnostics.xml' path='doc/member[@name="IXamlDiagnostics.GetInitializationData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetInitializationData([NativeTypeName("BSTR *")] ushort** pInitializationData)
    {
        return ((delegate* unmanaged<IXamlDiagnostics*, ushort**, int>)(lpVtbl[10]))((IXamlDiagnostics*)Unsafe.AsPointer(ref this), pInitializationData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDispatcher(IInspectable** ppDispatcher);

        [VtblIndex(4)]
        HRESULT GetUiLayer(IInspectable** ppLayer);

        [VtblIndex(5)]
        HRESULT GetApplication(IInspectable** ppApplication);

        [VtblIndex(6)]
        HRESULT GetIInspectableFromHandle(InstanceHandle instanceHandle, IInspectable** ppInstance);

        [VtblIndex(7)]
        HRESULT GetHandleFromIInspectable(IInspectable* pInstance, InstanceHandle* pHandle);

        [VtblIndex(8)]
        HRESULT HitTest(RECT rect, [NativeTypeName("unsigned int *")] uint* pCount, InstanceHandle** ppInstanceHandles);

        [VtblIndex(9)]
        HRESULT RegisterInstance(IInspectable* pInstance, InstanceHandle* pInstanceHandle);

        [VtblIndex(10)]
        HRESULT GetInitializationData([NativeTypeName("BSTR *")] ushort** pInitializationData);
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

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable**, int> GetDispatcher;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable**, int> GetUiLayer;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable**, int> GetApplication;

        [NativeTypeName("HRESULT (InstanceHandle, IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, InstanceHandle, IInspectable**, int> GetIInspectableFromHandle;

        [NativeTypeName("HRESULT (IInspectable *, InstanceHandle *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable*, InstanceHandle*, int> GetHandleFromIInspectable;

        [NativeTypeName("HRESULT (RECT, unsigned int *, InstanceHandle **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT, uint*, InstanceHandle**, int> HitTest;

        [NativeTypeName("HRESULT (IInspectable *, InstanceHandle *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInspectable*, InstanceHandle*, int> RegisterInstance;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetInitializationData;
    }
}
