using Wholesale.Domain.Common.Base;
using Wholesale.Domain.Enums.OTH;

namespace Wholesale.Domain.Entities.PRT
{
    public class FileEntity : BaseEntity
    {
        public FileType FileType { get; set; }

        public string FileName { get; set; }
 
        public string Alt { get; set; }

        public string Title { get; set; }
    }
 
}
