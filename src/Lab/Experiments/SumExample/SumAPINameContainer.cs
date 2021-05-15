// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Core.Loader;

namespace SumExample
{
    internal class SumAPINameContainer : SearchPathContainer
    {
        public override string Windows64 => "lib/win-x64/SumC.dll";
        public override string Windows86 => "lib/win-x86/SumC.dll";
        public override string Linux => "lib/linux/libSumC.so";
        public override string MacOS => throw new PlatformNotSupportedException("Unfortunately no MacOS build exists.");
    }
}
