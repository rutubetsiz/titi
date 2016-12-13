using MadamRozikaGlobal.Dtos.ViewDtos;

namespace MadamRozikaData.Functions
{
    public partial class Mapper
    {
        public CategoryMenuDto MapTo(Category entity)
        {
            if (entity == null)
                return null;

            return new CategoryMenuDto
            {
                Name = entity.Name,
                Url = entity.Url,
                CategoryId = entity.CategoryId,
                MegaMenu = entity.MegaMenu,
                ParentId = entity.ParentId
            };
        }
    }
}