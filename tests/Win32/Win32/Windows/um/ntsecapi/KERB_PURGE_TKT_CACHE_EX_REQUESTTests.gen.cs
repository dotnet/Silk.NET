// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "KERB_PURGE_TKT_CACHE_EX_REQUEST"/> struct.</summary>
public static unsafe partial class KERB_PURGE_TKT_CACHE_EX_REQUESTTests
{
    /// <summary>Validates that the <see cref = "KERB_PURGE_TKT_CACHE_EX_REQUEST"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<KERB_PURGE_TKT_CACHE_EX_REQUEST>(),
            Is.EqualTo(sizeof(KERB_PURGE_TKT_CACHE_EX_REQUEST))
        );
    }

    /// <summary>Validates that the <see cref = "KERB_PURGE_TKT_CACHE_EX_REQUEST"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(KERB_PURGE_TKT_CACHE_EX_REQUEST).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "KERB_PURGE_TKT_CACHE_EX_REQUEST"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(KERB_PURGE_TKT_CACHE_EX_REQUEST), Is.EqualTo(112));
        }
        else
        {
            Assert.That(sizeof(KERB_PURGE_TKT_CACHE_EX_REQUEST), Is.EqualTo(80));
        }
    }
}
