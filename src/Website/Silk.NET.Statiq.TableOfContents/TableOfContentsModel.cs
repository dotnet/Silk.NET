﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Statiq.TableOfContents
{
    public record TableOfContentsModel
    (
        TableOfContentsElement Root,
        TableOfContentsElement? Node
    );
}