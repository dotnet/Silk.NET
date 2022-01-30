// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch
{
    public readonly struct OverrideContext
    {
        public OverrideContext(string name, string lib, EntryPoint[] entrypoints, bool isNet5OrGreater)
            => (Name, Library, EntryPoints, IsNet5OrGreater) = (name, lib, entrypoints, isNet5OrGreater);
        public string Name { get; }
        public string Library { get; }
        public EntryPoint[] EntryPoints { get; }
        public bool IsNet5OrGreater { get; }
    }
}
