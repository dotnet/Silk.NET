// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class SQLITE
{
    [NativeTypeName("#define SQLITE_E_ERROR _HRESULT_TYPEDEF_(0x87AF0001L)")]
    public const int SQLITE_E_ERROR = unchecked((int)(0x87AF0001));
    [NativeTypeName("#define SQLITE_E_INTERNAL _HRESULT_TYPEDEF_(0x87AF0002L)")]
    public const int SQLITE_E_INTERNAL = unchecked((int)(0x87AF0002));
    [NativeTypeName("#define SQLITE_E_PERM _HRESULT_TYPEDEF_(0x87AF0003L)")]
    public const int SQLITE_E_PERM = unchecked((int)(0x87AF0003));
    [NativeTypeName("#define SQLITE_E_ABORT _HRESULT_TYPEDEF_(0x87AF0004L)")]
    public const int SQLITE_E_ABORT = unchecked((int)(0x87AF0004));
    [NativeTypeName("#define SQLITE_E_BUSY _HRESULT_TYPEDEF_(0x87AF0005L)")]
    public const int SQLITE_E_BUSY = unchecked((int)(0x87AF0005));
    [NativeTypeName("#define SQLITE_E_LOCKED _HRESULT_TYPEDEF_(0x87AF0006L)")]
    public const int SQLITE_E_LOCKED = unchecked((int)(0x87AF0006));
    [NativeTypeName("#define SQLITE_E_NOMEM _HRESULT_TYPEDEF_(0x87AF0007L)")]
    public const int SQLITE_E_NOMEM = unchecked((int)(0x87AF0007));
    [NativeTypeName("#define SQLITE_E_READONLY _HRESULT_TYPEDEF_(0x87AF0008L)")]
    public const int SQLITE_E_READONLY = unchecked((int)(0x87AF0008));
    [NativeTypeName("#define SQLITE_E_INTERRUPT _HRESULT_TYPEDEF_(0x87AF0009L)")]
    public const int SQLITE_E_INTERRUPT = unchecked((int)(0x87AF0009));
    [NativeTypeName("#define SQLITE_E_IOERR _HRESULT_TYPEDEF_(0x87AF000AL)")]
    public const int SQLITE_E_IOERR = unchecked((int)(0x87AF000A));
    [NativeTypeName("#define SQLITE_E_CORRUPT _HRESULT_TYPEDEF_(0x87AF000BL)")]
    public const int SQLITE_E_CORRUPT = unchecked((int)(0x87AF000B));
    [NativeTypeName("#define SQLITE_E_NOTFOUND _HRESULT_TYPEDEF_(0x87AF000CL)")]
    public const int SQLITE_E_NOTFOUND = unchecked((int)(0x87AF000C));
    [NativeTypeName("#define SQLITE_E_FULL _HRESULT_TYPEDEF_(0x87AF000DL)")]
    public const int SQLITE_E_FULL = unchecked((int)(0x87AF000D));
    [NativeTypeName("#define SQLITE_E_CANTOPEN _HRESULT_TYPEDEF_(0x87AF000EL)")]
    public const int SQLITE_E_CANTOPEN = unchecked((int)(0x87AF000E));
    [NativeTypeName("#define SQLITE_E_PROTOCOL _HRESULT_TYPEDEF_(0x87AF000FL)")]
    public const int SQLITE_E_PROTOCOL = unchecked((int)(0x87AF000F));
    [NativeTypeName("#define SQLITE_E_EMPTY _HRESULT_TYPEDEF_(0x87AF0010L)")]
    public const int SQLITE_E_EMPTY = unchecked((int)(0x87AF0010));
    [NativeTypeName("#define SQLITE_E_SCHEMA _HRESULT_TYPEDEF_(0x87AF0011L)")]
    public const int SQLITE_E_SCHEMA = unchecked((int)(0x87AF0011));
    [NativeTypeName("#define SQLITE_E_TOOBIG _HRESULT_TYPEDEF_(0x87AF0012L)")]
    public const int SQLITE_E_TOOBIG = unchecked((int)(0x87AF0012));
    [NativeTypeName("#define SQLITE_E_CONSTRAINT _HRESULT_TYPEDEF_(0x87AF0013L)")]
    public const int SQLITE_E_CONSTRAINT = unchecked((int)(0x87AF0013));
    [NativeTypeName("#define SQLITE_E_MISMATCH _HRESULT_TYPEDEF_(0x87AF0014L)")]
    public const int SQLITE_E_MISMATCH = unchecked((int)(0x87AF0014));
    [NativeTypeName("#define SQLITE_E_MISUSE _HRESULT_TYPEDEF_(0x87AF0015L)")]
    public const int SQLITE_E_MISUSE = unchecked((int)(0x87AF0015));
    [NativeTypeName("#define SQLITE_E_NOLFS _HRESULT_TYPEDEF_(0x87AF0016L)")]
    public const int SQLITE_E_NOLFS = unchecked((int)(0x87AF0016));
    [NativeTypeName("#define SQLITE_E_AUTH _HRESULT_TYPEDEF_(0x87AF0017L)")]
    public const int SQLITE_E_AUTH = unchecked((int)(0x87AF0017));
    [NativeTypeName("#define SQLITE_E_FORMAT _HRESULT_TYPEDEF_(0x87AF0018L)")]
    public const int SQLITE_E_FORMAT = unchecked((int)(0x87AF0018));
    [NativeTypeName("#define SQLITE_E_RANGE _HRESULT_TYPEDEF_(0x87AF0019L)")]
    public const int SQLITE_E_RANGE = unchecked((int)(0x87AF0019));
    [NativeTypeName("#define SQLITE_E_NOTADB _HRESULT_TYPEDEF_(0x87AF001AL)")]
    public const int SQLITE_E_NOTADB = unchecked((int)(0x87AF001A));
    [NativeTypeName("#define SQLITE_E_NOTICE _HRESULT_TYPEDEF_(0x87AF001BL)")]
    public const int SQLITE_E_NOTICE = unchecked((int)(0x87AF001B));
    [NativeTypeName("#define SQLITE_E_WARNING _HRESULT_TYPEDEF_(0x87AF001CL)")]
    public const int SQLITE_E_WARNING = unchecked((int)(0x87AF001C));
    [NativeTypeName("#define SQLITE_E_ROW _HRESULT_TYPEDEF_(0x87AF0064L)")]
    public const int SQLITE_E_ROW = unchecked((int)(0x87AF0064));
    [NativeTypeName("#define SQLITE_E_DONE _HRESULT_TYPEDEF_(0x87AF0065L)")]
    public const int SQLITE_E_DONE = unchecked((int)(0x87AF0065));
    [NativeTypeName("#define SQLITE_E_IOERR_READ _HRESULT_TYPEDEF_(0x87AF010AL)")]
    public const int SQLITE_E_IOERR_READ = unchecked((int)(0x87AF010A));
    [NativeTypeName("#define SQLITE_E_IOERR_SHORT_READ _HRESULT_TYPEDEF_(0x87AF020AL)")]
    public const int SQLITE_E_IOERR_SHORT_READ = unchecked((int)(0x87AF020A));
    [NativeTypeName("#define SQLITE_E_IOERR_WRITE _HRESULT_TYPEDEF_(0x87AF030AL)")]
    public const int SQLITE_E_IOERR_WRITE = unchecked((int)(0x87AF030A));
    [NativeTypeName("#define SQLITE_E_IOERR_FSYNC _HRESULT_TYPEDEF_(0x87AF040AL)")]
    public const int SQLITE_E_IOERR_FSYNC = unchecked((int)(0x87AF040A));
    [NativeTypeName("#define SQLITE_E_IOERR_DIR_FSYNC _HRESULT_TYPEDEF_(0x87AF050AL)")]
    public const int SQLITE_E_IOERR_DIR_FSYNC = unchecked((int)(0x87AF050A));
    [NativeTypeName("#define SQLITE_E_IOERR_TRUNCATE _HRESULT_TYPEDEF_(0x87AF060AL)")]
    public const int SQLITE_E_IOERR_TRUNCATE = unchecked((int)(0x87AF060A));
    [NativeTypeName("#define SQLITE_E_IOERR_FSTAT _HRESULT_TYPEDEF_(0x87AF070AL)")]
    public const int SQLITE_E_IOERR_FSTAT = unchecked((int)(0x87AF070A));
    [NativeTypeName("#define SQLITE_E_IOERR_UNLOCK _HRESULT_TYPEDEF_(0x87AF080AL)")]
    public const int SQLITE_E_IOERR_UNLOCK = unchecked((int)(0x87AF080A));
    [NativeTypeName("#define SQLITE_E_IOERR_RDLOCK _HRESULT_TYPEDEF_(0x87AF090AL)")]
    public const int SQLITE_E_IOERR_RDLOCK = unchecked((int)(0x87AF090A));
    [NativeTypeName("#define SQLITE_E_IOERR_DELETE _HRESULT_TYPEDEF_(0x87AF0A0AL)")]
    public const int SQLITE_E_IOERR_DELETE = unchecked((int)(0x87AF0A0A));
    [NativeTypeName("#define SQLITE_E_IOERR_BLOCKED _HRESULT_TYPEDEF_(0x87AF0B0AL)")]
    public const int SQLITE_E_IOERR_BLOCKED = unchecked((int)(0x87AF0B0A));
    [NativeTypeName("#define SQLITE_E_IOERR_NOMEM _HRESULT_TYPEDEF_(0x87AF0C0AL)")]
    public const int SQLITE_E_IOERR_NOMEM = unchecked((int)(0x87AF0C0A));
    [NativeTypeName("#define SQLITE_E_IOERR_ACCESS _HRESULT_TYPEDEF_(0x87AF0D0AL)")]
    public const int SQLITE_E_IOERR_ACCESS = unchecked((int)(0x87AF0D0A));
    [NativeTypeName("#define SQLITE_E_IOERR_CHECKRESERVEDLOCK _HRESULT_TYPEDEF_(0x87AF0E0AL)")]
    public const int SQLITE_E_IOERR_CHECKRESERVEDLOCK = unchecked((int)(0x87AF0E0A));
    [NativeTypeName("#define SQLITE_E_IOERR_LOCK _HRESULT_TYPEDEF_(0x87AF0F0AL)")]
    public const int SQLITE_E_IOERR_LOCK = unchecked((int)(0x87AF0F0A));
    [NativeTypeName("#define SQLITE_E_IOERR_CLOSE _HRESULT_TYPEDEF_(0x87AF100AL)")]
    public const int SQLITE_E_IOERR_CLOSE = unchecked((int)(0x87AF100A));
    [NativeTypeName("#define SQLITE_E_IOERR_DIR_CLOSE _HRESULT_TYPEDEF_(0x87AF110AL)")]
    public const int SQLITE_E_IOERR_DIR_CLOSE = unchecked((int)(0x87AF110A));
    [NativeTypeName("#define SQLITE_E_IOERR_SHMOPEN _HRESULT_TYPEDEF_(0x87AF120AL)")]
    public const int SQLITE_E_IOERR_SHMOPEN = unchecked((int)(0x87AF120A));
    [NativeTypeName("#define SQLITE_E_IOERR_SHMSIZE _HRESULT_TYPEDEF_(0x87AF130AL)")]
    public const int SQLITE_E_IOERR_SHMSIZE = unchecked((int)(0x87AF130A));
    [NativeTypeName("#define SQLITE_E_IOERR_SHMLOCK _HRESULT_TYPEDEF_(0x87AF140AL)")]
    public const int SQLITE_E_IOERR_SHMLOCK = unchecked((int)(0x87AF140A));
    [NativeTypeName("#define SQLITE_E_IOERR_SHMMAP _HRESULT_TYPEDEF_(0x87AF150AL)")]
    public const int SQLITE_E_IOERR_SHMMAP = unchecked((int)(0x87AF150A));
    [NativeTypeName("#define SQLITE_E_IOERR_SEEK _HRESULT_TYPEDEF_(0x87AF160AL)")]
    public const int SQLITE_E_IOERR_SEEK = unchecked((int)(0x87AF160A));
    [NativeTypeName("#define SQLITE_E_IOERR_DELETE_NOENT _HRESULT_TYPEDEF_(0x87AF170AL)")]
    public const int SQLITE_E_IOERR_DELETE_NOENT = unchecked((int)(0x87AF170A));
    [NativeTypeName("#define SQLITE_E_IOERR_MMAP _HRESULT_TYPEDEF_(0x87AF180AL)")]
    public const int SQLITE_E_IOERR_MMAP = unchecked((int)(0x87AF180A));
    [NativeTypeName("#define SQLITE_E_IOERR_GETTEMPPATH _HRESULT_TYPEDEF_(0x87AF190AL)")]
    public const int SQLITE_E_IOERR_GETTEMPPATH = unchecked((int)(0x87AF190A));
    [NativeTypeName("#define SQLITE_E_IOERR_CONVPATH _HRESULT_TYPEDEF_(0x87AF1A0AL)")]
    public const int SQLITE_E_IOERR_CONVPATH = unchecked((int)(0x87AF1A0A));
    [NativeTypeName("#define SQLITE_E_IOERR_VNODE _HRESULT_TYPEDEF_(0x87AF1A02L)")]
    public const int SQLITE_E_IOERR_VNODE = unchecked((int)(0x87AF1A02));
    [NativeTypeName("#define SQLITE_E_IOERR_AUTH _HRESULT_TYPEDEF_(0x87AF1A03L)")]
    public const int SQLITE_E_IOERR_AUTH = unchecked((int)(0x87AF1A03));
    [NativeTypeName("#define SQLITE_E_LOCKED_SHAREDCACHE _HRESULT_TYPEDEF_(0x87AF0106L)")]
    public const int SQLITE_E_LOCKED_SHAREDCACHE = unchecked((int)(0x87AF0106));
    [NativeTypeName("#define SQLITE_E_BUSY_RECOVERY _HRESULT_TYPEDEF_(0x87AF0105L)")]
    public const int SQLITE_E_BUSY_RECOVERY = unchecked((int)(0x87AF0105));
    [NativeTypeName("#define SQLITE_E_BUSY_SNAPSHOT _HRESULT_TYPEDEF_(0x87AF0205L)")]
    public const int SQLITE_E_BUSY_SNAPSHOT = unchecked((int)(0x87AF0205));
    [NativeTypeName("#define SQLITE_E_CANTOPEN_NOTEMPDIR _HRESULT_TYPEDEF_(0x87AF010EL)")]
    public const int SQLITE_E_CANTOPEN_NOTEMPDIR = unchecked((int)(0x87AF010E));
    [NativeTypeName("#define SQLITE_E_CANTOPEN_ISDIR _HRESULT_TYPEDEF_(0x87AF020EL)")]
    public const int SQLITE_E_CANTOPEN_ISDIR = unchecked((int)(0x87AF020E));
    [NativeTypeName("#define SQLITE_E_CANTOPEN_FULLPATH _HRESULT_TYPEDEF_(0x87AF030EL)")]
    public const int SQLITE_E_CANTOPEN_FULLPATH = unchecked((int)(0x87AF030E));
    [NativeTypeName("#define SQLITE_E_CANTOPEN_CONVPATH _HRESULT_TYPEDEF_(0x87AF040EL)")]
    public const int SQLITE_E_CANTOPEN_CONVPATH = unchecked((int)(0x87AF040E));
    [NativeTypeName("#define SQLITE_E_CORRUPT_VTAB _HRESULT_TYPEDEF_(0x87AF010BL)")]
    public const int SQLITE_E_CORRUPT_VTAB = unchecked((int)(0x87AF010B));
    [NativeTypeName("#define SQLITE_E_READONLY_RECOVERY _HRESULT_TYPEDEF_(0x87AF0108L)")]
    public const int SQLITE_E_READONLY_RECOVERY = unchecked((int)(0x87AF0108));
    [NativeTypeName("#define SQLITE_E_READONLY_CANTLOCK _HRESULT_TYPEDEF_(0x87AF0208L)")]
    public const int SQLITE_E_READONLY_CANTLOCK = unchecked((int)(0x87AF0208));
    [NativeTypeName("#define SQLITE_E_READONLY_ROLLBACK _HRESULT_TYPEDEF_(0x87AF0308L)")]
    public const int SQLITE_E_READONLY_ROLLBACK = unchecked((int)(0x87AF0308));
    [NativeTypeName("#define SQLITE_E_READONLY_DBMOVED _HRESULT_TYPEDEF_(0x87AF0408L)")]
    public const int SQLITE_E_READONLY_DBMOVED = unchecked((int)(0x87AF0408));
    [NativeTypeName("#define SQLITE_E_ABORT_ROLLBACK _HRESULT_TYPEDEF_(0x87AF0204L)")]
    public const int SQLITE_E_ABORT_ROLLBACK = unchecked((int)(0x87AF0204));
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_CHECK _HRESULT_TYPEDEF_(0x87AF0113L)")]
    public const int SQLITE_E_CONSTRAINT_CHECK = unchecked((int)(0x87AF0113));
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_COMMITHOOK _HRESULT_TYPEDEF_(0x87AF0213L)")]
    public const int SQLITE_E_CONSTRAINT_COMMITHOOK = unchecked((int)(0x87AF0213));
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_FOREIGNKEY _HRESULT_TYPEDEF_(0x87AF0313L)")]
    public const int SQLITE_E_CONSTRAINT_FOREIGNKEY = unchecked((int)(0x87AF0313));
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_FUNCTION _HRESULT_TYPEDEF_(0x87AF0413L)")]
    public const int SQLITE_E_CONSTRAINT_FUNCTION = unchecked((int)(0x87AF0413));
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_NOTNULL _HRESULT_TYPEDEF_(0x87AF0513L)")]
    public const int SQLITE_E_CONSTRAINT_NOTNULL = unchecked((int)(0x87AF0513));
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_PRIMARYKEY _HRESULT_TYPEDEF_(0x87AF0613L)")]
    public const int SQLITE_E_CONSTRAINT_PRIMARYKEY = unchecked((int)(0x87AF0613));
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_TRIGGER _HRESULT_TYPEDEF_(0x87AF0713L)")]
    public const int SQLITE_E_CONSTRAINT_TRIGGER = unchecked((int)(0x87AF0713));
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_UNIQUE _HRESULT_TYPEDEF_(0x87AF0813L)")]
    public const int SQLITE_E_CONSTRAINT_UNIQUE = unchecked((int)(0x87AF0813));
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_VTAB _HRESULT_TYPEDEF_(0x87AF0913L)")]
    public const int SQLITE_E_CONSTRAINT_VTAB = unchecked((int)(0x87AF0913));
    [NativeTypeName("#define SQLITE_E_CONSTRAINT_ROWID _HRESULT_TYPEDEF_(0x87AF0A13L)")]
    public const int SQLITE_E_CONSTRAINT_ROWID = unchecked((int)(0x87AF0A13));
    [NativeTypeName("#define SQLITE_E_NOTICE_RECOVER_WAL _HRESULT_TYPEDEF_(0x87AF011BL)")]
    public const int SQLITE_E_NOTICE_RECOVER_WAL = unchecked((int)(0x87AF011B));
    [NativeTypeName("#define SQLITE_E_NOTICE_RECOVER_ROLLBACK _HRESULT_TYPEDEF_(0x87AF021BL)")]
    public const int SQLITE_E_NOTICE_RECOVER_ROLLBACK = unchecked((int)(0x87AF021B));
    [NativeTypeName("#define SQLITE_E_WARNING_AUTOINDEX _HRESULT_TYPEDEF_(0x87AF011CL)")]
    public const int SQLITE_E_WARNING_AUTOINDEX = unchecked((int)(0x87AF011C));
}