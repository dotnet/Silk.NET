// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Silk.NET.SilkTouch.Symbols;

namespace Silk.NET.SilkTouch.Scraper;

internal sealed class XmlVisitor
{
    private List<Symbol> _symbols = new();

    public IEnumerable<Symbol> Symbols => _symbols;

    public void Visit(XmlNode node)
    {
        switch (node)
        {
            case XmlElement { Name: "bindings" } bindings:
            {
                foreach (var child in bindings.ChildNodes.Cast<XmlNode>())
                {
                    if (child is null) continue;
                    Visit(child);
                }
                break;
            }
            default:
            {
                throw new NotImplementedException();
            }
        }
    }
}
