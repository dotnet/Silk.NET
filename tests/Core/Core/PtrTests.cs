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
        Assert.Multiple(() =>
        {
            Assert.That(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr.Handle)), Is.True);
            Assert.That(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr[0])), Is.True);
            Assert.That(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr.GetPinnableReference())), Is.True);
            Assert.That((nint*)ptr is null, Is.True);
            Assert.That((void*)ptr is null, Is.True);
        });
    }
}
