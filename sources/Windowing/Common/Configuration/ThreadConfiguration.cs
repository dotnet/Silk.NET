// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Windowing;

/// <summary>
/// Configures the surface with the given threading configuration. This must be applied to the root surface.
/// </summary>
/// <param name="UseSeparateEventThread">
/// Whether a separate event thread should be used for the root surface. If <c>false</c>, the root surface will be
/// responsible for pumping events to the other surfaces. This has the advantage of having only one core with a busy
/// loop instead of two, but has the disadvantage of potentially allowing the render logic of the root surface to cause
/// delay in the delivery of events to child surfaces. If <c>true</c>, the main thread's sole responsibility shall be
/// the delivery of surface events to surfaces running on other threads. This configuration has no effect on child
/// surfaces as the event loop is owned by the root surface.
/// </param>
/// <param name="UseBufferedEventLoop">
/// If <c>false</c>, the event pump shall not advance past an event until all surfaces have read that event, sending the
/// surfaces that have read that event into a busy loop in the meantime. If <c>true</c>, a buffer is maintained to
/// allow each surface to retrieve events at their own pace. This is useful in cases where one surface is slowing down
/// all other surface due to the event pump being advanced at a sufficient rate.
/// </param>
/// <remarks>This configuration is not guaranteed to be honoured by a backend.</remarks>
// TODO  <param name="UseSeparateUpdateThread">
// TODO  If the default <see cref="ISurface"/> implementation (i.e. <see cref="Surface{TImpl}"/>) is being used without a
// TODO  <see cref="ISurfaceActor"/> (i.e. the
// TODO  </param>
public readonly record struct ThreadConfiguration(
    bool UseSeparateEventThread = false,
    bool UseBufferedEventLoop = false
);
