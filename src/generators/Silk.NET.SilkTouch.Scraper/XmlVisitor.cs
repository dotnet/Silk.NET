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
            case XmlElement { Name: "struct" } @struct:
                return VisitStruct(@struct);
            case XmlElement { Name: "field" } field:
                return VisitField(field);
            default:
            {
                throw new NotImplementedException();
            }
        }
    }

    private IEnumerable<Symbol> VisitField(XmlElement field)
    {
        var name = field.Attributes["name"]?.Value;
        if (name is null)
        {
            throw new InvalidOperationException("Field requires a name");
        }

        // TODO: Appropriately Visit Type.
        var type = new ExternalTypeReference
        (
            null,
            new IdentifierSymbol
            (
                field.ChildNodes.Cast<XmlNode>().SingleOrDefault(x => x.Name == "type")?.InnerText ??
                throw new InvalidOperationException("Could not decode Field Type")
            )
        );

        return new[]
        {
            new FieldSymbol(type, new IdentifierSymbol(name))
        };
    }

    private IEnumerable<Symbol> VisitStruct(XmlElement @struct)
    {
        var fields = new List<FieldSymbol>();
        foreach (var node in @struct.ChildNodes.Cast<XmlNode>())
        {
            var symbols = Visit(node);
            foreach (var v in symbols)
            {
                if (v is FieldSymbol fieldSymbol)
                {
                    fields.Add(fieldSymbol);
                }
            }
        }
        
        return new[]
        {
            new StructSymbol
            (
                new IdentifierSymbol(@struct.Attributes?["name"]?.Value ?? throw new InvalidOperationException()),
                fields.ToImmutableArray()
            )
        };
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
                    .SelectMany(Visit)
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
