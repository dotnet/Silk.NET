// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;
using System.IO;
using System.Text;
using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common
{
    public class ImplementedFunction
    {
        public ImplementedFunction()
        {
        }
        public ImplementedFunction(Function function, StringBuilder sb, Function @base, bool b = true)
        {
            Signature = function;
            using var sr = new StringReader(sb.ToString());
            string line;
            var lines = new List<string>();
            while ((line = sr.ReadLine()) != null)
            {
                lines.Add(line);
            }

            Body = lines.ToArray();
            IsUnsafe = b;
            Base = @base;
        }

        public Function Signature { get; set; }
        public Function Base { get; set; }
        public string[] Body { get; set; }
        public bool IsUnsafe { get; set; }
    }
}
