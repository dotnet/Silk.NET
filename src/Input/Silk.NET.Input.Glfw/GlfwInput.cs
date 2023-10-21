// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq;
using Silk.NET.Windowing.Glfw;

namespace Silk.NET.Input.Glfw
{
    public static class GlfwInput
    {
        public static void RegisterPlatform()
        {
            GlfwWindowing.RegisterPlatform(); // just in case it's not already
            if (!InputWindowExtensions._platforms.OfType<GlfwInputPlatform>().Any())
            {
                InputWindowExtensions.Add(new GlfwInputPlatform());
            }
        }
    }
}
