// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;

namespace Silk.NET.SilkTouch.Configuration
{
    /// <summary>
    /// Represents an exclusion "hint" which tells the subagent to exclude a specific kind of API, construct, or other
    /// element of the bindings process from the generated bindings.
    /// </summary>
    [Flags]
    public enum ExclusionHint
    {
        /// <summary>
        /// Represents an empty hint. Does nothing.
        /// </summary>
        None = 0,
        
        /// <summary>
        /// If set, excludes anonymous field helper code by setting the <c>ExcludeAnonymousFieldHelpers</c> ClangSharp
        /// command line option.
        /// </summary>
        AnonymousFieldHelpers = 1 << 0,
        
        /// <summary>
        /// If set, excludes COM proxies by setting the <c>ExcludeComProxies</c> ClangSharp command line option.
        /// </summary>
        ComProxies = 1 << 1,
        
        /// <summary>
        /// If set, excludes default remappings for well-known types, such as <see cref="IntPtr"/> by setting the
        /// <c>NoDefaultRemappings</c> ClangSharp command line option.
        /// </summary>
        DefaultRemappings = 1 << 2,
        
        /// <summary>
        /// If set, excludes empty records (structs) by setting the <c>ExcludeEmptyRecords</c> ClangSharp command line
        /// option.
        /// </summary>
        EmptyRecords = 1 << 3,
        
        /// <summary>
        /// If set, excludes enum operator code by setting the <c>ExcludeEnumOperators</c> ClangSharp command line
        /// option.
        /// </summary>
        EnumOperators = 1 << 4,
        
        /// <summary>
        /// If set, excludes converting functions with bodies to C# by setting the <c>ExcludeFunctionsWithBody</c>
        /// ClangSharp command line option.
        /// </summary>
        FunctionsWithBodies = 1 << 5,
        
        /// <summary>
        /// If set, excludes function which the ClangSharp subagent deems are safe to enable the
        /// <see cref="MethodImplOptions.AggressiveInlining"/> <see cref="MethodImplOptions"/> for by unsetting the
        /// <c>GenerateAggressiveInlining</c> ClangSharp command line option.
        /// </summary>
        AggressiveInlining = 1 << 7,
        
        /// <summary>
        /// If set, excludes C# attribute representation of C++ attributes by unsetting the <c>GenerateCppAttributes</c>
        /// ClangSharp command line option.
        /// </summary>
        CppAttributes = 1 << 8,
        
        /// <summary>
        /// If set, excludes bindings to macros by unsetting the <c>GenerateMacroBindings</c> ClangSharp command line
        /// option.
        /// </summary>
        MacroBindings = 1 << 9,
        
        /// <summary>
        /// If set, excludes generating C# attributes representing native C++ class inheritance by unsetting the
        /// <c>GenerateNativeInheritanceAttribute</c> ClangSharp command line option.
        /// </summary>
        NativeInheritanceAttribute = 1 << 10,
        
        /// <summary>
        /// If set, excludes generating bindings to C++ templates by unsetting the <c>GenerateTemplateBindings</c>
        /// ClangSharp command line option.
        /// </summary>
        TemplateBindings = 1 << 11,
        
        /// <summary>
        /// If set, excludes generating C# attributes representing VTable indices for functions within a struct
        /// representing a COM interface.
        /// </summary>
        VTableIndexAttribute = 1 << 12
    }
}
