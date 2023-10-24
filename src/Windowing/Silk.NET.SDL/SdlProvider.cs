// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;

namespace Silk.NET.SDL
{
    /// <summary>
    /// Singleton providing easy SDL implementation access.
    /// </summary>
    public static class SdlProvider
    {
        /// <summary>
        /// The flags with which to initialize SDL.
        /// </summary>
        public static uint InitFlags { get; set; } = //Sdl.InitTimer |
            //Sdl.InitAudio |
            Sdl.InitVideo |
            Sdl.InitJoystick |
            Sdl.InitHaptic |
            Sdl.InitGamecontroller |
            Sdl.InitEvents;
        //Sdl.InitSensor |
        //Sdl.InitNoparachute;

        /// <summary>
        /// Gets or sets a value indicating whether the lazy loader should call <see cref="Sdl.SetMainReady" />.
        /// </summary>
        public static bool SetMainReady { get; set; }

        /// <summary>
        /// Creates a new instance of the GlfwProvider class.
        /// </summary>
        static SdlProvider()
        {
            UninitializedSDL = new Lazy<Sdl>(() =>
                {
                    Console.WriteLine("HI THERE: " + SearchPathContainer.Platform);
                    return SearchPathContainer.Platform == UnderlyingPlatform.Browser
                        ? Sdl.PleaseDontTryThisAtHomeGetApi()
                        : Sdl.GetApi();
                }
            );
            SDL = new Lazy<Sdl>(GetSdl);
        }

        private static Sdl GetSdl()
        {
            var sdl = UninitializedSDL.Value;
            if (SetMainReady)
            {
                sdl.SetMainReady();
            }

            #if DEBUG
            Console.WriteLine("SDL initialized.");
            #endif

            //Disable haptic support on the web
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Create("BROWSER")))
            {
                InitFlags &= ~Sdl.InitHaptic;
            }

            if (sdl.Init(InitFlags) != 0)
            {
                sdl.ThrowError();
            }

            return sdl;
        }

        /// <summary>
        /// Gets a SDL interface implementation lazily, without calling SDL_Init.
        /// </summary>
        public static Lazy<Sdl> UninitializedSDL { get; internal set; }

        /// <summary>
        /// Gets a SDL interface implementation lazily.
        /// </summary>
        public static Lazy<Sdl> SDL { get; internal set; }

        /// <summary>
        /// Unloads the loaded <see cref="SDL" /> interface implementation.
        /// </summary>
        public static void Unload()
        {
            SDL.Value.Quit();
            SDL.Value.Dispose();
            UninitializedSDL = new Lazy<Sdl>(() =>
                {
                    Console.WriteLine("HI THERE: " + SearchPathContainer.Platform);
                    return SearchPathContainer.Platform == UnderlyingPlatform.Browser
                        ? Sdl.PleaseDontTryThisAtHomeGetApi()
                        : Sdl.GetApi();
                }
            );
            SDL = new Lazy<Sdl>(GetSdl);
        }
    }
}
