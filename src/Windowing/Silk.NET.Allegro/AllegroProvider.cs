// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Allegro
{
    /// <summary>
    /// Singleton providing easy GLFW implementation access.
    /// </summary>
    public static class AllegroProvider
    {
        /// <summary>
        /// Creates a new instance of the GlfwProvider class.
        /// </summary>
        static AllegroProvider()
        {
            Allegro = new Lazy<Allegro>
            (
                () =>
                {
                    var allegro = NET.Allegro.Allegro.GetApi();
                    if (!allegro.Init())
                    {
                        throw new AllegroException("Failed to initialize Allegro.");
                    }

                    return allegro;
                }
            );
        }
        /// <summary>
        /// Gets a GLFW interface implementation lazily.
        /// </summary>
        public static Lazy<Allegro> Allegro { get; internal set; }

        /// <summary>
        /// Unloads the loaded <see cref="Allegro" /> interface implementation.
        /// </summary>
        public static void Unload()
        {
            Allegro = new Lazy<Allegro>
            (
                () =>
                {
                    var allegro = NET.Allegro.Allegro.GetApi();
                    if (!allegro.Init())
                    {
                        throw new AllegroException("Failed to initialize Allegro.");
                    }

                    return allegro;
                }
            );
        }
    }
}