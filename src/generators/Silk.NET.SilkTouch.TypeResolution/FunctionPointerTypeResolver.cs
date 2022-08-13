// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using System.Text.RegularExpressions;
using Silk.NET.SilkTouch.Symbols;

namespace Silk.NET.SilkTouch.TypeResolution;

/// <summary>
/// A <see cref="SimpleTypeResolverBase"/> that resolves strings of standard C# form
/// </summary>
public class FunctionPointerTypeResolver : SimpleTypeResolverBase
{
    private static readonly Regex _regex = new
    (/*lang=regex*/
        @"delegate\*\sunmanaged(\[((?'modifier'.(?=,\s?)?)+)*\])?\<((?'parameter'(.(?=,\s?)+))(,\s?))*(?'return_type'(.)+)\>",
        RegexOptions.CultureInvariant
    );

    /// <inheritdoc />
    public FunctionPointerTypeResolver(TypeStore typeStore) : base(typeStore)
    {
    }

    /// <inheritdoc />
    protected override bool TryResolve(UnresolvedTypeReference utr, out TypeReference? resolved)
    {
        if (utr.Text.StartsWith("delegate*"))
        {
            var match = _regex.Match(utr.Text);
            if (match.Success)
            {
                var parameters = match.Groups["parameter"]
                    .Captures.OfType<Capture>()
                    .Select(x => new UnresolvedTypeReference(x.Value))
                    .Cast<TypeReference>()
                    .ToImmutableArray();
                var returnType = new UnresolvedTypeReference(match.Groups["return_type"].Value);

                resolved = new FunctionPointerTypeReference(returnType, parameters);
                return true;
            }
        }
        resolved = null;
        return false;
    }
}
