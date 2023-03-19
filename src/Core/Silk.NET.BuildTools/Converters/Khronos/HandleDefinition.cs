using System;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

namespace Silk.NET.BuildTools.Converters.Khronos
{
    /// <summary>
    /// The definition of a handle.
    /// </summary>
    public class HandleDefinition
    {
        /// <summary>
        /// The name of this handle.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Whether or not this handle can be dispatched.
        /// </summary>
        public bool CanBeDispatched { get; }
        
        /// <summary>
        /// The parent of this handle.
        /// </summary>
        public string Parent { get; }
        
        /// <summary>
        /// The specific API this handle is applicable to.
        /// </summary>
        public string? Api { get; }

        /// <summary>
        /// Create a new HandleDefinition.
        /// </summary>
        /// <param name="name">The name of this handle.</param>
        /// <param name="canBeDispatched">Whether or not this handle can be dispatched.</param>
        /// <param name="parent">The parent of this handle.</param>
        public HandleDefinition(string name, bool canBeDispatched, string parent, string? api)
        {
            Name = name;
            CanBeDispatched = canBeDispatched;
            Parent = parent;
            Api = api;
        }

        /// <summary>
        /// Create a new handle definition from XML.
        /// </summary>
        /// <param name="xe">The XML to create from.</param>
        /// <returns>A new HandleDefinition.</returns>
        public static HandleDefinition CreateFromXml(XElement xe)
        {
            Require.NotNull(xe);

            if (!(xe.Attribute("alias") is null))
            {
                Debug.Assert(xe.Document != null, "xe.Document != null");
                var ret = CreateFromXml
                (
                    xe.Document.Element("registry")?
                        .Elements("types")
                        .Elements("type")
                        .Where(type => type.HasCategoryAttribute("handle"))
                        .FirstOrDefault(x => x.GetNameElementOrNull() == xe.Attribute("alias")?.Value) ?? throw new Exception("wat")
                );
                
                return new HandleDefinition(xe.GetNameAttribute(), ret.CanBeDispatched, ret.Parent, ret.Api);
            }
            
            var name = xe.GetNameElement();
            var canBeDispatched = xe.GetTypeElement() == "VK_DEFINE_HANDLE";
            var parent = xe.Attribute("parent")?.Value;
            var api = xe.Attribute("api")?.Value;

            return new HandleDefinition(name, canBeDispatched, parent, api);
        }
    }
}
