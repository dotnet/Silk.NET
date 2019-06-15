using System.Text;
using Generator.Common.Functions;

namespace Generator.Bind.Overloading
{
    public class Overload
    {
        public Overload()
        {
            
        }

        public Overload(Function sig, StringBuilder code, bool @unsafe = false)
        {
            Signature = sig;
            CodeBlock = code.ToString();
            Unsafe = @unsafe;
        }
        
        public Function Signature { get; set; }

        public string CodeBlock { get; set; }
        
        public bool Unsafe { get; set; }
    }
}
