// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Symbols;
using Silk.NET.SilkTouch.TypeResolution.Annotations;

namespace Silk.NET.SilkTouch.TypeResolution;

/// <summary>
/// A <see cref="SimpleTypeResolverBase"/> that resolves strings of standard C# form
/// </summary>
public class FunctionPointerTypeResolver : SimpleTypeResolverBase
{
    private readonly ILogger _logger;

    /// <inheritdoc />
    public FunctionPointerTypeResolver(ILogger<FunctionPointerTypeResolver> logger, TypeStore typeStore) : base(typeStore)
    {
        _logger = logger;
    }

    /// <inheritdoc />
    protected override bool TryResolve(UnresolvedTypeReference utr, out TypeReference? resolved)
    {
        int c = 0;
        var text = utr.Text;
        if (text.Length > "delegate*".Length && text[text.Length - 1] == '>' && text.Substring(c, "delegate*".Length) == "delegate*")
        {
            _logger.LogTrace("Attempting to resolve {text} to function pointer after passing preliminary tests", utr.Text);
            c += "delegate*".Length;
            if (text.Substring(c, " unmanaged".Length) == " unmanaged")
            {
                c += " unmanaged".Length;
                if (text[c] == '[')
                {
                    var endOffset = text.AsSpan(c).IndexOf(']');
                    
                    var attributeText = text.Substring(c + 1, endOffset - 1);
                    _logger.LogDebug("{text} may be a function pointer and has unhandled attributes {attributes}", utr.Text, attributeText);
                    // TODO: parse out function attributes here
                    
                    c += endOffset + 1;
                }
                var types = new List<TypeReference>();
                if (text[c] == '<')
                {
                    var annotations = ImmutableArray<ISymbolAnnotation>.Empty;
                    c += 1;
                    while (true)
                    {
                        var typeTextEndIndex = text.AsSpan(c).IndexOf(',');
                        if (typeTextEndIndex != -1)
                        {
                            var typeText = text.Substring(c, typeTextEndIndex);
                            c += typeTextEndIndex + 1;
                            if (text[c] == ' ') c++;
                            types.Add(new UnresolvedTypeReference(typeText, annotations));
                        }
                        else
                        {
                            var l = text.Length - c - 1;
                            if (l > 0)
                            {
                                var typeText = text.Substring(c, l);
                                types.Add(new UnresolvedTypeReference(typeText, annotations));
                            }
                            break;
                        }
                    }
                }
                else
                {
                    _logger.LogDebug("{text} may be a function pointer but generic params are somehow scrambled", utr.Text);
                }


                // at least a return type is required
                if (types.Count > 0)
                {
                    resolved = new FunctionPointerTypeReference
                    (
                        types.Last(),
                        types.Take(types.Count - 1).ToImmutableArray(),
                        utr.Annotations.ReplaceOrAdd(x => x is ResolvedFromAnnotation, new ResolvedFromAnnotation(text))
                    );
                    _logger.LogTrace("{text} resolved to function pointer {ptr}", utr.Text, resolved);
                    return true;
                }
            }
            else
            {
                _logger.LogDebug("Rejecting {text} as it may be a function pointer, but not unmanaged", utr.Text);
            }
        }
        resolved = null;
        return false;
    }
}
