using System.Collections.Generic;
using Generator.Common;

namespace Generator.Bind.Overloading
{
    public static class Overloader
    {
        // TODO: Implement overloaders
        public static readonly IFunctionOverloader[] Pipeline = new IFunctionOverloader[0];

        public static IEnumerable<Overload> GetOverloads(Project project)
        {
            // TODO: this could be optimized by implementing parallelism
            foreach (var @interface in project.Interfaces.Values)
            {
                foreach (var function in @interface.Functions)
                {
                    foreach (var overloader in Pipeline)
                    {
                        foreach (var overload in overloader.CreateOverloads(function))
                        {
                            yield return overload;
                        }
                    }
                }
            }
        }
    }
}
