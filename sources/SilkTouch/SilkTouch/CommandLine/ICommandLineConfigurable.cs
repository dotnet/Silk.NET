// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.CommandLine;
using System.CommandLine.Invocation;

namespace Silk.NET.SilkTouch.CommandLine;

/// <summary>
/// Provides a way to register command line options and read them after they have been parsed.
/// </summary>
public interface ICommandLineConfigurable
{
    /// <summary>
    /// Registers the command line options through the provided callback.
    /// </summary>
    /// <remarks>
    /// Options are recommended to be statically defined so they can be deduplicated.
    /// </remarks>
    public void RegisterCommandLineOptions(Action<Option> register);

    /// <summary>
    /// Reads the command line options from the provided context.
    /// </summary>
    public void ReadCommandLineOptions(InvocationContext ctx);
}
