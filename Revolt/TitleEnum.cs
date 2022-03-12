using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revolt{

    //all of the possible titles, which can be combinations as well
    [Flags] public enum TitleEnum : long{
        NONE            = 0,
        QUEEN           = 1,
        KING            = 2,
        LEADER          = 4,
        DEPUTY          = 8,
        ARTIST          = 16,
        ASTROLOGER      = 32,
        ATILLIATOR      = 64,
        BAILIFF         = 128,
        BAKER           = 256,
        BARBER          = 512,
        BLACKSMITH      = 1024,
        BOTTLER         = 2048,
        BUTLER          = 4096,
        BOWYER          = 8192,
        CANDLEMAKER     = 16384,
        CARPENTER       = 32768,
        CASTELLAN       = 65536,
        CHAMBERLAIN     = 131072,
        CHANCELLOR      = 262144,
        CHAPLAIN        = 524288,
        CLERK           = 1048576,
        CLOTHIER        = 2097152,
        CONSTABLE       = 4194304,
        COOK            = 8388608,
        CORDWAINER      = 16777216,
        COTTAR          = 33554432,
        DITCHER         = 67108864,
        EWERER          = 134217728,
        FLETCHER        = 268435456,
        GARDENER        = 536870912,
        HERALD          = 1073741824,
        HERBALIST       = 2147483648,
        JANITOR         = 4294967296,
        JESTER          = 8589934592,
        KNIGHT          = 17179869184,
        MARSHAL         = 34359738368,
        MESSENGER       = 68719476736,
        MINSTREL        = 137438953472,
        MONEYLENDER     = 274877906944,
        PAGE            = 549755813888,
        PAINTER         = 1099511627776,
        PORTER          = 2199023255552,
        PHYSICIAN       = 4398046511104,
        POTTER          = 8796093022208,
        REEVE           = 17592186044416,
        SCRIBE          = 35184372088832,
        SCULLION        = 70368744177664,
        SHERIFF         = 140737488355328,
        SHOEMAKER       = 281474976710656,
        SPINSTER        = 562949953421312,
        STEWARD         = 1125899906842624,
        SQUIRE          = 2251799813685248,
        WATCHMAN        = 4503599627370496,
        MUSE            = 9007199254740992
    }
}
