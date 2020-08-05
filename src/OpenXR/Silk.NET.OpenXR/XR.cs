using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;
using ExtensionAttribute = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public partial class XR
    {
        public Instance? CurrentInstance { get; set; }
        public static XR GetApi()
        {
             var ret = LibraryActivator.CreateInstance<XR>(new OpenXRLibraryNameContainer().GetLibraryName());
             ret._extensionLoaders = new XrExtensionLoaderSource(ret);
             return ret;
        }

        [Obsolete("Use IsInstanceExtensionPresent instead.", true)]
        public override bool IsExtensionPresent(string extension) => IsInstanceExtensionPresent(null, extension);
        private Dictionary<string, List<string>> _cachedInstanceExtensions = new Dictionary<string, List<string>>();
        private XrExtensionLoaderSource _extensionLoaders;

        /// <summary>
        /// Attempts to load the given instance extension.
        /// </summary>
        /// <param name="instance">The instance to load the extension from.</param>
        /// <param name="ext">The loaded instance extension, or null if load failed.</param>
        /// <typeparam name="T">The instance extension to load.</typeparam>
        /// <remarks>
        /// This function doesn't check that the extension is enabled - you will get an error later on if you attempt
        /// to call an extension function from an extension that isn't loaded.
        /// </remarks>
        /// <returns>Whether the extension is available and loaded.</returns>
        public bool TryGetInstanceExtension<T>(string layer, Instance instance, out T ext) where T:NativeExtension<XR> =>
            !((ext = IsInstanceExtensionPresent(layer, ExtensionAttribute.GetExtensionAttribute(typeof(T)).Name)
                ? LibraryActivator.CreateInstance<T>
                    (SearchPaths.GetLibraryName(), _extensionLoaders.Get(instance))
                : null) is null);

        /// <summary>
        /// Checks whether the given instance extension is available.
        /// </summary>
        /// <param name="extension">The instance extension name.</param>
        /// <returns>Whether the instance extension is available.</returns>
        public unsafe bool IsInstanceExtensionPresent(string layer, string extension)
        {
            layer ??= string.Empty;
            if (_cachedInstanceExtensions.TryGetValue(layer, out var val))
            {
                return val.Contains(extension);
            }

            var l = new List<string>();
            if (string.IsNullOrWhiteSpace(layer))
            {
                Add(l, null);
            }
            else
            {
                var layerName = SilkMarshal.MarshalStringToPtr(layer);
                Add(l, (byte*) layerName);
                SilkMarshal.FreeStringPtr(layerName);
            }

            _cachedInstanceExtensions[layer] = l;

            return l.Contains(extension);
        }

        private unsafe void Add(ICollection<string> extensions, byte* layerName)
        {
            var extensionCount = 0u;
            EnumerateInstanceExtensionProperties(layerName, extensionCount, &extensionCount, null);
            var exts = stackalloc ExtensionProperties[(int)extensionCount];
            EnumerateInstanceExtensionProperties(layerName, extensionCount, &extensionCount, exts);
            for (var i = 0; i < extensionCount; i++)
            {
                extensions.Add(Marshal.PtrToStringAnsi((IntPtr) exts[i].ExtensionName));
            }
        }
    }
}

