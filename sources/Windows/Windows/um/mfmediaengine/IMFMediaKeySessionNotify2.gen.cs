// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IMFMediaKeySessionNotify2.xml' path='doc/member[@name="IMFMediaKeySessionNotify2"]/*'/>
[Guid("C3A9E92A-DA88-46B0-A110-6CF953026CB9")]
[NativeTypeName("struct IMFMediaKeySessionNotify2 : IMFMediaKeySessionNotify")]
[NativeInheritance("IMFMediaKeySessionNotify")]
public unsafe partial struct IMFMediaKeySessionNotify2 : IMFMediaKeySessionNotify2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaKeySessionNotify2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaKeySessionNotify2*, Guid*, void**, int> )(lpVtbl[0]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaKeySessionNotify2*, uint> )(lpVtbl[1]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaKeySessionNotify2*, uint> )(lpVtbl[2]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFMediaKeySessionNotify.KeyMessage"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void KeyMessage([NativeTypeName("BSTR")] ushort* destinationURL, [NativeTypeName("const BYTE *")] byte* message, [NativeTypeName("DWORD")] uint cb)
    {
        ((delegate* unmanaged<IMFMediaKeySessionNotify2*, ushort*, byte*, uint, void> )(lpVtbl[3]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this), destinationURL, message, cb);
    }

    /// <inheritdoc cref = "IMFMediaKeySessionNotify.KeyAdded"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void KeyAdded()
    {
        ((delegate* unmanaged<IMFMediaKeySessionNotify2*, void> )(lpVtbl[4]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMFMediaKeySessionNotify.KeyError"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void KeyError(ushort code, [NativeTypeName("DWORD")] uint systemCode)
    {
        ((delegate* unmanaged<IMFMediaKeySessionNotify2*, ushort, uint, void> )(lpVtbl[5]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this), code, systemCode);
    }

    /// <include file='IMFMediaKeySessionNotify2.xml' path='doc/member[@name="IMFMediaKeySessionNotify2.KeyMessage2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void KeyMessage2(MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType, [NativeTypeName("BSTR")] ushort* destinationURL, [NativeTypeName("const BYTE *")] byte* pbMessage, [NativeTypeName("DWORD")] uint cbMessage)
    {
        ((delegate* unmanaged<IMFMediaKeySessionNotify2*, MF_MEDIAKEYSESSION_MESSAGETYPE, ushort*, byte*, uint, void> )(lpVtbl[6]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this), eMessageType, destinationURL, pbMessage, cbMessage);
    }

    /// <include file='IMFMediaKeySessionNotify2.xml' path='doc/member[@name="IMFMediaKeySessionNotify2.KeyStatusChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void KeyStatusChange()
    {
        ((delegate* unmanaged<IMFMediaKeySessionNotify2*, void> )(lpVtbl[7]))((IMFMediaKeySessionNotify2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IMFMediaKeySessionNotify.Interface
    {
        [VtblIndex(6)]
        void KeyMessage2(MF_MEDIAKEYSESSION_MESSAGETYPE eMessageType, [NativeTypeName("BSTR")] ushort* destinationURL, [NativeTypeName("const BYTE *")] byte* pbMessage, [NativeTypeName("DWORD")] uint cbMessage);
        [VtblIndex(7)]
        void KeyStatusChange();
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
        [NativeTypeName("void (BSTR, const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, byte*, uint, void> KeyMessage;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> KeyAdded;
        [NativeTypeName("void (USHORT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, uint, void> KeyError;
        [NativeTypeName("void (MF_MEDIAKEYSESSION_MESSAGETYPE, BSTR, const BYTE *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, MF_MEDIAKEYSESSION_MESSAGETYPE, ushort*, byte*, uint, void> KeyMessage2;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> KeyStatusChange;
    }
}