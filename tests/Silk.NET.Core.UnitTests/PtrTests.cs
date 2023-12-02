using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core.UnitTests;

public class PtrTests
{
    [Test]
    public unsafe void NullIsNull()
    {
        Ptr<nint> ptr = nullptr;
        Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr.Handle)));
        Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr[0])));
        Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr.GetPinnableReference())));
        Assert.True((nint*) ptr is null);
        Assert.True((void*) ptr is null);
    }
}
