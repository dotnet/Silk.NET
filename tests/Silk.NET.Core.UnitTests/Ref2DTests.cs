using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core.UnitTests;

public class Ref2DTests
{
    [Test]
    public void SingleStringPtrUtf8FromSpan()
    {
        Span<byte> thing = Encoding.UTF8.GetBytes(STR_1 + "\0");
        var thingPtr = thing.AsRef2D();
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(
            Encoding.UTF8.GetString(thingPtr[0].AsSpan(Encoding.UTF8.GetByteCount(STR_1))),
            Is.EqualTo(STR_1)
        );
        Assert.That(thingPtr.ReadToStringArray(length: 1)?[0], Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringPtrUtf16FromSpan()
    {
        var thing = MemoryMarshal.Cast<byte, char>(Encoding.Unicode.GetBytes(STR_1 + "\0"));
        var thingPtr = thing.AsRef2D();
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(thingPtr[0].AsSpan(STR_1.Length).ToString(), Is.EqualTo(STR_1));
        Assert.That(thingPtr.ReadToStringArray(length: 1)?[0], Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringPtrUtf32FromSpan()
    {
        var thing = MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0"));
        var thingPtr = thing.AsRef2D();
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(
            Encoding.UTF32.GetString(
                MemoryMarshal.Cast<uint, byte>(
                    thingPtr[0].AsSpan(Encoding.UTF32.GetByteCount(STR_1) / 4)
                )
            ),
            Is.EqualTo(STR_1)
        );
        Assert.That(thingPtr.ReadToStringArray(length: 1)?[0], Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringPtrUtf8FromPointerArray()
    {
        fixed (byte* thing = Encoding.UTF8.GetBytes(STR_1 + "\0"))
        {
            Ref2D<byte> thingPtr = new[] { thing };
            Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
            Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
            Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
            Assert.That(
                Encoding.UTF8.GetString(thingPtr[0].AsSpan(Encoding.UTF8.GetByteCount(STR_1))),
                Is.EqualTo(STR_1)
            );
            Assert.That(thingPtr.ReadToStringArray(length: 1)?[0], Is.EqualTo(STR_1));
        }
    }

    [Test]
    public unsafe void SingleStringPtrUtf16FromPointerArray()
    {
        fixed (byte* thing = Encoding.Unicode.GetBytes(STR_1 + "\0"))
        {
            Ref2D<char> thingPtr = new[] { (char*)thing };
            Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
            Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
            Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
            Assert.That(thingPtr[0].AsSpan(STR_1.Length).ToString(), Is.EqualTo(STR_1));
            Assert.That(thingPtr.ReadToStringArray(length: 1)?[0], Is.EqualTo(STR_1));
        }
    }

    [Test]
    public unsafe void SingleStringPtrUtf32FromPointerArray()
    {
        fixed (byte* thing = Encoding.UTF32.GetBytes(STR_1 + "\0"))
        {
            Ref2D<uint> thingPtr = new[] { (uint*)thing };
            Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
            Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
            Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
            Assert.That(
                Encoding.UTF32.GetString(
                    MemoryMarshal.Cast<uint, byte>(
                        thingPtr[0].AsSpan(Encoding.UTF32.GetByteCount(STR_1) / 4)
                    )
                ),
                Is.EqualTo(STR_1)
            );
            Assert.That(thingPtr.ReadToStringArray(length: 1)?[0], Is.EqualTo(STR_1));
        }
    }

    [Test]
    public unsafe void SingleStringPtrUtf8FromJaggedArray()
    {
        Ref2D<byte> thingPtr = new[] { Encoding.UTF8.GetBytes(STR_1 + "\0") };
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(
            Encoding.UTF8.GetString(thingPtr[0].AsSpan(Encoding.UTF8.GetByteCount(STR_1))),
            Is.EqualTo(STR_1)
        );
        Assert.That(thingPtr.ReadToStringArray(length: 1)?[0], Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringPtrUtf16FromJaggedArray()
    {
        Ref2D<char> thingPtr = new[]
        {
            MemoryMarshal.Cast<byte, char>(Encoding.Unicode.GetBytes(STR_1 + "\0")).ToArray()
        };
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(thingPtr[0].AsSpan(STR_1.Length).ToString(), Is.EqualTo(STR_1));
        Assert.That(thingPtr.ReadToStringArray(length: 1)?[0], Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringPtrUtf32FromJaggedArray()
    {
        Ref2D<uint> thingPtr = new[]
        {
            MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0")).ToArray()
        };
        Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
        Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
        Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
        Assert.That(
            Encoding.UTF32.GetString(
                MemoryMarshal.Cast<uint, byte>(
                    thingPtr[0].AsSpan(Encoding.UTF32.GetByteCount(STR_1) / 4)
                )
            ),
            Is.EqualTo(STR_1)
        );
        Assert.That(thingPtr.ReadToStringArray(length: 1)?[0], Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringPtrUtf8FromRawPointer()
    {
        fixed (byte* thing = Encoding.UTF8.GetBytes(STR_1 + "\0"))
        {
            Ref2D<byte> thingPtr = &thing;
            Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
            Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
            Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
            Assert.That(
                Encoding.UTF8.GetString(thingPtr[0].AsSpan(Encoding.UTF8.GetByteCount(STR_1))),
                Is.EqualTo(STR_1)
            );
            Assert.That(thingPtr.ReadToStringArray(length: 1)?[0], Is.EqualTo(STR_1));
        }
    }

    [Test]
    public unsafe void SingleStringPtrUtf16FromRawPointer()
    {
        fixed (byte* thing = Encoding.Unicode.GetBytes(STR_1 + "\0"))
        {
            Ref2D<char> thingPtr = (char**)&thing;
            Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
            Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
            Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
            Assert.That(thingPtr[0].AsSpan(STR_1.Length).ToString(), Is.EqualTo(STR_1));
            Assert.That(thingPtr.ReadToStringArray(length: 1)?[0], Is.EqualTo(STR_1));
        }
    }

    [Test]
    public unsafe void SingleStringPtrUtf32FromRawPointer()
    {
        fixed (byte* thing = Encoding.UTF32.GetBytes(STR_1 + "\0"))
        {
            Ref2D<uint> thingPtr = (uint**)&thing;
            Assert.That((string)thingPtr.Ref, Is.EqualTo(STR_1));
            Assert.That((string)thingPtr[0], Is.EqualTo(STR_1));
            Assert.That(thingPtr[0][0], Is.EqualTo(STR_1[0]));
            Assert.That(
                Encoding.UTF32.GetString(
                    MemoryMarshal.Cast<uint, byte>(
                        thingPtr[0].AsSpan(Encoding.UTF32.GetByteCount(STR_1) / 4)
                    )
                ),
                Is.EqualTo(STR_1)
            );
            Assert.That(thingPtr.ReadToStringArray(length: 1)?[0], Is.EqualTo(STR_1));
        }
    }

    [Test]
    public unsafe void NullIsNull()
    {
        Ref2D<nint> ptr = nullptr;
        Assert.That(
            (
                (delegate* <ref Ref<nint>, bool>)
                    (delegate* <ref readonly int, bool>)&Unsafe.IsNullRef<int>
            )(
                ref (
                    (delegate* <in Ref<nint>, ref Ref<nint>>)
                        (delegate* <ref readonly int, ref int>)&Unsafe.AsRef<int>
                )(in ptr.Ref)
            ),
            Is.True
        );
        Assert.That(
            (
                (delegate* <ref Ref<nint>, bool>)
                    (delegate* <ref readonly int, bool>)&Unsafe.IsNullRef<int>
            )(
                ref (
                    (delegate* <in Ref<nint>, ref Ref<nint>>)
                        (delegate* <ref readonly int, ref int>)&Unsafe.AsRef<int>
                )(in ptr[0])
            ),
            Is.True
        );
        Assert.That(
            (
                (delegate* <ref nint*, bool>)
                    (delegate* <ref readonly int, bool>)&Unsafe.IsNullRef<int>
            )(
                ref (
                    (delegate* <in nint*, ref nint*>)
                        (delegate* <ref readonly int, ref int>)&Unsafe.AsRef<int>
                )(in ptr.GetPinnableReference())
            ),
            Is.True
        );
        Assert.That((nint**)ptr is null, Is.True);
        Assert.That((void**)ptr is null, Is.True);
    }
}
