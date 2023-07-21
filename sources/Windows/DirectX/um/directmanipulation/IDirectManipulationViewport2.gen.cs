// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDirectManipulationViewport2.xml' path='doc/member[@name="IDirectManipulationViewport2"]/*' />
[Guid("923CCAAC-61E1-4385-B726-017AF189882A")]
[NativeTypeName("struct IDirectManipulationViewport2 : IDirectManipulationViewport")]
[NativeInheritance("IDirectManipulationViewport")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDirectManipulationViewport2 : IDirectManipulationViewport2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationViewport2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, Guid*, void**, int>)(lpVtbl[0]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, uint>)(lpVtbl[1]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, uint>)(lpVtbl[2]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirectManipulationViewport.Enable" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Enable()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, int>)(lpVtbl[3]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirectManipulationViewport.Disable" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Disable()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, int>)(lpVtbl[4]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirectManipulationViewport.SetContact" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetContact([NativeTypeName("UINT32")] uint pointerId)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, uint, int>)(lpVtbl[5]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), pointerId);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.ReleaseContact" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReleaseContact([NativeTypeName("UINT32")] uint pointerId)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, uint, int>)(lpVtbl[6]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), pointerId);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.ReleaseAllContacts" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReleaseAllContacts()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, int>)(lpVtbl[7]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirectManipulationViewport.GetStatus" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStatus(DIRECTMANIPULATION_STATUS* status)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, DIRECTMANIPULATION_STATUS*, int>)(lpVtbl[8]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), status);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.GetTag" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetTag([NativeTypeName("const IID &")] Guid* riid, void** @object, [NativeTypeName("UINT32 *")] uint* id)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, Guid*, void**, uint*, int>)(lpVtbl[9]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), riid, @object, id);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.SetTag" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, IUnknown*, uint, int>)(lpVtbl[10]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), @object, id);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.GetViewportRect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetViewportRect(RECT* viewport)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, RECT*, int>)(lpVtbl[11]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), viewport);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.SetViewportRect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetViewportRect([NativeTypeName("const RECT *")] RECT* viewport)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, RECT*, int>)(lpVtbl[12]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), viewport);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.ZoomToRect" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ZoomToRect([NativeTypeName("const float")] float left, [NativeTypeName("const float")] float top, [NativeTypeName("const float")] float right, [NativeTypeName("const float")] float bottom, BOOL animate)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, float, float, float, float, BOOL, int>)(lpVtbl[13]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), left, top, right, bottom, animate);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.SetViewportTransform" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetViewportTransform([NativeTypeName("const float *")] float* matrix, [NativeTypeName("DWORD")] uint pointCount)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, float*, uint, int>)(lpVtbl[14]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), matrix, pointCount);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.SyncDisplayTransform" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SyncDisplayTransform([NativeTypeName("const float *")] float* matrix, [NativeTypeName("DWORD")] uint pointCount)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, float*, uint, int>)(lpVtbl[15]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), matrix, pointCount);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.GetPrimaryContent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetPrimaryContent([NativeTypeName("const IID &")] Guid* riid, void** @object)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, Guid*, void**, int>)(lpVtbl[16]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), riid, @object);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.AddContent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AddContent(IDirectManipulationContent* content)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, IDirectManipulationContent*, int>)(lpVtbl[17]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), content);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.RemoveContent" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RemoveContent(IDirectManipulationContent* content)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, IDirectManipulationContent*, int>)(lpVtbl[18]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), content);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.SetViewportOptions" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetViewportOptions(DIRECTMANIPULATION_VIEWPORT_OPTIONS options)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, DIRECTMANIPULATION_VIEWPORT_OPTIONS, int>)(lpVtbl[19]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), options);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.AddConfiguration" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AddConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, DIRECTMANIPULATION_CONFIGURATION, int>)(lpVtbl[20]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), configuration);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.RemoveConfiguration" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RemoveConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, DIRECTMANIPULATION_CONFIGURATION, int>)(lpVtbl[21]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), configuration);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.ActivateConfiguration" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ActivateConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, DIRECTMANIPULATION_CONFIGURATION, int>)(lpVtbl[22]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), configuration);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.SetManualGesture" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetManualGesture(DIRECTMANIPULATION_GESTURE_CONFIGURATION configuration)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, DIRECTMANIPULATION_GESTURE_CONFIGURATION, int>)(lpVtbl[23]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), configuration);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.SetChaining" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetChaining(DIRECTMANIPULATION_MOTION_TYPES enabledTypes)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, DIRECTMANIPULATION_MOTION_TYPES, int>)(lpVtbl[24]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), enabledTypes);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.AddEventHandler" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT AddEventHandler(HWND window, IDirectManipulationViewportEventHandler* eventHandler, [NativeTypeName("DWORD *")] uint* cookie)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, HWND, IDirectManipulationViewportEventHandler*, uint*, int>)(lpVtbl[25]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), window, eventHandler, cookie);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.RemoveEventHandler" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT RemoveEventHandler([NativeTypeName("DWORD")] uint cookie)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, uint, int>)(lpVtbl[26]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.SetInputMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetInputMode(DIRECTMANIPULATION_INPUT_MODE mode)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, DIRECTMANIPULATION_INPUT_MODE, int>)(lpVtbl[27]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), mode);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.SetUpdateMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetUpdateMode(DIRECTMANIPULATION_INPUT_MODE mode)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, DIRECTMANIPULATION_INPUT_MODE, int>)(lpVtbl[28]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), mode);
    }

    /// <inheritdoc cref="IDirectManipulationViewport.Stop" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, int>)(lpVtbl[29]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDirectManipulationViewport.Abandon" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT Abandon()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, int>)(lpVtbl[30]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectManipulationViewport2.xml' path='doc/member[@name="IDirectManipulationViewport2.AddBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT AddBehavior(IUnknown* behavior, [NativeTypeName("DWORD *")] uint* cookie)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, IUnknown*, uint*, int>)(lpVtbl[31]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), behavior, cookie);
    }

    /// <include file='IDirectManipulationViewport2.xml' path='doc/member[@name="IDirectManipulationViewport2.RemoveBehavior"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT RemoveBehavior([NativeTypeName("DWORD")] uint cookie)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, uint, int>)(lpVtbl[32]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IDirectManipulationViewport2.xml' path='doc/member[@name="IDirectManipulationViewport2.RemoveAllBehaviors"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT RemoveAllBehaviors()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport2*, int>)(lpVtbl[33]))((IDirectManipulationViewport2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDirectManipulationViewport.Interface
    {
        [VtblIndex(31)]
        HRESULT AddBehavior(IUnknown* behavior, [NativeTypeName("DWORD *")] uint* cookie);

        [VtblIndex(32)]
        HRESULT RemoveBehavior([NativeTypeName("DWORD")] uint cookie);

        [VtblIndex(33)]
        HRESULT RemoveAllBehaviors();
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Enable;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Disable;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetContact;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> ReleaseContact;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReleaseAllContacts;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_STATUS*, int> GetStatus;

        [NativeTypeName("HRESULT (const IID &, void **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, uint*, int> GetTag;

        [NativeTypeName("HRESULT (IUnknown *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint, int> SetTag;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> GetViewportRect;

        [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> SetViewportRect;

        [NativeTypeName("HRESULT (const float, const float, const float, const float, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, BOOL, int> ZoomToRect;

        [NativeTypeName("HRESULT (const float *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, int> SetViewportTransform;

        [NativeTypeName("HRESULT (const float *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, int> SyncDisplayTransform;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetPrimaryContent;

        [NativeTypeName("HRESULT (IDirectManipulationContent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectManipulationContent*, int> AddContent;

        [NativeTypeName("HRESULT (IDirectManipulationContent *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectManipulationContent*, int> RemoveContent;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_VIEWPORT_OPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_VIEWPORT_OPTIONS, int> SetViewportOptions;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_CONFIGURATION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_CONFIGURATION, int> AddConfiguration;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_CONFIGURATION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_CONFIGURATION, int> RemoveConfiguration;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_CONFIGURATION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_CONFIGURATION, int> ActivateConfiguration;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_GESTURE_CONFIGURATION) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_GESTURE_CONFIGURATION, int> SetManualGesture;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_MOTION_TYPES) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_MOTION_TYPES, int> SetChaining;

        [NativeTypeName("HRESULT (HWND, IDirectManipulationViewportEventHandler *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, IDirectManipulationViewportEventHandler*, uint*, int> AddEventHandler;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveEventHandler;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_INPUT_MODE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_INPUT_MODE, int> SetInputMode;

        [NativeTypeName("HRESULT (DIRECTMANIPULATION_INPUT_MODE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIRECTMANIPULATION_INPUT_MODE, int> SetUpdateMode;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Abandon;

        [NativeTypeName("HRESULT (IUnknown *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, uint*, int> AddBehavior;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveBehavior;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllBehaviors;
    }
}
