using System.ComponentModel;
namespace Wholesale.Domain.Enums.FCT
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
