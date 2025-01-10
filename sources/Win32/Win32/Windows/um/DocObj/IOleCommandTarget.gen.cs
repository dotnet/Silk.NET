// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B722BCCB-4E68-101B-A2BC-00AA00404770")]
[NativeTypeName("struct IOleCommandTarget : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleCommandTarget : IOleCommandTarget.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleCommandTarget));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleCommandTarget, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOleCommandTarget, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleCommandTarget, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryStatus(
        [NativeTypeName("const GUID *")] Guid* pguidCmdGroup,
        [NativeTypeName("ULONG")] uint cCmds,
        [NativeTypeName("OLECMD[]")] OLECMD* prgCmds,
        OLECMDTEXT* pCmdText
    )
    {
        return (
            (delegate* unmanaged<IOleCommandTarget, Guid*, uint, OLECMD*, OLECMDTEXT*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pguidCmdGroup, cCmds, prgCmds, pCmdText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Exec(
        [NativeTypeName("const GUID *")] Guid* pguidCmdGroup,
        [NativeTypeName("DWORD")] uint nCmdID,
        [NativeTypeName("DWORD")] uint nCmdexecopt,
        VARIANT* pvaIn,
        VARIANT* pvaOut
    )
    {
        return (
            (delegate* unmanaged<IOleCommandTarget, Guid*, uint, uint, VARIANT*, VARIANT*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryStatus(
            [NativeTypeName("const GUID *")] Guid* pguidCmdGroup,
            [NativeTypeName("ULONG")] uint cCmds,
            [NativeTypeName("OLECMD[]")] OLECMD* prgCmds,
            OLECMDTEXT* pCmdText
        );

        [VtblIndex(4)]
        HRESULT Exec(
            [NativeTypeName("const GUID *")] Guid* pguidCmdGroup,
            [NativeTypeName("DWORD")] uint nCmdID,
            [NativeTypeName("DWORD")] uint nCmdexecopt,
            VARIANT* pvaIn,
            VARIANT* pvaOut
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

        [NativeTypeName(
            "HRESULT (const GUID *, ULONG, OLECMD *, OLECMDTEXT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, uint, OLECMD*, OLECMDTEXT*, int> QueryStatus;

        [NativeTypeName(
            "HRESULT (const GUID *, DWORD, DWORD, VARIANT *, VARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, uint, uint, VARIANT*, VARIANT*, int> Exec;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOleCommandTarget"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOleCommandTarget(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOleCommandTarget"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOleCommandTarget(Silk.NET.Windows.IUnknown value)
    {
        return new IOleCommandTarget(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOleCommandTarget"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOleCommandTarget"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOleCommandTarget value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
