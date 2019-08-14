// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using Silk.NET.BuildTools.Common;

namespace Silk.NET.BuildTools.VKXmlConvert
{
    public class VulkanReader
    {
        public IEnumerable<Struct> ReadStructs(XDocument document)
        {
            foreach (var xml in document.Elements("types").Elements("type").Where(x => x.Attribute("category")?.Value == "struct"))
            {
                var @struct = new Struct();
                @struct.NativeName = xml.Attribute("name")?.Value ?? throw new DataException("No name attribute");
                @struct.Name = NativeIdentifierTranslator.TranslateIdentifierName(@struct.NativeName);
                yield return null; //todo
            }
        }
    }
}
