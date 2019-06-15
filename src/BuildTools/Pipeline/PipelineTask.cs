using System.Collections.Generic;

namespace Silk.NET.BuildTools.Pipeline
{
    public class PipelineTask
    {
        public string Task { get; set; }
        public List<string> Args { get; set; }
    }
}
