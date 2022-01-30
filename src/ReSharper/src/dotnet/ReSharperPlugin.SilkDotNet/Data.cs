// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Linq;
using JetBrains.Annotations;
using JetBrains.Metadata.Reader.Impl;
using JetBrains.ReSharper.Psi;

namespace ReSharperPlugin.SilkDotNet
{
    internal partial class Data
    {
        [CanBeNull]
        public static Uri FindHelpUrl(IMethod referencedMethod)
        {
            var attributeTypeName = new ClrTypeName("Silk.NET.Core.Native.NativeApiAttribute");
            var attribute = referencedMethod.GetAttributeInstances(attributeTypeName, inherit: true).SingleOrDefault();
            if (attribute is null)
            {
                return null;
            }

            var (_, attributeValue) = attribute.NamedParameters().SingleOrDefault(x => x.First == "EntryPoint");
            var name = attributeValue?.ConstantValue.Value?.ToString();
            if (name is null)
            {
                return null;
            }

            var containingType = referencedMethod.GetContainingType();
            if (containingType is null)
            {
                return null;
            }

            if (!DocumentationUrls.TryGetValue(containingType.GetContainingNamespace().QualifiedName, out var docs))
            {
                return null;
            }

            return docs.TryGetValue(name, out var url) ? new Uri(url) : null;
        }
    }
}
