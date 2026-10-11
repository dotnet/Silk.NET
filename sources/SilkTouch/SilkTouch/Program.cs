// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch;

internal static class Program
{
    public static async Task Main(string[] args) => await SilkTouchHost.Create().RunAsync(args);
}
