using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Silk.NET.Core.UnitTests;

public class ConstPtrTests
{
    [Test]
    public void SingleStringUtf8()
    {
        ConstPtr<byte> thing = STR_1;
        string thingBack = thing;
        Assert.That(thingBack, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf16()
    {
        ConstPtr<char> thing = STR_1;
        string thingBack = thing;
        Assert.That(thingBack, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf32()
    {
        ConstPtr<uint> thing = STR_1;
        string thingBack = thing;
        Assert.That(thingBack, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf8FromByteArray()
    {
        ConstPtr<byte> thing = Encoding.UTF8.GetBytes(STR_1 + "\0");
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf8FromSpan()
    {
        ConstPtr<byte> thing = Encoding.UTF8.GetBytes(STR_1 + "\0").AsSpan();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf8FromReadOnlySpan()
    {
        ConstPtr<byte> thing = (ReadOnlySpan<byte>) Encoding.UTF8.GetBytes(STR_1 + "\0");
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringUtf8FromRawPointer()
    {
        fixed (byte* ptr = Encoding.UTF8.GetBytes(STR_1 + "\0"))
        {
            ConstPtr<byte> thing = ptr;
            Assert.That((string)thing, Is.EqualTo(STR_1));
        }
    }

    [Test]
    public void SingleStringUtf16FromByteArray()
    {
        ConstPtr<char> thing = STR_1.ToArray();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf16FromSpan()
    {
        ConstPtr<char> thing = STR_1.AsSpan();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf16FromReadOnlySpan()
    {
        ConstPtr<char> thing = (ReadOnlySpan<char>) STR_1;
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringUtf16FromRawPointer()
    {
        fixed (byte* ptr = Encoding.Unicode.GetBytes(STR_1 + "\0"))
        {
            ConstPtr<char> thing = (char*)ptr;
            Assert.That((string)thing, Is.EqualTo(STR_1));
        }
    }

    [Test]
    public void SingleStringUtf32FromByteArray()
    {
        ConstPtr<uint> thing = MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0")).ToArray();
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf32FromSpan()
    {
        ConstPtr<uint> thing = MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0"));
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public void SingleStringUtf32FromReadOnlySpan()
    {
        ConstPtr<uint> thing = (ReadOnlySpan<uint>)MemoryMarshal.Cast<byte, uint>(Encoding.UTF32.GetBytes(STR_1 + "\0"));
        Assert.That((string) thing, Is.EqualTo(STR_1));
    }

    [Test]
    public unsafe void SingleStringUtf32FromRawPointer()
    {
        fixed (byte* ptr = Encoding.UTF32.GetBytes(STR_1 + "\0"))
        {
            ConstPtr<uint> thing = (uint*)ptr;
            Assert.That((string)thing, Is.EqualTo(STR_1));
        }
    }

    [Test]
    public void StringWithNonStringPointer()
    {
        nint dummy = 0x12345678;
        Assert.Throws<InvalidCastException>(() => _ = (ConstPtr<nint>)"Hello");
        Assert.Throws<InvalidCastException>(() => _ = (string)dummy.AsPtr());
    }

    [Test]
    public unsafe void NullIsNull()
    {
        ConstPtr<nint> ptr = nullptr;
        Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr.Ref)));
        Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr[0])));
        Assert.True(Unsafe.IsNullRef(ref Unsafe.AsRef(in ptr.GetPinnableReference())));
        Assert.True((nint*) ptr is null);
        Assert.True((void*) ptr is null);
    }
}
