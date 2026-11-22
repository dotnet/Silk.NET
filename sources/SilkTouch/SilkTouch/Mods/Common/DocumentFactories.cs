// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Mods;

internal class DocumentFactories : IDocumentFactories
{
    public DocumentFactories(DocumentFactory source, DocumentFactory test)
    {
        Source = source;
        Test = test;
    }

    public DocumentFactory Source { get; }
    public DocumentFactory Test { get; }
}
