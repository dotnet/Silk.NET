// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("38E09D4C-586D-435A-B592-C8A86691DEC6")]
[NativeTypeName("struct ISpeechCommandProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpeechCommandProvider : ISpeechCommandProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechCommandProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechCommandProvider, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechCommandProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechCommandProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnumSpeechCommands(
        [NativeTypeName("LANGID")] ushort langid,
        IEnumSpeechCommands* ppEnum
    )
    {
        return (
            (delegate* unmanaged<ISpeechCommandProvider, ushort, IEnumSpeechCommands*, int>)(
                (*lpVtbl)[3]
            )
        )(this, langid, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ProcessCommand(
        [NativeTypeName("const WCHAR *")] ushort* pszCommand,
        [NativeTypeName("ULONG")] uint cch,
        [NativeTypeName("LANGID")] ushort langid
    )
    {
        return (
            (delegate* unmanaged<ISpeechCommandProvider, ushort*, uint, ushort, int>)((*lpVtbl)[4])
        )(this, pszCommand, cch, langid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnumSpeechCommands(
            [NativeTypeName("LANGID")] ushort langid,
            IEnumSpeechCommands* ppEnum
        );

        [VtblIndex(4)]
        HRESULT ProcessCommand(
            [NativeTypeName("const WCHAR *")] ushort* pszCommand,
            [NativeTypeName("ULONG")] uint cch,
            [NativeTypeName("LANGID")] ushort langid
        );
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
        public delegate* unmanaged<TSelf*, ushort, IEnumSpeechCommands*, int> EnumSpeechCommands;

        [NativeTypeName("HRESULT (const WCHAR *, ULONG, LANGID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, ushort, int> ProcessCommand;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechCommandProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechCommandProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechCommandProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechCommandProvider(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechCommandProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechCommandProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechCommandProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechCommandProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
