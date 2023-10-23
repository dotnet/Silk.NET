// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagMKREDUCE")]
    public enum MKRREDUCE : int
    {
        [Obsolete("Deprecated in favour of \"One\"")]
        [NativeName("Name", "MKRREDUCE_ONE")]
        MkrreduceOne = 0x30000,
        [Obsolete("Deprecated in favour of \"Touser\"")]
        [NativeName("Name", "MKRREDUCE_TOUSER")]
        MkrreduceTouser = 0x20000,
        [Obsolete("Deprecated in favour of \"Throughuser\"")]
        [NativeName("Name", "MKRREDUCE_THROUGHUSER")]
        MkrreduceThroughuser = 0x10000,
        [Obsolete("Deprecated in favour of \"All\"")]
        [NativeName("Name", "MKRREDUCE_ALL")]
        MkrreduceAll = 0x0,
        [NativeName("Name", "MKRREDUCE_ONE")]
        One = 0x30000,
        [NativeName("Name", "MKRREDUCE_TOUSER")]
        Touser = 0x20000,
        [NativeName("Name", "MKRREDUCE_THROUGHUSER")]
        Throughuser = 0x10000,
        [NativeName("Name", "MKRREDUCE_ALL")]
        All = 0x0,
    }
}
