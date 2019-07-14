// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Collections.Generic;

namespace Silk.NET.BuildTools.Pipeline
{
    public class PipelineTask
    {
        public string Task { get; set; }
        public List<string> Args { get; set; }
    }
}
