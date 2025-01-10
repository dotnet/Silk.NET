// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3051083A-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IScriptEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IScriptEventHandler : IScriptEventHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IScriptEventHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IScriptEventHandler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IScriptEventHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IScriptEventHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FunctionName([NativeTypeName("BSTR *")] ushort** pbstrFunctionName)
    {
        return ((delegate* unmanaged<IScriptEventHandler, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrFunctionName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DebugDocumentContext(IUnknown* ppDebugDocumentContext)
    {
        return ((delegate* unmanaged<IScriptEventHandler, IUnknown*, int>)((*lpVtbl)[4]))(
            this,
            ppDebugDocumentContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EventHandlerDispatch(IDispatch* ppDispHandler)
    {
        return ((delegate* unmanaged<IScriptEventHandler, IDispatch*, int>)((*lpVtbl)[5]))(
            this,
            ppDispHandler
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UsesCapture(BOOL* pfUsesCapture)
    {
        return ((delegate* unmanaged<IScriptEventHandler, BOOL*, int>)((*lpVtbl)[6]))(
            this,
            pfUsesCapture
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Cookie([NativeTypeName("ULONGLONG *")] ulong* pullCookie)
    {
        return ((delegate* unmanaged<IScriptEventHandler, ulong*, int>)((*lpVtbl)[7]))(
            this,
            pullCookie
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FunctionName([NativeTypeName("BSTR *")] ushort** pbstrFunctionName);

        [VtblIndex(4)]
        HRESULT DebugDocumentContext(IUnknown* ppDebugDocumentContext);

        [VtblIndex(5)]
        HRESULT EventHandlerDispatch(IDispatch* ppDispHandler);

        [VtblIndex(6)]
        HRESULT UsesCapture(BOOL* pfUsesCapture);

        [VtblIndex(7)]
        HRESULT Cookie([NativeTypeName("ULONGLONG *")] ulong* pullCookie);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> FunctionName;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> DebugDocumentContext;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> EventHandlerDispatch;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> UsesCapture;

        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> Cookie;
    }

    /// <summary>Initializes a new instance of the <see cref = "IScriptEventHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IScriptEventHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IScriptEventHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IScriptEventHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IScriptEventHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IScriptEventHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IScriptEventHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IScriptEventHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
