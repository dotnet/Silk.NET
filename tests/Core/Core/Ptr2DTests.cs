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
        Assert.That(
            (
                (delegate* <ref Ptr<nint>, bool>)
                    (delegate* <ref readonly int, bool>)&Unsafe.IsNullRef<int>
            )(
                ref (
                    (delegate* <in Ptr<nint>, ref Ptr<nint>>)
                        (delegate* <ref readonly int, ref int>)&Unsafe.AsRef<int>
                )(in ptr.Handle)
            ),
            Is.True
        );
        Assert.That(
            (
                (delegate* <ref Ptr<nint>, bool>)
                    (delegate* <ref readonly int, bool>)&Unsafe.IsNullRef<int>
            )(
                ref (
                    (delegate* <in Ptr<nint>, ref Ptr<nint>>)
                        (delegate* <ref readonly int, ref int>)&Unsafe.AsRef<int>
                )(in ptr[0])
            ),
            Is.True
        );
        Assert.That((nint**)ptr is null, Is.True);
        Assert.That((void**)ptr is null, Is.True);
    }
}
