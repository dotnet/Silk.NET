// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propkey.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class Windows
{
    [NativeTypeName("#define AUDIO_CHANNELCOUNT_MONO 1ul")]
    public const uint AUDIO_CHANNELCOUNT_MONO = 1U;
    [NativeTypeName("#define AUDIO_CHANNELCOUNT_STEREO 2ul")]
    public const uint AUDIO_CHANNELCOUNT_STEREO = 2U;
    [NativeTypeName("#define CALENDAR_RESPONSESTATUS_NONE 0u")]
    public const uint CALENDAR_RESPONSESTATUS_NONE = 0U;
    [NativeTypeName("#define CALENDAR_RESPONSESTATUS_ORGANIZED 1u")]
    public const uint CALENDAR_RESPONSESTATUS_ORGANIZED = 1U;
    [NativeTypeName("#define CALENDAR_RESPONSESTATUS_TENTATIVE 2u")]
    public const uint CALENDAR_RESPONSESTATUS_TENTATIVE = 2U;
    [NativeTypeName("#define CALENDAR_RESPONSESTATUS_ACCEPTED 3u")]
    public const uint CALENDAR_RESPONSESTATUS_ACCEPTED = 3U;
    [NativeTypeName("#define CALENDAR_RESPONSESTATUS_DECLINED 4u")]
    public const uint CALENDAR_RESPONSESTATUS_DECLINED = 4U;
    [NativeTypeName("#define CALENDAR_RESPONSESTATUS_NOTRESPONDED 5u")]
    public const uint CALENDAR_RESPONSESTATUS_NOTRESPONDED = 5U;
    [NativeTypeName("#define CALENDAR_SHOWTIMEAS_FREE 0u")]
    public const uint CALENDAR_SHOWTIMEAS_FREE = 0U;
    [NativeTypeName("#define CALENDAR_SHOWTIMEAS_TENTATIVE 1u")]
    public const uint CALENDAR_SHOWTIMEAS_TENTATIVE = 1U;
    [NativeTypeName("#define CALENDAR_SHOWTIMEAS_BUSY 2u")]
    public const uint CALENDAR_SHOWTIMEAS_BUSY = 2U;
    [NativeTypeName("#define CALENDAR_SHOWTIMEAS_OOF 3u")]
    public const uint CALENDAR_SHOWTIMEAS_OOF = 3U;
    [NativeTypeName("#define COMMUNICATION_DIRECTION_UNKNOWN 0u")]
    public const uint COMMUNICATION_DIRECTION_UNKNOWN = 0U;
    [NativeTypeName("#define COMMUNICATION_DIRECTION_INCOMING 1u")]
    public const uint COMMUNICATION_DIRECTION_INCOMING = 1U;
    [NativeTypeName("#define COMMUNICATION_DIRECTION_OUTGOING 2u")]
    public const uint COMMUNICATION_DIRECTION_OUTGOING = 2U;
    [NativeTypeName("#define TASKSTATUS_NOTSTARTED 0u")]
    public const uint TASKSTATUS_NOTSTARTED = 0U;
    [NativeTypeName("#define TASKSTATUS_INPROGRESS 1u")]
    public const uint TASKSTATUS_INPROGRESS = 1U;
    [NativeTypeName("#define TASKSTATUS_COMPLETE 2u")]
    public const uint TASKSTATUS_COMPLETE = 2U;
    [NativeTypeName("#define TASKSTATUS_WAITING 3u")]
    public const uint TASKSTATUS_WAITING = 3U;
    [NativeTypeName("#define TASKSTATUS_DEFERRED 4u")]
    public const uint TASKSTATUS_DEFERRED = 4U;
    [NativeTypeName("#define GENDERVALUE_UNSPECIFIED 0u")]
    public const uint GENDERVALUE_UNSPECIFIED = 0U;
    [NativeTypeName("#define GENDERVALUE_FEMALE 1u")]
    public const uint GENDERVALUE_FEMALE = 1U;
    [NativeTypeName("#define GENDERVALUE_MALE 2u")]
    public const uint GENDERVALUE_MALE = 2U;
    [NativeTypeName("#define CREATOROPENWITHUIOPTION_HIDDEN 0ul")]
    public const uint CREATOROPENWITHUIOPTION_HIDDEN = 0U;
    [NativeTypeName("#define CREATOROPENWITHUIOPTION_VISIBLE 1ul")]
    public const uint CREATOROPENWITHUIOPTION_VISIBLE = 1U;
    [NativeTypeName("#define ISDEFAULTSAVE_NONE 0ul")]
    public const uint ISDEFAULTSAVE_NONE = 0U;
    [NativeTypeName("#define ISDEFAULTSAVE_OWNER 1ul")]
    public const uint ISDEFAULTSAVE_OWNER = 1U;
    [NativeTypeName("#define ISDEFAULTSAVE_NONOWNER 2ul")]
    public const uint ISDEFAULTSAVE_NONOWNER = 2U;
    [NativeTypeName("#define ISDEFAULTSAVE_BOTH 3ul")]
    public const uint ISDEFAULTSAVE_BOTH = 3U;
    [NativeTypeName("#define FILEOFFLINEAVAILABILITYSTATUS_NOTAVAILABLEOFFLINE 0ul")]
    public const uint FILEOFFLINEAVAILABILITYSTATUS_NOTAVAILABLEOFFLINE = 0U;
    [NativeTypeName("#define FILEOFFLINEAVAILABILITYSTATUS_PARTIAL 1ul")]
    public const uint FILEOFFLINEAVAILABILITYSTATUS_PARTIAL = 1U;
    [NativeTypeName("#define FILEOFFLINEAVAILABILITYSTATUS_COMPLETE 2ul")]
    public const uint FILEOFFLINEAVAILABILITYSTATUS_COMPLETE = 2U;
    [NativeTypeName("#define FILEOFFLINEAVAILABILITYSTATUS_COMPLETE_PINNED 3ul")]
    public const uint FILEOFFLINEAVAILABILITYSTATUS_COMPLETE_PINNED = 3U;
    [NativeTypeName("#define FILEOFFLINEAVAILABILITYSTATUS_EXCLUDED 4ul")]
    public const uint FILEOFFLINEAVAILABILITYSTATUS_EXCLUDED = 4U;
    [NativeTypeName("#define FILEOFFLINEAVAILABILITYSTATUS_FOLDER_EMPTY 5ul")]
    public const uint FILEOFFLINEAVAILABILITYSTATUS_FOLDER_EMPTY = 5U;
    [NativeTypeName("#define FLAGCOLOR_PURPLE 1u")]
    public const uint FLAGCOLOR_PURPLE = 1U;
    [NativeTypeName("#define FLAGCOLOR_ORANGE 2u")]
    public const uint FLAGCOLOR_ORANGE = 2U;
    [NativeTypeName("#define FLAGCOLOR_GREEN 3u")]
    public const uint FLAGCOLOR_GREEN = 3U;
    [NativeTypeName("#define FLAGCOLOR_YELLOW 4u")]
    public const uint FLAGCOLOR_YELLOW = 4U;
    [NativeTypeName("#define FLAGCOLOR_BLUE 5u")]
    public const uint FLAGCOLOR_BLUE = 5U;
    [NativeTypeName("#define FLAGCOLOR_RED 6u")]
    public const uint FLAGCOLOR_RED = 6U;
    [NativeTypeName("#define FLAGSTATUS_NOTFLAGGED 0l")]
    public const int FLAGSTATUS_NOTFLAGGED = 0;
    [NativeTypeName("#define FLAGSTATUS_COMPLETED 1l")]
    public const int FLAGSTATUS_COMPLETED = 1;
    [NativeTypeName("#define FLAGSTATUS_FOLLOWUP 2l")]
    public const int FLAGSTATUS_FOLLOWUP = 2;
    [NativeTypeName("#define IMPORTANCE_LOW_MIN 0l")]
    public const int IMPORTANCE_LOW_MIN = 0;
    [NativeTypeName("#define IMPORTANCE_LOW_SET 1l")]
    public const int IMPORTANCE_LOW_SET = 1;
    [NativeTypeName("#define IMPORTANCE_LOW_MAX 1l")]
    public const int IMPORTANCE_LOW_MAX = 1;
    [NativeTypeName("#define IMPORTANCE_NORMAL_MIN 2l")]
    public const int IMPORTANCE_NORMAL_MIN = 2;
    [NativeTypeName("#define IMPORTANCE_NORMAL_SET 3l")]
    public const int IMPORTANCE_NORMAL_SET = 3;
    [NativeTypeName("#define IMPORTANCE_NORMAL_MAX 4l")]
    public const int IMPORTANCE_NORMAL_MAX = 4;
    [NativeTypeName("#define IMPORTANCE_HIGH_MIN 5l")]
    public const int IMPORTANCE_HIGH_MIN = 5;
    [NativeTypeName("#define IMPORTANCE_HIGH_SET 5l")]
    public const int IMPORTANCE_HIGH_SET = 5;
    [NativeTypeName("#define IMPORTANCE_HIGH_MAX 5l")]
    public const int IMPORTANCE_HIGH_MAX = 5;
    [NativeTypeName("#define KIND_CALENDAR L\"calendar\"")]
    public const string KIND_CALENDAR = "calendar";
    [NativeTypeName("#define KIND_COMMUNICATION L\"communication\"")]
    public const string KIND_COMMUNICATION = "communication";
    [NativeTypeName("#define KIND_CONTACT L\"contact\"")]
    public const string KIND_CONTACT = "contact";
    [NativeTypeName("#define KIND_DOCUMENT L\"document\"")]
    public const string KIND_DOCUMENT = "document";
    [NativeTypeName("#define KIND_EMAIL L\"email\"")]
    public const string KIND_EMAIL = "email";
    [NativeTypeName("#define KIND_FEED L\"feed\"")]
    public const string KIND_FEED = "feed";
    [NativeTypeName("#define KIND_FOLDER L\"folder\"")]
    public const string KIND_FOLDER = "folder";
    [NativeTypeName("#define KIND_GAME L\"game\"")]
    public const string KIND_GAME = "game";
    [NativeTypeName("#define KIND_INSTANTMESSAGE L\"instantmessage\"")]
    public const string KIND_INSTANTMESSAGE = "instantmessage";
    [NativeTypeName("#define KIND_JOURNAL L\"journal\"")]
    public const string KIND_JOURNAL = "journal";
    [NativeTypeName("#define KIND_LINK L\"link\"")]
    public const string KIND_LINK = "link";
    [NativeTypeName("#define KIND_MOVIE L\"movie\"")]
    public const string KIND_MOVIE = "movie";
    [NativeTypeName("#define KIND_MUSIC L\"music\"")]
    public const string KIND_MUSIC = "music";
    [NativeTypeName("#define KIND_NOTE L\"note\"")]
    public const string KIND_NOTE = "note";
    [NativeTypeName("#define KIND_PICTURE L\"picture\"")]
    public const string KIND_PICTURE = "picture";
    [NativeTypeName("#define KIND_PLAYLIST L\"playlist\"")]
    public const string KIND_PLAYLIST = "playlist";
    [NativeTypeName("#define KIND_PROGRAM L\"program\"")]
    public const string KIND_PROGRAM = "program";
    [NativeTypeName("#define KIND_RECORDEDTV L\"recordedtv\"")]
    public const string KIND_RECORDEDTV = "recordedtv";
    [NativeTypeName("#define KIND_SEARCHFOLDER L\"searchfolder\"")]
    public const string KIND_SEARCHFOLDER = "searchfolder";
    [NativeTypeName("#define KIND_TASK L\"task\"")]
    public const string KIND_TASK = "task";
    [NativeTypeName("#define KIND_VIDEO L\"video\"")]
    public const string KIND_VIDEO = "video";
    [NativeTypeName("#define KIND_WEBHISTORY L\"webhistory\"")]
    public const string KIND_WEBHISTORY = "webhistory";
    [NativeTypeName("#define KIND_UNKNOWN L\"unknown\"")]
    public const string KIND_UNKNOWN = "unknown";
    [NativeTypeName("#define OFFLINEAVAILABILITY_NOT_AVAILABLE 0ul")]
    public const uint OFFLINEAVAILABILITY_NOT_AVAILABLE = 0U;
    [NativeTypeName("#define OFFLINEAVAILABILITY_AVAILABLE 1ul")]
    public const uint OFFLINEAVAILABILITY_AVAILABLE = 1U;
    [NativeTypeName("#define OFFLINEAVAILABILITY_ALWAYS_AVAILABLE 2ul")]
    public const uint OFFLINEAVAILABILITY_ALWAYS_AVAILABLE = 2U;
    [NativeTypeName("#define OFFLINESTATUS_ONLINE 0ul")]
    public const uint OFFLINESTATUS_ONLINE = 0U;
    [NativeTypeName("#define OFFLINESTATUS_OFFLINE 1ul")]
    public const uint OFFLINESTATUS_OFFLINE = 1U;
    [NativeTypeName("#define OFFLINESTATUS_OFFLINE_FORCED 2ul")]
    public const uint OFFLINESTATUS_OFFLINE_FORCED = 2U;
    [NativeTypeName("#define OFFLINESTATUS_OFFLINE_SLOW 3ul")]
    public const uint OFFLINESTATUS_OFFLINE_SLOW = 3U;
    [NativeTypeName("#define OFFLINESTATUS_OFFLINE_ERROR 4ul")]
    public const uint OFFLINESTATUS_OFFLINE_ERROR = 4U;
    [NativeTypeName("#define OFFLINESTATUS_OFFLINE_ITEM_VERSION_CONFLICT 5ul")]
    public const uint OFFLINESTATUS_OFFLINE_ITEM_VERSION_CONFLICT = 5U;
    [NativeTypeName("#define OFFLINESTATUS_OFFLINE_SUSPENDED 6ul")]
    public const uint OFFLINESTATUS_OFFLINE_SUSPENDED = 6U;
    [NativeTypeName("#define PRIORITY_PROP_LOW 0u")]
    public const uint PRIORITY_PROP_LOW = 0U;
    [NativeTypeName("#define PRIORITY_PROP_NORMAL 1u")]
    public const uint PRIORITY_PROP_NORMAL = 1U;
    [NativeTypeName("#define PRIORITY_PROP_HIGH 2u")]
    public const uint PRIORITY_PROP_HIGH = 2U;
    [NativeTypeName("#define RATING_ONE_STAR_MIN 1ul")]
    public const uint RATING_ONE_STAR_MIN = 1U;
    [NativeTypeName("#define RATING_ONE_STAR_SET 1ul")]
    public const uint RATING_ONE_STAR_SET = 1U;
    [NativeTypeName("#define RATING_ONE_STAR_MAX 12ul")]
    public const uint RATING_ONE_STAR_MAX = 12U;
    [NativeTypeName("#define RATING_TWO_STARS_MIN 13ul")]
    public const uint RATING_TWO_STARS_MIN = 13U;
    [NativeTypeName("#define RATING_TWO_STARS_SET 25ul")]
    public const uint RATING_TWO_STARS_SET = 25U;
    [NativeTypeName("#define RATING_TWO_STARS_MAX 37ul")]
    public const uint RATING_TWO_STARS_MAX = 37U;
    [NativeTypeName("#define RATING_THREE_STARS_MIN 38ul")]
    public const uint RATING_THREE_STARS_MIN = 38U;
    [NativeTypeName("#define RATING_THREE_STARS_SET 50ul")]
    public const uint RATING_THREE_STARS_SET = 50U;
    [NativeTypeName("#define RATING_THREE_STARS_MAX 62ul")]
    public const uint RATING_THREE_STARS_MAX = 62U;
    [NativeTypeName("#define RATING_FOUR_STARS_MIN 63ul")]
    public const uint RATING_FOUR_STARS_MIN = 63U;
    [NativeTypeName("#define RATING_FOUR_STARS_SET 75ul")]
    public const uint RATING_FOUR_STARS_SET = 75U;
    [NativeTypeName("#define RATING_FOUR_STARS_MAX 87ul")]
    public const uint RATING_FOUR_STARS_MAX = 87U;
    [NativeTypeName("#define RATING_FIVE_STARS_MIN 88ul")]
    public const uint RATING_FIVE_STARS_MIN = 88U;
    [NativeTypeName("#define RATING_FIVE_STARS_SET 99ul")]
    public const uint RATING_FIVE_STARS_SET = 99U;
    [NativeTypeName("#define RATING_FIVE_STARS_MAX 99ul")]
    public const uint RATING_FIVE_STARS_MAX = 99U;
    [NativeTypeName("#define SENSITIVITY_PROP_NORMAL 0u")]
    public const uint SENSITIVITY_PROP_NORMAL = 0U;
    [NativeTypeName("#define SENSITIVITY_PROP_PERSONAL 1u")]
    public const uint SENSITIVITY_PROP_PERSONAL = 1U;
    [NativeTypeName("#define SENSITIVITY_PROP_PRIVATE 2u")]
    public const uint SENSITIVITY_PROP_PRIVATE = 2U;
    [NativeTypeName("#define SENSITIVITY_PROP_CONFIDENTIAL 3u")]
    public const uint SENSITIVITY_PROP_CONFIDENTIAL = 3U;
    [NativeTypeName("#define SHARINGSTATUS_NOTSHARED 0ul")]
    public const uint SHARINGSTATUS_NOTSHARED = 0U;
    [NativeTypeName("#define SHARINGSTATUS_SHARED 1ul")]
    public const uint SHARINGSTATUS_SHARED = 1U;
    [NativeTypeName("#define SHARINGSTATUS_PRIVATE 2ul")]
    public const uint SHARINGSTATUS_PRIVATE = 2U;
    [NativeTypeName("#define BLUETOOTH_ADDRESS_TYPE_PUBLIC 0")]
    public const int BLUETOOTH_ADDRESS_TYPE_PUBLIC = 0;
    [NativeTypeName("#define BLUETOOTH_ADDRESS_TYPE_RANDOM 1")]
    public const int BLUETOOTH_ADDRESS_TYPE_RANDOM = 1;
    [NativeTypeName("#define BLUETOOTH_CACHE_MODE_CACHED 0")]
    public const int BLUETOOTH_CACHE_MODE_CACHED = 0;
    [NativeTypeName("#define BLUETOOTH_CACHED_MODE_UNCACHED 1")]
    public const int BLUETOOTH_CACHED_MODE_UNCACHED = 1;
    [NativeTypeName("#define PLAYBACKSTATE_UNKNOWN 0")]
    public const int PLAYBACKSTATE_UNKNOWN = 0;
    [NativeTypeName("#define PLAYBACKSTATE_STOPPED 1")]
    public const int PLAYBACKSTATE_STOPPED = 1;
    [NativeTypeName("#define PLAYBACKSTATE_PLAYING 2")]
    public const int PLAYBACKSTATE_PLAYING = 2;
    [NativeTypeName("#define PLAYBACKSTATE_TRANSITIONING 3")]
    public const int PLAYBACKSTATE_TRANSITIONING = 3;
    [NativeTypeName("#define PLAYBACKSTATE_PAUSED 4")]
    public const int PLAYBACKSTATE_PAUSED = 4;
    [NativeTypeName("#define PLAYBACKSTATE_RECORDINGPAUSED 5")]
    public const int PLAYBACKSTATE_RECORDINGPAUSED = 5;
    [NativeTypeName("#define PLAYBACKSTATE_RECORDING 6")]
    public const int PLAYBACKSTATE_RECORDING = 6;
    [NativeTypeName("#define PLAYBACKSTATE_NOMEDIA 7")]
    public const int PLAYBACKSTATE_NOMEDIA = 7;
    [NativeTypeName("#define LAYOUTPATTERN_CVMFB_ALPHA L\"alpha\"")]
    public const string LAYOUTPATTERN_CVMFB_ALPHA = "alpha";
    [NativeTypeName("#define LAYOUTPATTERN_CVMFB_BETA L\"beta\"")]
    public const string LAYOUTPATTERN_CVMFB_BETA = "beta";
    [NativeTypeName("#define LAYOUTPATTERN_CVMFB_GAMMA L\"gamma\"")]
    public const string LAYOUTPATTERN_CVMFB_GAMMA = "gamma";
    [NativeTypeName("#define LAYOUTPATTERN_CVMFB_DELTA L\"delta\"")]
    public const string LAYOUTPATTERN_CVMFB_DELTA = "delta";
    [NativeTypeName("#define LAYOUTPATTERN_CVMFS_ALPHA L\"alpha\"")]
    public const string LAYOUTPATTERN_CVMFS_ALPHA = "alpha";
    [NativeTypeName("#define LAYOUTPATTERN_CVMFS_BETA L\"beta\"")]
    public const string LAYOUTPATTERN_CVMFS_BETA = "beta";
    [NativeTypeName("#define LAYOUTPATTERN_CVMFS_GAMMA L\"gamma\"")]
    public const string LAYOUTPATTERN_CVMFS_GAMMA = "gamma";
    [NativeTypeName("#define LAYOUTPATTERN_CVMFS_DELTA L\"delta\"")]
    public const string LAYOUTPATTERN_CVMFS_DELTA = "delta";
    [NativeTypeName("#define LINK_STATUS_RESOLVED 1l")]
    public const int LINK_STATUS_RESOLVED = 1;
    [NativeTypeName("#define LINK_STATUS_BROKEN 2l")]
    public const int LINK_STATUS_BROKEN = 2;
    [NativeTypeName("#define NOTE_COLOR_BLUE 0u")]
    public const uint NOTE_COLOR_BLUE = 0U;
    [NativeTypeName("#define NOTE_COLOR_GREEN 1u")]
    public const uint NOTE_COLOR_GREEN = 1U;
    [NativeTypeName("#define NOTE_COLOR_PINK 2u")]
    public const uint NOTE_COLOR_PINK = 2U;
    [NativeTypeName("#define NOTE_COLOR_YELLOW 3u")]
    public const uint NOTE_COLOR_YELLOW = 3U;
    [NativeTypeName("#define NOTE_COLOR_WHITE 4u")]
    public const uint NOTE_COLOR_WHITE = 4U;
    [NativeTypeName("#define NOTE_COLOR_LIGHTGREEN 5u")]
    public const uint NOTE_COLOR_LIGHTGREEN = 5U;
    [NativeTypeName("#define PHOTO_CONTRAST_NORMAL 0ul")]
    public const uint PHOTO_CONTRAST_NORMAL = 0U;
    [NativeTypeName("#define PHOTO_CONTRAST_SOFT 1ul")]
    public const uint PHOTO_CONTRAST_SOFT = 1U;
    [NativeTypeName("#define PHOTO_CONTRAST_HARD 2ul")]
    public const uint PHOTO_CONTRAST_HARD = 2U;
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_UNKNOWN 0ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_UNKNOWN = 0U;
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_MANUAL 1ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_MANUAL = 1U;
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_NORMAL 2ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_NORMAL = 2U;
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_APERTURE 3ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_APERTURE = 3U;
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_SHUTTER 4ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_SHUTTER = 4U;
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_CREATIVE 5ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_CREATIVE = 5U;
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_ACTION 6ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_ACTION = 6U;
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_PORTRAIT 7ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_PORTRAIT = 7U;
    [NativeTypeName("#define PHOTO_EXPOSUREPROGRAM_LANDSCAPE 8ul")]
    public const uint PHOTO_EXPOSUREPROGRAM_LANDSCAPE = 8U;
    [NativeTypeName("#define PHOTO_FLASH_NONE 0")]
    public const int PHOTO_FLASH_NONE = 0;
    [NativeTypeName("#define PHOTO_FLASH_FLASH 1")]
    public const int PHOTO_FLASH_FLASH = 1;
    [NativeTypeName("#define PHOTO_FLASH_WITHOUTSTROBE 5")]
    public const int PHOTO_FLASH_WITHOUTSTROBE = 5;
    [NativeTypeName("#define PHOTO_FLASH_WITHSTROBE 7")]
    public const int PHOTO_FLASH_WITHSTROBE = 7;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_COMPULSORY 9")]
    public const int PHOTO_FLASH_FLASH_COMPULSORY = 9;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_COMPULSORY_NORETURNLIGHT 13")]
    public const int PHOTO_FLASH_FLASH_COMPULSORY_NORETURNLIGHT = 13;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_COMPULSORY_RETURNLIGHT 15")]
    public const int PHOTO_FLASH_FLASH_COMPULSORY_RETURNLIGHT = 15;
    [NativeTypeName("#define PHOTO_FLASH_NONE_COMPULSORY 16")]
    public const int PHOTO_FLASH_NONE_COMPULSORY = 16;
    [NativeTypeName("#define PHOTO_FLASH_NONE_AUTO 24")]
    public const int PHOTO_FLASH_NONE_AUTO = 24;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_AUTO 25")]
    public const int PHOTO_FLASH_FLASH_AUTO = 25;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_AUTO_NORETURNLIGHT 29")]
    public const int PHOTO_FLASH_FLASH_AUTO_NORETURNLIGHT = 29;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_AUTO_RETURNLIGHT 31")]
    public const int PHOTO_FLASH_FLASH_AUTO_RETURNLIGHT = 31;
    [NativeTypeName("#define PHOTO_FLASH_NOFUNCTION 32")]
    public const int PHOTO_FLASH_NOFUNCTION = 32;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_REDEYE 65")]
    public const int PHOTO_FLASH_FLASH_REDEYE = 65;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_REDEYE_NORETURNLIGHT 69")]
    public const int PHOTO_FLASH_FLASH_REDEYE_NORETURNLIGHT = 69;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_REDEYE_RETURNLIGHT 71")]
    public const int PHOTO_FLASH_FLASH_REDEYE_RETURNLIGHT = 71;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_COMPULSORY_REDEYE 73")]
    public const int PHOTO_FLASH_FLASH_COMPULSORY_REDEYE = 73;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_COMPULSORY_REDEYE_NORETURNLIGHT 77")]
    public const int PHOTO_FLASH_FLASH_COMPULSORY_REDEYE_NORETURNLIGHT = 77;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_COMPULSORY_REDEYE_RETURNLIGHT 79")]
    public const int PHOTO_FLASH_FLASH_COMPULSORY_REDEYE_RETURNLIGHT = 79;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_AUTO_REDEYE 89")]
    public const int PHOTO_FLASH_FLASH_AUTO_REDEYE = 89;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_AUTO_REDEYE_NORETURNLIGHT 93")]
    public const int PHOTO_FLASH_FLASH_AUTO_REDEYE_NORETURNLIGHT = 93;
    [NativeTypeName("#define PHOTO_FLASH_FLASH_AUTO_REDEYE_RETURNLIGHT 95")]
    public const int PHOTO_FLASH_FLASH_AUTO_REDEYE_RETURNLIGHT = 95;
    [NativeTypeName("#define PHOTO_GAINCONTROL_NONE 0.0")]
    public const double PHOTO_GAINCONTROL_NONE = 0.0;
    [NativeTypeName("#define PHOTO_GAINCONTROL_LOWGAINUP 1.0")]
    public const double PHOTO_GAINCONTROL_LOWGAINUP = 1.0;
    [NativeTypeName("#define PHOTO_GAINCONTROL_HIGHGAINUP 2.0")]
    public const double PHOTO_GAINCONTROL_HIGHGAINUP = 2.0;
    [NativeTypeName("#define PHOTO_GAINCONTROL_LOWGAINDOWN 3.0")]
    public const double PHOTO_GAINCONTROL_LOWGAINDOWN = 3.0;
    [NativeTypeName("#define PHOTO_GAINCONTROL_HIGHGAINDOWN 4.0")]
    public const double PHOTO_GAINCONTROL_HIGHGAINDOWN = 4.0;
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_UNKNOWN 0ul")]
    public const uint PHOTO_LIGHTSOURCE_UNKNOWN = 0U;
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_DAYLIGHT 1ul")]
    public const uint PHOTO_LIGHTSOURCE_DAYLIGHT = 1U;
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_FLUORESCENT 2ul")]
    public const uint PHOTO_LIGHTSOURCE_FLUORESCENT = 2U;
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_TUNGSTEN 3ul")]
    public const uint PHOTO_LIGHTSOURCE_TUNGSTEN = 3U;
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_STANDARD_A 17ul")]
    public const uint PHOTO_LIGHTSOURCE_STANDARD_A = 17U;
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_STANDARD_B 18ul")]
    public const uint PHOTO_LIGHTSOURCE_STANDARD_B = 18U;
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_STANDARD_C 19ul")]
    public const uint PHOTO_LIGHTSOURCE_STANDARD_C = 19U;
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_D55 20ul")]
    public const uint PHOTO_LIGHTSOURCE_D55 = 20U;
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_D65 21ul")]
    public const uint PHOTO_LIGHTSOURCE_D65 = 21U;
    [NativeTypeName("#define PHOTO_LIGHTSOURCE_D75 22ul")]
    public const uint PHOTO_LIGHTSOURCE_D75 = 22U;
    [NativeTypeName("#define PHOTO_METERINGMODE_UNKNOWN 0u")]
    public const uint PHOTO_METERINGMODE_UNKNOWN = 0U;
    [NativeTypeName("#define PHOTO_METERINGMODE_AVERAGE 1u")]
    public const uint PHOTO_METERINGMODE_AVERAGE = 1U;
    [NativeTypeName("#define PHOTO_METERINGMODE_CENTER 2u")]
    public const uint PHOTO_METERINGMODE_CENTER = 2U;
    [NativeTypeName("#define PHOTO_METERINGMODE_SPOT 3u")]
    public const uint PHOTO_METERINGMODE_SPOT = 3U;
    [NativeTypeName("#define PHOTO_METERINGMODE_MULTISPOT 4u")]
    public const uint PHOTO_METERINGMODE_MULTISPOT = 4U;
    [NativeTypeName("#define PHOTO_METERINGMODE_PATTERN 5u")]
    public const uint PHOTO_METERINGMODE_PATTERN = 5U;
    [NativeTypeName("#define PHOTO_METERINGMODE_PARTIAL 6u")]
    public const uint PHOTO_METERINGMODE_PARTIAL = 6U;
    [NativeTypeName("#define PHOTO_ORIENTATION_NORMAL 1u")]
    public const uint PHOTO_ORIENTATION_NORMAL = 1U;
    [NativeTypeName("#define PHOTO_ORIENTATION_FLIPHORIZONTAL 2u")]
    public const uint PHOTO_ORIENTATION_FLIPHORIZONTAL = 2U;
    [NativeTypeName("#define PHOTO_ORIENTATION_ROTATE180 3u")]
    public const uint PHOTO_ORIENTATION_ROTATE180 = 3U;
    [NativeTypeName("#define PHOTO_ORIENTATION_FLIPVERTICAL 4u")]
    public const uint PHOTO_ORIENTATION_FLIPVERTICAL = 4U;
    [NativeTypeName("#define PHOTO_ORIENTATION_TRANSPOSE 5u")]
    public const uint PHOTO_ORIENTATION_TRANSPOSE = 5U;
    [NativeTypeName("#define PHOTO_ORIENTATION_ROTATE270 6u")]
    public const uint PHOTO_ORIENTATION_ROTATE270 = 6U;
    [NativeTypeName("#define PHOTO_ORIENTATION_TRANSVERSE 7u")]
    public const uint PHOTO_ORIENTATION_TRANSVERSE = 7U;
    [NativeTypeName("#define PHOTO_ORIENTATION_ROTATE90 8u")]
    public const uint PHOTO_ORIENTATION_ROTATE90 = 8U;
    [NativeTypeName("#define PHOTO_PHOTOMETRIC_RGB 2u")]
    public const uint PHOTO_PHOTOMETRIC_RGB = 2U;
    [NativeTypeName("#define PHOTO_PHOTOMETRIC_YCBCR 6u")]
    public const uint PHOTO_PHOTOMETRIC_YCBCR = 6U;
    [NativeTypeName("#define PHOTO_PROGRAMMODE_NOTDEFINED 0ul")]
    public const uint PHOTO_PROGRAMMODE_NOTDEFINED = 0U;
    [NativeTypeName("#define PHOTO_PROGRAMMODE_MANUAL 1ul")]
    public const uint PHOTO_PROGRAMMODE_MANUAL = 1U;
    [NativeTypeName("#define PHOTO_PROGRAMMODE_NORMAL 2ul")]
    public const uint PHOTO_PROGRAMMODE_NORMAL = 2U;
    [NativeTypeName("#define PHOTO_PROGRAMMODE_APERTURE 3ul")]
    public const uint PHOTO_PROGRAMMODE_APERTURE = 3U;
    [NativeTypeName("#define PHOTO_PROGRAMMODE_SHUTTER 4ul")]
    public const uint PHOTO_PROGRAMMODE_SHUTTER = 4U;
    [NativeTypeName("#define PHOTO_PROGRAMMODE_CREATIVE 5ul")]
    public const uint PHOTO_PROGRAMMODE_CREATIVE = 5U;
    [NativeTypeName("#define PHOTO_PROGRAMMODE_ACTION 6ul")]
    public const uint PHOTO_PROGRAMMODE_ACTION = 6U;
    [NativeTypeName("#define PHOTO_PROGRAMMODE_PORTRAIT 7ul")]
    public const uint PHOTO_PROGRAMMODE_PORTRAIT = 7U;
    [NativeTypeName("#define PHOTO_PROGRAMMODE_LANDSCAPE 8ul")]
    public const uint PHOTO_PROGRAMMODE_LANDSCAPE = 8U;
    [NativeTypeName("#define PHOTO_SATURATION_NORMAL 0ul")]
    public const uint PHOTO_SATURATION_NORMAL = 0U;
    [NativeTypeName("#define PHOTO_SATURATION_LOW 1ul")]
    public const uint PHOTO_SATURATION_LOW = 1U;
    [NativeTypeName("#define PHOTO_SATURATION_HIGH 2ul")]
    public const uint PHOTO_SATURATION_HIGH = 2U;
    [NativeTypeName("#define PHOTO_SHARPNESS_NORMAL 0ul")]
    public const uint PHOTO_SHARPNESS_NORMAL = 0U;
    [NativeTypeName("#define PHOTO_SHARPNESS_SOFT 1ul")]
    public const uint PHOTO_SHARPNESS_SOFT = 1U;
    [NativeTypeName("#define PHOTO_SHARPNESS_HARD 2ul")]
    public const uint PHOTO_SHARPNESS_HARD = 2U;
    [NativeTypeName("#define PHOTO_WHITEBALANCE_AUTO 0ul")]
    public const uint PHOTO_WHITEBALANCE_AUTO = 0U;
    [NativeTypeName("#define PHOTO_WHITEBALANCE_MANUAL 1ul")]
    public const uint PHOTO_WHITEBALANCE_MANUAL = 1U;
    [NativeTypeName("#define SFGAOSTR_FILESYS L\"filesys\"")]
    public const string SFGAOSTR_FILESYS = "filesys";
    [NativeTypeName("#define SFGAOSTR_FILEANC L\"fileanc\"")]
    public const string SFGAOSTR_FILEANC = "fileanc";
    [NativeTypeName("#define SFGAOSTR_STORAGEANC L\"storageanc\"")]
    public const string SFGAOSTR_STORAGEANC = "storageanc";
    [NativeTypeName("#define SFGAOSTR_STREAM L\"stream\"")]
    public const string SFGAOSTR_STREAM = "stream";
    [NativeTypeName("#define SFGAOSTR_LINK L\"link\"")]
    public const string SFGAOSTR_LINK = "link";
    [NativeTypeName("#define SFGAOSTR_HIDDEN L\"hidden\"")]
    public const string SFGAOSTR_HIDDEN = "hidden";
    [NativeTypeName("#define SFGAOSTR_SUPERHIDDEN L\"superhidden\"")]
    public const string SFGAOSTR_SUPERHIDDEN = "superhidden";
    [NativeTypeName("#define SFGAOSTR_FOLDER L\"folder\"")]
    public const string SFGAOSTR_FOLDER = "folder";
    [NativeTypeName("#define SFGAOSTR_NONENUM L\"nonenum\"")]
    public const string SFGAOSTR_NONENUM = "nonenum";
    [NativeTypeName("#define SFGAOSTR_BROWSABLE L\"browsable\"")]
    public const string SFGAOSTR_BROWSABLE = "browsable";
    [NativeTypeName("#define SFGAOSTR_SYSTEM L\"system\"")]
    public const string SFGAOSTR_SYSTEM = "system";
    [NativeTypeName("#define SFGAOSTR_PLACEHOLDER L\"placeholder\"")]
    public const string SFGAOSTR_PLACEHOLDER = "placeholder";
    [NativeTypeName("#define APPUSERMODEL_STARTPINOPTION_DEFAULT 0ul")]
    public const uint APPUSERMODEL_STARTPINOPTION_DEFAULT = 0U;
    [NativeTypeName("#define APPUSERMODEL_STARTPINOPTION_NOPINONINSTALL 1ul")]
    public const uint APPUSERMODEL_STARTPINOPTION_NOPINONINSTALL = 1U;
    [NativeTypeName("#define APPUSERMODEL_STARTPINOPTION_USERPINNED 2ul")]
    public const uint APPUSERMODEL_STARTPINOPTION_USERPINNED = 2U;
    [NativeTypeName("#define SYNC_HANDLERTYPE_OTHER 0ul")]
    public const uint SYNC_HANDLERTYPE_OTHER = 0U;
    [NativeTypeName("#define SYNC_HANDLERTYPE_PROGRAMS 1ul")]
    public const uint SYNC_HANDLERTYPE_PROGRAMS = 1U;
    [NativeTypeName("#define SYNC_HANDLERTYPE_DEVICES 2ul")]
    public const uint SYNC_HANDLERTYPE_DEVICES = 2U;
    [NativeTypeName("#define SYNC_HANDLERTYPE_FOLDERS 3ul")]
    public const uint SYNC_HANDLERTYPE_FOLDERS = 3U;
    [NativeTypeName("#define SYNC_HANDLERTYPE_WEBSERVICES 4ul")]
    public const uint SYNC_HANDLERTYPE_WEBSERVICES = 4U;
    [NativeTypeName("#define SYNC_HANDLERTYPE_COMPUTERS 5ul")]
    public const uint SYNC_HANDLERTYPE_COMPUTERS = 5U;
    [NativeTypeName("#define SYNC_STATE_NOTSETUP 0ul")]
    public const uint SYNC_STATE_NOTSETUP = 0U;
    [NativeTypeName("#define SYNC_STATE_SYNCNOTRUN 1ul")]
    public const uint SYNC_STATE_SYNCNOTRUN = 1U;
    [NativeTypeName("#define SYNC_STATE_IDLE 2ul")]
    public const uint SYNC_STATE_IDLE = 2U;
    [NativeTypeName("#define SYNC_STATE_ERROR 3ul")]
    public const uint SYNC_STATE_ERROR = 3U;
    [NativeTypeName("#define SYNC_STATE_PENDING 4ul")]
    public const uint SYNC_STATE_PENDING = 4U;
    [NativeTypeName("#define SYNC_STATE_SYNCING 5ul")]
    public const uint SYNC_STATE_SYNCING = 5U;
}