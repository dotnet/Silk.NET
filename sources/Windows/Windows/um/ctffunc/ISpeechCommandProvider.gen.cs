// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ISpeechCommandProvider.xml' path='doc/member[@name="ISpeechCommandProvider"]/*'/>
[Guid("38E09D4C-586D-435A-B592-C8A86691DEC6")]
[NativeTypeName("struct ISpeechCommandProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpeechCommandProvider : ISpeechCommandProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechCommandProvider));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechCommandProvider*, Guid*, void**, int> )(lpVtbl[0]))((ISpeechCommandProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechCommandProvider*, uint> )(lpVtbl[1]))((ISpeechCommandProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechCommandProvider*, uint> )(lpVtbl[2]))((ISpeechCommandProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpeechCommandProvider.xml' path='doc/member[@name="ISpeechCommandProvider.EnumSpeechCommands"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnumSpeechCommands([NativeTypeName("LANGID")] ushort langid, IEnumSpeechCommands** ppEnum)
    {
        return ((delegate* unmanaged<ISpeechCommandProvider*, ushort, IEnumSpeechCommands**, int> )(lpVtbl[3]))((ISpeechCommandProvider*)Unsafe.AsPointer(ref this), langid, ppEnum);
    }

    /// <include file='ISpeechCommandProvider.xml' path='doc/member[@name="ISpeechCommandProvider.ProcessCommand"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ProcessCommand([NativeTypeName("const WCHAR *")] ushort* pszCommand, [NativeTypeName("ULONG")] uint cch, [NativeTypeName("LANGID")] ushort langid)
    {
        return ((delegate* unmanaged<ISpeechCommandProvider*, ushort*, uint, ushort, int> )(lpVtbl[4]))((ISpeechCommandProvider*)Unsafe.AsPointer(ref this), pszCommand, cch, langid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnumSpeechCommands([NativeTypeName("LANGID")] ushort langid, IEnumSpeechCommands** ppEnum);
        [VtblIndex(4)]
        HRESULT ProcessCommand([NativeTypeName("const WCHAR *")] ushort* pszCommand, [NativeTypeName("ULONG")] uint cch, [NativeTypeName("LANGID")] ushort langid);
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
        [NativeTypeName("HRESULT (LANGID, IEnumSpeechCommands **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, IEnumSpeechCommands**, int> EnumSpeechCommands;
        [NativeTypeName("HRESULT (const WCHAR *, ULONG, LANGID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort, int> ProcessCommand;
    }
}