// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Windowing;
using Silk.NET.Windowing.Glfw;

namespace Silk.NET.Input.Glfw
{
    public static class GlfwInput
    {
        public static void RegisterPlatform()
        {
            Window.Add(new GlfwPlatform());
            InputWindowExtensions.Add(new GlfwInputPlatform());
        }
    }
}
