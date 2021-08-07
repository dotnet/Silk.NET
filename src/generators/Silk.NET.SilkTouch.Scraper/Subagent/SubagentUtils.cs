// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using ClangSharp;
using Silk.NET.SilkTouch.Configuration;

namespace Silk.NET.SilkTouch.Scraper.Subagent
{
    internal static class SubagentUtils
    {
        public static PInvokeGeneratorConfigurationOptions GetOptions(ExclusionHint hints, bool unixMode)
        {
            var opts = PInvokeGeneratorConfigurationOptions.None;
            
            // If these hints are defined, define the corresponding ClangSharp exclusion option.
            if ((hints & ExclusionHint.ComProxies) != 0)
            {
                opts |= PInvokeGeneratorConfigurationOptions.ExcludeComProxies;
            }

            if ((hints & ExclusionHint.DefaultRemappings) != 0)
            {
                opts |= PInvokeGeneratorConfigurationOptions.NoDefaultRemappings;
            }

            if ((hints & ExclusionHint.EmptyRecords) != 0)
            {
                opts |= PInvokeGeneratorConfigurationOptions.ExcludeEmptyRecords;
            }

            if ((hints & ExclusionHint.EnumOperators) != 0)
            {
                opts |= PInvokeGeneratorConfigurationOptions.ExcludeEnumOperators;
            }

            if ((hints & ExclusionHint.AnonymousFieldHelpers) != 0)
            {
                opts |= PInvokeGeneratorConfigurationOptions.ExcludeAnonymousFieldHelpers;
            }

            if ((hints & ExclusionHint.FunctionsWithBodies) != 0)
            {
                opts |= PInvokeGeneratorConfigurationOptions.ExcludeFunctionsWithBody;
            }

            if ((hints & ExclusionHint.UsingStaticForEnums) != 0)
            {
                opts |= PInvokeGeneratorConfigurationOptions.DontUseUsingStaticsForEnums;
            }

            // If these hints are not defined, define the corresponding ClangSharp inclusion option.
            if ((hints & ExclusionHint.MacroBindings) == 0)
            {
                opts |= PInvokeGeneratorConfigurationOptions.GenerateMacroBindings;
            }

            if (((hints & ExclusionHint.AggressiveInlining) == 0))
            {
                opts |= PInvokeGeneratorConfigurationOptions.GenerateAggressiveInlining;
            }

            if ((hints & ExclusionHint.CppAttributes) == 0)
            {
                opts |= PInvokeGeneratorConfigurationOptions.GenerateCppAttributes;
            }

            if ((hints & ExclusionHint.NativeInheritanceAttribute) == 0)
            {
                opts |= PInvokeGeneratorConfigurationOptions.GenerateNativeInheritanceAttribute;
            }

            if ((hints & ExclusionHint.TemplateBindings) == 0)
            {
                opts |= PInvokeGeneratorConfigurationOptions.GenerateTemplateBindings;
            }

            if ((hints & ExclusionHint.VTableIndexAttribute) == 0)
            {
                opts |= PInvokeGeneratorConfigurationOptions.GenerateVtblIndexAttribute;
            }

            if (unixMode)
            {
                opts |= PInvokeGeneratorConfigurationOptions.GenerateUnixTypes;
            }

            opts |= PInvokeGeneratorConfigurationOptions.LogExclusions;
            opts |= PInvokeGeneratorConfigurationOptions.LogVisitedFiles;
            return opts;
        }
    }
}
