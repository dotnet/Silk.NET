// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.Input.SDL3;

/// <summary>
/// A base class for SDL input devices that operate in terms of a window's or DWMs bounds.
/// </summary>
/// <param name="backend">The backend.</param>
internal abstract class SdlBoundedPointerDevice(SdlInputBackend backend)
    : SdlDevice(backend),
        IPointerDevice
{
    public abstract PointerState State { get; }

    [field: MaybeNull]
    public virtual IReadOnlyList<IPointerTarget> Targets =>
        field ??= [Backend.BoundedPointerTarget];

    /// <summary>
    /// Determines whether the <see cref="SdlBoundedPointerTarget"/> should interpret <see cref="PointerState.Points"/>
    /// as being bounded points. For all devices supported by this backend, only one target is supported at a time
    /// today.
    /// </summary>
    public virtual bool IsBounded => true;

    // ReSharper disable once ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract
    public InputMarshal.ListOwner<TargetPoint> BoundedPoints =>
        field.List.Data is null ? field = InputMarshal.CreateList<TargetPoint>() : field;
}
