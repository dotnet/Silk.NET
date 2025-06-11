// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Silk.NET.Input;

/// <summary>
/// An internal class that represents a list of <see cref="InputContext.Devices"/> that are assignable to
/// <typeparamref name="T"/>. The backing list is lazily initialized.
/// </summary>
/// <typeparam name="T">The device type.</typeparam>
/// <remarks>
/// This type is not intended for public consumption and has no API/ABI stability guarantees.
/// </remarks>
[Experimental(
    "ST0005",
    UrlFormat = "https://dotnet.github.io/Silk.NET/docs/v3/silk.net/diagnostics/{0}"
)]
public abstract class InputContextDeviceList<T> : IReadOnlyList<T>, IInputHandler
{
    private readonly InputContext _ctx;
    private List<T>? _list;

    internal InputContextDeviceList(InputContext ctx) => _ctx = ctx;

    private List<T> List => _list ??= _ctx.Devices.OfType<T>().ToList();

    /// <inheritdoc />
    public IEnumerator<T> GetEnumerator() => throw new NotImplementedException();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    /// <inheritdoc />
    public int Count => List.Count;

    /// <inheritdoc />
    public T this[int index] => List[index];

    void IInputHandler.HandleDeviceConnectionChanged(ConnectionEvent @event) =>
        HandleDeviceConnectionChanged(@event);

    /// <inheritdoc cref="IInputHandler.HandleDeviceConnectionChanged"/>
    protected internal virtual void HandleDeviceConnectionChanged(ConnectionEvent @event)
    {
        if (_list is null || @event.Device is not T t)
        {
            return;
        }

        if (@event.IsConnected)
        {
            _list.Add(t);
        }
        else
        {
            _list.Remove(t);
        }
    }
}
