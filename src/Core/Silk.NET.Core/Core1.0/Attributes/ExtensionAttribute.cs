// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Reflection;

namespace Silk.NET.Core.Attributes
{
    public class ExtensionAttribute : Attribute
    {
        public ExtensionAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public static ExtensionAttribute GetExtensionAttribute(MemberInfo type)
        {
            return type.GetCustomAttribute<ExtensionAttribute>();
        }
    }
}