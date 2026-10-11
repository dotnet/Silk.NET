// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Jobs;

internal static class Program
{
    public static Task Main(string[] args) =>
        SilkTouchHost
            .Create()
            .DefineMicrosoftJob()
            .DefineOpenALJob()
            .DefineOpenCLJob()
            .DefineOpenGLJob()
            .DefineOpenXRJob()
            .DefineSDLJob()
            .DefineVulkanJob()
            .RunAsync(args);
}
