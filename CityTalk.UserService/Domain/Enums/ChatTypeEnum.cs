using System.ComponentModel;

namespace Domain.Enums
{
    public enum ChatTypeEnum
    {
        [Description("Личный")]
        Private = 0,

        [Description("Многопользовательский")]
        MultiUser = 1
    }
}
