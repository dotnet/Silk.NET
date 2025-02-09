// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.Core;

/// <summary>
/// Provides a lightweight mechanism for requesting a resource with request data from a producer thread and spinning
/// until the request is fulfilled.
/// </summary>
/// <remarks>
/// This struct is very performant, but it is very dangerous (hence breakneck).
/// It's recommended to use the framework-provided locks where possible.
/// </remarks>
/// <typeparam name="TResource">The resource to request.</typeparam>
/// <typeparam name="TParameters">The parameters of the request.</typeparam>
public struct BreakneckRequest<TResource, TParameters>
{
    private int _currentSerial;
    private int _requestedSerial;
    private int _gate;
    private TParameters _params;
    private TResource _result;

    /// <summary>
    /// Requests the resource.
    /// </summary>
    /// <returns>The resource.</returns>
    public TResource Request(TParameters parameters)
    {
        // 1. Get a ticket - we use Interlocked here because there are potentially many threads doing the same.
        var ourTicket = Interlocked.Increment(ref _requestedSerial);

        // 2. Wait in line.
        while (Interlocked.CompareExchange(ref _currentSerial, ourTicket, ourTicket) != ourTicket)
        { }

        // 6. Provide our parameters
        _params = parameters;
        Interlocked.Decrement(ref _gate); // 2 = "I have sent my parameters"

        // 9. Wait for the provider to give us the resource.
        while (_gate != 1) { }

        // 10. Get the result.
        var ret = _result;
        _result = default!;
        Interlocked.Decrement(ref _gate); // 0 = "I have picked up my things"
        return ret;
    }

    /// <summary>
    /// Attempts to retrieve a request.
    /// </summary>
    /// <param name="parameters">The request parameters.</param>
    /// <returns>True if a request was found, false otherwise.</returns>
    /// <remarks>
    /// <see cref="Provide"/> must be called if this function returns <c>true</c>.
    /// </remarks>
    public bool TryGetRequest([NotNullWhen(true)] out TParameters? parameters)
    {
        // 3. Determine whether we have a request to serve
        if (_requestedSerial == _currentSerial)
        {
            parameters = default;
            return false;
        }

        // 4. Wait for the last requester in line to pick up their things.
        while (Interlocked.CompareExchange(ref _gate, 3, 0) != 0) { }

        // 5. Serve the next ticket.
        Interlocked.Increment(ref _currentSerial);

        // 7. Wait for the requester to give us their parameters.
        while (_gate != 2) { }
        parameters = _params!;
        return true;
    }

    /// <summary>
    /// Provides the resource requested.
    /// </summary>
    /// <param name="resource">The resource.</param>
    public void Provide(TResource resource)
    {
        // 8. Provide the result.
        _result = resource;
        Interlocked.Decrement(ref _gate); // 1 = "I now have the resource"
    }
}
