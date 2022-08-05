// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata;
using System.Xml;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Symbols;
using TypeReference=Silk.NET.SilkTouch.Symbols.TypeReference;

namespace Silk.NET.SilkTouch.Scraper;

internal sealed class XmlVisitor
{
    private readonly ILogger _logger;
    public XmlVisitor(ILogger logger) {
        _logger = logger;
    }

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

        var typeNode = field.ChildNodes.Cast<XmlNode>().SingleOrDefault(x => x.Name == "type") as XmlElement;
        if (typeNode is null)
            throw new InvalidOperationException("Field type cannot be null");

        TypeReference? finalType = null;
        foreach (var type in VisitType(typeNode))
        {
            if (type is null)
            {
                throw new InvalidOperationException
                (
                    $"{nameof(XmlVisitor)}.{nameof(VisitType)} has returned null"
                );
            }
            
            if (type is not TypeReference tr)
            {
                throw new InvalidOperationException
                (
                    $"{nameof(XmlVisitor)}.{nameof(VisitType)} has returned something other then a type reference"
                );
            }

            if (finalType is not null)
            {
                throw new InvalidOperationException
                    ($"{nameof(XmlVisitor)}.{nameof(VisitType)} has returned more then one result");
            }

            finalType = tr;
        }

        if (finalType is null)
        {
            throw new InvalidOperationException
                ($"No type could be resolved from {typeNode.OuterXml}");
        }

        return new[]
        {
            new FieldSymbol(finalType, new IdentifierSymbol(name))
        };
    }
    
    // TODO: Configurable Type maps
    private static readonly Dictionary<string, TypeReference> _typeMap = new()
    {
        ["int"] = new ExternalTypeReference(null, new IdentifierSymbol("int"))
    };
    
    private bool TryResolveTypeRef(string text, [NotNullWhen(true)] out TypeReference? reference)
    {
        if (_typeMap.TryGetValue(text, out reference))
        {
            return true;
        }
        else
        {
            _logger.LogDebug("Failed to resolve type reference from \"{text}\"", text);
            return false;
        }
    }

    // NOTE: This does not visit types as in class/struct, but visits *references* to types. Like from methods or fields.
    private IEnumerable<Symbol> VisitType(XmlElement type)
    {
        return
            TryResolveTypeRef(type.InnerText, out var r)
                ? new[] { r }
                : Array.Empty<Symbol>();
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
