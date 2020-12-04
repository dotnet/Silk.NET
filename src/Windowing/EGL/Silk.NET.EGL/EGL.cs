using System;
using System.Collections;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.EGL
{
    /// <summary>
    /// Provides access to the EGL API.
    /// </summary>
    public partial class EGL
    {
        /// <summary>
        /// Gets an instance of the API.
        /// </summary>
        /// <returns>The instance.</returns>
        public static EGL GetApi()
        {
            return LibraryLoader<EGL>.Load(new EGLLibraryNameContainer());
        }

        /// <summary>
        /// Try to get an extension.
        /// </summary>
        /// <param name="ext">The extension obtained. If the return value is false, then this is null.</param>
        /// <typeparam name="T">The extension type to check for.</typeparam>
        /// <returns>Whether or not the extension was found. If false, the extension was not found.</returns>
        public bool TryGetExtension<T>(out T ext)
            where T : NativeExtension<EGL>
        {
            ext = LibraryLoader<EGL>.Load<T>(this);
            return ext != null;
        }

        /// <inheritdoc />
        public override bool IsExtensionPresent(string extension)
            => ((IList)QueryStringS(IntPtr.Zero, (int)EGLEnum.Extensions).Split(' ')).Contains("EGL_" + extension);
    }
}

