// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.SDL
{
    /// <summary>
    /// Singleton providing easy GLFW implementation access.
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
            SDL = new Lazy<Sdl>
            (
                () =>
                {
                    var sdl = Sdl.GetApi();
                    if (SetMainReady)
                    {
                        sdl.SetMainReady();
                    }

                    sdl.Init(InitFlags);
                    sdl.ThrowError();

                    return sdl;
                }
            );
        }

        /// <summary>
        /// Gets a GLFW interface implementation lazily.
        /// </summary>
        public static Lazy<Sdl> SDL { get; internal set; }

        /// <summary>
        /// Unloads the loaded <see cref="SDL" /> interface implementation.
        /// </summary>
        public static void Unload()
        {
            SDL.Value.Quit();
            SDL = new Lazy<Sdl>
            (
                () =>
                {
                    var sdl = Sdl.GetApi();
                    if (SetMainReady)
                    {
                        sdl.SetMainReady();
                    }

                    sdl.Init(InitFlags);
                    sdl.ThrowError();

                    return sdl;
                }
            );
        }
    }
}
