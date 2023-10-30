using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core.UnitTests;

public class Ptr2DTests
{
    [Test]
    public unsafe void NullIsNull()
    {
        Ptr2D<nint> ptr = nullptr;
        Assert.True(((delegate*<ref Ptr<nint>, bool>)(delegate*<ref readonly int, bool>)&Unsafe.IsNullRef<int>)(
            ref ((delegate*<in Ptr<nint>, ref Ptr<nint>>)(delegate*<ref readonly int, ref int>)&Unsafe.AsRef<int>)(
                in ptr.Handle)));
        Assert.True(((delegate*<ref Ptr<nint>, bool>)(delegate*<ref readonly int, bool>)&Unsafe.IsNullRef<int>)(
            ref ((delegate*<in Ptr<nint>, ref Ptr<nint>>)(delegate*<ref readonly int, ref int>)&Unsafe.AsRef<int>)(
                in ptr[0])));
        Assert.True((nint**)ptr is null);
        Assert.True((void**)ptr is null);
    }
}
