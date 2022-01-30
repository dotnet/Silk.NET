// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using JetBrains.Application;
using JetBrains.ReSharper.Feature.Services.OnlineHelp;
using JetBrains.ReSharper.Psi;

namespace ReSharperPlugin.SilkDotNet
{
    [ShellComponent]
    public class SilkNetCompiledElementOnlineHelpProvider : CompiledElementOnlineHelpProvider
    {
        public override Uri GetUrl(ICompiledElement element)
            => element is IMethod method ? Data.FindHelpUrl(method) : null;

        public override bool IsAvailable(IDeclaredElement element)
            => element is IMethod method && Data.FindHelpUrl(method) is not null;

        public override int Priority => 10;
        public override bool ShouldValidate => true;
    }
}
