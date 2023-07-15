// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mssip.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MS_ADDINFO_CATALOGMEMBER"/> struct.</summary>
public static unsafe partial class MS_ADDINFO_CATALOGMEMBERTests
{
    /// <summary>Validates that the <see cref = "MS_ADDINFO_CATALOGMEMBER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MS_ADDINFO_CATALOGMEMBER>(), Is.EqualTo(sizeof(MS_ADDINFO_CATALOGMEMBER)));
    }

    /// <summary>Validates that the <see cref = "MS_ADDINFO_CATALOGMEMBER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MS_ADDINFO_CATALOGMEMBER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MS_ADDINFO_CATALOGMEMBER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MS_ADDINFO_CATALOGMEMBER), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(MS_ADDINFO_CATALOGMEMBER), Is.EqualTo(12));
        }
    }
}