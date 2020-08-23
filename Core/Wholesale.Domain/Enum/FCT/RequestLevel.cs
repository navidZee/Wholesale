using System.ComponentModel;
namespace Wholesale.Domain.Enum.FCT
{
    public enum RequestLevel
    {
        [Description("درحال ارسال")]
        Sending,
        [Description("اتمام درخواست ")]
        delivered,
        [Description("مرجوئی")]
        Rejectd
    }
}
