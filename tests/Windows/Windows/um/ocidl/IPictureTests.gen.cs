// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IPicture"/> struct.</summary>
public static unsafe partial class IPictureTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IPicture"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPicture).GUID, Is.EqualTo(IID_IPicture));
    }

    /// <summary>Validates that the <see cref = "IPicture"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPicture>(), Is.EqualTo(sizeof(IPicture)));
    }

    /// <summary>Validates that the <see cref = "IPicture"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPicture).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IPicture"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPicture), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPicture), Is.EqualTo(4));
        }
    }
}