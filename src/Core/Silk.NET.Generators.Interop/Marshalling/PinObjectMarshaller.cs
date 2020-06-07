// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System.Linq;

namespace Silk.NET.Generators.Interop.Marshalling
{
    public class PinObjectMarshaller : IMarshaller
    {
        public void Marshal(in MethodMarshalContext ctx)
        {
            var args = ctx.Method.Parameters.Where(x => x.Attributes.Any(y => y.Name == "PinObjectAttribute"));
            foreach (var parameter in args)
            {
                if (parameter.Attributes.First(x => x.Name == "PinObjectAttribute").Arguments.LastOrDefault()?
                    .EndsWith("UntilNextCall") ?? false)
                {
                    ctx.Writer.AppendLine($"GcUtility.PinUntilNextCall({parameter.Name}, $SLOT$);");
                }
                else
                {
                    ctx.Writer.AppendLine($"GcUtility.Pin({parameter.Name}, $SLOT$);");
                }
            }

            ctx.WriteNativeCall(ctx.Method, ctx.Writer);
        }
    }
}
