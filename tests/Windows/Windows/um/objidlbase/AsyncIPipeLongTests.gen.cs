// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "AsyncIPipeLong"/> struct.</summary>
public static unsafe partial class AsyncIPipeLongTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "AsyncIPipeLong"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(AsyncIPipeLong).GUID, Is.EqualTo(IID_AsyncIPipeLong));
    }

    /// <summary>Validates that the <see cref = "AsyncIPipeLong"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AsyncIPipeLong>(), Is.EqualTo(sizeof(AsyncIPipeLong)));
    }

    /// <summary>Validates that the <see cref = "AsyncIPipeLong"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AsyncIPipeLong).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "AsyncIPipeLong"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(AsyncIPipeLong), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(AsyncIPipeLong), Is.EqualTo(4));
        }
    }
}