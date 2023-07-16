// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "RemotableHandle"/> struct.</summary>
public static unsafe partial class RemotableHandleTests
{
    /// <summary>Validates that the <see cref = "RemotableHandle"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RemotableHandle>(), Is.EqualTo(sizeof(RemotableHandle)));
    }

    /// <summary>Validates that the <see cref = "RemotableHandle"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RemotableHandle).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RemotableHandle"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RemotableHandle), Is.EqualTo(8));
    }
}