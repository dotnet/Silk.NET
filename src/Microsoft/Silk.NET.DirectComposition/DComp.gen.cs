// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DirectComposition
{
    public unsafe partial class DComp
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "__REQUIRED_RPCNDR_H_VERSION__")]
        public const int RequiredRpcndrHVersion = unchecked((int) 0x1DB);
        [NativeName("Type", "int")]
        [NativeName("Name", "__REQUIRED_RPCSAL_H_VERSION__")]
        public const int RequiredRpcsalHVersion = unchecked((int) 0x64);
        [NativeName("Type", "long")]
        [NativeName("Name", "COMPOSITIONOBJECT_READ")]
        public const int CompositionobjectRead = unchecked((int) 0x1);
        [NativeName("Type", "long")]
        [NativeName("Name", "COMPOSITIONOBJECT_WRITE")]
        public const int CompositionobjectWrite = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "DCOMPOSITION_MAX_WAITFORCOMPOSITORCLOCK_OBJECTS")]
        public const int MaxWaitforcompositorclockObjects = unchecked((int) 0x20);
        [NativeName("Type", "int")]
        [NativeName("Name", "COMPOSITION_STATS_MAX_TARGETS")]
        public const int CompositionStatsMaxTargets = unchecked((int) 0x100);

    }
}

