// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.SilkTouch.Configuration
{
    [Flags]
    public enum ExclusionHint
    {
        None = 0,
        AnonymousFieldHelpers = 1 << 0,
        ComProxies = 1 << 1,
        DefaultRemappings = 1 << 2,
        EmptyRecords = 1 << 3,
        EnumOperators = 1 << 4,
        FunctionsWithBodies = 1 << 5,
        UsingStaticForEnums = 1 << 6,
        AggressiveInlining = 1 << 7,
        CppAttributes = 1 << 8,
        MacroBindings = 1 << 9,
        NativeInheritanceAttribute = 1 << 10,
        TemplateBindings = 1 << 11,
        VTableIndexAttribute = 1 << 12
    }
}
