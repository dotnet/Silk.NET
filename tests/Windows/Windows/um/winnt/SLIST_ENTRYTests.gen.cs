// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SLIST_ENTRY"/> struct.</summary>
public static unsafe partial class SLIST_ENTRYTests
{
    /// <summary>Validates that the <see cref = "SLIST_ENTRY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SLIST_ENTRY>(), Is.EqualTo(sizeof(SLIST_ENTRY)));
    }

    /// <summary>Validates that the <see cref = "SLIST_ENTRY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SLIST_ENTRY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SLIST_ENTRY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SLIST_ENTRY), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(SLIST_ENTRY), Is.EqualTo(4));
        }
    }
}