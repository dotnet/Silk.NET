// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "ICastingEventHandler"/> struct.</summary>
public static unsafe partial class ICastingEventHandlerTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ICastingEventHandler"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ICastingEventHandler).GUID, Is.EqualTo(IID_ICastingEventHandler));
    }

    /// <summary>Validates that the <see cref = "ICastingEventHandler"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<ICastingEventHandler>(),
            Is.EqualTo(sizeof(ICastingEventHandler))
        );
    }

    /// <summary>Validates that the <see cref = "ICastingEventHandler"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICastingEventHandler).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ICastingEventHandler"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ICastingEventHandler), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ICastingEventHandler), Is.EqualTo(4));
        }
    }
}
