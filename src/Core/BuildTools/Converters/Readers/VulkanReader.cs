// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis.CSharp;
using MoreLinq.Extensions;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Common.Structs;
using Vk.Generator;
using Attribute = Silk.NET.BuildTools.Common.Attribute;
using Enum = Silk.NET.BuildTools.Common.Enums.Enum;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Converters.Readers
{
    public class VulkanReader : IReader
    {
        public object Load(Stream stream)
        {
            return VulkanSpecification.LoadFromXmlStream(stream);
        }

        public IEnumerable<Struct> ReadStructs(object obj, ProfileConverterOptions opts)
        {
            var spec = (VulkanSpecification) obj;
        }

        private Dictionary<string, Struct> ConvertStructs(VulkanSpecification spec)
        {
            
        }

        public IEnumerable<Function> ReadFunctions(object obj, ProfileConverterOptions opts)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Enum> ReadEnums(object obj, ProfileConverterOptions opts)
        {
            throw new NotImplementedException();
        }
    }
}
