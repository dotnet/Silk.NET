// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
        public ImplementedFunction(Function function, StringBuilder sb, bool b = true)
        {
            Signature = function;
            Body = sb.ToString().Split('\n');
            IsUnsafe = b;
        }

        public Function Signature { get; set; }
        public string[] Body { get; set; }
        public bool IsUnsafe { get; set; }
    }
}
