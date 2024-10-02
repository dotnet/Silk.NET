// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Rename;
using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// A wrapper over the <see cref="Renamer"/> class.
/// </summary>
public class RenameHelper
{
    /// <summary>
    /// The solution to operate on.
    /// </summary>
    public required Project Project { get; set; }

    /// <summary>
    /// The symbol rename options to use.
    /// </summary>
    public required SymbolRenameOptions Options { get; set; }

    /// <summary>
    /// The compilation obtained in the last call to <see cref="RenameSymbolAsync"/>.
    /// </summary>
    public Compilation? Compilation { get; private set; }

    /// <summary>
    /// Renames a symbol and retrieves the new symbol using <see cref="ModUtils.GetNewSymbol"/>.
    /// </summary>
    /// <param name="symbol">The symbol to rename.</param>
    /// <param name="newName">The new name of the symbol.</param>
    /// <param name="cancellationToken">A cancellation token.</param>
    /// <returns>An asynchronous task returning the new symbol.</returns>
    public async Task<ISymbol> RenameSymbolAsync(
        ISymbol symbol,
        string newName,
        CancellationToken cancellationToken = default
    )
    {
        var newProj =
            (
                await Renamer.RenameSymbolAsync(
                    Project.Solution,
                    symbol,
                    Options,
                    newName,
                    cancellationToken
                )
            ).GetProject(Project.Id)
            ?? throw new InvalidOperationException(
                "New solution did not contain the source project!"
            );
        var newComp =
            await newProj.GetCompilationAsync(cancellationToken)
            ?? throw new InvalidOperationException(
                "Couldn't obtain compilation for modified project!"
            );
        var ret = newComp.GetNewSymbol(symbol, newName);
        Project = newProj;
        Compilation = newComp;
        return ret;
    }
}
