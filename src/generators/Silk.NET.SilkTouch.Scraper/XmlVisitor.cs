// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata;
using System.Xml;
using Silk.NET.SilkTouch.Symbols;

namespace Silk.NET.SilkTouch.Scraper;

internal sealed class XmlVisitor
{
    public IEnumerable<Symbol> Visit(XmlNode node)
    {
        switch (node)
        {
            case XmlElement { Name: "bindings" } bindings:
                return VisitBinding(bindings);
            case XmlElement { Name: "namespace" } @namespace:
                return VisitNamespace(@namespace);
            default:
            {
                throw new NotImplementedException();
            }
        }
    }

    private IEnumerable<Symbol> VisitBinding(XmlElement bindings)
    {
        return bindings.ChildNodes.Cast<XmlNode>().Where(x => x is not null).SelectMany(Visit);
    }

    private IEnumerable<Symbol> VisitNamespace(XmlElement @namespace)
    {
        return new[]
        {
            new NamespaceSymbol
            (
                new IdentifierSymbol(@namespace.Attributes?["name"]?.Value ?? throw new InvalidOperationException()),
                @namespace.ChildNodes.Cast<XmlNode>()
                    .Select(Visit)
                    .Select
                    (
                        x =>
                        {
                            if (x is not TypeSymbol ts) throw new InvalidOperationException();
                            return ts;
                        }
                    )
                    .ToImmutableArray()
            )
        };
    }
}
