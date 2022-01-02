// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// Convenience wrapper for easily creating a Silk.NET window.
    /// </summary>
    public static class Window
    {
        private const string GlfwBackendNamespace = "Silk.NET.Windowing.Glfw";
        private const string SdlBackendNamespace = "Silk.NET.Windowing.Sdl";
        private const string GlfwBackendName = "GlfwPlatform";
        private const string SdlBackendName = "SdlPlatform";
        private const string FallbackWindowClass = "Silk.NET";

        private static List<Type> _platformsKeys = new List<Type>();
        private static List<IWindowPlatform> _platformsValues = new List<IWindowPlatform>();

        private static bool _initializedFirstPartyPlatforms = false;

        internal static string DefaultWindowClass { get; }

        static Window()
        {
            var defaultWindowClassName = Process.GetCurrentProcess().MainModule?.ModuleName;
            if (defaultWindowClassName is not null)
            {
                DefaultWindowClass = Path.GetFileNameWithoutExtension(defaultWindowClassName);
                return;
            }

            DefaultWindowClass = Assembly.GetEntryAssembly()?.GetName()?.Name ?? FallbackWindowClass;
        }

        public static IReadOnlyCollection<IWindowPlatform> Platforms
        {
            get
            {
                if (!_initializedFirstPartyPlatforms)
                {
                    DoLoadFirstPartyPlatformsViaReflection();
                    _initializedFirstPartyPlatforms = true;
                }

                return _platformsValues;
            }
        }

        public static void ShouldLoadFirstPartyPlatforms(bool shouldLoad)
        {
            if (_initializedFirstPartyPlatforms)
                throw new InvalidOperationException("Window Platforms already loaded, cannot change first party loading");

            _initializedFirstPartyPlatforms = !shouldLoad;
        }
        
        private static void DoLoadFirstPartyPlatformsViaReflection()
        {
            // Try add the first-party backends
            TryAdd(GlfwBackendNamespace);
            TryAdd(SdlBackendNamespace);
        }

        internal static Exception NoPlatformException => new PlatformNotSupportedException
        (
            "Couldn't find a suitable window platform. " +
            "https://docs.ultz.co.uk/silk.net/windowing/troubleshooting.html"
        );

        /// <summary>
        /// Gets the first platform registered that is applicable and isn't view-only.
        /// </summary>
        /// <returns>The first platform registered that is applicable and isn't view-only.</returns>
        public static IWindowPlatform? GetWindowPlatform(bool viewOnly)
        {
            foreach (var windowPlatform in Platforms)
            {
                if (windowPlatform.IsApplicable && (!viewOnly || windowPlatform.IsViewOnly))
                {
                    return windowPlatform;
                }
            }

            return null;
        }

        /// <summary>
        /// Gets whether this platform only supports window views. If false, this means that you may use desktop
        /// functionality with your applications.
        /// </summary>
        public static bool IsViewOnly
        {
            get
            {
                foreach (var windowPlatform in Platforms)
                {
                    if (windowPlatform.IsApplicable && !windowPlatform.IsViewOnly)
                    {
                        return false;
                    }
                }

                return true;
            }
        }

        /// <summary>
        /// Create a window on the current platform.
        /// </summary>
        /// <param name="options">The window to use.</param>
        /// <returns>A Silk.NET window using the current platform.</returns>
        public static IWindow Create(WindowOptions options)
        {
            if (Platforms.Count == 0)
            {
                throw NoPlatformException;
            }

            if (IsViewOnly)
            {
                throw new NotSupportedException
                (
                    "The currently bound window platform(s) only support views, " +
                    "instead of windows. Use the view APIs instead."
                );
            }

            foreach (var platform in Platforms)
            {
                if (platform.IsViewOnly)
                {
                    continue;
                }

                // ReSharper disable once PossibleNullReferenceException
                return platform.CreateWindow(options);
            }

            throw NoPlatformException;
        }

        /// <summary>
        /// Create a view on the current platform.
        /// </summary>
        /// <param name="options">The window to use.</param>
        /// <returns>A Silk.NET window using the current platform.</returns>
        public static IView GetView(ViewOptions? options = null)
        {
            foreach (var platform in Platforms)
            {
                if (platform.IsApplicable)
                {
                    return platform.GetView(options);
                }
            }

            throw NoPlatformException;
        }

        /// <summary>
        /// Clears all current contexts for this backend on the current thread.
        /// </summary>
        public static void ClearCurrentContexts(IView view)
        {
            foreach (var platform in Platforms)
            {
                if (platform.IsSourceOfView(view))
                {
                    platform.ClearContexts();
                }
            }
        }

        // Registrar functions

        /// <summary>
        /// Adds/moves this window platform to the top of the platform list, to ensure that <see cref="Window"/>
        /// functions check/use the provided platform first.
        /// </summary>
        public static void Prioritize(IWindowPlatform platform)
        {
            Remove(platform);
            _platformsKeys.Insert(0, platform.GetType());
            _platformsValues.Insert(0, platform);
        }

        /// <summary>
        /// If added, moves the GLFW platform to the top of the platform list, to ensure that <see cref="Window"/>
        /// functions check/use the provided platform first.
        /// </summary>
        public static void PrioritizeGlfw()
        {
            var platform = Platforms.FirstOrDefault
                (x => x.GetType().FullName == GlfwBackendNamespace + "." + GlfwBackendName);
            if (platform is null)
            {
                return;
            }

            Prioritize(platform);
        }

        /// <summary>
        /// If added, moves the SDL platform to the top of the platform list, to ensure that <see cref="Window"/>
        /// functions check/use the provided platform first.
        /// </summary>
        public static void PrioritizeSdl()
        {
            var platform = Platforms.FirstOrDefault
                (x => x.GetType().FullName == SdlBackendNamespace + "." + SdlBackendName);
            if (platform is null)
            {
                return;
            }

            Prioritize(platform);
        }

        /// <summary>
        /// Adds this window platform to the platform list. Shouldn't be used unless writing your own windowing backend.
        /// </summary>
        /// <param name="platform">The platform to add.</param>
        public static void Add(IWindowPlatform platform)
        {
            if (!_platformsKeys.Contains(platform.GetType()))
            {
                _platformsKeys.Add(platform.GetType());
                _platformsValues.Add(platform);
            }
        }

        /// <summary>
        /// Removes this window platform from the platform list. Shouldn't be used unless writing your own windowing backend.
        /// </summary>
        /// <param name="platform">The platform to remove.</param>
        public static void Remove(IWindowPlatform platform)
        {
            var index = _platformsKeys.IndexOf(platform.GetType());
            if (index != -1)
            {
                _platformsKeys.RemoveAt(index);
                _platformsValues.RemoveAt(index);
            }
        }

        /// <summary>
        /// Attempts to load the given assembly by name, checks for a <see cref="IWindowPlatform"/>, if one is found it
        /// is added to the list. Shouldn't be used unless writing your own windowing backend.
        /// </summary>
        /// <param name="assemblyName">The assembly's name to load.</param>
        /// <returns>Whether the operation was successful.</returns>
        public static bool TryAdd(string assemblyName)
        {
            try
            {
                var asm = Assembly.Load(assemblyName);
                var attr = asm.GetCustomAttribute<WindowPlatformAttribute>();
                if (attr is null)
                {
                    return false;
                }

                if (!typeof(IWindowPlatform).IsAssignableFrom(attr.Type))
                {
                    return false;
                }

                Add((IWindowPlatform) Activator.CreateInstance(attr.Type, true));
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the instance of the given window platform type if added, or <c>default</c> if the window platform is
        /// not registered with <see cref="Platforms"/>.
        /// </summary>
        /// <typeparam name="T">The type of the window platform to get.</typeparam>
        /// <returns>The instance of the window platform type or <c>default</c></returns>
        public static T? GetOrDefault<T>() where T : class, IWindowPlatform
            => _platformsKeys.Contains(typeof(T)) ? (T)_platformsValues[_platformsKeys.IndexOf(typeof(T))] : default;
    }
}
