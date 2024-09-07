// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.SDL;

public readonly unsafe struct HitTest : IDisposable
{
    private readonly void* Pointer;
    public delegate* unmanaged<WindowHandle, Point*, void*, HitTestResult> Handle =>
        (delegate* unmanaged<WindowHandle, Point*, void*, HitTestResult>)Pointer;

    public HitTest(delegate* unmanaged<WindowHandle, Point*, void*, HitTestResult> ptr) =>
        Pointer = ptr;

    public HitTest(HitTestDelegate proc) => Pointer = SilkMarshal.DelegateToPtr(proc);

    public void Dispose() => SilkMarshal.Free(Pointer);

    public static implicit operator HitTest(
        delegate* unmanaged<WindowHandle, Point*, void*, HitTestResult> pfn
    ) => new(pfn);

    public static implicit operator delegate* unmanaged<WindowHandle, Point*, void*, HitTestResult>(
        HitTest pfn
    ) => (delegate* unmanaged<WindowHandle, Point*, void*, HitTestResult>)pfn.Pointer;
}
