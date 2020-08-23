using Wholesale.Domain.Common.Base;

namespace Wholesale.Domain.Entities.PRT
{
    public class CategoryEntity: BaseEntity
    {        
        public string Name { get; set; }

        public string ImgName { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
