// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SDL;

if (!Sdl.Init(Sdl.InitVideo))
{
    throw new Exception($"SDL failed to initialize: {Sdl.GetError().ReadToString()}");
}

var window = Sdl.CreateWindow("Silk.NET.SDL - Hello Window", 800, 600, Sdl.WindowResizable);
if (window == nullptr)
{
    throw new Exception("Failed to create window");
}

try
{
    var renderer = Sdl.CreateRenderer(window, nullptr);
    {
        var shouldRun = true;
        while (shouldRun)
        {
            var e = default(Event);
            Sdl.PollEvent(e.AsRef());

            if (e.Type == (uint)EventType.Quit)
            {
                shouldRun = false;
            }

            Sdl.SetRenderDrawColor(renderer, 0, 255, 0, 255);
            Sdl.RenderClear(renderer);
            Sdl.RenderPresent(renderer);
        }
    }
    Sdl.DestroyWindow(window);
}
finally
{
    Sdl.Quit();
}
