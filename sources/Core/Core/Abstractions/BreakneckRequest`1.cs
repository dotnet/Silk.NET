// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core;

/// <summary>
/// Provides a lightweight mechanism for requesting a resource from a producer thread and spinning until the request is
/// fulfilled.
/// </summary>
/// <remarks>
/// This struct is very performant, but it is very dangerous (hence breakneck).
/// It's recommended to use the framework-provided locks where possible.
/// </remarks>
/// <typeparam name="TResource">The resource to request.</typeparam>
public struct BreakneckRequest<TResource>
{
    private int _currentSerial;
    private int _requestedSerial;
    private int _gate;
    private TResource _result;

    /// <summary>
    /// Used by the producing thread only to determine whether the resource is requested.
    /// </summary>
    public bool IsRequested => _requestedSerial != _currentSerial;

    /// <summary>
    /// Requests the resource.
    /// </summary>
    /// <returns>The resource.</returns>
    public TResource Request()
    {
        // 1. Get a ticket - we use Interlocked here because there are potentially many threads doing the same.
        var ourTicket = Interlocked.Increment(ref _requestedSerial);

        // 2. Wait in line.
        while (Interlocked.CompareExchange(ref _currentSerial, ourTicket, ourTicket) != ourTicket)
        { }

        // 5. Get the result.
        var ret = _result;
        _result = default!;
        Interlocked.Decrement(ref _gate); // 0 = "I have picked up my things"
        return ret;
    }

    /// <summary>
    /// Provides the resource requested.
    /// </summary>
    /// <param name="resource">The resource.</param>
    /// <remarks>
    /// This must only be called once it is validated that <see cref="IsRequested"/> is <c>true</c>. Failure to follow
    /// this will result in this function hanging forever.
    /// </remarks>
    public void Provide(TResource resource)
    {
        // 3. Wait for the last requester in line to pick up their things.
        while (Interlocked.CompareExchange(ref _gate, 1, 0) != 0) { }

        // 4. Serve the next ticket.
        _result = resource;
        Interlocked.Increment(ref _currentSerial);
    }
}
