// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Reflection;
using Silk.NET.Windowing;

namespace Silk.NET.Input
{
    /// <summary>
    /// Extensions related to input contexts and windows.
    /// </summary>
    public static class InputWindowExtensions
    {
        internal static List<IInputPlatform> _platforms = new List<IInputPlatform>();

        /// <summary>
        /// Gets the input platforms currently registered with the input system.
        /// </summary>
        public static IReadOnlyList<IInputPlatform> Platforms
        {
            get
            {
                if (!_initializedFirstPartyPlatforms)
                {
                    DoLoadFirstPartyPlatformsViaReflection();
                    _initializedFirstPartyPlatforms = true;
                }

                return _platforms;
            }
        }

        private static bool _initializedFirstPartyPlatforms = false;

        public static void ShouldLoadFirstPartyPlatforms(bool shouldLoad)
        {
            if (_initializedFirstPartyPlatforms)
                throw new InvalidOperationException("Input Platforms already loaded, cannot change first party loading");

            _initializedFirstPartyPlatforms = !shouldLoad;
        }
        
        private static void DoLoadFirstPartyPlatformsViaReflection()
        {
            TryAdd("Silk.NET.Input.Glfw");
            TryAdd("Silk.NET.Input.Sdl");
        }

        /// <summary>
        /// Creates an input context for the given view.
        /// </summary>
        /// <param name="view">The view to create an input context for.</param>
        /// <returns>The new input context.</returns>
        /// <exception cref="InvalidOperationException">
        /// Couldn't create input context as the view was not initialized. This occurs when you try to create an InputContext without initializing the view first.
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// Couldn't find a suitable input platform for this view. This occurs when you've created a window/view using
        /// a window platform, but haven't installed
        /// </exception>
        public static IInputContext CreateInput(this IView view)
        {
            if (!view.IsInitialized)
            {
                throw new InvalidOperationException("Couldn't create input context as the view was not initialized.");
            }

            foreach (var inputPlatform in Platforms)
            {
                if (inputPlatform.IsApplicable(view))
                {
                    return inputPlatform.CreateInput(view);
                }
            }

            throw new NotSupportedException("Couldn't find a suitable input platform for this view.");
        }

        /// <summary>
        /// Adds this input platform to the platform list. Shouldn't be used unless writing your own input backend.
        /// </summary>
        /// <param name="platform">The platform to add.</param>
        public static void Add(IInputPlatform platform) => _platforms.Add(platform);

        /// <summary>
        /// Removes this input platform from the platform list. Shouldn't be used unless writing your own input backend.
        /// </summary>
        /// <param name="platform">The platform to remove.</param>
        public static void Remove(IInputPlatform platform) => _platforms.Remove(platform);

        /// <summary>
        /// Attempts to load the given assembly by name, checks for a <see cref="IInputPlatform"/>, if one is found it
        /// is added to the list. Shouldn't be used unless writing your own input backend.
        /// </summary>
        /// <param name="assemblyName">The assembly's name to load.</param>
        /// <returns>Whether the operation was successful.</returns>
        public static bool TryAdd(string assemblyName)
        {
            try
            {
                var asm = Assembly.Load(assemblyName);
                var attr = asm.GetCustomAttribute<InputPlatformAttribute>();
                if (attr is null)
                {
                    return false;
                }

                if (!typeof(IInputPlatform).IsAssignableFrom(attr.Type))
                {
                    return false;
                }

                Add((IInputPlatform) Activator.CreateInstance(attr.Type, true));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
