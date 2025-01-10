// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000126-0000-0000-C000-000000000046")]
[NativeTypeName("struct IRunnableObject : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRunnableObject : IRunnableObject.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRunnableObject));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRunnableObject, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRunnableObject, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRunnableObject, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRunningClass([NativeTypeName("LPCLSID")] Guid* lpClsid)
    {
        return ((delegate* unmanaged<IRunnableObject, Guid*, int>)((*lpVtbl)[3]))(this, lpClsid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Run([NativeTypeName("LPBINDCTX")] IBindCtx pbc)
    {
        return ((delegate* unmanaged<IRunnableObject, IBindCtx, int>)((*lpVtbl)[4]))(this, pbc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public BOOL IsRunning()
    {
        return ((delegate* unmanaged<IRunnableObject, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LockRunning(BOOL fLock, BOOL fLastUnlockCloses)
    {
        return ((delegate* unmanaged<IRunnableObject, BOOL, BOOL, int>)((*lpVtbl)[6]))(
            this,
            fLock,
            fLastUnlockCloses
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetContainedObject(BOOL fContained)
    {
        return ((delegate* unmanaged<IRunnableObject, BOOL, int>)((*lpVtbl)[7]))(this, fContained);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRunningClass([NativeTypeName("LPCLSID")] Guid* lpClsid);

        [VtblIndex(4)]
        HRESULT Run([NativeTypeName("LPBINDCTX")] IBindCtx pbc);

        [VtblIndex(5)]
        BOOL IsRunning();

        [VtblIndex(6)]
        HRESULT LockRunning(BOOL fLock, BOOL fLastUnlockCloses);

        [VtblIndex(7)]
        HRESULT SetContainedObject(BOOL fContained);
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

        [NativeTypeName("HRESULT (LPCLSID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetRunningClass;

        [NativeTypeName("HRESULT (LPBINDCTX) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IBindCtx, int> Run;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsRunning;

        [NativeTypeName("HRESULT (BOOL, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, BOOL, int> LockRunning;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetContainedObject;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRunnableObject"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRunnableObject(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRunnableObject"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRunnableObject(Silk.NET.Windows.IUnknown value)
    {
        return new IRunnableObject(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRunnableObject"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRunnableObject"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRunnableObject value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
