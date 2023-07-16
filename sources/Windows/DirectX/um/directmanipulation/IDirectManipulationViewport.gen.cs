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
/// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport"]/*'/>
[Guid("28B85A3D-60A0-48BD-9BA1-5CE8D9EA3A6D")]
[NativeTypeName("struct IDirectManipulationViewport : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDirectManipulationViewport : IDirectManipulationViewport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectManipulationViewport));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, Guid*, void**, int> )(lpVtbl[0]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, uint> )(lpVtbl[1]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, uint> )(lpVtbl[2]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.Enable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Enable()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, int> )(lpVtbl[3]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.Disable"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Disable()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, int> )(lpVtbl[4]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.SetContact"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetContact([NativeTypeName("UINT32")] uint pointerId)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, uint, int> )(lpVtbl[5]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), pointerId);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.ReleaseContact"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReleaseContact([NativeTypeName("UINT32")] uint pointerId)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, uint, int> )(lpVtbl[6]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), pointerId);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.ReleaseAllContacts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReleaseAllContacts()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, int> )(lpVtbl[7]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.GetStatus"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStatus(DIRECTMANIPULATION_STATUS* status)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_STATUS*, int> )(lpVtbl[8]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), status);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.GetTag"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetTag([NativeTypeName("const IID &")] Guid* riid, void** @object, [NativeTypeName("UINT32 *")] uint* id)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, Guid*, void**, uint*, int> )(lpVtbl[9]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), riid, @object, id);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.SetTag"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, IUnknown*, uint, int> )(lpVtbl[10]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), @object, id);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.GetViewportRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetViewportRect(RECT* viewport)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, RECT*, int> )(lpVtbl[11]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), viewport);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.SetViewportRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetViewportRect([NativeTypeName("const RECT *")] RECT* viewport)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, RECT*, int> )(lpVtbl[12]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), viewport);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.ZoomToRect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ZoomToRect([NativeTypeName("const float")] float left, [NativeTypeName("const float")] float top, [NativeTypeName("const float")] float right, [NativeTypeName("const float")] float bottom, BOOL animate)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, float, float, float, float, BOOL, int> )(lpVtbl[13]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), left, top, right, bottom, animate);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.SetViewportTransform"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetViewportTransform([NativeTypeName("const float *")] float* matrix, [NativeTypeName("DWORD")] uint pointCount)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, float*, uint, int> )(lpVtbl[14]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), matrix, pointCount);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.SyncDisplayTransform"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SyncDisplayTransform([NativeTypeName("const float *")] float* matrix, [NativeTypeName("DWORD")] uint pointCount)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, float*, uint, int> )(lpVtbl[15]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), matrix, pointCount);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.GetPrimaryContent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetPrimaryContent([NativeTypeName("const IID &")] Guid* riid, void** @object)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, Guid*, void**, int> )(lpVtbl[16]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), riid, @object);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.AddContent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AddContent(IDirectManipulationContent* content)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, IDirectManipulationContent*, int> )(lpVtbl[17]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), content);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.RemoveContent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RemoveContent(IDirectManipulationContent* content)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, IDirectManipulationContent*, int> )(lpVtbl[18]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), content);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.SetViewportOptions"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetViewportOptions(DIRECTMANIPULATION_VIEWPORT_OPTIONS options)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_VIEWPORT_OPTIONS, int> )(lpVtbl[19]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), options);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.AddConfiguration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT AddConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_CONFIGURATION, int> )(lpVtbl[20]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), configuration);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.RemoveConfiguration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT RemoveConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_CONFIGURATION, int> )(lpVtbl[21]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), configuration);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.ActivateConfiguration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT ActivateConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_CONFIGURATION, int> )(lpVtbl[22]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), configuration);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.SetManualGesture"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetManualGesture(DIRECTMANIPULATION_GESTURE_CONFIGURATION configuration)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_GESTURE_CONFIGURATION, int> )(lpVtbl[23]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), configuration);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.SetChaining"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetChaining(DIRECTMANIPULATION_MOTION_TYPES enabledTypes)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_MOTION_TYPES, int> )(lpVtbl[24]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), enabledTypes);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.AddEventHandler"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT AddEventHandler(HWND window, IDirectManipulationViewportEventHandler* eventHandler, [NativeTypeName("DWORD *")] uint* cookie)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, HWND, IDirectManipulationViewportEventHandler*, uint*, int> )(lpVtbl[25]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), window, eventHandler, cookie);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.RemoveEventHandler"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT RemoveEventHandler([NativeTypeName("DWORD")] uint cookie)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, uint, int> )(lpVtbl[26]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.SetInputMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetInputMode(DIRECTMANIPULATION_INPUT_MODE mode)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_INPUT_MODE, int> )(lpVtbl[27]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), mode);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.SetUpdateMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetUpdateMode(DIRECTMANIPULATION_INPUT_MODE mode)
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, DIRECTMANIPULATION_INPUT_MODE, int> )(lpVtbl[28]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this), mode);
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.Stop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, int> )(lpVtbl[29]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectManipulationViewport.xml' path='doc/member[@name="IDirectManipulationViewport.Abandon"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT Abandon()
    {
        return ((delegate* unmanaged<IDirectManipulationViewport*, int> )(lpVtbl[30]))((IDirectManipulationViewport*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Enable();
        [VtblIndex(4)]
        HRESULT Disable();
        [VtblIndex(5)]
        HRESULT SetContact([NativeTypeName("UINT32")] uint pointerId);
        [VtblIndex(6)]
        HRESULT ReleaseContact([NativeTypeName("UINT32")] uint pointerId);
        [VtblIndex(7)]
        HRESULT ReleaseAllContacts();
        [VtblIndex(8)]
        HRESULT GetStatus(DIRECTMANIPULATION_STATUS* status);
        [VtblIndex(9)]
        HRESULT GetTag([NativeTypeName("const IID &")] Guid* riid, void** @object, [NativeTypeName("UINT32 *")] uint* id);
        [VtblIndex(10)]
        HRESULT SetTag(IUnknown* @object, [NativeTypeName("UINT32")] uint id);
        [VtblIndex(11)]
        HRESULT GetViewportRect(RECT* viewport);
        [VtblIndex(12)]
        HRESULT SetViewportRect([NativeTypeName("const RECT *")] RECT* viewport);
        [VtblIndex(13)]
        HRESULT ZoomToRect([NativeTypeName("const float")] float left, [NativeTypeName("const float")] float top, [NativeTypeName("const float")] float right, [NativeTypeName("const float")] float bottom, BOOL animate);
        [VtblIndex(14)]
        HRESULT SetViewportTransform([NativeTypeName("const float *")] float* matrix, [NativeTypeName("DWORD")] uint pointCount);
        [VtblIndex(15)]
        HRESULT SyncDisplayTransform([NativeTypeName("const float *")] float* matrix, [NativeTypeName("DWORD")] uint pointCount);
        [VtblIndex(16)]
        HRESULT GetPrimaryContent([NativeTypeName("const IID &")] Guid* riid, void** @object);
        [VtblIndex(17)]
        HRESULT AddContent(IDirectManipulationContent* content);
        [VtblIndex(18)]
        HRESULT RemoveContent(IDirectManipulationContent* content);
        [VtblIndex(19)]
        HRESULT SetViewportOptions(DIRECTMANIPULATION_VIEWPORT_OPTIONS options);
        [VtblIndex(20)]
        HRESULT AddConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration);
        [VtblIndex(21)]
        HRESULT RemoveConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration);
        [VtblIndex(22)]
        HRESULT ActivateConfiguration(DIRECTMANIPULATION_CONFIGURATION configuration);
        [VtblIndex(23)]
        HRESULT SetManualGesture(DIRECTMANIPULATION_GESTURE_CONFIGURATION configuration);
        [VtblIndex(24)]
        HRESULT SetChaining(DIRECTMANIPULATION_MOTION_TYPES enabledTypes);
        [VtblIndex(25)]
        HRESULT AddEventHandler(HWND window, IDirectManipulationViewportEventHandler* eventHandler, [NativeTypeName("DWORD *")] uint* cookie);
        [VtblIndex(26)]
        HRESULT RemoveEventHandler([NativeTypeName("DWORD")] uint cookie);
        [VtblIndex(27)]
        HRESULT SetInputMode(DIRECTMANIPULATION_INPUT_MODE mode);
        [VtblIndex(28)]
        HRESULT SetUpdateMode(DIRECTMANIPULATION_INPUT_MODE mode);
        [VtblIndex(29)]
        HRESULT Stop();
        [VtblIndex(30)]
        HRESULT Abandon();
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
    }
}